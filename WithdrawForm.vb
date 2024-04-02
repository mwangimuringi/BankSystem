Imports System.Data.OleDb
Public Class WithdrawalForm
    Private Sub WithdrawButton_Click(sender As Object, e As EventArgs) Handles WithdrawButton.Click
        If AccountTextBox.Text = "" Or AmountTextBox.Text = "" Then
            MessageBox.Show("Please enter account number and amount to withdraw.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim accountNumber As Double = Double.Parse(AccountTextBox.Text)
        Dim amount As Decimal = Decimal.Parse(AmountTextBox.Text)

        If amount > GetAccountBalance(accountNumber) Then
            MessageBox.Show("Insufficient balance in the account.", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If UpdateAccountBalance(accountNumber, -amount) Then
            MessageBox.Show("Withdrawal successful.", "Withdrawal Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error while processing the withdrawal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function GetAccountBalance(accountNumber As Integer) As Decimal
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source= C:\Users\user\source\repos\BankSystem\BankingSystem1.accdb;"
        Dim connection As New OleDbConnection(connectionString)
        Dim command As New OleDbCommand("SELECT Balance FROM Accounts WHERE AccountNumber = @accountNumber", connection)
        command.Parameters.AddWithValue("@accountNumber", accountNumber)

        Try
            connection.Open()
            Dim result As Object = command.ExecuteScalar()
            If result IsNot Nothing Then
                Return Convert.ToDecimal(result)
            Else
                Return 0
            End If
        Finally
            connection.Close()
        End Try
    End Function

    Private Function UpdateAccountBalance(accountNumber As Integer, amount As Decimal) As Boolean
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\user\source\repos\BankSystem\BankingSystem1.accdb;"
        Dim connection As New OleDbConnection(connectionString)
        Dim command As New OleDbCommand("UPDATE Accounts SET Balance = Balance + @amount WHERE AccountNumber = @accountNumber", connection)
        command.Parameters.AddWithValue("@accountNumber", accountNumber)
        command.Parameters.AddWithValue("@amount", amount)

        Try
            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            Return rowsAffected > 0
        Finally
            connection.Close()
        End Try
    End Function
End Class

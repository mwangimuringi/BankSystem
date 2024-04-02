Imports System.Data.OleDb


Public Class CreateAccountForm
    Dim Connect As New OleDbConnection
    Dim Cmd As OleDbCommand
    Dim DataTable As New DataTable
    Dim DataAdapter As New OleDbDataAdapter(Cmd)

    Private bitmap As Bitmap
    Private Gender

    Private Sub CreateAccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\markk\source\repos\BankSystem_\BankingSystem1.accdb"

    End Sub

    Private Sub CreateAccountButton_Click(sender As Object, e As EventArgs) Handles CreateAccountButton.Click
        'TEST DATA **
        'Dim FirstName As String = "John"
        'Dim SecondName As String = "Doe"
        'Dim Surname As String = "Smith"
        'Dim AccountNum As String = "1234567890"
        'Dim AccountTitle As String = "Mr."
        'Dim Gender As String = "Male"
        'Dim DateOfBirth As Date = #1980-01-01#
        'Dim Nationality As String = "American"
        'Dim PostalAddress As String = "123 Main St, Anytown, USA"
        'Dim PhoneNumber As String = "123-456-7890"
        'Dim EmailAddress As String = "john.doe@example.com"
        'Dim InitialDeposit As Double = 1000.0
        'Dim Balance As Double = 1000.0
        'Dim Occupation As String = "Engineer"

        'Use this string to test db
        'Cmd.CommandText = $"INSERT INTO Customer(FirstName, SecondName, Surname, AccountNumber, AccountTitle, Gender, DateOfBirth, Nationality, PostalAddress, PhoneNumber, EmailAddress, InitialDeposit, Balance, Occupation) VALUES ('{FirstName}', '{SecondName}', '{Surname}', '{AccountNum}', '{AccountTitle}', '{Gender}', '{DateOfBirth}', '{Nationality}', '{PostalAddress}', '{PhoneNumber}', '{EmailAddress}', {InitialDeposit}, {Balance}, '{Occupation}')"

        'Format the date
        Dim SelectedDate As Date = DateOfBirth.Value
        Dim FormattedDate As String = SelectedDate.ToString("MM/dd/yyyy")

        Try
            Connect.Open()
            Cmd = Connect.CreateCommand()
            Cmd.CommandType = CommandType.Text




            Cmd.CommandText = $"INSERT INTO Customer(FirstName, SecondName, Surname, AccountNumber, AccountTitle, Gender, DateOfBirth, Nationality, PostalAddress, PhoneNumber, EmailAddress, InitialDeposit, Balance, Occupation) VALUES ('{FirstName.Text}', '{SecondName.Text}', '{Surname.Text}', '{AccountNumber.Text}', '{AccountTitle.Text}', '{Gender}', '{FormattedDate}', '{Nationality}', '{PostalAddress.Text}', '{PhoneNumber}', '{EmailAddress.Text}', {InitialDeposit.Text}, {InitialDeposit.Text}, '{Occupation}')"
            Cmd.ExecuteNonQuery()
            Connect.Close()
            MessageBox.Show("Record saved", "Customer information Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Account Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub MaleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MaleRadioButton.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub FemaleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FemaleRadioButton.CheckedChanged
        Gender = "Female"
    End Sub

End Class
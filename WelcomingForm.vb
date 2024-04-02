Public Class WelcomingForm
    Private Sub WelcomingForm_Click(Sender As Object, e As EventArgs) Handles MyBase.Click
        WindowState = FormWindowState.Maximized
    End Sub

    'To load create account form
    Private Sub CreateNewAccountButton_Click(Sender As Object, e As EventArgs) Handles CreateNewAccountButton.Click, Button1.Click
        Dim CreateAccountForm As New CreateAccountForm
        CreateAccountForm.Show
    End Sub
    'To load deposit form
    Private Sub DepositButton_Click(Sender As Object, e As EventArgs) Handles DepositButton.Click, Button2.Click
        Dim DeposittForm As New DepositForm
        DepositForm.Show
    End Sub
    'To load withdraw form
    Private Sub WithdrawButton_Click(Sender As Object, e As EventArgs) Handles WithdrawButton.Click, Button4.Click
        Dim withdrawForm As New WithdrawForm
        withdrawForm.Show
    End Sub
    'To load deposit form
    Private Sub TransferButton_Click(Sender As Object, e As EventArgs) Handles TransferButton.Click, Button3.Click
        Dim TransferForm As New TransferForm
        TransferForm.Show
    End Sub
    'To load Check balance form
    Private Sub CheckBalanceButton_Click(Sender As Object, e As EventArgs) Handles CheckBalanceButton.Click, Button5.Click
        Dim CheckBalanceForm As New CheckBalanceForm
        CheckBalanceForm.Show
    End Sub
    'To load transactions form
    Private Sub TransactionsButton_Click(Sender As Object, e As EventArgs) Handles TransactionsButton.Click
        Dim TransactionsForm As New TransactionsForm
        TransactionsForm.Show()
    End Sub
    ' To load loans form
    Private Sub LoanButton_Click(Sender As Object, e As EventArgs) Handles LoanButton.Click
        Dim LoanForm As New LoanForm
        LoanForm.Show()
    End Sub
End Class
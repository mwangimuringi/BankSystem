﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        CheckBalanceButton = New Button()
        WithdrawButton = New Button()
        TransferButton = New Button()
        DepositButton = New Button()
        CreateNewAccountButton = New Button()
        GroupBox2 = New GroupBox()
        AccountDetailsButton = New Button()
        LoanButton = New Button()
        TransactionsButton = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CheckBalanceButton)
        GroupBox1.Controls.Add(WithdrawButton)
        GroupBox1.Controls.Add(TransferButton)
        GroupBox1.Controls.Add(DepositButton)
        GroupBox1.Controls.Add(CreateNewAccountButton)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(301, 379)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Member task"
        ' 
        ' CheckBalanceButton
        ' 
        CheckBalanceButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBalanceButton.Location = New Point(22, 245)
        CheckBalanceButton.Margin = New Padding(3, 4, 3, 4)
        CheckBalanceButton.Name = "CheckBalanceButton"
        CheckBalanceButton.Size = New Size(181, 45)
        CheckBalanceButton.TabIndex = 3
        CheckBalanceButton.Text = "Check balance"
        CheckBalanceButton.UseVisualStyleBackColor = True
        ' 
        ' WithdrawButton
        ' 
        WithdrawButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        WithdrawButton.Location = New Point(22, 173)
        WithdrawButton.Margin = New Padding(3, 4, 3, 4)
        WithdrawButton.Name = "WithdrawButton"
        WithdrawButton.Size = New Size(181, 45)
        WithdrawButton.TabIndex = 2
        WithdrawButton.Text = "Withdraw amount"
        WithdrawButton.UseVisualStyleBackColor = True
        ' 
        ' TransferButton
        ' 
        TransferButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TransferButton.Location = New Point(22, 317)
        TransferButton.Margin = New Padding(3, 4, 3, 4)
        TransferButton.Name = "TransferButton"
        TransferButton.Size = New Size(181, 45)
        TransferButton.TabIndex = 0
        TransferButton.Text = "Transfer amount"
        TransferButton.UseVisualStyleBackColor = True
        ' 
        ' DepositButton
        ' 
        DepositButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DepositButton.Location = New Point(22, 101)
        DepositButton.Margin = New Padding(3, 4, 3, 4)
        DepositButton.Name = "DepositButton"
        DepositButton.Size = New Size(181, 45)
        DepositButton.TabIndex = 1
        DepositButton.Text = "Deposit amount"
        DepositButton.UseVisualStyleBackColor = True
        ' 
        ' CreateNewAccountButton
        ' 
        CreateNewAccountButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CreateNewAccountButton.Location = New Point(22, 29)
        CreateNewAccountButton.Margin = New Padding(3, 4, 3, 4)
        CreateNewAccountButton.Name = "CreateNewAccountButton"
        CreateNewAccountButton.Size = New Size(181, 45)
        CreateNewAccountButton.TabIndex = 0
        CreateNewAccountButton.Text = "Create new account"
        CreateNewAccountButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(AccountDetailsButton)
        GroupBox2.Controls.Add(LoanButton)
        GroupBox2.Controls.Add(TransactionsButton)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(513, 29)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(318, 351)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Management"
        ' 
        ' AccountDetailsButton
        ' 
        AccountDetailsButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AccountDetailsButton.Location = New Point(46, 161)
        AccountDetailsButton.Margin = New Padding(3, 4, 3, 4)
        AccountDetailsButton.Name = "AccountDetailsButton"
        AccountDetailsButton.Size = New Size(155, 45)
        AccountDetailsButton.TabIndex = 3
        AccountDetailsButton.Text = "Account details"
        AccountDetailsButton.UseVisualStyleBackColor = True
        ' 
        ' LoanButton
        ' 
        LoanButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoanButton.Location = New Point(46, 99)
        LoanButton.Margin = New Padding(3, 4, 3, 4)
        LoanButton.Name = "LoanButton"
        LoanButton.Size = New Size(155, 45)
        LoanButton.TabIndex = 2
        LoanButton.Text = "Borrow Loan"
        LoanButton.UseVisualStyleBackColor = True
        ' 
        ' TransactionsButton
        ' 
        TransactionsButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TransactionsButton.Location = New Point(46, 37)
        TransactionsButton.Margin = New Padding(3, 4, 3, 4)
        TransactionsButton.Name = "TransactionsButton"
        TransactionsButton.Size = New Size(155, 45)
        TransactionsButton.TabIndex = 1
        TransactionsButton.Text = "Transactions"
        TransactionsButton.UseVisualStyleBackColor = True
        ' 
        ' WelcomingForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(861, 475)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "WelcomingForm"
        Text = "Investor Bank"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBalanceButton As Button
    Friend WithEvents WithdrawButton As Button
    Friend WithEvents DepositButton As Button
    Friend WithEvents CreateNewAccountButton As Button
    Friend WithEvents LoanButton As Button
    Friend WithEvents TransactionsButton As Button
    Friend WithEvents TransferButton As Button
    Friend WithEvents AccountDetailsButton As Button

End Class

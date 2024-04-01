<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionsForm
    Inherits System.Windows.Forms.Form

    Private accountNumberToSearch As String

    Private Sub SearchTransactionButton_Click(sender As Object, e As EventArgs) Handles SearchTransactionButton.Click

        accountNumberToSearch = TextBox1.Text

        ' You can then use this account number to query transactions from the database
    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        SearchTransactionButton = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 0
        Label1.Text = "Transactions:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(SearchTransactionButton)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(26, 65)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(673, 131)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Search  Account"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 17)
        Label2.TabIndex = 0
        Label2.Text = "Account Number:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(188, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(346, 25)
        TextBox1.TabIndex = 1
        ' 
        ' SearchTransactionButton
        ' 
        SearchTransactionButton.Location = New Point(568, 69)
        SearchTransactionButton.Name = "SearchTransactionButton"
        SearchTransactionButton.Size = New Size(75, 23)
        SearchTransactionButton.TabIndex = 2
        SearchTransactionButton.Text = "Search"
        SearchTransactionButton.UseVisualStyleBackColor = True
        ' 
        ' TransactionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(762, 357)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "TransactionsForm"
        Text = "Transactions Statement Form"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SearchTransactionButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
End Class

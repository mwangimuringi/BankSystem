<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WithdrawForm
    Inherits System.Windows.Forms.Form
    ' Variables to store account information
    Private accountNumber As String
    Private accountTitle As String
    Private nicNumber As String

    ' Variable to store withdrawal amount
    Private withdrawalAmount As Decimal

    ' Variables to display customer information
    Private customerName As String
    Private currentBalance As Decimal

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
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        SearchWithdrawButton = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 0
        Label1.Text = "Withdraw:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(SearchWithdrawButton)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(356, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(351, 152)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Search Account"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 17)
        Label4.TabIndex = 3
        Label4.Text = "NIC Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 17)
        Label3.TabIndex = 2
        Label3.Text = "Account Title:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 17)
        Label2.TabIndex = 0
        Label2.Text = "Account Number:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 219)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 15)
        Label5.TabIndex = 2
        Label5.Text = "Customer Name:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 252)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 15)
        Label6.TabIndex = 3
        Label6.Text = "Account Title:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 285)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 15)
        Label7.TabIndex = 4
        Label7.Text = "Current Balance:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 316)
        Label8.Name = "Label8"
        Label8.Size = New Size(108, 15)
        Label8.TabIndex = 5
        Label8.Text = "Withdraw Amount:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(176, 24)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(169, 25)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(176, 55)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(169, 25)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(176, 88)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(169, 25)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(145, 219)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(176, 23)
        TextBox4.TabIndex = 6
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(145, 252)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(176, 23)
        TextBox5.TabIndex = 7
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(145, 281)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(176, 23)
        TextBox6.TabIndex = 8
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(145, 308)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(176, 23)
        TextBox7.TabIndex = 9
        ' 
        ' SearchWithdrawButton
        ' 
        SearchWithdrawButton.Location = New Point(220, 123)
        SearchWithdrawButton.Name = "SearchWithdrawButton"
        SearchWithdrawButton.Size = New Size(75, 23)
        SearchWithdrawButton.TabIndex = 7
        SearchWithdrawButton.Text = "Search"
        SearchWithdrawButton.UseVisualStyleBackColor = True
        ' 
        ' WithdrawForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(752, 357)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "WithdrawForm"
        Text = "Withdraw Form"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents SearchWithdrawButton As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox


    Private Sub SearchWithdrawButton_Click(sender As Object, e As EventArgs) Handles SearchWithdrawButton.Click
        ' Perform search operation to fetch account details and customer information
        ' You can implement the search functionality here based on the account number entered
        ' For demonstration purposes, let's assume the details are fetched from a database
        ' and stored in variables

        ' Example data (replace with actual database retrieval logic)
        accountNumber = TextBox1.Text
        accountTitle = TextBox2.Text
        nicNumber = TextBox3.Text

        ' Example customer information (replace with actual data retrieval)
        customerName = "John Doe"
        currentBalance = 5000 ' Example current balance

        ' Display customer information
        TextBox4.Text = customerName
        TextBox5.Text = accountTitle
        TextBox6.Text = currentBalance.ToString("C") ' Display balance in currency format
    End Sub

    Private Sub WithdrawAmount()
        ' Validate withdrawal amount
        If Decimal.TryParse(TextBox7.Text, withdrawalAmount) Then
            ' Check if withdrawal amount is less than or equal to current balance
            If withdrawalAmount <= currentBalance Then
                ' Process withdrawal (you can implement withdrawal logic here)
                ' For demonstration purposes, let's assume the withdrawal is successful
                MessageBox.Show("Withdrawal successful!")
                ' Update current balance
                currentBalance -= withdrawalAmount
                ' Update displayed current balance
                TextBox6.Text = currentBalance.ToString("C")
            Else
                MessageBox.Show("Insufficient funds!")
            End If
        Else
            MessageBox.Show("Invalid withdrawal amount!")
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        ' Allow only numeric input and control keys (Backspace, Delete, etc.)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyDown
        ' Process withdrawal when Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            WithdrawAmount()
        End If
    End Sub

    Private Sub TextBox7_Leave(sender As Object, e As EventArgs) Handles TextBox7.Leave
        ' Process withdrawal when TextBox loses focus
        WithdrawAmount()
    End Sub
End Class

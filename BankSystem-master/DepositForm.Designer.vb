<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepositForm
    Inherits System.Windows.Forms.Form

    ' Variables to store user inputs
    Private accountNumber As String
    Private accountTitle As String
    Private nicNumber As String

    ' Variables to store values from the database
    Private customerName As String
    Private accountTitleFromDB As String
    Private currentBalance As Decimal
    Private depositAmount As Decimal

    Private Sub SearchDepositButton_Click(sender As Object, e As EventArgs) Handles SearchDepositButton.Click
        ' Here you would typically integrate database operations to retrieve values based on user input.
        ' For this example, I'll just demonstrate storing the values in the variables.
        accountNumber = TextBox1.Text
        accountTitle = TextBox2.Text
        nicNumber = TextBox3.Text

        'get values from db

        ' Display values in textboxes
        TextBox4.Text = customerName
        TextBox5.Text = accountTitleFromDB
        TextBox6.Text = currentBalance.ToString()
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
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        SearchDepositButton = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(37, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 0
        Label1.Text = "Deposit:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(SearchDepositButton)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(250, 19)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(407, 172)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Search Account"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 17)
        Label2.TabIndex = 0
        Label2.Text = "Account Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 17)
        Label3.TabIndex = 1
        Label3.Text = "Account Title:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 17)
        Label4.TabIndex = 2
        Label4.Text = "NIC Number:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(208, 34)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(146, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(208, 66)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(146, 25)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(208, 97)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(146, 25)
        TextBox3.TabIndex = 5
        ' 
        ' SearchDepositButton
        ' 
        SearchDepositButton.Location = New Point(249, 144)
        SearchDepositButton.Name = "SearchDepositButton"
        SearchDepositButton.Size = New Size(75, 23)
        SearchDepositButton.TabIndex = 6
        SearchDepositButton.Text = "Search"
        SearchDepositButton.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 15)
        Label5.TabIndex = 2
        Label5.Text = "Customer Name:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(20, 258)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 15)
        Label6.TabIndex = 3
        Label6.Text = "Account Title:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(20, 293)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 15)
        Label7.TabIndex = 4
        Label7.Text = "Current Balance:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(20, 325)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 15)
        Label8.TabIndex = 5
        Label8.Text = "Deposit Amount:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(140, 215)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(218, 23)
        TextBox4.TabIndex = 6
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(140, 250)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(218, 23)
        TextBox5.TabIndex = 7
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(140, 285)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(218, 23)
        TextBox6.TabIndex = 8
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(140, 322)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(218, 23)
        TextBox7.TabIndex = 9
        ' 
        ' DepositForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(750, 355)
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
        Name = "DepositForm"
        Text = "Deposit Amount Form"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchDepositButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
End Class

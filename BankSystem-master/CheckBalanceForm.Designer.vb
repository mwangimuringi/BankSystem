<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckBalanceForm
    Inherits System.Windows.Forms.Form
    Private customerName As String = "Mark"
    Private accountNumber As String = "" ' Initialize to empty string
    Private accountTitle As String = "" ' Initialize to empty string
    Private nicNumber As String = "" ' Initialize to empty string
    Private currentBalance As Double

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        SearchBalanceButton = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 0
        Label1.Text = "Check Balance:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(SearchBalanceButton)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(291, 32)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(353, 165)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Search Amount"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(152, 102)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(180, 25)
        TextBox6.TabIndex = 5
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(152, 68)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(180, 25)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(152, 31)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(180, 25)
        TextBox4.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 17)
        Label4.TabIndex = 2
        Label4.Text = "NIC Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 17)
        Label3.TabIndex = 1
        Label3.Text = "Account Title:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 17)
        Label2.TabIndex = 0
        Label2.Text = "Account Number:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 15)
        Label5.TabIndex = 2
        Label5.Text = "Customer Name:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(33, 244)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 15)
        Label6.TabIndex = 3
        Label6.Text = "Account Title:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(33, 282)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 15)
        Label7.TabIndex = 4
        Label7.Text = "Current Balance:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(174, 203)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(171, 23)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(174, 241)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(171, 23)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(174, 279)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(171, 23)
        TextBox3.TabIndex = 7
        ' 
        ' SearchBalanceButton
        ' 
        SearchBalanceButton.Location = New Point(223, 136)
        SearchBalanceButton.Name = "SearchBalanceButton"
        SearchBalanceButton.Size = New Size(93, 23)
        SearchBalanceButton.TabIndex = 6
        SearchBalanceButton.Text = "Search"
        SearchBalanceButton.UseVisualStyleBackColor = True
        ' 
        ' CheckBalanceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(755, 356)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "CheckBalanceForm"
        Text = "Check Balance Form"
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
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents SearchBalanceButton As Button

    Private Sub SearchBalanceButton_Click(sender As Object, e As EventArgs) Handles SearchBalanceButton.Click
        ' Assuming you're retrieving data from a database or some other source
        ' You would assign values to these variables based on the search result
        currentBalance = GetBalanceFromDB() ' Example function to retrieve balance from database
        TextBox2.Text = currentBalance

        ' Now you can use these variables as needed
    End Sub

    Private Function GetBalanceFromDB() As Double
        ' Example function to simulate retrieving balance from database
        Return 1000.0 ' Replace with actual logic to retrieve balance
    End Function
    Private Function GetCustomerNameFromDB() As String
        ' Example function to simulate retrieving customerName from database
        Return "John Doe" ' Replace with actual logic to retrieve customerName
    End Function

    Private Sub CheckBalanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default values for accountNumber, accountTitle, and nicNumber
        TextBox4.Text = "123456789" ' Example default account number
        TextBox5.Text = "Savings Account" ' Example default account title
        TextBox6.Text = "1234567890" ' Example default NIC number
    End Sub
End Class

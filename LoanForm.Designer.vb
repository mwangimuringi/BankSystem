<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanForm
    Inherits System.Windows.Forms.Form

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
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        ExitLoanButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(0, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(372, 297)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Borrow Loan"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(TextBox8)
        GroupBox2.Controls.Add(TextBox9)
        GroupBox2.Controls.Add(TextBox10)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(399, 22)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(345, 287)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Pay Loan"
        ' 
        ' ExitLoanButton
        ' 
        ExitLoanButton.Location = New Point(511, 315)
        ExitLoanButton.Name = "ExitLoanButton"
        ExitLoanButton.Size = New Size(149, 36)
        ExitLoanButton.TabIndex = 2
        ExitLoanButton.Text = "E&xit"
        ExitLoanButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 20)
        Label1.TabIndex = 0
        Label1.Text = "Customer Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 20)
        Label2.TabIndex = 1
        Label2.Text = "Account Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 20)
        Label3.TabIndex = 2
        Label3.Text = "Loan Amount:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 232)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 20)
        Label5.TabIndex = 4
        Label5.Text = "Loan Interest:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(157, 45)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(165, 27)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(157, 90)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(165, 27)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(157, 139)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(165, 27)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(157, 236)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(165, 27)
        TextBox5.TabIndex = 9
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(161, 225)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(165, 27)
        TextBox6.TabIndex = 19
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(161, 171)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(165, 27)
        TextBox7.TabIndex = 18
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(161, 128)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(165, 27)
        TextBox8.TabIndex = 17
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(161, 79)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(165, 27)
        TextBox9.TabIndex = 16
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(161, 34)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(165, 27)
        TextBox10.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(25, 221)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 20)
        Label6.TabIndex = 14
        Label6.Text = "Total Loan Paid:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(19, 171)
        Label7.Name = "Label7"
        Label7.Size = New Size(122, 20)
        Label7.TabIndex = 13
        Label7.Text = "MonthlyInterest:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(19, 125)
        Label8.Name = "Label8"
        Label8.Size = New Size(105, 20)
        Label8.TabIndex = 12
        Label8.Text = "Loan Amount:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(19, 79)
        Label9.Name = "Label9"
        Label9.Size = New Size(131, 20)
        Label9.TabIndex = 11
        Label9.Text = "Account Number:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(19, 37)
        Label10.Name = "Label10"
        Label10.Size = New Size(123, 20)
        Label10.TabIndex = 10
        Label10.Text = "Customer Name:"
        ' 
        ' LoanForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(756, 356)
        Controls.Add(ExitLoanButton)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "LoanForm"
        Text = "Loan Form"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ExitLoanButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class

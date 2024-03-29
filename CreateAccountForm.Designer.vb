<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccountForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        GroupBox2 = New GroupBox()
        PictureBox2 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        MaleRadioButton = New RadioButton()
        FemaleRadioButton = New RadioButton()
        OtherRadioButton = New RadioButton()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        CreateAccountButton = New Button()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 20)
        Label1.TabIndex = 0
        Label1.Text = "Customer Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 20)
        Label2.TabIndex = 1
        Label2.Text = "Account Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 20)
        Label3.TabIndex = 2
        Label3.Text = "Account Title:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 20)
        Label4.TabIndex = 3
        Label4.Text = "Gender:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 136)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 20)
        Label5.TabIndex = 4
        Label5.Text = "Date Of Birth:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 167)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 20)
        Label6.TabIndex = 5
        Label6.Text = "Nationality:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 196)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 20)
        Label7.TabIndex = 6
        Label7.Text = "Postal Address:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 228)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 20)
        Label8.TabIndex = 7
        Label8.Text = "Phone Number:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 258)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 20)
        Label9.TabIndex = 8
        Label9.Text = "Email Address:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(11, 290)
        Label10.Name = "Label10"
        Label10.Size = New Size(91, 20)
        Label10.TabIndex = 9
        Label10.Text = "Occupation:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(11, 323)
        Label11.Name = "Label11"
        Label11.Size = New Size(107, 20)
        Label11.TabIndex = 10
        Label11.Text = "Initial Deposit:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Location = New Point(512, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(209, 164)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Passport Photo"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(6, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(142, 108)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(PictureBox2)
        GroupBox2.Location = New Point(512, 174)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 115)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Signature Here"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(25, 18)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(134, 64)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(182, 9)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(190, 23)
        TextBox1.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(182, 38)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(190, 23)
        TextBox2.TabIndex = 14
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(182, 71)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(190, 23)
        TextBox3.TabIndex = 15
        ' 
        ' MaleRadioButton
        ' 
        MaleRadioButton.AutoSize = True
        MaleRadioButton.Location = New Point(182, 100)
        MaleRadioButton.Name = "MaleRadioButton"
        MaleRadioButton.Size = New Size(61, 24)
        MaleRadioButton.TabIndex = 16
        MaleRadioButton.TabStop = True
        MaleRadioButton.Text = "Male"
        MaleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' FemaleRadioButton
        ' 
        FemaleRadioButton.AutoSize = True
        FemaleRadioButton.Location = New Point(253, 102)
        FemaleRadioButton.Name = "FemaleRadioButton"
        FemaleRadioButton.Size = New Size(76, 24)
        FemaleRadioButton.TabIndex = 17
        FemaleRadioButton.TabStop = True
        FemaleRadioButton.Text = "Female"
        FemaleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' OtherRadioButton
        ' 
        OtherRadioButton.AutoSize = True
        OtherRadioButton.Location = New Point(335, 100)
        OtherRadioButton.Name = "OtherRadioButton"
        OtherRadioButton.Size = New Size(66, 24)
        OtherRadioButton.TabIndex = 18
        OtherRadioButton.TabStop = True
        OtherRadioButton.Text = "Other"
        OtherRadioButton.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(182, 167)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(190, 23)
        TextBox5.TabIndex = 20
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(182, 193)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(190, 23)
        TextBox6.TabIndex = 21
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(182, 289)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(190, 27)
        TextBox9.TabIndex = 24
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(182, 320)
        TextBox10.Multiline = True
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(190, 23)
        TextBox10.TabIndex = 25
        ' 
        ' CreateAccountButton
        ' 
        CreateAccountButton.Location = New Point(537, 295)
        CreateAccountButton.Name = "CreateAccountButton"
        CreateAccountButton.Size = New Size(158, 37)
        CreateAccountButton.TabIndex = 26
        CreateAccountButton.Text = "Create Account"
        CreateAccountButton.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"+253", "+254", "+233", "+44", "+280", "+244"})
        ComboBox1.Location = New Point(182, 222)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(190, 28)
        ComboBox1.TabIndex = 27
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005"})
        ComboBox2.Location = New Point(182, 133)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(190, 28)
        ComboBox2.TabIndex = 28
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"@gmail.com", "@yahoo.com", "@go.ke"})
        ComboBox3.Location = New Point(182, 255)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(190, 28)
        ComboBox3.TabIndex = 29
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(122, 134)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 25)
        Button1.TabIndex = 1
        Button1.Text = "Browse"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CreateAccountForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(755, 346)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(CreateAccountButton)
        Controls.Add(TextBox10)
        Controls.Add(TextBox9)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(OtherRadioButton)
        Controls.Add(FemaleRadioButton)
        Controls.Add(MaleRadioButton)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "CreateAccountForm"
        Text = "Create new account"
        GroupBox1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents OtherRadioButton As RadioButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents CreateAccountButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button1 As Button
End Class

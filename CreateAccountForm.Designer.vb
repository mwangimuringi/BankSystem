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
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        GroupBox2 = New GroupBox()
        PictureBox2 = New PictureBox()
        FirstName = New TextBox()
        AccountNumber = New TextBox()
        AccountTitle = New TextBox()
        MaleRadioButton = New RadioButton()
        FemaleRadioButton = New RadioButton()
        Nationality = New TextBox()
        PostalAddress = New TextBox()
        Occupation = New TextBox()
        InitialDeposit = New TextBox()
        CreateAccountButton = New Button()
        PhoneNumber = New ComboBox()
        EmailAddress = New ComboBox()
        Label12 = New Label()
        NationalID = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        SecondName = New TextBox()
        Surname = New TextBox()
        DateOfBirth = New DateTimePicker()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 25)
        Label1.TabIndex = 0
        Label1.Text = "First Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 238)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 25)
        Label2.TabIndex = 1
        Label2.Text = "Account Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 284)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 25)
        Label3.TabIndex = 2
        Label3.Text = "Account Title:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 337)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 25)
        Label4.TabIndex = 3
        Label4.Text = "Gender:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 386)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 25)
        Label5.TabIndex = 4
        Label5.Text = "Date Of Birth:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(11, 435)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 25)
        Label6.TabIndex = 5
        Label6.Text = "Nationality:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(9, 484)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 25)
        Label7.TabIndex = 6
        Label7.Text = "Postal Address:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(8, 522)
        Label8.Name = "Label8"
        Label8.Size = New Size(148, 25)
        Label8.TabIndex = 7
        Label8.Text = "Phone Number:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(7, 562)
        Label9.Name = "Label9"
        Label9.Size = New Size(137, 25)
        Label9.TabIndex = 8
        Label9.Text = "Email Address:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(9, 605)
        Label10.Name = "Label10"
        Label10.Size = New Size(115, 25)
        Label10.TabIndex = 9
        Label10.Text = "Occupation:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(7, 647)
        Label11.Name = "Label11"
        Label11.Size = New Size(137, 25)
        Label11.TabIndex = 10
        Label11.Text = "Initial Deposit:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Location = New Point(512, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(209, 185)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Passport Photo"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(116, 149)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 30)
        Button1.TabIndex = 1
        Button1.Text = "Browse"
        Button1.UseVisualStyleBackColor = True
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
        GroupBox2.Location = New Point(512, 193)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(209, 147)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Signature Here"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(6, 45)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(188, 96)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' FirstName
        ' 
        FirstName.Location = New Point(182, 9)
        FirstName.Multiline = True
        FirstName.Name = "FirstName"
        FirstName.Size = New Size(250, 42)
        FirstName.TabIndex = 13
        ' 
        ' AccountNumber
        ' 
        AccountNumber.Location = New Point(182, 229)
        AccountNumber.Multiline = True
        AccountNumber.Name = "AccountNumber"
        AccountNumber.Size = New Size(250, 42)
        AccountNumber.TabIndex = 14
        ' 
        ' AccountTitle
        ' 
        AccountTitle.Location = New Point(182, 284)
        AccountTitle.Multiline = True
        AccountTitle.Name = "AccountTitle"
        AccountTitle.Size = New Size(250, 42)
        AccountTitle.TabIndex = 15
        ' 
        ' MaleRadioButton
        ' 
        MaleRadioButton.AutoSize = True
        MaleRadioButton.Location = New Point(182, 333)
        MaleRadioButton.Name = "MaleRadioButton"
        MaleRadioButton.Size = New Size(76, 29)
        MaleRadioButton.TabIndex = 16
        MaleRadioButton.TabStop = True
        MaleRadioButton.Text = "Male"
        MaleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' FemaleRadioButton
        ' 
        FemaleRadioButton.AutoSize = True
        FemaleRadioButton.Location = New Point(277, 333)
        FemaleRadioButton.Name = "FemaleRadioButton"
        FemaleRadioButton.Size = New Size(95, 29)
        FemaleRadioButton.TabIndex = 17
        FemaleRadioButton.TabStop = True
        FemaleRadioButton.Text = "Female"
        FemaleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Nationality
        ' 
        Nationality.Location = New Point(182, 421)
        Nationality.Multiline = True
        Nationality.Name = "Nationality"
        Nationality.Size = New Size(250, 39)
        Nationality.TabIndex = 20
        ' 
        ' PostalAddress
        ' 
        PostalAddress.Location = New Point(182, 470)
        PostalAddress.Multiline = True
        PostalAddress.Name = "PostalAddress"
        PostalAddress.Size = New Size(250, 39)
        PostalAddress.TabIndex = 21
        ' 
        ' Occupation
        ' 
        Occupation.Location = New Point(182, 605)
        Occupation.Name = "Occupation"
        Occupation.Size = New Size(250, 32)
        Occupation.TabIndex = 24
        ' 
        ' InitialDeposit
        ' 
        InitialDeposit.Location = New Point(182, 647)
        InitialDeposit.Multiline = True
        InitialDeposit.Name = "InitialDeposit"
        InitialDeposit.Size = New Size(250, 32)
        InitialDeposit.TabIndex = 25
        ' 
        ' CreateAccountButton
        ' 
        CreateAccountButton.Location = New Point(512, 641)
        CreateAccountButton.Name = "CreateAccountButton"
        CreateAccountButton.Size = New Size(209, 37)
        CreateAccountButton.TabIndex = 26
        CreateAccountButton.Text = "Create Account"
        CreateAccountButton.UseVisualStyleBackColor = True
        ' 
        ' PhoneNumber
        ' 
        PhoneNumber.FormattingEnabled = True
        PhoneNumber.Items.AddRange(New Object() {"+253", "+254", "+233", "+44", "+280", "+244"})
        PhoneNumber.Location = New Point(182, 519)
        PhoneNumber.Name = "PhoneNumber"
        PhoneNumber.Size = New Size(250, 33)
        PhoneNumber.TabIndex = 27
        ' 
        ' EmailAddress
        ' 
        EmailAddress.FormattingEnabled = True
        EmailAddress.Items.AddRange(New Object() {"@gmail.com", "@yahoo.com", "@go.ke"})
        EmailAddress.Location = New Point(182, 562)
        EmailAddress.Name = "EmailAddress"
        EmailAddress.Size = New Size(250, 33)
        EmailAddress.TabIndex = 29
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(13, 177)
        Label12.Name = "Label12"
        Label12.Size = New Size(111, 25)
        Label12.TabIndex = 0
        Label12.Text = "National ID"
        ' 
        ' NationalID
        ' 
        NationalID.Location = New Point(182, 174)
        NationalID.Multiline = True
        NationalID.Name = "NationalID"
        NationalID.Size = New Size(250, 42)
        NationalID.TabIndex = 13
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(13, 67)
        Label13.Name = "Label13"
        Label13.Size = New Size(136, 25)
        Label13.TabIndex = 0
        Label13.Text = "Second Name:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(13, 122)
        Label14.Name = "Label14"
        Label14.Size = New Size(88, 25)
        Label14.TabIndex = 0
        Label14.Text = "Surname"
        ' 
        ' SecondName
        ' 
        SecondName.Location = New Point(182, 64)
        SecondName.Multiline = True
        SecondName.Name = "SecondName"
        SecondName.Size = New Size(250, 42)
        SecondName.TabIndex = 13
        ' 
        ' Surname
        ' 
        Surname.Location = New Point(182, 119)
        Surname.Multiline = True
        Surname.Name = "Surname"
        Surname.Size = New Size(250, 42)
        Surname.TabIndex = 13
        ' 
        ' DateOfBirth
        ' 
        DateOfBirth.Location = New Point(182, 379)
        DateOfBirth.Name = "DateOfBirth"
        DateOfBirth.Size = New Size(250, 32)
        DateOfBirth.TabIndex = 30
        ' 
        ' CreateAccountForm
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(755, 686)
        Controls.Add(DateOfBirth)
        Controls.Add(EmailAddress)
        Controls.Add(PhoneNumber)
        Controls.Add(CreateAccountButton)
        Controls.Add(InitialDeposit)
        Controls.Add(Occupation)
        Controls.Add(PostalAddress)
        Controls.Add(Nationality)
        Controls.Add(FemaleRadioButton)
        Controls.Add(MaleRadioButton)
        Controls.Add(AccountTitle)
        Controls.Add(AccountNumber)
        Controls.Add(NationalID)
        Controls.Add(Surname)
        Controls.Add(SecondName)
        Controls.Add(FirstName)
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
        Controls.Add(Label12)
        Controls.Add(Label14)
        Controls.Add(Label13)
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
    Friend WithEvents FirstName As TextBox
    Friend WithEvents AccountNumber As TextBox
    Friend WithEvents AccountTitle As TextBox
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents Nationality As TextBox
    Friend WithEvents PostalAddress As TextBox
    Friend WithEvents Occupation As TextBox
    Friend WithEvents InitialDeposit As TextBox
    Friend WithEvents CreateAccountButton As Button
    Friend WithEvents PhoneNumber As ComboBox
    Friend WithEvents EmailAddress As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents NationalID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents SecondName As TextBox
    Friend WithEvents Surname As TextBox
    Friend WithEvents DateOfBirth As DateTimePicker
End Class

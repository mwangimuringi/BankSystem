<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WithdrawalForm
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
        Me.AccountTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.WithdrawButton = New System.Windows.Forms.Button()
        Me.AccountNumberLabel = New System.Windows.Forms.Label()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AccountTextBox
        '
        Me.AccountTextBox.Location = New System.Drawing.Point(272, 175)
        Me.AccountTextBox.Name = "AccountTextBox"
        Me.AccountTextBox.Size = New System.Drawing.Size(191, 20)
        Me.AccountTextBox.TabIndex = 0
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(272, 235)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(191, 20)
        Me.AmountTextBox.TabIndex = 1
        '
        'WithdrawButton
        '
        Me.WithdrawButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WithdrawButton.Location = New System.Drawing.Point(314, 305)
        Me.WithdrawButton.Name = "WithdrawButton"
        Me.WithdrawButton.Size = New System.Drawing.Size(98, 23)
        Me.WithdrawButton.TabIndex = 2
        Me.WithdrawButton.Text = "WITHDRAW"
        Me.WithdrawButton.UseVisualStyleBackColor = True
        '
        'AccountNumberLabel
        '
        Me.AccountNumberLabel.AutoSize = True
        Me.AccountNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountNumberLabel.Location = New System.Drawing.Point(114, 182)
        Me.AccountNumberLabel.Name = "AccountNumberLabel"
        Me.AccountNumberLabel.Size = New System.Drawing.Size(105, 13)
        Me.AccountNumberLabel.TabIndex = 3
        Me.AccountNumberLabel.Text = "Account Number:"
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountLabel.Location = New System.Drawing.Point(114, 235)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(129, 13)
        Me.AmountLabel.TabIndex = 4
        Me.AmountLabel.Text = "Amount To Withdraw:"
        '
        'WithdrawalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.AccountNumberLabel)
        Me.Controls.Add(Me.WithdrawButton)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.AccountTextBox)
        Me.Name = "WithdrawalForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AccountTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents WithdrawButton As Button
    Friend WithEvents AccountNumberLabel As Label
    Friend WithEvents AmountLabel As Label
End Class

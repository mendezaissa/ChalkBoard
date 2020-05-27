<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 83)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ChalkBoard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.usernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameLabel.Location = New System.Drawing.Point(244, 192)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(118, 25)
        Me.usernameLabel.TabIndex = 1
        Me.usernameLabel.Text = "Username"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.BackColor = System.Drawing.Color.Transparent
        Me.passwordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLabel.Location = New System.Drawing.Point(244, 284)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(114, 25)
        Me.passwordLabel.TabIndex = 2
        Me.passwordLabel.Text = "Password"
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(249, 220)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(191, 29)
        Me.usernameTextBox.TabIndex = 3
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(249, 312)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextBox.Size = New System.Drawing.Size(191, 29)
        Me.passwordTextBox.TabIndex = 4
        '
        'loginButton
        '
        Me.loginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.Location = New System.Drawing.Point(249, 371)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(98, 37)
        Me.loginButton.TabIndex = 5
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'loginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SE_Project.My.Resources.Resources.chalkboard_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(758, 638)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.usernameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "loginPage"
        Me.Text = "ChalkBoard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents loginButton As Button
End Class

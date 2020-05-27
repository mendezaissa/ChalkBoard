<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student1Form
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
        Me.seLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.mlLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.logoutButton1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "My Courses"
        '
        'seLinkLabel
        '
        Me.seLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.seLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seLinkLabel.Location = New System.Drawing.Point(47, 114)
        Me.seLinkLabel.Name = "seLinkLabel"
        Me.seLinkLabel.Size = New System.Drawing.Size(431, 36)
        Me.seLinkLabel.TabIndex = 1
        Me.seLinkLabel.TabStop = True
        Me.seLinkLabel.Text = "Spring 2019 CS 3321 TTH 11:30-12:45pm"
        Me.seLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mlLinkLabel
        '
        Me.mlLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.mlLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mlLinkLabel.Location = New System.Drawing.Point(48, 174)
        Me.mlLinkLabel.Name = "mlLinkLabel"
        Me.mlLinkLabel.Size = New System.Drawing.Size(351, 39)
        Me.mlLinkLabel.TabIndex = 2
        Me.mlLinkLabel.TabStop = True
        Me.mlLinkLabel.Text = "Spring 2019 CS 4319 Fully Online"
        Me.mlLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'logoutButton1
        '
        Me.logoutButton1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.logoutButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutButton1.Location = New System.Drawing.Point(704, 36)
        Me.logoutButton1.Name = "logoutButton1"
        Me.logoutButton1.Size = New System.Drawing.Size(87, 40)
        Me.logoutButton1.TabIndex = 3
        Me.logoutButton1.Text = "Log Out"
        Me.logoutButton1.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(48, 244)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(431, 36)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Spring 2019 4332 T 1:00pm-2:15pm"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(47, 320)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(431, 36)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Spring 2019 CS 2401 TTH 8:30am-9:45am"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'student1Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SE_Project.My.Resources.Resources.chalk_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(950, 547)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.logoutButton1)
        Me.Controls.Add(Me.mlLinkLabel)
        Me.Controls.Add(Me.seLinkLabel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "student1Form"
        Me.Text = "Mendez, Aissa"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents seLinkLabel As LinkLabel
    Friend WithEvents mlLinkLabel As LinkLabel
    Friend WithEvents logoutButton1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class

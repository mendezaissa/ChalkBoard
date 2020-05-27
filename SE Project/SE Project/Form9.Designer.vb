<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class softEngForm
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
        Me.seHomePage = New System.Windows.Forms.Label()
        Me.seGrades = New System.Windows.Forms.LinkLabel()
        Me.hwLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.mymessagesLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.seBackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'seHomePage
        '
        Me.seHomePage.AutoSize = True
        Me.seHomePage.BackColor = System.Drawing.Color.Transparent
        Me.seHomePage.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seHomePage.Location = New System.Drawing.Point(63, 41)
        Me.seHomePage.Name = "seHomePage"
        Me.seHomePage.Size = New System.Drawing.Size(208, 39)
        Me.seHomePage.TabIndex = 1
        Me.seHomePage.Text = "Home Page"
        '
        'seGrades
        '
        Me.seGrades.BackColor = System.Drawing.Color.Transparent
        Me.seGrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seGrades.Location = New System.Drawing.Point(66, 119)
        Me.seGrades.Name = "seGrades"
        Me.seGrades.Size = New System.Drawing.Size(131, 42)
        Me.seGrades.TabIndex = 2
        Me.seGrades.TabStop = True
        Me.seGrades.Text = "My Grades"
        Me.seGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'hwLinkLabel
        '
        Me.hwLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.hwLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hwLinkLabel.Location = New System.Drawing.Point(66, 192)
        Me.hwLinkLabel.Name = "hwLinkLabel"
        Me.hwLinkLabel.Size = New System.Drawing.Size(141, 40)
        Me.hwLinkLabel.TabIndex = 3
        Me.hwLinkLabel.TabStop = True
        Me.hwLinkLabel.Text = "Homework"
        Me.hwLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(66, 278)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(112, 37)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Syllabus"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mymessagesLinkLabel
        '
        Me.mymessagesLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.mymessagesLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mymessagesLinkLabel.Location = New System.Drawing.Point(66, 351)
        Me.mymessagesLinkLabel.Name = "mymessagesLinkLabel"
        Me.mymessagesLinkLabel.Size = New System.Drawing.Size(158, 38)
        Me.mymessagesLinkLabel.TabIndex = 5
        Me.mymessagesLinkLabel.TabStop = True
        Me.mymessagesLinkLabel.Text = "My Messages"
        Me.mymessagesLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seBackButton
        '
        Me.seBackButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.seBackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seBackButton.Location = New System.Drawing.Point(635, 43)
        Me.seBackButton.Name = "seBackButton"
        Me.seBackButton.Size = New System.Drawing.Size(91, 50)
        Me.seBackButton.TabIndex = 6
        Me.seBackButton.Text = "Back to My Courses"
        Me.seBackButton.UseVisualStyleBackColor = False
        '
        'softEngForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SE_Project.My.Resources.Resources.chalk_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(818, 564)
        Me.Controls.Add(Me.seBackButton)
        Me.Controls.Add(Me.mymessagesLinkLabel)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.hwLinkLabel)
        Me.Controls.Add(Me.seGrades)
        Me.Controls.Add(Me.seHomePage)
        Me.Name = "softEngForm"
        Me.Text = "Software Engineering"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents seHomePage As Label
    Friend WithEvents seGrades As LinkLabel
    Friend WithEvents hwLinkLabel As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents mymessagesLinkLabel As LinkLabel
    Friend WithEvents seBackButton As Button
End Class

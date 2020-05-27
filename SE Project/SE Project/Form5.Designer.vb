<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class machineForm
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
        Me.mlHomePage = New System.Windows.Forms.Label()
        Me.mLgrades = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.backButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mlHomePage
        '
        Me.mlHomePage.AutoSize = True
        Me.mlHomePage.BackColor = System.Drawing.Color.Transparent
        Me.mlHomePage.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mlHomePage.Location = New System.Drawing.Point(64, 40)
        Me.mlHomePage.Name = "mlHomePage"
        Me.mlHomePage.Size = New System.Drawing.Size(208, 39)
        Me.mlHomePage.TabIndex = 0
        Me.mlHomePage.Text = "Home Page"
        '
        'mLgrades
        '
        Me.mLgrades.BackColor = System.Drawing.Color.Transparent
        Me.mLgrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mLgrades.Location = New System.Drawing.Point(67, 126)
        Me.mLgrades.Name = "mLgrades"
        Me.mLgrades.Size = New System.Drawing.Size(138, 47)
        Me.mLgrades.TabIndex = 1
        Me.mLgrades.TabStop = True
        Me.mLgrades.Text = "My Grades"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(67, 197)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(134, 52)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Homework"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(67, 277)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(100, 23)
        Me.LinkLabel3.TabIndex = 3
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Syllabus"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(67, 350)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(149, 36)
        Me.LinkLabel4.TabIndex = 4
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "My Messages"
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.backButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.Location = New System.Drawing.Point(637, 40)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(102, 53)
        Me.backButton.TabIndex = 5
        Me.backButton.Text = "Back to My Courses"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'machineForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SE_Project.My.Resources.Resources.chalk_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(817, 544)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.mLgrades)
        Me.Controls.Add(Me.mlHomePage)
        Me.Name = "machineForm"
        Me.Text = "Machine Learning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mlHomePage As Label
    Friend WithEvents mLgrades As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents backButton As Button
End Class

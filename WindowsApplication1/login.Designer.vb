<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLogin))
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.labelBack = New System.Windows.Forms.Label()
        Me.labelMsgWrong = New System.Windows.Forms.Label()
        Me.bLogin = New System.Windows.Forms.Button()
        Me.labelCPassword = New System.Windows.Forms.Label()
        Me.textUserName = New System.Windows.Forms.TextBox()
        Me.labelRNewUser = New System.Windows.Forms.Label()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.picAdmin = New System.Windows.Forms.PictureBox()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelTitle
        '
        Me.labelTitle.AutoSize = True
        Me.labelTitle.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle.Font = New System.Drawing.Font("Beatnik SF", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.White
        Me.labelTitle.Location = New System.Drawing.Point(337, 86)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(228, 33)
        Me.labelTitle.TabIndex = 2
        Me.labelTitle.Text = "Select  Account"
        '
        'textPassword
        '
        Me.textPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textPassword.Font = New System.Drawing.Font("Beatnik SF", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPassword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.textPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.textPassword.Location = New System.Drawing.Point(316, 379)
        Me.textPassword.MaxLength = 10
        Me.textPassword.Name = "textPassword"
        Me.textPassword.Size = New System.Drawing.Size(278, 35)
        Me.textPassword.TabIndex = 3
        Me.textPassword.Text = "Password"
        Me.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.textPassword.Visible = False
        '
        'labelBack
        '
        Me.labelBack.AutoSize = True
        Me.labelBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelBack.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelBack.Location = New System.Drawing.Point(313, 292)
        Me.labelBack.Name = "labelBack"
        Me.labelBack.Size = New System.Drawing.Size(45, 18)
        Me.labelBack.TabIndex = 4
        Me.labelBack.Tag = "Back"
        Me.labelBack.Text = "Back"
        Me.labelBack.Visible = False
        '
        'labelMsgWrong
        '
        Me.labelMsgWrong.AutoSize = True
        Me.labelMsgWrong.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMsgWrong.ForeColor = System.Drawing.Color.Red
        Me.labelMsgWrong.Location = New System.Drawing.Point(616, 389)
        Me.labelMsgWrong.Name = "labelMsgWrong"
        Me.labelMsgWrong.Size = New System.Drawing.Size(140, 18)
        Me.labelMsgWrong.TabIndex = 5
        Me.labelMsgWrong.Text = "Wrong Password!"
        Me.labelMsgWrong.Visible = False
        '
        'bLogin
        '
        Me.bLogin.BackColor = System.Drawing.Color.DimGray
        Me.bLogin.Font = New System.Drawing.Font("Beatnik SF", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLogin.ForeColor = System.Drawing.Color.White
        Me.bLogin.Location = New System.Drawing.Point(532, 335)
        Me.bLogin.Name = "bLogin"
        Me.bLogin.Size = New System.Drawing.Size(63, 23)
        Me.bLogin.TabIndex = 6
        Me.bLogin.Text = "Login"
        Me.bLogin.UseVisualStyleBackColor = False
        Me.bLogin.Visible = False
        '
        'labelCPassword
        '
        Me.labelCPassword.AutoSize = True
        Me.labelCPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelCPassword.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelCPassword.Location = New System.Drawing.Point(12, 47)
        Me.labelCPassword.Name = "labelCPassword"
        Me.labelCPassword.Size = New System.Drawing.Size(151, 18)
        Me.labelCPassword.TabIndex = 7
        Me.labelCPassword.Tag = "Back"
        Me.labelCPassword.Text = "Change password"
        '
        'textUserName
        '
        Me.textUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.textUserName.Font = New System.Drawing.Font("Beatnik SF", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textUserName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.textUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.textUserName.Location = New System.Drawing.Point(317, 323)
        Me.textUserName.MaxLength = 10
        Me.textUserName.Name = "textUserName"
        Me.textUserName.Size = New System.Drawing.Size(278, 35)
        Me.textUserName.TabIndex = 8
        Me.textUserName.Text = "Username"
        Me.textUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.textUserName.Visible = False
        '
        'labelRNewUser
        '
        Me.labelRNewUser.AutoSize = True
        Me.labelRNewUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelRNewUser.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRNewUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelRNewUser.Location = New System.Drawing.Point(12, 12)
        Me.labelRNewUser.Name = "labelRNewUser"
        Me.labelRNewUser.Size = New System.Drawing.Size(142, 18)
        Me.labelRNewUser.TabIndex = 9
        Me.labelRNewUser.Tag = "Back"
        Me.labelRNewUser.Text = "Register new user"
        '
        'picUser
        '
        Me.picUser.BackColor = System.Drawing.Color.Transparent
        Me.picUser.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.userlogo2
        Me.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picUser.Location = New System.Drawing.Point(532, 175)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(99, 96)
        Me.picUser.TabIndex = 1
        Me.picUser.TabStop = False
        '
        'picAdmin
        '
        Me.picAdmin.BackColor = System.Drawing.Color.Transparent
        Me.picAdmin.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.adminlogo2
        Me.picAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picAdmin.Location = New System.Drawing.Point(284, 175)
        Me.picAdmin.Name = "picAdmin"
        Me.picAdmin.Size = New System.Drawing.Size(98, 96)
        Me.picAdmin.TabIndex = 0
        Me.picAdmin.TabStop = False
        '
        'formLogin
        '
        Me.AcceptButton = Me.bLogin
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.labelRNewUser)
        Me.Controls.Add(Me.textUserName)
        Me.Controls.Add(Me.labelCPassword)
        Me.Controls.Add(Me.labelMsgWrong)
        Me.Controls.Add(Me.labelBack)
        Me.Controls.Add(Me.textPassword)
        Me.Controls.Add(Me.labelTitle)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.picAdmin)
        Me.Controls.Add(Me.bLogin)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "formLogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to VK GST & POS M.sys"
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picAdmin As System.Windows.Forms.PictureBox
    Friend WithEvents picUser As System.Windows.Forms.PictureBox
    Friend WithEvents labelTitle As System.Windows.Forms.Label
    Friend WithEvents textPassword As System.Windows.Forms.TextBox
    Friend WithEvents labelBack As System.Windows.Forms.Label
    Friend WithEvents labelMsgWrong As System.Windows.Forms.Label
    Friend WithEvents bLogin As System.Windows.Forms.Button
    Friend WithEvents labelCPassword As System.Windows.Forms.Label
    Friend WithEvents textUserName As System.Windows.Forms.TextBox
    Friend WithEvents labelRNewUser As System.Windows.Forms.Label

End Class

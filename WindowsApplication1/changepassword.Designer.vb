<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changepassword))
        Me.textRTypePassword = New System.Windows.Forms.TextBox()
        Me.textNUserPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.textUserName = New System.Windows.Forms.TextBox()
        Me.labelSProductType = New System.Windows.Forms.Label()
        Me.bDone = New System.Windows.Forms.PictureBox()
        CType(Me.bDone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textRTypePassword
        '
        Me.textRTypePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.textRTypePassword.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textRTypePassword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.textRTypePassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.textRTypePassword.Location = New System.Drawing.Point(55, 243)
        Me.textRTypePassword.MaxLength = 10
        Me.textRTypePassword.Name = "textRTypePassword"
        Me.textRTypePassword.Size = New System.Drawing.Size(221, 26)
        Me.textRTypePassword.TabIndex = 38
        Me.textRTypePassword.Text = "Retype Password"
        Me.textRTypePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textNUserPassword
        '
        Me.textNUserPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.textNUserPassword.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textNUserPassword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.textNUserPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.textNUserPassword.Location = New System.Drawing.Point(55, 191)
        Me.textNUserPassword.MaxLength = 10
        Me.textNUserPassword.Name = "textNUserPassword"
        Me.textNUserPassword.Size = New System.Drawing.Size(221, 26)
        Me.textNUserPassword.TabIndex = 37
        Me.textNUserPassword.Text = "New Password"
        Me.textNUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 18)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Enter your new password: "
        '
        'textPassword
        '
        Me.textPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.textPassword.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPassword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.textPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.textPassword.Location = New System.Drawing.Point(55, 101)
        Me.textPassword.MaxLength = 10
        Me.textPassword.Name = "textPassword"
        Me.textPassword.Size = New System.Drawing.Size(221, 26)
        Me.textPassword.TabIndex = 34
        Me.textPassword.Text = "Password"
        Me.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textUserName
        '
        Me.textUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.textUserName.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textUserName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.textUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.textUserName.Location = New System.Drawing.Point(55, 51)
        Me.textUserName.MaxLength = 10
        Me.textUserName.Name = "textUserName"
        Me.textUserName.Size = New System.Drawing.Size(221, 26)
        Me.textUserName.TabIndex = 33
        Me.textUserName.Text = "Username"
        Me.textUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelSProductType
        '
        Me.labelSProductType.AutoSize = True
        Me.labelSProductType.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSProductType.ForeColor = System.Drawing.Color.White
        Me.labelSProductType.Location = New System.Drawing.Point(11, 17)
        Me.labelSProductType.Name = "labelSProductType"
        Me.labelSProductType.Size = New System.Drawing.Size(216, 18)
        Me.labelSProductType.TabIndex = 32
        Me.labelSProductType.Text = "Enter your account's detail: "
        '
        'bDone
        '
        Me.bDone.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.done4
        Me.bDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bDone.Location = New System.Drawing.Point(245, 318)
        Me.bDone.Name = "bDone"
        Me.bDone.Size = New System.Drawing.Size(92, 31)
        Me.bDone.TabIndex = 93
        Me.bDone.TabStop = False
        '
        'changepassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(349, 361)
        Me.Controls.Add(Me.bDone)
        Me.Controls.Add(Me.textRTypePassword)
        Me.Controls.Add(Me.textNUserPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textPassword)
        Me.Controls.Add(Me.textUserName)
        Me.Controls.Add(Me.labelSProductType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "changepassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        CType(Me.bDone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textRTypePassword As System.Windows.Forms.TextBox
    Friend WithEvents textNUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textPassword As System.Windows.Forms.TextBox
    Friend WithEvents textUserName As System.Windows.Forms.TextBox
    Friend WithEvents labelSProductType As System.Windows.Forms.Label
    Friend WithEvents bDone As System.Windows.Forms.PictureBox
End Class

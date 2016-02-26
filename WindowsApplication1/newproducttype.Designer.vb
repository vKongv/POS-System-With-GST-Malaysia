<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newproducttype
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newproducttype))
        Me.bDone = New System.Windows.Forms.PictureBox()
        Me.cbGSTType = New System.Windows.Forms.ComboBox()
        Me.labelSGSTType = New System.Windows.Forms.Label()
        Me.labelSProductType = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.bDone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bDone
        '
        Me.bDone.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.done4
        Me.bDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bDone.Location = New System.Drawing.Point(180, 218)
        Me.bDone.Name = "bDone"
        Me.bDone.Size = New System.Drawing.Size(92, 31)
        Me.bDone.TabIndex = 96
        Me.bDone.TabStop = False
        '
        'cbGSTType
        '
        Me.cbGSTType.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbGSTType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGSTType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGSTType.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGSTType.ForeColor = System.Drawing.Color.White
        Me.cbGSTType.FormattingEnabled = True
        Me.cbGSTType.Items.AddRange(New Object() {"Standard rated (6%)", "Exempted", "Zero rated (0%)"})
        Me.cbGSTType.Location = New System.Drawing.Point(15, 152)
        Me.cbGSTType.Name = "cbGSTType"
        Me.cbGSTType.Size = New System.Drawing.Size(208, 26)
        Me.cbGSTType.TabIndex = 95
        '
        'labelSGSTType
        '
        Me.labelSGSTType.AutoSize = True
        Me.labelSGSTType.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSGSTType.ForeColor = System.Drawing.Color.White
        Me.labelSGSTType.Location = New System.Drawing.Point(12, 122)
        Me.labelSGSTType.Name = "labelSGSTType"
        Me.labelSGSTType.Size = New System.Drawing.Size(237, 18)
        Me.labelSGSTType.TabIndex = 94
        Me.labelSGSTType.Text = "Please select default GST type:"
        '
        'labelSProductType
        '
        Me.labelSProductType.AutoSize = True
        Me.labelSProductType.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSProductType.ForeColor = System.Drawing.Color.White
        Me.labelSProductType.Location = New System.Drawing.Point(12, 29)
        Me.labelSProductType.Name = "labelSProductType"
        Me.labelSProductType.Size = New System.Drawing.Size(206, 18)
        Me.labelSProductType.TabIndex = 92
        Me.labelSProductType.Text = "Type in new product type:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(15, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 26)
        Me.TextBox1.TabIndex = 97
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bDone)
        Me.Controls.Add(Me.cbGSTType)
        Me.Controls.Add(Me.labelSGSTType)
        Me.Controls.Add(Me.labelSProductType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form8"
        Me.Text = "Add new product type"
        CType(Me.bDone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bDone As System.Windows.Forms.PictureBox
    Friend WithEvents cbGSTType As System.Windows.Forms.ComboBox
    Friend WithEvents labelSGSTType As System.Windows.Forms.Label
    Friend WithEvents labelSProductType As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEGST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEGST))
        Me.labelSProductType = New System.Windows.Forms.Label()
        Me.cbPType = New System.Windows.Forms.ComboBox()
        Me.labelSGSTType = New System.Windows.Forms.Label()
        Me.cbGSTType = New System.Windows.Forms.ComboBox()
        Me.bDone = New System.Windows.Forms.PictureBox()
        CType(Me.bDone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelSProductType
        '
        Me.labelSProductType.AutoSize = True
        Me.labelSProductType.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSProductType.ForeColor = System.Drawing.Color.White
        Me.labelSProductType.Location = New System.Drawing.Point(12, 29)
        Me.labelSProductType.Name = "labelSProductType"
        Me.labelSProductType.Size = New System.Drawing.Size(211, 18)
        Me.labelSProductType.TabIndex = 24
        Me.labelSProductType.Text = "Please select product type:"
        '
        'cbPType
        '
        Me.cbPType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbPType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPType.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbPType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPType.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPType.ForeColor = System.Drawing.Color.White
        Me.cbPType.FormattingEnabled = True
        Me.cbPType.Location = New System.Drawing.Point(15, 59)
        Me.cbPType.Name = "cbPType"
        Me.cbPType.Size = New System.Drawing.Size(208, 26)
        Me.cbPType.TabIndex = 88
        '
        'labelSGSTType
        '
        Me.labelSGSTType.AutoSize = True
        Me.labelSGSTType.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSGSTType.ForeColor = System.Drawing.Color.White
        Me.labelSGSTType.Location = New System.Drawing.Point(12, 122)
        Me.labelSGSTType.Name = "labelSGSTType"
        Me.labelSGSTType.Size = New System.Drawing.Size(218, 18)
        Me.labelSGSTType.TabIndex = 89
        Me.labelSGSTType.Text = "Please select new GST type:"
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
        Me.cbGSTType.TabIndex = 90
        '
        'bDone
        '
        Me.bDone.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.done4
        Me.bDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bDone.Location = New System.Drawing.Point(180, 218)
        Me.bDone.Name = "bDone"
        Me.bDone.Size = New System.Drawing.Size(92, 31)
        Me.bDone.TabIndex = 91
        Me.bDone.TabStop = False
        '
        'formEGST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.bDone)
        Me.Controls.Add(Me.cbGSTType)
        Me.Controls.Add(Me.labelSGSTType)
        Me.Controls.Add(Me.cbPType)
        Me.Controls.Add(Me.labelSProductType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formEGST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit default GST type"
        CType(Me.bDone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelSProductType As System.Windows.Forms.Label
    Friend WithEvents cbPType As System.Windows.Forms.ComboBox
    Friend WithEvents labelSGSTType As System.Windows.Forms.Label
    Friend WithEvents cbGSTType As System.Windows.Forms.ComboBox
    Friend WithEvents bDone As System.Windows.Forms.PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSCheckingUser
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSCheckingUser))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.textICode = New System.Windows.Forms.TextBox()
        Me.bEnter = New System.Windows.Forms.Button()
        Me.bSearch = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelSeparation = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picSChecking = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picTSales = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picTransaction = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.labelCID = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSChecking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = "-"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(91, 320)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1172, 372)
        Me.DataGridView1.TabIndex = 73
        '
        'textICode
        '
        Me.textICode.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textICode.Font = New System.Drawing.Font("Beatnik SF", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textICode.ForeColor = System.Drawing.Color.White
        Me.textICode.Location = New System.Drawing.Point(186, 205)
        Me.textICode.Name = "textICode"
        Me.textICode.Size = New System.Drawing.Size(966, 38)
        Me.textICode.TabIndex = 68
        Me.textICode.Text = "Type Stock Name / Code"
        Me.textICode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bEnter
        '
        Me.bEnter.Location = New System.Drawing.Point(1064, 220)
        Me.bEnter.Name = "bEnter"
        Me.bEnter.Size = New System.Drawing.Size(75, 23)
        Me.bEnter.TabIndex = 74
        Me.bEnter.Text = "Button1"
        Me.bEnter.UseVisualStyleBackColor = True
        '
        'bSearch
        '
        Me.bSearch.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.search
        Me.bSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bSearch.Location = New System.Drawing.Point(1180, 205)
        Me.bSearch.Name = "bSearch"
        Me.bSearch.Size = New System.Drawing.Size(40, 38)
        Me.bSearch.TabIndex = 69
        Me.bSearch.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Beatnik SF", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(814, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 42)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "|"
        '
        'labelSeparation
        '
        Me.labelSeparation.AutoSize = True
        Me.labelSeparation.Font = New System.Drawing.Font("Beatnik SF", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSeparation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelSeparation.Location = New System.Drawing.Point(489, 30)
        Me.labelSeparation.Name = "labelSeparation"
        Me.labelSeparation.Size = New System.Drawing.Size(24, 42)
        Me.labelSeparation.TabIndex = 81
        Me.labelSeparation.Text = "|"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Beatnik SF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(952, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 23)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Stocks Checking"
        '
        'picSChecking
        '
        Me.picSChecking.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.stockchecking1
        Me.picSChecking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSChecking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSChecking.Location = New System.Drawing.Point(884, 22)
        Me.picSChecking.Name = "picSChecking"
        Me.picSChecking.Size = New System.Drawing.Size(53, 50)
        Me.picSChecking.TabIndex = 79
        Me.picSChecking.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Beatnik SF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(629, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 23)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Today's Sales"
        '
        'picTSales
        '
        Me.picTSales.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.salesreport11
        Me.picTSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picTSales.Location = New System.Drawing.Point(561, 22)
        Me.picTSales.Name = "picTSales"
        Me.picTSales.Size = New System.Drawing.Size(53, 50)
        Me.picTSales.TabIndex = 77
        Me.picTSales.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Beatnik SF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(313, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 23)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Transactions"
        '
        'picTransaction
        '
        Me.picTransaction.BackColor = System.Drawing.Color.Transparent
        Me.picTransaction.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.cashier12
        Me.picTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picTransaction.Location = New System.Drawing.Point(254, 22)
        Me.picTransaction.Name = "picTransaction"
        Me.picTransaction.Size = New System.Drawing.Size(53, 50)
        Me.picTransaction.TabIndex = 75
        Me.picTransaction.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.bar21
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(877, 68)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(252, 19)
        Me.PictureBox3.TabIndex = 83
        Me.PictureBox3.TabStop = False
        '
        'labelCID
        '
        Me.labelCID.AutoSize = True
        Me.labelCID.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelCID.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCID.ForeColor = System.Drawing.Color.White
        Me.labelCID.Location = New System.Drawing.Point(12, 706)
        Me.labelCID.Name = "labelCID"
        Me.labelCID.Size = New System.Drawing.Size(164, 18)
        Me.labelCID.TabIndex = 84
        Me.labelCID.Tag = "Back"
        Me.labelCID.Text = "Cashier ID: Unknown"
        '
        'formSCheckingUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.labelCID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labelSeparation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picSChecking)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picTSales)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picTransaction)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bSearch)
        Me.Controls.Add(Me.textICode)
        Me.Controls.Add(Me.bEnter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formSCheckingUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Checking"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSChecking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bSearch As System.Windows.Forms.PictureBox
    Friend WithEvents textICode As System.Windows.Forms.TextBox
    Friend WithEvents bEnter As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents labelSeparation As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picSChecking As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picTSales As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picTransaction As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents labelCID As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTSales))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelSeparation = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelTDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.labelTSales = New System.Windows.Forms.Label()
        Me.labelTGST = New System.Windows.Forms.Label()
        Me.labelTIncludeGST = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.labelTItemSold = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picSChecking = New System.Windows.Forms.PictureBox()
        Me.picTSales = New System.Windows.Forms.PictureBox()
        Me.picTransaction = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.labelCID = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSChecking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Beatnik SF", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(814, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 42)
        Me.Label4.TabIndex = 29
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
        Me.labelSeparation.TabIndex = 28
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
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Stocks Checking"
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
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Today's Sales"
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
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Transactions"
        '
        'labelTDate
        '
        Me.labelTDate.AutoSize = True
        Me.labelTDate.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTDate.ForeColor = System.Drawing.Color.IndianRed
        Me.labelTDate.Location = New System.Drawing.Point(368, 116)
        Me.labelTDate.Name = "labelTDate"
        Me.labelTDate.Size = New System.Drawing.Size(151, 33)
        Me.labelTDate.TabIndex = 31
        Me.labelTDate.Text = "12/12/2014"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(199, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 18)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Total Sales               :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(199, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 18)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Total GST received   :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(199, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(165, 18)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Total (included GST) :"
        '
        'labelTSales
        '
        Me.labelTSales.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTSales.ForeColor = System.Drawing.Color.IndianRed
        Me.labelTSales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.labelTSales.Location = New System.Drawing.Point(444, 201)
        Me.labelTSales.Name = "labelTSales"
        Me.labelTSales.Size = New System.Drawing.Size(190, 23)
        Me.labelTSales.TabIndex = 39
        Me.labelTSales.Text = "0.00"
        Me.labelTSales.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labelTGST
        '
        Me.labelTGST.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTGST.ForeColor = System.Drawing.Color.IndianRed
        Me.labelTGST.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.labelTGST.Location = New System.Drawing.Point(444, 235)
        Me.labelTGST.Name = "labelTGST"
        Me.labelTGST.Size = New System.Drawing.Size(190, 23)
        Me.labelTGST.TabIndex = 40
        Me.labelTGST.Text = "0.00"
        Me.labelTGST.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labelTIncludeGST
        '
        Me.labelTIncludeGST.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTIncludeGST.ForeColor = System.Drawing.Color.IndianRed
        Me.labelTIncludeGST.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.labelTIncludeGST.Location = New System.Drawing.Point(440, 283)
        Me.labelTIncludeGST.Name = "labelTIncludeGST"
        Me.labelTIncludeGST.Size = New System.Drawing.Size(194, 23)
        Me.labelTIncludeGST.TabIndex = 41
        Me.labelTIncludeGST.Text = "0.00"
        Me.labelTIncludeGST.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(199, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(488, 18)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "____________________________________________________________"
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
        Me.DataGridView1.Location = New System.Drawing.Point(153, 384)
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
        Me.DataGridView1.Size = New System.Drawing.Size(986, 325)
        Me.DataGridView1.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Beatnik SF", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(145, 348)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(313, 31)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Number of item(s) sold: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Beatnik SF", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(196, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 31)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Today date:"
        '
        'labelTItemSold
        '
        Me.labelTItemSold.AutoSize = True
        Me.labelTItemSold.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTItemSold.ForeColor = System.Drawing.Color.IndianRed
        Me.labelTItemSold.Location = New System.Drawing.Point(456, 346)
        Me.labelTItemSold.Name = "labelTItemSold"
        Me.labelTItemSold.Size = New System.Drawing.Size(29, 33)
        Me.labelTItemSold.TabIndex = 61
        Me.labelTItemSold.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.IndianRed
        Me.Label12.Location = New System.Drawing.Point(396, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 23)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "RM"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.IndianRed
        Me.Label13.Location = New System.Drawing.Point(396, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 23)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "RM"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.IndianRed
        Me.Label14.Location = New System.Drawing.Point(396, 283)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 23)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "RM"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(199, 306)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(488, 18)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "____________________________________________________________"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(1157, 659)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 50)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'picSChecking
        '
        Me.picSChecking.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.stockchecking1
        Me.picSChecking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSChecking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSChecking.Location = New System.Drawing.Point(884, 22)
        Me.picSChecking.Name = "picSChecking"
        Me.picSChecking.Size = New System.Drawing.Size(53, 50)
        Me.picSChecking.TabIndex = 26
        Me.picSChecking.TabStop = False
        '
        'picTSales
        '
        Me.picTSales.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.salesreport11
        Me.picTSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picTSales.Location = New System.Drawing.Point(561, 22)
        Me.picTSales.Name = "picTSales"
        Me.picTSales.Size = New System.Drawing.Size(53, 50)
        Me.picTSales.TabIndex = 24
        Me.picTSales.TabStop = False
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
        Me.picTransaction.TabIndex = 22
        Me.picTransaction.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.bar21
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(541, 68)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(252, 19)
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'labelCID
        '
        Me.labelCID.AutoSize = True
        Me.labelCID.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelCID.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCID.ForeColor = System.Drawing.Color.White
        Me.labelCID.Location = New System.Drawing.Point(3, 712)
        Me.labelCID.Name = "labelCID"
        Me.labelCID.Size = New System.Drawing.Size(164, 18)
        Me.labelCID.TabIndex = 67
        Me.labelCID.Tag = "Back"
        Me.labelCID.Text = "Cashier ID: Unknown"
        '
        'formTSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.labelCID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.labelTItemSold)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.labelTIncludeGST)
        Me.Controls.Add(Me.labelTGST)
        Me.Controls.Add(Me.labelTSales)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labelTDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labelSeparation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picSChecking)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picTSales)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picTransaction)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formTSales"
        Me.Text = "Today's Sales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSChecking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents labelSeparation As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picSChecking As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picTSales As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picTransaction As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents labelTDate As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents labelTSales As System.Windows.Forms.Label
    Friend WithEvents labelTGST As System.Windows.Forms.Label
    Friend WithEvents labelTIncludeGST As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents labelTItemSold As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents labelCID As System.Windows.Forms.Label
End Class

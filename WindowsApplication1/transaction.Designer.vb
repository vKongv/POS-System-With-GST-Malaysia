<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTransactions))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelSeparation = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textICode = New System.Windows.Forms.TextBox()
        Me.labelQty = New System.Windows.Forms.Label()
        Me.textQty = New System.Windows.Forms.TextBox()
        Me.textDiscount = New System.Windows.Forms.TextBox()
        Me.labelDiscount = New System.Windows.Forms.Label()
        Me.rbRM = New System.Windows.Forms.RadioButton()
        Me.rbPercent = New System.Windows.Forms.RadioButton()
        Me.gbIAdded = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.textIName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labelSTotal = New System.Windows.Forms.Label()
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.bAddItem = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bEnter = New System.Windows.Forms.Button()
        Me.bDone = New System.Windows.Forms.PictureBox()
        Me.picSChecking = New System.Windows.Forms.PictureBox()
        Me.picTSales = New System.Windows.Forms.PictureBox()
        Me.picTransaction = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.labelCID = New System.Windows.Forms.Label()
        Me.gbIAdded.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bDone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSChecking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Transactions"
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
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Today's Sales"
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
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Stocks Checking"
        '
        'labelSeparation
        '
        Me.labelSeparation.AutoSize = True
        Me.labelSeparation.Font = New System.Drawing.Font("Beatnik SF", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSeparation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelSeparation.Location = New System.Drawing.Point(489, 30)
        Me.labelSeparation.Name = "labelSeparation"
        Me.labelSeparation.Size = New System.Drawing.Size(24, 42)
        Me.labelSeparation.TabIndex = 6
        Me.labelSeparation.Text = "|"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Beatnik SF", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(814, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 42)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "|"
        '
        'textICode
        '
        Me.textICode.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textICode.Font = New System.Drawing.Font("Beatnik SF", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textICode.ForeColor = System.Drawing.Color.White
        Me.textICode.Location = New System.Drawing.Point(290, 111)
        Me.textICode.Name = "textICode"
        Me.textICode.Size = New System.Drawing.Size(862, 38)
        Me.textICode.TabIndex = 8
        Me.textICode.Text = "Type Item Code"
        Me.textICode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelQty
        '
        Me.labelQty.AutoSize = True
        Me.labelQty.Font = New System.Drawing.Font("Beatnik SF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelQty.ForeColor = System.Drawing.Color.White
        Me.labelQty.Location = New System.Drawing.Point(313, 245)
        Me.labelQty.Name = "labelQty"
        Me.labelQty.Size = New System.Drawing.Size(108, 23)
        Me.labelQty.TabIndex = 10
        Me.labelQty.Text = "Quantity : "
        '
        'textQty
        '
        Me.textQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textQty.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textQty.ForeColor = System.Drawing.Color.White
        Me.textQty.Location = New System.Drawing.Point(417, 246)
        Me.textQty.Name = "textQty"
        Me.textQty.Size = New System.Drawing.Size(100, 26)
        Me.textQty.TabIndex = 11
        Me.textQty.Text = "1"
        '
        'textDiscount
        '
        Me.textDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textDiscount.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textDiscount.ForeColor = System.Drawing.Color.White
        Me.textDiscount.Location = New System.Drawing.Point(793, 246)
        Me.textDiscount.Name = "textDiscount"
        Me.textDiscount.Size = New System.Drawing.Size(100, 26)
        Me.textDiscount.TabIndex = 13
        Me.textDiscount.Text = "0"
        '
        'labelDiscount
        '
        Me.labelDiscount.AutoSize = True
        Me.labelDiscount.Font = New System.Drawing.Font("Beatnik SF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDiscount.ForeColor = System.Drawing.Color.White
        Me.labelDiscount.Location = New System.Drawing.Point(689, 245)
        Me.labelDiscount.Name = "labelDiscount"
        Me.labelDiscount.Size = New System.Drawing.Size(111, 23)
        Me.labelDiscount.TabIndex = 12
        Me.labelDiscount.Text = "Discount : "
        '
        'rbRM
        '
        Me.rbRM.AutoSize = True
        Me.rbRM.Checked = True
        Me.rbRM.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRM.Location = New System.Drawing.Point(911, 250)
        Me.rbRM.Name = "rbRM"
        Me.rbRM.Size = New System.Drawing.Size(69, 22)
        Me.rbRM.TabIndex = 14
        Me.rbRM.TabStop = True
        Me.rbRM.Text = "in RM"
        Me.rbRM.UseVisualStyleBackColor = True
        '
        'rbPercent
        '
        Me.rbPercent.AutoSize = True
        Me.rbPercent.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPercent.Location = New System.Drawing.Point(1000, 250)
        Me.rbPercent.Name = "rbPercent"
        Me.rbPercent.Size = New System.Drawing.Size(125, 22)
        Me.rbPercent.TabIndex = 15
        Me.rbPercent.Text = "in Percent (%)"
        Me.rbPercent.UseVisualStyleBackColor = True
        '
        'gbIAdded
        '
        Me.gbIAdded.Controls.Add(Me.DataGridView1)
        Me.gbIAdded.Font = New System.Drawing.Font("Beatnik SF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbIAdded.ForeColor = System.Drawing.Color.White
        Me.gbIAdded.Location = New System.Drawing.Point(180, 304)
        Me.gbIAdded.Name = "gbIAdded"
        Me.gbIAdded.Size = New System.Drawing.Size(1075, 311)
        Me.gbIAdded.TabIndex = 18
        Me.gbIAdded.TabStop = False
        Me.gbIAdded.Text = "Item(s) Added"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Beatnik SF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Beatnik SF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = "-"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(6, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1063, 275)
        Me.DataGridView1.TabIndex = 58
        '
        'textIName
        '
        Me.textIName.BackColor = System.Drawing.Color.LightSeaGreen
        Me.textIName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textIName.Cursor = System.Windows.Forms.Cursors.No
        Me.textIName.Enabled = False
        Me.textIName.Font = New System.Drawing.Font("Beatnik SF", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textIName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.textIName.Location = New System.Drawing.Point(290, 175)
        Me.textIName.Name = "textIName"
        Me.textIName.ReadOnly = True
        Me.textIName.Size = New System.Drawing.Size(862, 31)
        Me.textIName.TabIndex = 22
        Me.textIName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Beatnik SF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(156, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Item Name : "
        '
        'labelSTotal
        '
        Me.labelSTotal.AutoSize = True
        Me.labelSTotal.Font = New System.Drawing.Font("Beatnik SF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSTotal.ForeColor = System.Drawing.Color.White
        Me.labelSTotal.Location = New System.Drawing.Point(176, 627)
        Me.labelSTotal.Name = "labelSTotal"
        Me.labelSTotal.Size = New System.Drawing.Size(72, 23)
        Me.labelSTotal.TabIndex = 25
        Me.labelSTotal.Text = "Total : "
        '
        'labelTotal
        '
        Me.labelTotal.AutoSize = True
        Me.labelTotal.Font = New System.Drawing.Font("Beatnik SF", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotal.ForeColor = System.Drawing.Color.White
        Me.labelTotal.Location = New System.Drawing.Point(245, 618)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(201, 54)
        Me.labelTotal.TabIndex = 26
        Me.labelTotal.Text = "RM 0.00"
        '
        'bAddItem
        '
        Me.bAddItem.AutoSize = True
        Me.bAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAddItem.Enabled = False
        Me.bAddItem.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAddItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bAddItem.Location = New System.Drawing.Point(1158, 124)
        Me.bAddItem.Name = "bAddItem"
        Me.bAddItem.Size = New System.Drawing.Size(79, 18)
        Me.bAddItem.TabIndex = 20
        Me.bAddItem.Text = "Add Item"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Beatnik SF", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1090, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 18)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Delete Selected Item"
        '
        'bEnter
        '
        Me.bEnter.Enabled = False
        Me.bEnter.Location = New System.Drawing.Point(1077, 126)
        Me.bEnter.Name = "bEnter"
        Me.bEnter.Size = New System.Drawing.Size(75, 23)
        Me.bEnter.TabIndex = 28
        Me.bEnter.Text = "bD"
        Me.bEnter.UseVisualStyleBackColor = True
        '
        'bDone
        '
        Me.bDone.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.done4
        Me.bDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bDone.Location = New System.Drawing.Point(1121, 617)
        Me.bDone.Name = "bDone"
        Me.bDone.Size = New System.Drawing.Size(134, 50)
        Me.bDone.TabIndex = 19
        Me.bDone.TabStop = False
        '
        'picSChecking
        '
        Me.picSChecking.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.stockchecking1
        Me.picSChecking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSChecking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSChecking.Location = New System.Drawing.Point(884, 22)
        Me.picSChecking.Name = "picSChecking"
        Me.picSChecking.Size = New System.Drawing.Size(53, 50)
        Me.picSChecking.TabIndex = 4
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
        Me.picTSales.TabIndex = 2
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
        Me.picTransaction.TabIndex = 0
        Me.picTransaction.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.VKGSTManagementSystem.My.Resources.Resources.bar21
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(229, 68)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(252, 19)
        Me.PictureBox3.TabIndex = 21
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
        Me.labelCID.TabIndex = 29
        Me.labelCID.Tag = "Back"
        Me.labelCID.Text = "Cashier ID: Unknown"
        '
        'formTransactions
        '
        Me.AcceptButton = Me.bEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.labelCID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labelTotal)
        Me.Controls.Add(Me.labelSTotal)
        Me.Controls.Add(Me.textIName)
        Me.Controls.Add(Me.bAddItem)
        Me.Controls.Add(Me.bDone)
        Me.Controls.Add(Me.gbIAdded)
        Me.Controls.Add(Me.rbPercent)
        Me.Controls.Add(Me.rbRM)
        Me.Controls.Add(Me.textDiscount)
        Me.Controls.Add(Me.labelDiscount)
        Me.Controls.Add(Me.textQty)
        Me.Controls.Add(Me.labelQty)
        Me.Controls.Add(Me.textICode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labelSeparation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picSChecking)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picTSales)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picTransaction)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bEnter)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formTransactions"
        Me.Text = "Transactions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbIAdded.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bDone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSChecking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTransaction As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picTSales As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picSChecking As System.Windows.Forms.PictureBox
    Friend WithEvents labelSeparation As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textICode As System.Windows.Forms.TextBox
    Friend WithEvents labelQty As System.Windows.Forms.Label
    Friend WithEvents textQty As System.Windows.Forms.TextBox
    Friend WithEvents textDiscount As System.Windows.Forms.TextBox
    Friend WithEvents labelDiscount As System.Windows.Forms.Label
    Friend WithEvents rbRM As System.Windows.Forms.RadioButton
    Friend WithEvents rbPercent As System.Windows.Forms.RadioButton
    Friend WithEvents gbIAdded As System.Windows.Forms.GroupBox
    Friend WithEvents bDone As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents textIName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents labelSTotal As System.Windows.Forms.Label
    Friend WithEvents labelTotal As System.Windows.Forms.Label
    Friend WithEvents bAddItem As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bEnter As System.Windows.Forms.Button
    Friend WithEvents labelCID As System.Windows.Forms.Label
End Class

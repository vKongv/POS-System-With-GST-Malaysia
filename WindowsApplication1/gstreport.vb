Public Class formGReport
    Dim todayDate As Date = Date.Today
    Dim nextYearDate As Date = Date.Today.AddYears(1)
    Dim finishLoading As Boolean = False
    Public cashier As String = ""
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(43, 46, 52)
        getCashierID()
        cbVByMonth.SelectedIndex = 0
        setYearComboBox()
        getTotalGST()
        finishLoading = True
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub picARestock_Click(sender As Object, e As EventArgs) Handles picARestock.Click, Label1.Click
        RemoveHandler Me.FormClosing, AddressOf formGReport_FormClosing
        Me.Close()
        formARestock.Show()
    End Sub

    Private Sub picSReport_Click(sender As Object, e As EventArgs) Handles picSReport.Click, labelTSalesAdmin.Click
        RemoveHandler Me.FormClosing, AddressOf formGReport_FormClosing
        Me.Close()
        formSReportAdmin.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, Label6.Click
        RemoveHandler Me.FormClosing, AddressOf formGReport_FormClosing
        Me.Close()
        formSChecking.Show()
    End Sub

    Private Sub getTotalGST()
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim supplyDataAdapter As OleDb.OleDbDataAdapter
        Dim supplyDataSet As New DataSet
        Dim SqlCommand As String

        Dim salesDataAdapter As OleDb.OleDbDataAdapter
        Dim salesDataSet As New DataSet
        Dim SqlCommandGSTOutput As String
        Dim totalGSTInput As Double = 0
        Dim totalGSTOutput As Double = 0
        'Get GST input data
        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection
        SqlCommand = "SELECT SUM(GSTInput) AS totalGSTInput FROM STOCK, SUPPLY_DETAIL WHERE SUPPLY_DETAIL.stockID = STOCK.stockID AND (STOCK.GSTType = 'ZERO RATED' OR STOCK.GSTType = 'STANDARD RATED') AND dateOfSupply BETWEEN #1/1/" + todayDate.Year.ToString + "# AND #1/1/" + nextYearDate.Year.ToString + "#;"
        supplyDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        supplyDataAdapter.Fill(supplyDataSet, "Supply")
        DBconnection.Close()

        If Not IsDBNull(supplyDataSet.Tables(0).Rows(0).Item(0)) Then
            totalGSTInput = Double.Parse(supplyDataSet.Tables(0).Rows(0).Item(0))
            labelTGSTInput.Text = totalGSTInput.ToString("F2")
        Else
            totalGSTInput = 0.0
            labelTGSTInput.Text = "0.00"
        End If

        'Get GST output data
        SqlCommandGSTOutput = "SELECT SUM(GSTOutput) AS totalGSTOutput FROM SALES WHERE salesDate BETWEEN #1/1/" + todayDate.Year.ToString + "# AND #1/1/" + nextYearDate.Year.ToString + "#;"
        salesDataAdapter = New OleDb.OleDbDataAdapter(SqlCommandGSTOutput, DBconnection)
        salesDataAdapter.Fill(salesDataSet, "Sales")

        If Not IsDBNull(salesDataSet.Tables(0).Rows(0).Item(0)) Then
            totalGSTOutput = Double.Parse(salesDataSet.Tables(0).Rows(0).Item(0))
            labelTGSTOutput.Text = totalGSTOutput.ToString("F2")
        Else
            totalGSTOutput = 0.0
            labelTGSTOutput.Text = "0.00"
        End If


        Dim totalNettGST As Double = totalGSTOutput - totalGSTInput

        If (totalNettGST > 0) Then
            labelTNettGST.Text = totalNettGST.ToString("F2")
            labelHelpText.Text = "This mean you need to pay RM " + totalNettGST.ToString("F2") + " to Custom Malaysia"
        ElseIf (totalNettGST = 0) Then
            labelTNettGST.Text = totalNettGST.ToString("F2")
            labelHelpText.Text = "No nett GST"
        Else
            labelTNettGST.Text = "( " + Math.Abs(totalNettGST).ToString("F2") + " )"
            labelHelpText.Text = "This mean you can claim RM " + Math.Abs(totalNettGST).ToString("F2") + " from Custom Malaysia"
        End If
    End Sub

    Private Sub Label12_MouseHover(sender As Object, e As EventArgs) Handles Label12.MouseHover
        labelHelpText.Visible = True
    End Sub

    Private Sub Label12_MouseLeave(sender As Object, e As EventArgs) Handles Label12.MouseLeave
        labelHelpText.Visible = False
    End Sub

    Private Sub labelTGSTInput_Click(sender As Object, e As EventArgs) Handles labelTGSTInput.Click

    End Sub

    Private Sub formGReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you want to quit this application? " + vbNewLine + "Press YES to continue or NO to SIGN OUT current account", _
                    "Close application", _
                    MessageBoxButtons.YesNo, _
                    MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            formLogin.Close()
        Else
            'Connect to database
            Dim DBconnection As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            Dim accountDataAdapter As OleDb.OleDbDataAdapter
            Dim accountDataSet As New DataSet
            Dim SqlCommand As String
            'Validate admin account and password
            DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
            DBconnection.Open()
            SqlCommand = "SELECT MAX(logID) FROM ACCOUNTLOG WHERE cashierID = '" + cashier + "';"
            accountDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
            accountDataAdapter.Fill(accountDataSet, "ACCOUNTLOG")
            Dim logID As String = accountDataSet.Tables(0).Rows(0).Item(0).ToString

            cmd.Connection = DBconnection
            cmd.CommandText = "UPDATE ACCOUNT SET accountStatus = 'INACTIVE' WHERE accountID = '" + cashier + "';"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "UPDATE ACCOUNTLOG SET logLogoutTime = '" + DateTime.Now.ToString + "' WHERE cashierID = '" + cashier + "' AND logID = " + logID + ";"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            DBconnection.Close()
            formLogin.Show()
        End If

    End Sub

    Private Sub cbGSTType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVByMonth.SelectedIndexChanged, cbVByYear.SelectedIndexChanged
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim supplyDataAdapter As OleDb.OleDbDataAdapter
        Dim supplyDataSet As New DataSet
        Dim SqlCommand As String = ""

        Dim totalGSTInput As Double = 0
        Dim totalGSTOutput As Double = 0
        Dim salesDataAdapter As OleDb.OleDbDataAdapter
        Dim salesDataSet As New DataSet
        Dim SqlCommandGSTOutput As String = ""

        'Get GST input data
        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection
        If finishLoading Then
            'Change the sql command based on user request
            If cbVByMonth.SelectedIndex > 0 Then
                SqlCommand = "SELECT SUM(GSTInput) AS totalGSTInput FROM STOCK, SUPPLY_DETAIL WHERE SUPPLY_DETAIL.stockID = STOCK.stockID AND (STOCK.GSTType = 'ZERO RATED' OR STOCK.GSTType = 'STANDARD RATED') AND  dateOfSupply BETWEEN #" + cbVByMonth.SelectedIndex.ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #" + (cbVByMonth.SelectedIndex + 1).ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "#;"
                SqlCommandGSTOutput = "SELECT SUM(GSTOutput) AS totalGSTOutput FROM SALES WHERE salesDate BETWEEN #" + cbVByMonth.SelectedIndex.ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #" + (cbVByMonth.SelectedIndex + 1).ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "#;"
            ElseIf cbVByMonth.SelectedIndex = 0 Then
                Dim nextYear As Integer = Integer.Parse(cbVByYear.Items(cbVByYear.SelectedIndex).ToString)
                nextYear = nextYear + 1
                SqlCommand = "SELECT SUM(GSTInput) AS totalGSTInput FROM STOCK, SUPPLY_DETAIL WHERE SUPPLY_DETAIL.stockID = STOCK.stockID AND (STOCK.GSTTYPE = 'ZERO RATED' OR STOCK.GSTType = 'STANDARD RATED') AND dateOfSupply BETWEEN #1/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #1/1/" + nextYear.ToString + "#;"
                SqlCommandGSTOutput = "SELECT SUM(GSTOutput) AS totalGSTOutput FROM SALES WHERE salesDate BETWEEN #1/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #1/1/" + nextYear.ToString + "#;"
            End If

            supplyDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
            supplyDataAdapter.Fill(supplyDataSet, "Supply")
            DBconnection.Close()

            If supplyDataSet.Tables(0).Rows.Count > 0 And Not IsDBNull(supplyDataSet.Tables(0).Rows(0).Item(0)) Then
                totalGSTInput = Double.Parse(supplyDataSet.Tables(0).Rows(0).Item(0))
            End If
            labelTGSTInput.Text = totalGSTInput.ToString("F2")

            'Get GST output data

            salesDataAdapter = New OleDb.OleDbDataAdapter(SqlCommandGSTOutput, DBconnection)
            salesDataAdapter.Fill(salesDataSet, "Sales")

            If supplyDataSet.Tables(0).Rows.Count > 0 And Not IsDBNull(salesDataSet.Tables(0).Rows(0).Item(0)) Then
                totalGSTOutput = Double.Parse(salesDataSet.Tables(0).Rows(0).Item(0))
            End If
            labelTGSTOutput.Text = totalGSTOutput.ToString("F2")

            Dim totalNettGST As Double = totalGSTOutput - totalGSTInput

            If (totalNettGST > 0) Then
                labelTNettGST.Text = totalNettGST.ToString("F2")
                labelHelpText.Text = "This mean you need to pay RM " + totalNettGST.ToString("F2") + " to Custom Malaysia"
            ElseIf totalNettGST = 0 Then
                labelTNettGST.Text = totalNettGST.ToString("F2")
                labelHelpText.Text = "No nett GST"
            Else
                labelTNettGST.Text = "( " + Math.Abs(totalNettGST).ToString("F2") + " )"
                labelHelpText.Text = "This mean you can claim RM " + Math.Abs(totalNettGST).ToString("F2") + " from Custom Malaysia"
            End If
        End If

    End Sub

    Private Sub setYearComboBox()
        Dim currentYear As Integer = Integer.Parse(todayDate.Year.ToString())
        cbVByYear.Items.Add((currentYear - 1).ToString)
        cbVByYear.Items.Add(currentYear.ToString)
        cbVByYear.SelectedIndex = cbVByYear.Items.Count - 1

    End Sub

    Private Sub bGReport_Click(sender As Object, e As EventArgs) Handles bGReport.Click
        'Connect to database
        If Not labelTGSTInput.Text = "0.00" Or Not labelTGSTOutput.Text = "0.00" Or Not labelTNettGST.Text = "0.00" Then
            Dim DBconnection As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            Dim gstInDataAdapter As OleDb.OleDbDataAdapter
            Dim gstInDataSet As New DataSet
            Dim gstOutDataAdapter As OleDb.OleDbDataAdapter
            Dim gstOutDataSet As New DataSet
            Dim SqlCommand As String
            Dim SqlCommandIn As String

            'Get date
            Dim dates As String = ""
            Dim dueDates As String = ""

            'Total Amount for GST in and Out (NOT GST
            Dim gstInSRTotal As Double = 0
            Dim gstInZRTotal As Double = 0
            Dim gstInEXTotal As Double = 0
            Dim gstOutSRTotal As Double = 0
            Dim gstOutZRTotal As Double = 0
            Dim gstOutEXTotal As Double = 0

            'GST Amount
            Dim gstInSR As Double = 0
            Dim gstInZR As Double = 0
            Dim gstInEX As Double = 0
            Dim gstOutSR As Double = 0
            Dim gstOutZR As Double = 0
            Dim gstOutEX As Double = 0
            Dim nettGST As Double = 0
            Dim nettGSTStr As String = ""

            'Get all sales data for today
            DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
            DBconnection.Open()
            cmd.Connection = DBconnection

            'Select sales and supply related to GST input and output
            If cbVByMonth.SelectedIndex > 0 Then
                dates = cbVByMonth.SelectedIndex.ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString
                dueDates = (cbVByMonth.SelectedIndex + 1).ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString
                SqlCommand = "SELECT SUM(TRANSACTIONS.salesQty * TRANSACTIONS.salesSinglePrice) AS totalZeroRatedItem FROM STOCK, SALES, TRANSACTIONS WHERE TRANSACTIONs.stockID = STOCK.stockID AND TRANSACTIONS.salesID = SALES.salesID AND sales.salesDate BETWEEN #" + cbVByMonth.SelectedIndex.ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #" + (cbVByMonth.SelectedIndex + 1).ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND stock.GSTType = 'ZERO RATED';"
                gstOutDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
                gstOutDataAdapter.Fill(gstOutDataSet, "Zero Rated")
                SqlCommand = "SELECT SUM(TRANSACTIONS.salesQty * TRANSACTIONS.salesSinglePrice) AS totalStandardRatedItem FROM STOCK, SALES, TRANSACTIONS WHERE TRANSACTIONs.stockID = STOCK.stockID AND TRANSACTIONS.salesID = SALES.salesID AND sales.salesDate BETWEEN #" + cbVByMonth.SelectedIndex.ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #" + (cbVByMonth.SelectedIndex + 1).ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND stock.GSTType = 'STANDARD RATED';"
                gstOutDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
                gstOutDataAdapter.Fill(gstOutDataSet, "Standard Rated")
                SqlCommand = "SELECT SUM(TRANSACTIONS.salesQty * TRANSACTIONS.salesSinglePrice) AS totalExemptedItem FROM STOCK, SALES, TRANSACTIONS WHERE TRANSACTIONs.stockID = STOCK.stockID AND TRANSACTIONS.salesID = SALES.salesID AND sales.salesDate BETWEEN #" + cbVByMonth.SelectedIndex.ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #" + (cbVByMonth.SelectedIndex + 1).ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND stock.GSTType = 'EXEMPTED';"
                gstOutDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
                gstOutDataAdapter.Fill(gstOutDataSet, "Exempted")


                SqlCommandIn = "SELECT SUM(totalCost) FROM STOCK, SUPPLY_DETAIL WHERE SUPPLY_DETAIL.stockID = STOCK.stockID AND stock.GSTType = 'ZERO RATED' AND dateOfSupply BETWEEN #" + cbVByMonth.SelectedIndex.ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #" + (cbVByMonth.SelectedIndex + 1).ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "#;"
                gstInDataAdapter = New OleDb.OleDbDataAdapter(SqlCommandIn, DBconnection)
                gstInDataAdapter.Fill(gstInDataSet, "Zero Rated")
                SqlCommandIn = "SELECT SUM(totalCost) FROM STOCK, SUPPLY_DETAIL WHERE SUPPLY_DETAIL.stockID = STOCK.stockID AND stock.GSTType = 'STANDARD RATED'AND dateOfSupply BETWEEN #" + cbVByMonth.SelectedIndex.ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #" + (cbVByMonth.SelectedIndex + 1).ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "#;"
                gstInDataAdapter = New OleDb.OleDbDataAdapter(SqlCommandIn, DBconnection)
                gstInDataAdapter.Fill(gstInDataSet, "Standard Rated")
                SqlCommandIn = "SELECT SUM(totalCost) FROM STOCK, SUPPLY_DETAIL WHERE SUPPLY_DETAIL.stockID = STOCK.stockID AND stock.GSTType = 'EXEMPTED' AND dateOfSupply BETWEEN #" + cbVByMonth.SelectedIndex.ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #" + (cbVByMonth.SelectedIndex + 1).ToString + "/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "#;"
                gstInDataAdapter = New OleDb.OleDbDataAdapter(SqlCommandIn, DBconnection)
                gstInDataAdapter.Fill(gstInDataSet, "Exempted")
            ElseIf cbVByMonth.SelectedIndex = 0 Then
                dates = "1/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString
                Dim nextYear As Integer = Integer.Parse(cbVByYear.Items(cbVByYear.SelectedIndex).ToString)
                nextYear = nextYear + 1
                dueDates = "1/1/" + nextYear.ToString
                SqlCommand = "SELECT SUM(TRANSACTIONS.salesQty * TRANSACTIONS.salesSinglePrice) AS totalZeroRatedItem FROM STOCK, SALES, TRANSACTIONS WHERE TRANSACTIONs.stockID = STOCK.stockID AND TRANSACTIONS.salesID = SALES.salesID AND sales.salesDate  BETWEEN #1/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #1/1/" + nextYear.ToString + "# AND stock.GSTType = 'ZERO RATED';"
                gstOutDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
                gstOutDataAdapter.Fill(gstOutDataSet, "Zero Rated")

                SqlCommand = "SELECT SUM(TRANSACTIONS.salesQty * TRANSACTIONS.salesSinglePrice) AS totalStandardRatedItem FROM STOCK, SALES, TRANSACTIONS WHERE TRANSACTIONs.stockID = STOCK.stockID AND TRANSACTIONS.salesID = SALES.salesID AND sales.salesDate BETWEEN #1/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #1/1/" + nextYear.ToString + "# AND stock.GSTType = 'STANDARD RATED';"
                gstOutDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
                gstOutDataAdapter.Fill(gstOutDataSet, "Standard Rated")

                SqlCommand = "SELECT SUM(TRANSACTIONS.salesQty * TRANSACTIONS.salesSinglePrice) AS totalExemptedItem FROM STOCK, SALES, TRANSACTIONS WHERE TRANSACTIONs.stockID = STOCK.stockID AND TRANSACTIONS.salesID = SALES.salesID AND sales.salesDate BETWEEN #1/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #1/1/" + nextYear.ToString + "# AND stock.GSTType = 'EXEMPTED';"
                gstOutDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
                gstOutDataAdapter.Fill(gstOutDataSet, "Exempted")

                SqlCommandIn = "SELECT SUM(totalCost) FROM STOCK, SUPPLY_DETAIL WHERE SUPPLY_DETAIL.stockID = STOCK.stockID AND stock.GSTType = 'ZERO RATED' AND dateOfSupply BETWEEN #1/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #1/1/" + nextYear.ToString + "#;"
                gstInDataAdapter = New OleDb.OleDbDataAdapter(SqlCommandIn, DBconnection)
                gstInDataAdapter.Fill(gstInDataSet, "Zero Rated")
                SqlCommandIn = "SELECT SUM(totalCost) FROM STOCK, SUPPLY_DETAIL WHERE SUPPLY_DETAIL.stockID = STOCK.stockID AND stock.GSTType = 'STANDARD RATED' AND dateOfSupply BETWEEN #1/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #1/1/" + nextYear.ToString + "#;"
                gstInDataAdapter = New OleDb.OleDbDataAdapter(SqlCommandIn, DBconnection)
                gstInDataAdapter.Fill(gstInDataSet, "Standard Rated")

                SqlCommandIn = "SELECT SUM(totalCost) FROM STOCK, SUPPLY_DETAIL WHERE SUPPLY_DETAIL.stockID = STOCK.stockID AND stock.GSTType = 'EXEMPTED' AND dateOfSupply BETWEEN #1/1/" + cbVByYear.Items(cbVByYear.SelectedIndex).ToString + "# AND #1/1/" + nextYear.ToString + "#;"
                gstInDataAdapter = New OleDb.OleDbDataAdapter(SqlCommandIn, DBconnection)
                gstInDataAdapter.Fill(gstInDataSet, "Exempted")
            End If


            'Assign value to total amount and gst amount
            If Not IsDBNull(gstOutDataSet.Tables(0).Rows(0).Item(0)) Then
                gstOutZRTotal = Double.Parse(gstOutDataSet.Tables(0).Rows(0).Item(0))
            Else
                gstOutZRTotal = 0
            End If
            gstOutZR = 0

            If Not IsDBNull(gstOutDataSet.Tables(1).Rows(0).Item(0)) Then
                gstOutSRTotal = Double.Parse(gstOutDataSet.Tables(1).Rows(0).Item(0))

            Else
                gstOutSRTotal = 0
            End If
            gstOutSR = gstOutSRTotal * 6 / 100

            If Not IsDBNull(gstOutDataSet.Tables(2).Rows(0).Item(0)) Then
                gstOutEXTotal = Double.Parse(gstOutDataSet.Tables(2).Rows(0).Item(0))
            Else
                gstOutEXTotal = 0
            End If
            gstOutEX = 0

            If Not IsDBNull(gstInDataSet.Tables(0).Rows(0).Item(0)) Then
                gstInZRTotal = Double.Parse(gstInDataSet.Tables(0).Rows(0).Item(0))
            Else
                gstInZRTotal = 0
            End If
            gstInZR = gstInZRTotal * 6 / 100

            If Not IsDBNull(gstInDataSet.Tables(1).Rows(0).Item(0)) Then
                gstInSRTotal = Double.Parse(gstInDataSet.Tables(1).Rows(0).Item(0))
            Else
                gstInSRTotal = 0
            End If
            gstInSR = gstInSRTotal * 6 / 100

            If Not IsDBNull(gstInDataSet.Tables(2).Rows(0).Item(0)) Then
                gstInEXTotal = Double.Parse(gstInDataSet.Tables(2).Rows(0).Item(0))
            Else
                gstInEXTotal = 0
            End If
            gstInEX = gstInEXTotal * 6 / 100

            nettGST = gstOutSR - gstInSR - gstInZR


            'Generate formatted report
            Dim FILE_NAME As String = "\gst.html"
            Dim path As String = System.IO.Directory.GetCurrentDirectory()
            FILE_NAME = path + FILE_NAME

            Try
                If System.IO.File.Exists(FILE_NAME) = True Then
                    Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                    objWriter.WriteLine("<!DOCTYPE html><html><head><style type='text/css'> p{margin-top:5%;text-align: center;font-weight:bold;font-family:'Couriew New';line-height:2.0;font-size:20px;}table{border-collapse: collapse;margin-bottom:5%;}table, th, td {border: 3px solid black;text-align:center;}th, td{padding:20px;}</style></head><body><table border='1' style='width:100%'><p> VK COMPANY <br>")
                    objWriter.WriteLine("GST Summary for Total Supply &amp; Net Tax for Taxable Period " + dates + "&ndash;" + dueDates + "</p><tr><th style='font-size:20px;'>Types of Supply</th><th style='font-size:20px;'>Value of Supply Excluding GST (RM) </th><th style='font-size:20px;' colspan='2'>Output Tax 6% (RM)</th></tr>")
                    objWriter.WriteLine("<tr><td>SR - Standard Rate</td><td>" + gstOutSRTotal.ToString("F2") + "</td><td colspan='2'>" + gstOutSR.ToString("F2") + "</td></tr>")
                    objWriter.WriteLine("<tr><td>ZR - Zero Supply Rate</td><td>" + gstOutZRTotal.ToString("F2") + "</td><td colspan='2'>&ndash;</td></tr>")
                    objWriter.WriteLine("<tr><td>ES - Exempted Supply Rate</td><td>" + gstOutEXTotal.ToString("F2") + "</td><td colspan='2'>&ndash;</td></tr>")
                    objWriter.WriteLine("<tr><th></th><th style='text-align:right;font-size:20px;'>Total of Output Tax:</th><th style='font-size:20px;' colspan='2'>" + (gstOutSR + gstOutZR + gstOutEX).ToString("F2") + "</th></tr>")
                    objWriter.WriteLine("  <tr><th style='font-size:20px;'>Types of Acquisition</th><th style='font-size:20px;'>Value of Acquisition Excluding GST (RM) </th><th style='font-size:20px;' colspan='2'>Input Tax 6% (RM)</th></tr>")
                    objWriter.WriteLine("<tr><td></td><td></td><td>Claimable</td><td>Non-Claimable</td><tr>")
                    objWriter.WriteLine("<td>TX - Purchase with GST</td><td>" + (gstInSRTotal + gstInEXTotal + gstInZRTotal).ToString("F2") + "</td><td>" + (gstInSR + gstInZR).ToString("F2") + "</td><td>" + gstInEX.ToString("F2") + "</td></tr>")
                    objWriter.WriteLine("<tr><td>BL - Purchase with GST but Not Claimable</td><td>" + gstInEXTotal.ToString("F2") + "</td><td>&ndash;</td><td></td></tr>")
                    objWriter.WriteLine("  <tr><td>EP - Purchase Exempted from GST</td><td>" + gstInEXTotal.ToString("F2") + "</td><td>&ndash;</td><td></td></tr>")
                    objWriter.WriteLine("<tr><th></th><th style='text-align:right;font-size:20px;'>Total of Input Tax:</th><th style='font-size:20px;'>" + (gstInSR + gstInZR).ToString("F2") + "</th><th style='font-size:20px;'>" + gstInEX.ToString("F2") + "</th></tr>")
                    objWriter.WriteLine("<tr><th></th><th style='text-align:right;font-size:20px;'>Net GST Tax:</th><th colspan='2' style='font-size:20px;'>" + nettGST.ToString("F2") + "</th></tr>")
                    objWriter.WriteLine("</table><br></body></html>")
                    objWriter.Close()
                Else
                    System.IO.File.Create(FILE_NAME)
                    Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                    objWriter.WriteLine("<!DOCTYPE html><html><head><style type='text/css'> p{margin-top:5%;text-align: center;font-weight:bold;font-family:'Couriew New';line-height:2.0;font-size:20px;}table{border-collapse: collapse;margin-bottom:5%;}table, th, td {border: 3px solid black;text-align:center;}th, td{padding:20px;}</style></head><body><table border='1' style='width:100%'><p> VK COMPANY <br>")
                    objWriter.WriteLine("GST Summary for Total Supply &amp; Net Tax for Taxable Period " + dates + "&ndash;" + dueDates + "</p><tr><th style='font-size:20px;'>Types of Supply</th><th style='font-size:20px;'>Value of Supply Excluding GST (RM) </th><th style='font-size:20px;' colspan='2'>Output Tax 6% (RM)</th></tr>")
                    objWriter.WriteLine("<tr><td>SR - Standard Rate</td><td>" + gstOutSRTotal.ToString("F2") + "</td><td colspan='2'>" + gstOutSR.ToString("F2") + "</td></tr>")
                    objWriter.WriteLine("<tr><td>ZR - Zero Supply Rate</td><td>" + gstOutZRTotal.ToString("F2") + "</td><td colspan='2'>&ndash;</td></tr>")
                    objWriter.WriteLine("<tr><td>ES - Exempted Supply Rate</td><td>" + gstOutEXTotal.ToString("F2") + "</td><td colspan='2'>&ndash;</td></tr>")
                    objWriter.WriteLine("<tr><th></th><th style='text-align:right;font-size:20px;'>Total of Output Tax:</th><th style='font-size:20px;' colspan='2'>" + (gstOutSR + gstOutZR + gstOutEX).ToString("F2") + "</th></tr>")
                    objWriter.WriteLine("  <tr><th style='font-size:20px;'>Types of Acquisition</th><th style='font-size:20px;'>Value of Acquisition Excluding GST (RM) </th><th style='font-size:20px;' colspan='2'>Input Tax 6% (RM)</th></tr>")
                    objWriter.WriteLine("<tr><td></td><td></td><td>Claimable</td><td>Non-Claimable</td><tr>")
                    objWriter.WriteLine("<td>TX - Purchase with GST</td><td>" + (gstInSRTotal + gstInEXTotal + gstInZRTotal).ToString("F2") + "</td><td>" + (gstInSR + gstInZR).ToString("F2") + "</td><td>" + gstInEX.ToString("F2") + "</td></tr>")
                    objWriter.WriteLine("<tr><td>BL - Purchase with GST but Not Claimable</td><td>" + gstInEXTotal.ToString("F2") + "</td><td>&ndash;</td><td></td></tr>")
                    objWriter.WriteLine("  <tr><td>EP - Purchase Exempted from GST</td><td>" + gstInEXTotal.ToString("F2") + "</td><td>&ndash;</td><td></td></tr>")
                    objWriter.WriteLine("<tr><th></th><th style='text-align:right;font-size:20px;'>Total of Input Tax:</th><th style='font-size:20px;'>" + (gstInSR + gstInZR).ToString("F2") + "</th><th style='font-size:20px;'>" + gstInEX.ToString("F2") + "</th></tr>")
                    objWriter.WriteLine("<tr><th></th><th style='text-align:right;font-size:20px;'>Net GST Tax:</th><th colspan='2' style='font-size:20px;'>" + labelTNettGST.Text + "</th></tr>")
                    objWriter.WriteLine("</table><br></body></html>")
                    objWriter.Close()
                End If

            Catch fileEx As Exception
                MsgBox(fileEx.Message.ToString)
            End Try


            showGSTReport.Show()
        Else
            MessageBox.Show("Cannot generate GST report due to NO GST record found with your request.", _
            "Cannot generate GST report", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Warning)
        End If



    End Sub

    Private Sub getCashierID()
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim accountDataAdapter As OleDb.OleDbDataAdapter
        Dim accountDataSet As New DataSet
        Dim SqlCommand As String

        'Get active user
        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection

        SqlCommand = "SELECT accountID FROM ACCOUNT WHERE accountStatus = 'ACTIVE';"
        accountDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        accountDataAdapter.Fill(accountDataSet, "Account")

        If accountDataSet.Tables(0).Rows.Count > 0 Then
            cashier = accountDataSet.Tables(0).Rows(0).Item(0).ToString
        Else
            RemoveHandler Me.FormClosing, AddressOf formGReport_FormClosing
            Me.Close()
            formLogin.Show()
        End If
    End Sub
End Class
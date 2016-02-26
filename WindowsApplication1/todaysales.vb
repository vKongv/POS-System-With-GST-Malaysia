Public Class formTSales
    Public cashier As String = ""
    Dim todayDate As Date = Date.Today
    Dim tomorrowDate As Date = Date.Today.AddDays(1)

    Private Sub formTSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(43, 46, 52)
        getCashierID()
        labelCID.Text = "Cashier ID : " + cashier
        changeTodayDate()
        getTodaySales()
        getItemSold()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles picSChecking.Click, Label3.Click
        RemoveHandler Me.FormClosing, AddressOf formTSales_FormClosing
        Me.Close()
        formSCheckingUser.Show()
    End Sub

    Private Sub picTransaction_Click(sender As Object, e As EventArgs) Handles picTransaction.Click, Label1.Click
        RemoveHandler Me.FormClosing, AddressOf formTSales_FormClosing
        Me.Close()
        formTransactions.Show()
    End Sub

    Private Sub changeTodayDate()
        labelTDate.Text = todayDate.ToShortDateString
    End Sub

    Private Sub getTodaySales()
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim salesDataAdapter As OleDb.OleDbDataAdapter
        Dim salesDataSet As New DataSet
        Dim SqlCommand As String

        'Get all the data
        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection

        SqlCommand = "SELECT salesPrice, GSTOutput FROM SALES WHERE salesDate BETWEEN #" + todayDate.ToShortDateString + "# AND #" + tomorrowDate.ToShortDateString + "#;"
        salesDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        salesDataAdapter.Fill(salesDataSet, "Sales")
        DBconnection.Close()

        'Total up sales and GST
        Dim totalSales As Double = 0
        Dim totalGST As Double = 0
        Dim totalSalesIncludeGST As Double = 0
        For index As Integer = 0 To salesDataSet.Tables(0).Rows.Count - 1
            Dim tempSales As Double = 0
            Dim tempGST As Double = 0
            'Calculate total sales
            If Double.TryParse(salesDataSet.Tables(0).Rows(index).Item(0), tempSales) Then
                totalSales = totalSales + tempSales
            Else
                MessageBox.Show("Error")
            End If

            'Calculate total GST
            If Double.TryParse(salesDataSet.Tables(0).Rows(index).Item(1), tempGST) Then
                totalGST = totalGST + tempGST
            Else
                MessageBox.Show("Error")
            End If
        Next


        totalSalesIncludeGST = totalSales + totalGST
        labelTSales.Text = totalSales.ToString("F2")
        labelTGST.Text = totalGST.ToString("F2")
        labelTIncludeGST.Text = totalSalesIncludeGST.ToString("F2")
    End Sub

    Private Sub getItemSold()
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim stockDataAdapter As OleDb.OleDbDataAdapter
        Dim stockDataSet As New DataSet
        Dim SqlCommand As String

        'Get all the data
        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection
        SqlCommand = "SELECT transactions.stockID, stock.stockName, SUM(salesQty) AS salesQuantity FROM STOCK,TRANSACTIONS,SALES WHERE transactions.stockID = stock.stockID AND transactions.salesID = sales.salesID AND sales.salesDate BETWEEN #" + todayDate.ToShortDateString + "# AND #" + tomorrowDate.ToShortDateString + "# GROUP BY transactions.stockID , stock.stockName"
        stockDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        stockDataAdapter.Fill(stockDataSet, "Transaction")
        DataGridView1.DataSource = stockDataSet
        DataGridView1.DataMember = "Transaction"
        DBconnection.Close()

        'Set all the cell style
        Dim cellStyleAll As DataGridViewCellStyle = DataGridView1.DefaultCellStyle()
        Dim cellStyleAllAlt As DataGridViewCellStyle = DataGridView1.AlternatingRowsDefaultCellStyle()
        cellStyleAll.BackColor = Color.FromArgb(37, 57, 57)
        cellStyleAllAlt.BackColor = Color.FromArgb(37, 57, 57)
        cellStyleAll.SelectionBackColor = cellStyleAll.BackColor
        cellStyleAllAlt.SelectionBackColor = cellStyleAllAlt.BackColor

        'Set the Data Grid View back colour
        DataGridView1.BackgroundColor = Color.FromArgb(43, 46, 52)


        'Adjust the width dynamically
        Dim columnArray As DataGridViewColumn() = {DataGridView1.Columns(0), DataGridView1.Columns(1), DataGridView1.Columns(2)}
        Dim widthPercentage As Double() = {0.4, 0.4, 0.2}
        For index As Integer = 0 To columnArray.Count - 1
            columnArray(index).Width = Math.Floor(DataGridView1.Width * widthPercentage(index))
        Next

        'Set the column header text
        columnArray(0).HeaderText = "Stock ID"
        columnArray(1).HeaderText = "Stock Name"
        columnArray(2).HeaderText = "Sold Quantity"

        'Calculate total number of item sold
        Dim totalSoldItem As Integer = 0
        For index As Integer = 0 To stockDataSet.Tables(0).Rows.Count - 1
            totalSoldItem = totalSoldItem + Integer.Parse(stockDataSet.Tables(0).Rows(index).Item(2))
        Next

        'Display total number of item sold
        labelTItemSold.Text = totalSoldItem.ToString
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If DataGridView1.RowCount > 0 Then
            'Connect to database
            Dim DBconnection As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            Dim salesDataAdapter As OleDb.OleDbDataAdapter
            Dim salesDataSet As New DataSet
            Dim SqlCommand As String

            'Get all sales data for today
            DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
            DBconnection.Open()
            cmd.Connection = DBconnection
            SqlCommand = "SELECT * FROM sales WHERE sales.salesDate BETWEEN #" + todayDate.ToShortDateString + "# AND #" + tomorrowDate.ToShortDateString + "#;"
            salesDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
            salesDataAdapter.Fill(salesDataSet, "Sales")
            DBconnection.Close()

            Dim FILE_NAME As String = "\salesreport.html"
            Dim path As String = System.IO.Directory.GetCurrentDirectory()
            FILE_NAME = path + FILE_NAME

            Try
                If System.IO.File.Exists(FILE_NAME) = True Then

                    Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                    objWriter.WriteLine()
                    objWriter.WriteLine("<!DOCTYPE html><html><head><style type='text/css'> body{  text-align : center;font-family : 'Calibri';}table {  border-collapse: collapse;}table, th, td {padding : 100 px;border: 2px solid black;}</style></head><body><h2> Sales report </h2>")
                    objWriter.WriteLine("<h2> Today Date : " + todayDate.ToShortDateString + "</h2>")
                    objWriter.WriteLine("<table cellpadding='4' align ='center'><thead><tr><th> Sales ID </th><th> Sales Date </th><th> Sales amount (RM) </th><th> GST Output (RM)</th>  </tr></thead>")
                    For index As Integer = 0 To salesDataSet.Tables(0).Rows.Count - 1
                        objWriter.WriteLine("<tr> ")
                        For j As Integer = 0 To 3
                            If j > 1 Then
                                Dim amount As Double
                                Double.TryParse(salesDataSet.Tables(0).Rows(index).Item(j), amount)
                                objWriter.WriteLine("<td> " + amount.ToString("F2") + "</td>")
                            Else
                                objWriter.WriteLine("<td> " + salesDataSet.Tables(0).Rows(index).Item(j).ToString + "</td>")
                            End If
                        Next
                        objWriter.WriteLine("</tr>")
                    Next
                    objWriter.WriteLine("<tfoot><tr><th colspan='3'> Total sales with GST (RM): </th><th>" + labelTIncludeGST.Text + "</th></tr>")
                    objWriter.WriteLine("<tfoot><tr><th colspan='4'> ----- Total amount ----- </th></tr>")
                    objWriter.WriteLine("<tfoot><tr><th colspan='3'> Total sales without GST (RM): </th><th>" + labelTSales.Text + "</th></tr>")



                    objWriter.WriteLine("</tfoot></table></body></html>")
                    objWriter.Close()
                Else
                    System.IO.File.Create(FILE_NAME)
                    Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                    objWriter.WriteLine()
                    objWriter.WriteLine("<!DOCTYPE html><html><head><style type='text/css'> body{  text-align : center;font-family : 'Calibri';}table {  border-collapse: collapse;}table, th, td {padding : 100 px;border: 2px solid black;}</style></head><body><h2> Sales report </h2>")
                    objWriter.WriteLine("<h2> Today Date : " + todayDate.ToShortDateString + "</h2>")
                    objWriter.WriteLine("<table cellpadding='4' align ='center'><thead><tr><th> Sales ID </th><th> Sales Date </th><th> Sales amount (RM) </th><th> GST Output (RM)</th>  </tr></thead>")
                    For index As Integer = 0 To salesDataSet.Tables(0).Rows.Count - 1
                        objWriter.WriteLine("<tr> ")
                        For j As Integer = 0 To 3
                            If j > 1 Then
                                Dim amount As Double
                                Double.TryParse(salesDataSet.Tables(0).Rows(index).Item(j), amount)
                                objWriter.WriteLine("<td> " + amount.ToString("F2") + "</td>")
                            Else
                                objWriter.WriteLine("<td> " + salesDataSet.Tables(0).Rows(index).Item(j).ToString + "</td>")
                            End If
                        Next
                        objWriter.WriteLine("</tr>")
                    Next
                    objWriter.WriteLine("<tfoot><tr><th colspan='3'> Total sales with GST (RM): </th><th>" + labelTIncludeGST.Text + "</th></tr>")
                    objWriter.WriteLine("<tfoot><tr><th colspan='4'> ----- Total amount ----- </th></tr>")
                    objWriter.WriteLine("<tfoot><tr><th colspan='3'> Total sales without GST (RM): </th><th>" + labelTSales.Text + "</th></tr>")



                    objWriter.WriteLine("</tfoot></table></body></html>")
                    objWriter.Close()
                End If
            Catch fileEx As Exception
                MsgBox(fileEx.Message.ToString)
            End Try
            showSalesReport.Show()
        Else
            MessageBox.Show("Cannot generate Sales Report due to NO sales record found with your request.", _
            "Cannot generate SALES report", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub formTSales_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
            RemoveHandler Me.FormClosing, AddressOf formTSales_FormClosing
            Me.Close()
            formLogin.Show()
        End If
    End Sub
End Class
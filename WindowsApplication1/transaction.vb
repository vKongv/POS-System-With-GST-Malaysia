Public Class formTransactions
    Public cashier As String = ""
    Dim singlePrice As Double
    Dim dataTable As New DataTable
    Dim GSToutput As Double = 0
    Dim totalPriceAll As Double = 0
    Dim salesID As String = ""

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(43, 46, 52)
        textIName.BackColor = Color.FromArgb(151, 40, 44)
        getCashierID()
        labelCID.Text = "Cashier ID : " + cashier
        setDataGridViewStyle()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub textICode_Click(sender As Object, e As EventArgs) Handles textICode.Click
        textICode.Text = ""
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Function connectDBandValidate(ByVal itemCode As String)
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim stockDataAdapter As OleDb.OleDbDataAdapter
        Dim stockDataSet As New DataSet
        Dim SqlCommand As String

        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection
        SqlCommand = "SELECT * FROM STOCK WHERE stockID = '" + itemCode + "';"
        stockDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        stockDataAdapter.Fill(stockDataSet, "Stock")

        'Check the item code is valid or not
        If stockDataSet.Tables(0).Rows().Count > 0 Then
            singlePrice = Double.Parse(stockDataSet.Tables(0).Rows(0).Item(4))
            Return stockDataSet.Tables(0).Rows(0).Item(1)
        Else
            Return ""
        End If
        DBconnection.Close()
    End Function

    Private Sub textICode_TextChanged(sender As Object, e As EventArgs) Handles textICode.TextChanged
        Dim stockName As String = connectDBandValidate(textICode.Text)
        If Not stockName = "" Then
            textIName.Text = stockName
            textIName.BackColor = Color.LightSeaGreen
        Else
            textIName.Text = ""
            textIName.BackColor = Color.FromArgb(151, 40, 44)
        End If

        'Validate input
        validateInputData()
    End Sub

    Private Sub setDataGridViewStyle()

        'Set all the cell style
        Dim cellStyleAll As DataGridViewCellStyle = DataGridView1.DefaultCellStyle()
        Dim cellStyleAllAlt As DataGridViewCellStyle = DataGridView1.AlternatingRowsDefaultCellStyle()
        cellStyleAll.BackColor = Color.FromArgb(37, 57, 57)
        cellStyleAllAlt.BackColor = Color.FromArgb(37, 57, 57)
        cellStyleAll.SelectionBackColor = Color.LightSeaGreen
        cellStyleAllAlt.SelectionBackColor = Color.LightSeaGreen

        'Set the Data Grid View back colour
        DataGridView1.BackgroundColor = Color.FromArgb(43, 46, 52)



        'Add the column 
        dataTable.Columns.Add("Item ID")
        dataTable.Columns.Add("Item Name")
        dataTable.Columns.Add("Quantity")
        dataTable.Columns.Add("Single Price")
        dataTable.Columns.Add("Price (GST)")

        DataGridView1.DataSource = dataTable

        'Adjust the width dynamically
        Dim columnArray As DataGridViewColumn() = {DataGridView1.Columns(0), DataGridView1.Columns(1), DataGridView1.Columns(2),
                                                   DataGridView1.Columns(3), DataGridView1.Columns(4)}

        Dim widthPercentage As Double() = {0.2, 0.4, 0.1, 0.15, 0.15}
        For index As Integer = 0 To columnArray.Count - 1
            columnArray(index).Width = Math.Floor(DataGridView1.Width * widthPercentage(index) - 1)
        Next


    End Sub

    Private Sub validateInputData()
        Dim quantity As Integer
        Dim discount As Double = 0

        If textIName.BackColor = Color.LightSeaGreen And
            Integer.TryParse(textQty.Text, quantity) And
            Double.TryParse(textDiscount.Text, discount) Then
            If rbPercent.Checked Then
                If discount > 100 Or discount < 0 Then
                    MessageBox.Show("Discount rate must be between 0% and 100%", _
                        "Invalid discount rate", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Warning)
                    textDiscount.Text = "0"
                    bAddItem.Enabled = False
                    bEnter.Enabled = False
                Else
                    bAddItem.Enabled = True
                    bEnter.Enabled = True
                End If
            Else
                If discount >= singlePrice Then
                    MessageBox.Show("Discount is larger than the original stock price!", _
                        "Invalid discount rate", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Warning)
                    textDiscount.Text = "0"
                    bAddItem.Enabled = False
                    bEnter.Enabled = False
                Else
                    bAddItem.Enabled = True
                    bEnter.Enabled = True
                End If
            End If
        Else
            bAddItem.Enabled = False
            bEnter.Enabled = False
        End If
    End Sub

    Private Sub textQty_TextChanged(sender As Object, e As EventArgs) Handles textQty.TextChanged
        validateInputData()
    End Sub

    Private Sub textDiscount_TextChanged(sender As Object, e As EventArgs) Handles textDiscount.TextChanged
        validateInputData()
    End Sub

    Private Sub bEnter_Click(sender As Object, e As EventArgs) Handles bAddItem.Click
        addItem()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        'Delete selected row
        If (DataGridView1.Rows.Count > 0) Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            calculateTotal()
        Else
            MessageBox.Show("No item added! ", _
                       "Cannot delete item", _
                       MessageBoxButtons.OK, _
                       MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub resetAllText()
        textICode.Text = ""
        textQty.Text = "1"
        textDiscount.Text = "0"
        rbRM.Checked = True

    End Sub

    Private Sub calculateTotal()
        Dim totalPrice As Double = 0
        'Add all the price
        For index As Integer = 0 To DataGridView1.Rows.Count() - 1
            totalPrice = totalPrice + Double.Parse(dataTable.Rows(index).Item("Price (GST)"))
        Next


        'Round to 2 decimal places
        Decimal.Round(totalPrice, 2, MidpointRounding.AwayFromZero)
        totalPriceAll = totalPrice
        'Display the total cost
        labelTotal.Text = "RM " + totalPrice.ToString("F2")
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        calculateTotal()
    End Sub
    Private Sub addItem()
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim stockDataAdapter As OleDb.OleDbDataAdapter
        Dim stockDataSet As New DataSet
        Dim SqlCommand As String

        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection
        SqlCommand = "SELECT * FROM STOCK WHERE stockID = '" + textICode.Text.ToUpper + "';"
        stockDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        stockDataAdapter.Fill(stockDataSet, "Stock")

        'Check the current stock with the stock that want to add inside
        Dim currentStock As Integer = (stockDataSet.Tables(0).Rows(0).Item(3))
        Dim overStock As Boolean = false
        Dim overStockPosition As Integer = 0
        If (Integer.Parse(textQty.Text) > currentStock) Then
            If MessageBox.Show("The current stock for this item is not enough for this transaction." + vbNewLine + "Press YES to continue or NO to cancel", _
                    "Not enough stock", _
                    MessageBoxButtons.YesNo, _
                    MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                overStock = True
                overStockPosition = DataGridView1.RowCount
            Else
                resetAllText()
                Exit Sub
            End If
        End If

        'Check the existing item whether it is exist in datagridview or not
        Dim existingStock As Integer = 0
        Dim editItemIndex As Integer = 0
        For index As Integer = 0 To DataGridView1.RowCount - 1
            Dim currentItemName As String = DataGridView1.Rows(index).Cells(1).Value.ToString
            If textIName.Text = currentItemName Then
                editItemIndex = index
                existingStock = Integer.Parse(DataGridView1.Rows(index).Cells(2).Value.ToString)

                If Not overStock And ((Integer.Parse(textQty.Text) + existingStock) > currentStock) Then
                    If MessageBox.Show("The current stock for this item is not enough for this transaction." + vbNewLine + "Press YES to continue or NO to cancel", _
                            "Not enough stock", _
                            MessageBoxButtons.YesNo, _
                            MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        overStock = True
                        overStockPosition = editItemIndex
                    Else
                        resetAllText()
                        Exit Sub
                    End If
                End If
                Exit For
            End If
        Next

        'Calculate the price
        Dim price As Double
        Dim oriPrice As Double
        Dim discount As Double = Double.Parse(textDiscount.Text)
        Dim quantity As Integer = Integer.Parse(textQty.Text) + existingStock
        Dim GST As Integer = 106
        Dim GSToutputSingle As Double
        If (stockDataSet.Tables(0).Rows(0).Item(5) = "ZERO RATED" Or stockDataSet.Tables(0).Rows(0).Item(5) = "EXEMPTED") Then
            GST = 100
        End If

        If rbPercent.Checked Then
            price = singlePrice * (100 - discount) / (100)
        Else
            price = singlePrice - discount
        End If

        oriPrice = price
        price = price * (GST / 100)
        GSToutputSingle = price - oriPrice
        price = price * quantity
        GSToutput += GSToutputSingle * quantity
        Decimal.Round(price, 2, MidpointRounding.AwayFromZero)
        Decimal.Round(oriPrice, 2, MidpointRounding.AwayFromZero)
        Decimal.Round(GSToutput, 2, MidpointRounding.AwayFromZero)
        Dim priceStr As String
        Dim oriPriceStr As String
        priceStr = price.ToString("F2")
        oriPriceStr = oriPrice.ToString("F2")

        If existingStock > 0 Then
            dataTable.Rows(editItemIndex).Item(2) = quantity.ToString
            dataTable.Rows(editItemIndex).Item(4) = priceStr
            calculateTotal()
        Else
            dataTable.Rows.Add(textICode.Text.ToUpper, textIName.Text, quantity.ToString, oriPriceStr, priceStr)
        End If


        If overStock Then
            Dim cellStyle As DataGridViewCellStyle = DataGridView1.Rows(overStockPosition).DefaultCellStyle()
            cellStyle.BackColor = Color.FromArgb(151, 40, 44)
            cellStyle.SelectionBackColor = cellStyle.BackColor
        End If

        'Reset all text
        resetAllText()
        DBconnection.Close()
    End Sub

    Private Sub bEnter_Click_1(sender As Object, e As EventArgs) Handles bEnter.Click
        addItem()
    End Sub

    Private Sub bDone_Click(sender As Object, e As EventArgs) Handles bDone.Click
        If (DataGridView1.Rows.Count > 0) Then
            insertIntoSales()
            insertIntoTransaction()
            showTaxInvoice()
            resetAllText()
            labelTotal.Text = "RM 0.00"
            resetTable()
        Else
            MessageBox.Show("No item added! ", _
                       "Cannot add transaction", _
                       MessageBoxButtons.OK, _
                       MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub insertIntoSales()
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim salesDataAdapter As OleDb.OleDbDataAdapter
        Dim salesDataSet As New DataSet
        Dim SqlCommand As String

        Dim thisDay As DateTime = DateTime.Now
        Dim todays As String = thisDay.ToString()


        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        cmd.Connection = DBconnection
        DBconnection.Open()

        'Get the number of rows and calculate the ID
        SqlCommand = "SELECT COUNT(*) FROM SALES ;"
        salesDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        salesDataAdapter.Fill(salesDataSet, "Sales")
        Dim numberOfRow = Integer.Parse(salesDataSet.Tables(0).Rows(0).Item(0))
        Dim id As Integer = 10000001 + numberOfRow

        salesID = id.ToString
        Dim totalPriceNoGST As Double
        totalPriceNoGST = totalPriceAll - GSToutput
        'Execute the sql command
        cmd.CommandText = "INSERT INTO SALES (salesID, salesDate,salesPrice,GSTOutput,cashierID) VALUES ('" + id.ToString + "','" + todays + "'," + totalPriceNoGST.ToString("F2") + "," + GSToutput.ToString("F2") + ",'" + cashier + "');"
        cmd.ExecuteNonQuery()
        DBconnection.Close()
        MsgBox("Successfully Added")
    End Sub

    Private Sub insertIntoTransaction()
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim transactionDataAdapter As OleDb.OleDbDataAdapter
        Dim transactionDataSet As New DataSet
        Dim SqlCommand As String

        Dim salesID As String = ""
        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        cmd.Connection = DBconnection
        DBconnection.Open()


        'Get the sales ID
        SqlCommand = "SELECT salesID FROM SALES ;"
        transactionDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        transactionDataAdapter.Fill(transactionDataSet, "Sales")

        Dim numOfRows As Integer = transactionDataSet.Tables(0).Rows.Count
        If (numOfRows > 0) Then
            salesID = transactionDataSet.Tables(0).Rows(numOfRows - 1).Item(0)
            MessageBox.Show(salesID)
        End If

        For index As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim x As String = DataGridView1.Rows(index).Cells(2).Value.ToString
            Dim id As String = DataGridView1.Rows(index).Cells(0).Value.ToString
            Dim price As String = DataGridView1.Rows(index).Cells(3).Value.ToString
            Dim priceWithDecimal As Double = Double.Parse(price)
            cmd.CommandText = "INSERT INTO TRANSACTIONS (stockID, salesID,salesQty,salesSinglePrice) VALUES ('" + id + "','" + salesID + "'," + x + "," + priceWithDecimal.ToString("F2") + ");"
            cmd.ExecuteNonQuery()

            'Update Stock
            cmd.CommandText = "UPDATE STOCK SET stockQty = stockQty - " + x + " WHERE stockID = '" + id + "';"
            cmd.ExecuteNonQuery()
        Next


        DBconnection.Close()
        cmd.Dispose()
    End Sub

    Private Sub resetTable()
        For index As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows.RemoveAt(0)
        Next
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles picTransaction.Click, Label1.Click
        resetAllText()
    End Sub

    Private Sub picTSales_Click(sender As Object, e As EventArgs) Handles picTSales.Click, Label2.Click
        RemoveHandler Me.FormClosing, AddressOf formTransactions_FormClosing
        Me.Close()
        formTSales.Show()
    End Sub

    Private Sub picSChecking_Click(sender As Object, e As EventArgs) Handles picSChecking.Click, Label3.Click
        RemoveHandler Me.FormClosing, AddressOf formTransactions_FormClosing
        Me.Close()
        formSCheckingUser.Show()
    End Sub

    Private Sub formTransactions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
            RemoveHandler Me.FormClosing, AddressOf formTransactions_FormClosing
            Me.Close()
            formLogin.Show()
        End If
    End Sub

    Private Sub showTaxInvoice()
        'Generate formatted report
        Dim FILE_NAME As String = "\taxInvoice.html"
        Dim path As String = System.IO.Directory.GetCurrentDirectory()
        FILE_NAME = path + FILE_NAME

        Try
            If System.IO.File.Exists(FILE_NAME) = True Then
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                objWriter.WriteLine("<!DOCTYPE html><html><head><meta charset='utf-8'><style = 'text/css'>p {text-align:center;line-height:1.5; font-weight:bold;}table#item tr td{ text-align:left;padding-left:50px; padding-right:50px;}</style></head><body><p style='font-size:20px;'>VK Saloon AEON Bandaraya Melaka<br>VK Hair Saloon (G-1-2-11)<br>AEON Bandaraya Melaka Shopping Center, Jalan Legenda, 75400 Melaka.</p><p style='margin-bottom:-20px;'>-----------------------------------------------------------------------------------------------------------------------------------</p><p style='margin-bottom:-20px;'><strong> TAX INVOICE </strong></p><p>-----------------------------------------------------------------------------------------------------------------------------------</p>")
                objWriter.WriteLine("<table align='center'><tr><td style='text-align:right;'>Transaction No.:</td><td style='text-align:left; padding-left:20px;'>" + salesID + "</td></tr>")
                objWriter.WriteLine("<tr><td style='padding-left:180px; padding-right:180px;'></td><td style='padding-left:180px; padding-right:180px;'>" + Date.Today.ToString + "</td></tr></table>")
                objWriter.WriteLine("<p>-----------------------------------------------------------------------------------------------------------------------------------</p><table id='item' align='center'>")
                objWriter.WriteLine("<thead><tr><th>No.</th><th>Item Name</th><th>Quantity</th><th>Amount (RM) </th></tr></thead>")
                MsgBox(DataGridView1.RowCount)
                For index As Integer = 0 To DataGridView1.RowCount - 1
                    objWriter.WriteLine("<tr><td>" + (index + 1).ToString + "</td><td>" + DataGridView1.Rows(index).Cells(1).Value.ToString + "</td><td>" + DataGridView1.Rows(index).Cells(2).Value.ToString + "</td><td>" + DataGridView1.Rows(index).Cells(4).Value.ToString + "</td></tr>")
                Next
                objWriter.WriteLine("<tr><td style='padding:10px;'colspan ='4'></td></tr><tr><td colspan ='3' style='text-align:left;padding:10px;'>GST:</td><td>" + GSToutput.ToString("F2") + "</td></tr>")
                objWriter.WriteLine("<tr><td style='text-align:left;padding:10px;' colspan ='3'>Total included GST:</td><td>" + totalPriceAll.ToString("F2") + "</td></tr></table>")
                objWriter.WriteLine("<p style='margin-bottom:-20px;'>-----------------------------------------------------------------------------------------------------------------------------------</p>")
                objWriter.WriteLine("<p style='text-align:center; margin-bottom:-20px;'><strong>transacted by Cashier" + cashier + "</strong></p>")
                objWriter.WriteLine("<p>-----------------------------------------------------------------------------------------------------------------------------------</p><p style='font-weight:normal;'>This served as your official receipt. <br>Thanks for your visiting. Have a nice day!</p></body></html>")
                objWriter.Close()
            Else
                System.IO.File.Create(FILE_NAME)
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
                objWriter.WriteLine("<!DOCTYPE html><html><head><meta charset='utf-8'<style>p {text-align:center;line-height:1.5; font-weight:bold;}table#item tr td{ text-align:left;padding-left:50px; padding-right:50px;}</style></head><body><p style='font-size:20px;'>VK Saloon AEON Bandaraya Melaka<br>VK Hair Saloon (G-1-2-11)<br>AEON Bandaraya Melaka Shopping Center, Jalan Legenda, 75400 Melaka.</p><p style='margin-bottom:-20px;'>-----------------------------------------------------------------------------------------------------------------------------------</p><p style='margin-bottom:-20px;'><strong> TAX INVOICE </strong></p><p>-----------------------------------------------------------------------------------------------------------------------------------</p>")
                objWriter.WriteLine("<table align='center'><tr><td style='text-align:right;'>Transaction No.:</td><td style='text-align:left; padding-left:20px;'>" + salesID + "</td></tr>")
                objWriter.WriteLine("<tr><td style='padding-left:180px; padding-right:180px;'></td><td style='padding-left:180px; padding-right:180px;'>" + DateTime.Now.ToString + "</td></tr></table>")
                objWriter.WriteLine("<p>-----------------------------------------------------------------------------------------------------------------------------------</p><table id='item' align='center'>")
                objWriter.WriteLine("<thead><tr><th>No.</th><th>Item Name</th><th>Quantity</th><th>Amount (RM) </th></tr></thead>")
                MsgBox(DataGridView1.RowCount)
                For index As Integer = 0 To DataGridView1.RowCount - 1
                    objWriter.WriteLine("<tr><td>" + (index + 1).ToString + "</td><td>" + DataGridView1.Rows(index).Cells(1).ToString + "</td><td>" + DataGridView1.Rows(index).Cells(2).ToString("F2") + "</td><td>" + DataGridView1.Rows(index).Cells(4).ToString + "</td></tr>")
                Next
                objWriter.WriteLine("<tr><td style='padding:10px;'colspan ='4'></td></tr><tr><td colspan ='3' style='text-align:left;padding:10px;'>GST:</td><td>" + GSToutput.ToString("F2") + "</td></tr>")
                objWriter.WriteLine("<tr><td style='text-align:left;padding:10px;' colspan ='3'>Total included GST:</td><td>" + totalPriceAll.ToString("F2") + "</td></tr></table>")
                objWriter.WriteLine("<p style='margin-bottom:-20px;'>-----------------------------------------------------------------------------------------------------------------------------------</p>")
                objWriter.WriteLine("<p style='text-align:center; margin-bottom:-20px;'><strong>transacted by Cashier " + cashier + "</strong></p>")
                objWriter.WriteLine("<p>-----------------------------------------------------------------------------------------------------------------------------------</p><p style='font-weight:normal;'>This served as your official receipt. <br>Thanks for your visiting. Have a nice day!</p></body></html>")
                objWriter.Close()
                objWriter.Close()
            End If

        Catch fileEx As Exception
            MsgBox(fileEx.Message.ToString)
        End Try
        taxInvoice.Show()
    End Sub
End Class
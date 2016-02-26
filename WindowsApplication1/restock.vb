Public Class formARestock
    Dim oriPrice As Double = 0.0
    Dim GSTinput As Double = 0.0
    Dim newProduct As Boolean = False
    Public cashier As String = ""

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(43, 46, 52)
        getCashierID()
        loadSupplierInfo()
        loadItemType()

    End Sub

    Private Sub salesReport_Click(sender As Object, e As EventArgs) Handles picSReport.Click, labelSReport.Click
        RemoveHandler Me.FormClosing, AddressOf formARestock_FormClosing
        Me.Close()
        formSReportAdmin.Show()
    End Sub

    Private Sub GSTReport_Click(sender As Object, e As EventArgs) Handles picGSTReport.Click, labelGSTReport.Click
        RemoveHandler Me.FormClosing, AddressOf formARestock_FormClosing
        Me.Close()
        formGReport.Show()
    End Sub

    Private Sub textICode_Click(sender As Object, e As EventArgs) Handles textICode.Click
        resetAll()
        'Reset the new product to false
        If (newProduct) Then
            newProduct = False
        End If
    End Sub

    Private Sub labelNStock_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles labelNStock.LinkClicked
        resetAll()
        showAll("")
        enableAll()
        labelEAll.Visible = False
        'Indicate that this is a new product
        newProduct = True
    End Sub

    Private Sub resetAll()
        'Reset all the thing in the form
        textICode.Text = ""
        textPCode.Text = ""
        textPName.Text = ""
        textSName.Text = ""
        textPPrice.Text = ""
        textSPrice.Text = ""
        textPQuantity.Text = ""
        gbPDetails.Visible = False
        labelEAll.Visible = True
        rbSRate.Checked = True
        textICode.CharacterCasing = CharacterCasing.Normal
        textPCode.Enabled = False
        textPCode.ReadOnly = True
        textPName.Enabled = False
        textPName.ReadOnly = True
        textSPrice.Enabled = False
        textSPrice.ReadOnly = True
        bDone.Visible = False
        labelIInput.Visible = False
        textPType.Enabled = False
        textPType.Text = ""
        labelIInput.Visible = False
    End Sub

    Private Sub stockChecking_Click(sender As Object, e As EventArgs)
        Me.Close()
        formSChecking.Show()
    End Sub

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bEnter.Click
        If gbPDetails.Visible = True Then
            Dim tempICode As String = textICode.Text
            resetAll()
            textICode.Text = tempICode
        End If
        Dim itemName As String = checkItemName()
        If Not (itemName = "") Then
            showAll(itemName)
        Else
            MessageBox.Show("We cannot find any matched item, please enter the correct item code. Please contact us for any assistant", _
           "No item found", _
           MessageBoxButtons.OK, _
           MessageBoxIcon.Warning)
            resetAll()
        End If


    End Sub

    Private Sub showAll(ByVal itemName As String)
        If itemName = "" Then
        Else
            addStockInfoToTextBox()
        End If


        gbPDetails.Visible = True
        labelIInput.Visible = True
        textPCode.Text = textICode.Text
        textPName.Text = itemName
    End Sub

    Private Sub labelEAll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles labelEAll.LinkClicked
        enableAll()
        textPType.Enabled = False
        textPCode.Enabled = False

    End Sub

    Private Sub enableAll()
        textPCode.Enabled = True
        textPCode.ReadOnly = False
        textPName.Enabled = True
        textPName.ReadOnly = False
        textSPrice.Enabled = True
        textSPrice.ReadOnly = False
        rbSRate.Enabled = True
        rbExempted.Enabled = True
        rbZRate.Enabled = True
        textPType.Enabled = True
    End Sub

    Private Sub labelEGST_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles labelEGST.LinkClicked
        'Open a form that allow the user to edit a default GST type
        formEGST.Show()
    End Sub

    Private Sub bDone_Click(sender As Object, e As EventArgs) Handles bDone.Click
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim cmdUpdateStock As New OleDb.OleDbCommand
        Dim cmdUpdateSupplyDetail As New OleDb.OleDbCommand
        Dim supplierDataAdapter As OleDb.OleDbDataAdapter
        Dim supplierDataSet As New DataSet
        Dim SqlCommand As String

        Dim thisDay As DateTime = DateTime.Now
        Dim todays As String = thisDay.ToString()
        Dim claimable As String = "1"

        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmdUpdateStock.Connection = DBconnection
        cmdUpdateSupplyDetail.Connection = DBconnection
        cmd.Connection = DBconnection

        'Check for exisiting stock ID whether the stock is exist or not
        If newProduct Then
            SqlCommand = "SELECT stockID,stockName FROM STOCK WHERE stockID = '" + textPCode.Text + "';"
            supplierDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
            supplierDataAdapter.Fill(supplierDataSet, "Stock")

            If supplierDataSet.Tables(0).Rows.Count > 0 Then
                MessageBox.Show("The product code you enter is conflic with product name: " + vbNewLine + supplierDataSet.Tables(0).Rows(0).Item(1).ToString.ToUpper + vbNewLine + "NO data will be saved!", _
                      "Conflict Product Code", _
                     MessageBoxButtons.OK, _
                     MessageBoxIcon.Warning)
                resetAll()
                cmd.Dispose()
                cmdUpdateStock.Dispose()
                cmdUpdateSupplyDetail.Dispose()
                DBconnection.Close()
                Exit Sub
            End If
        End if

        Dim supplierID As String = ""
        'Get the supplierID if the supplier is existing supplier
        If labelNewSup.Visible = False Then
            SqlCommand = "SELECT supID FROM SUPPLIER WHERE supName = '" + textSName.Text + "';"
            supplierDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
            supplierDataAdapter.Fill(supplierDataSet, "Supplier")
            supplierID = supplierDataSet.Tables(1).Rows(0).Item(0).ToString
        Else
            'Add new supplier
            'Generate Supplier ID
            Dim supplierIDs As Integer = 0

            SqlCommand = "SELECT supID FROM SUPPLIER;"
            supplierDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
            supplierDataAdapter.Fill(supplierDataSet, "Supplier")
            Dim numOfSupplier As Integer = supplierDataSet.Tables(1).Rows.Count

            supplierIDs = 30000001 + numOfSupplier
            supplierID = supplierIDs.ToString

            cmd.CommandText = "INSERT INTO SUPPLIER (supID,supName) VALUES ('" + supplierID + "','" + textSName.Text + "');"
            cmd.ExecuteNonQuery()
        End If



        'Generate the gst type based on check box checked
        Dim gstName As String = ""

        If rbSRate.Checked Then
            gstName = "STANDARD RATED"
        ElseIf rbExempted.Checked Then
            gstName = "EXEMPTED"
            claimable = "0"
        ElseIf rbZRate.Checked Then
            gstName = "ZERO RATED"
        End If

        'Generate the GST input
        Dim totalCost As Double = oriPrice * Integer.Parse(textPQuantity.Text)

        If rbPExcludedGST.Checked Then

            GSTinput = totalCost * 6 / 106
            Decimal.Round(GSTinput, 2, MidpointRounding.AwayFromZero)
            MessageBox.Show(GSTinput)

        ElseIf rbPIncludeGST.Checked Then

            Dim oriPrice1 As Double = 0
            oriPrice1 = totalCost * 100 / 106
            GSTinput = totalCost - oriPrice1
            Decimal.Round(GSTinput, 2, MidpointRounding.AwayFromZero)

        ElseIf rbPNoGST.Checked Then
            GSTinput = 0
        End If

        totalCost = totalCost - GSTinput

        'Restock or add new product
        If newProduct Then
            Dim upperCaseStockID = textPCode.Text.ToUpper
            cmdUpdateStock.CommandText = "INSERT INTO STOCK (stockID, stockName, stockType, stockQty, stockPrice, GSTType) VALUES ('" + upperCaseStockID + "','" + textPName.Text +
                                        "','" + textPType.Text + "'," + textPQuantity.Text + "," + textSPrice.Text + ",'" + gstName + "');"
            cmdUpdateStock.ExecuteNonQuery()


        Else
            cmdUpdateStock.CommandText = "UPDATE STOCK SET stockName = '" + textPName.Text + "', GSTType = '" + gstName + "', stockPrice = " + textSPrice.Text +
                            ",stockQty = stockQty + " + textPQuantity.Text + " WHERE stockID ='" + textPCode.Text + "';"
            cmdUpdateStock.ExecuteNonQuery()
        End If

        cmdUpdateSupplyDetail.CommandText = "INSERT INTO SUPPLY_DETAIL (supID,stockID,dateOfSupply,stockAmount,totalCost,GSTInput) VALUES ('" + supplierID + "','" + textPCode.Text + "','" + todays + "'," + textPQuantity.Text + ", " + totalCost.ToString("F2") + ", " + GSTinput.ToString("F2") + ");"
        cmdUpdateSupplyDetail.ExecuteNonQuery()

        If labelNewType.Visible = True Then
            cmd.CommandText = "INSERT INTO GSTRATE (productType,gstType) VALUES ('" + textPType.Text + "','" + gstName + "');"
            cmd.ExecuteNonQuery()
        End If

        cmd.Dispose()
        cmdUpdateStock.Dispose()
        cmdUpdateSupplyDetail.Dispose()
        DBconnection.Close()
        resetAll()
    End Sub

    Private Sub loadSupplierInfo()
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim supplierDataAdapter As OleDb.OleDbDataAdapter
        Dim supplierDataSet As New DataSet
        Dim SqlCommand As String

        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection
        SqlCommand = "SELECT supName FROM SUPPLIER ;"
        supplierDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        supplierDataAdapter.Fill(supplierDataSet, "Supplier")

        'Set the arrayList's element(s) with the supplierName get from database
        Dim supplierInfo As ArrayList = New ArrayList()
        If supplierDataSet.Tables(0).Rows.Count > 0 Then
            For index As Integer = 0 To supplierDataSet.Tables(0).Rows.Count - 1
                supplierInfo.Add(supplierDataSet.Tables(0).Rows(index).Item(0))
            Next
        End If

        'Pass the array list to an array string
        Dim supplierInfoArr As String() = CType(supplierInfo.ToArray(GetType(String)), String())

        textSName.AutoCompleteCustomSource.AddRange(supplierInfoArr)

        DBconnection.Close()
    End Sub

    Private Sub loadItemType()
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim stockDataAdapter As OleDb.OleDbDataAdapter
        Dim stockDataSet As New DataSet
        Dim SqlCommand As String

        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection
        SqlCommand = "SELECT productType FROM GSTRATE ;"
        stockDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        stockDataAdapter.Fill(stockDataSet, "Stock")

        Dim stockInfo As ArrayList = New ArrayList()

        If stockDataSet.Tables(0).Rows.Count > 0 Then
            For index As Integer = 0 To stockDataSet.Tables(0).Rows.Count - 1
                stockInfo.Add(stockDataSet.Tables(0).Rows(index).Item(0))
            Next
        Else
            MessageBox.Show("No data added")
        End If

        'Pass the array list to an array string
        Dim stockInfoArr As String() = CType(stockInfo.ToArray(GetType(String)), String())

        textPType.AutoCompleteCustomSource.AddRange(stockInfoArr)

        DBconnection.Close()
    End Sub

    Private Function checkItemName()
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim stockDataAdapter As OleDb.OleDbDataAdapter
        Dim stockDataSet As New DataSet
        Dim SqlCommand As String

        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection
        SqlCommand = "SELECT * FROM STOCK WHERE stockID = '" + textICode.Text + "';"
        stockDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        stockDataAdapter.Fill(stockDataSet, "Stock")

        'Check the item code is valid or not
        If stockDataSet.Tables(0).Rows().Count > 0 Then
            Return stockDataSet.Tables(0).Rows(0).Item(1)
        Else
            Return ""
        End If
        DBconnection.Close()
    End Function

    Private Sub addStockInfoToTextBox()
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim stockDataAdapter As OleDb.OleDbDataAdapter
        Dim stockDataSet As New DataSet
        Dim SqlCommand As String

        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection
        SqlCommand = "SELECT * FROM STOCK WHERE stockID = '" + textICode.Text + "';"
        stockDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        stockDataAdapter.Fill(stockDataSet, "Stock")

        'Store the price and the transfer it to 2 decimal places
        Dim sellPrice As Double = 0
        sellPrice = Double.Parse(stockDataSet.Tables(0).Rows(0).Item("stockPrice").ToString())
        textSPrice.Text = sellPrice.ToString("F2")

        'Display the product type
        textPType.Text = stockDataSet.Tables(0).Rows(0).Item("stockType").ToString()

        If (stockDataSet.Tables(0).Rows(0).Item("GSTType") = "Zero Rated") Then
            rbZRate.Checked = True
        ElseIf (stockDataSet.Tables(0).Rows(0).Item("GSTType") = "Exempted") Then
            rbExempted.Checked = True
        End If

    End Sub


    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub productPriceChanger()
        Dim productPrice As Double
        Dim gst As Double
        'If it is checked, change the price to GST price
        If (rbPExcludedGST.Checked) And Not (textPPrice.Text = "") And (Double.TryParse(textPPrice.Text, productPrice)) Then
            gst = productPrice * 6 / 100
            productPrice = productPrice + gst
            Decimal.Round(productPrice, 2, MidpointRounding.AwayFromZero)
            textPPrice.Text = productPrice.ToString("F2")
        ElseIf ((rbPIncludeGST.Checked) Or (rbPNoGST.Checked)) And Not (textPPrice.Text = "") And (Double.TryParse(textPPrice.Text, productPrice)) Then
            Decimal.Round(oriPrice, 2, MidpointRounding.AwayFromZero)
            textPPrice.Text = oriPrice.ToString("F2")
        End If

    End Sub

    Private Sub rbPNoGST_Click(sender As Object, e As EventArgs) Handles rbPNoGST.Click
        productPriceChanger()
        MessageBox.Show(oriPrice)
    End Sub

    Private Sub rbPIncludeGST_Click(sender As Object, e As EventArgs) Handles rbPIncludeGST.Click
        productPriceChanger()
        MessageBox.Show(oriPrice)
    End Sub

    Private Sub rbPExcludedGST_Click(sender As Object, e As EventArgs) Handles rbPExcludedGST.Click
        productPriceChanger()
        MessageBox.Show(oriPrice)
    End Sub

    Private Function validateInput()


        If (gbPDetails.Visible) Then
            'Check for number first
            Dim valid As Boolean = False
            Dim productPrice As Double = 0
            Dim sellingPrice As Double = 0
            Dim quantity As Integer = 0

            If Double.TryParse(textPPrice.Text, productPrice) And Double.TryParse(textSPrice.Text, sellingPrice) And Integer.TryParse(textPQuantity.Text, quantity) Then
                valid = True
            Else
                valid = False
            End If

            'Check the input box
            If (valid) Then
                If Not textPCode.Text = "" And Not (textPName.Text = "") And Not textSName.Text = "" And Not textPType.Text = "" Then
                    valid = True
                Else
                    valid = False
                End If
            Else
                valid = False
            End If
            Return valid
        End If
        Return False
    End Function

    Private Sub textPPrice_TextChanged(sender As Object, e As EventArgs) Handles textPPrice.TextChanged
        Dim price As Double = 0
        If (validateInput()) Then
            labelIInput.Visible = False
            bDone.Visible = True
        Else
            labelIInput.Visible = True
            bDone.Visible = False
        End If

        If Double.TryParse(textPPrice.Text, price) Then
            oriPrice = price
        Else
            oriPrice = 0.0
        End If


    End Sub

    Private Sub textPName_TextChanged(sender As Object, e As EventArgs) Handles textPName.TextChanged
        If (validateInput()) Then
            labelIInput.Visible = False
            bDone.Visible = True
        Else
            labelIInput.Visible = True
            bDone.Visible = False
        End If
    End Sub

    Private Sub textSName_TextChanged(sender As Object, e As EventArgs) Handles textSName.TextChanged
        If (validateInput()) Then
            labelIInput.Visible = False
            bDone.Visible = True
        Else
            labelIInput.Visible = True
            bDone.Visible = False
        End If

        'Check the supplier name matched with the current or not
        Dim found = False
        If textSName.Text = "" Then
            labelNewSup.Visible = False
            Exit Sub
        End If

        For index As Integer = 0 To textSName.AutoCompleteCustomSource.Count - 1
            If textSName.Text = textSName.AutoCompleteCustomSource.Item(index) Then
                found = True
                Exit For
            End If
        Next


        If Not found Then
            labelNewSup.Visible = True
        Else
            labelNewSup.Visible = False
        End If


    End Sub

    Private Sub textPType_TextChanged(sender As Object, e As EventArgs) Handles textPType.TextChanged
        If (validateInput()) Then
            labelIInput.Visible = False
            bDone.Visible = True
        Else
            labelIInput.Visible = True
            bDone.Visible = False
        End If

        'Select GST type based on product type selected
        selectGSTType()
    End Sub

    Private Sub textSPrice_TextChanged(sender As Object, e As EventArgs) Handles textSPrice.TextChanged
        If (validateInput()) Then
            labelIInput.Visible = False
            bDone.Visible = True
        Else
            labelIInput.Visible = True
            bDone.Visible = False
        End If
    End Sub

    Private Sub textPQuantity_TextChanged(sender As Object, e As EventArgs) Handles textPQuantity.TextChanged
        If (validateInput()) Then
            labelIInput.Visible = False
            bDone.Visible = True
        Else
            labelIInput.Visible = True
            bDone.Visible = False
        End If

    End Sub

    Private Sub textPPrice_Click(sender As Object, e As EventArgs) Handles textPPrice.Click
        textPPrice.Text = ""
        oriPrice = 0.0
    End Sub

    Private Sub picSChecking_Click(sender As Object, e As EventArgs) Handles picSChecking.Click, labelSChecking.Click
        RemoveHandler Me.FormClosing, AddressOf formARestock_FormClosing
        Me.Close()
        formSChecking.Show()
    End Sub

    Private Sub formARestock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        resetAll()
    End Sub

    Private Sub picARestock_Click(sender As Object, e As EventArgs) Handles picARestock.Click
        resetAll()
    End Sub

    Private Sub selectGSTType()
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim gstDataAdapter As OleDb.OleDbDataAdapter
        Dim gstDataSet As New DataSet
        Dim SqlCommand As String

        'Get all the data
        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection
        SqlCommand = "SELECT * FROM GSTRATE WHERE productType = '" + textPType.Text + "';"
        gstDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        gstDataAdapter.Fill(gstDataSet, "GST")
        DBconnection.Close()

        If gstDataSet.Tables(0).Rows.Count > 0 Then
            labelNewType.Visible = False
            If gstDataSet.Tables(0).Rows(0).Item(2) = "STANDARD RATED" Then
                rbSRate.Checked = True
            ElseIf gstDataSet.Tables(0).Rows(0).Item(2) = "ZERO RATED" Then
                rbZRate.Checked = True
            Else
                rbExempted.Checked = True
            End If
        Else
            labelNewType.Visible = True
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
            RemoveHandler Me.FormClosing, AddressOf formARestock_FormClosing
            Me.Close()
            formLogin.Show()
        End If
    End Sub
End Class
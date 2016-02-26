Public Class formSChecking
    Public cashier As String = ""
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(43, 46, 52)
        getCashierID()
        displayAllData()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bEnter_Click(sender As Object, e As EventArgs) Handles bEnter.Click
        searchStock()
    End Sub

    Private Sub bSearch_Click(sender As Object, e As EventArgs) Handles bSearch.Click
        searchStock()
    End Sub

    Private Sub displayAllData()
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
        SqlCommand = "SELECT * FROM Stock ORDER BY stockQty ASC;"
        stockDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        stockDataAdapter.Fill(stockDataSet, "Stock")
        DataGridView1.DataSource = stockDataSet
        DataGridView1.DataMember = "Stock"
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
        Dim columnArray As DataGridViewColumn() = {DataGridView1.Columns(0), DataGridView1.Columns(1), DataGridView1.Columns(2),
                                                       DataGridView1.Columns(3), DataGridView1.Columns(4), DataGridView1.Columns(5)}

        Dim widthPercentage As Double() = {0.2, 0.2, 0.2, 0.1, 0.1, 0.2}
        For index As Integer = 0 To columnArray.Count - 1
            columnArray(index).Width = Math.Floor(DataGridView1.Width * widthPercentage(index))
        Next

        'Set the column header text
        columnArray(0).HeaderText = "Stock ID"
        columnArray(1).HeaderText = "Stock Name"
        columnArray(2).HeaderText = "Stock Type"
        columnArray(3).HeaderText = "Quantity"
        columnArray(4).HeaderText = "Price (RM)"
        lowStockNotification(stockDataSet)
        
    End Sub


    Private Sub searchStock()
        'Establish connection to Database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim stockDataAdapter As OleDb.OleDbDataAdapter
        Dim stockDataSet As New DataSet
        Dim SqlCommand As String

        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection
        SqlCommand = "SELECT * FROM Stock WHERE stockID = '" + textICode.Text + "' OR stockName = '" + textICode.Text + "'"
        stockDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        stockDataAdapter.Fill(stockDataSet, "Stock")
        If Not stockDataSet.Tables(0).Rows().Count = 0 Then
            DataGridView1.DataSource = stockDataSet
            DataGridView1.DataMember = "Stock"
            DBconnection.Close()
        Else
            MessageBox.Show("No records found!")
            displayAllData()
            resetTextICode()
            DBconnection.Close()
        End If

        lowStockNotification(stockDataSet)
    End Sub

    Private Sub lowStockNotification(ByRef stockDataSet As DataSet)
        'Warn user about the less stock quantity.
        For index As Integer = 0 To stockDataSet.Tables(0).Rows().Count - 1
            If stockDataSet.Tables(0).Rows(index).Item("stockQty") <= 5 Then
                Dim cellStyle As DataGridViewCellStyle = DataGridView1.Rows(index).DefaultCellStyle()
                cellStyle.BackColor = Color.FromArgb(151, 40, 44)
                cellStyle.SelectionBackColor = cellStyle.BackColor
            End If
        Next
    End Sub


    Private Sub textICode_Click(sender As Object, e As EventArgs) Handles textICode.Click
        resetTextICode()
    End Sub

    Private Sub resetTextICode()
        textICode.Text = ""
    End Sub

    Private Sub picARestock_Click(sender As Object, e As EventArgs) Handles picARestock.Click, Label1.Click
        RemoveHandler Me.FormClosing, AddressOf formSChecking_FormClosing
        Me.Close()
        formARestock.Show()
    End Sub

    Private Sub picSReport_Click(sender As Object, e As EventArgs) Handles picSReport.Click, labelTSalesAdmin.Click
        RemoveHandler Me.FormClosing, AddressOf formSChecking_FormClosing
        Me.Close()
        formSReportAdmin.Show()
    End Sub

    Private Sub picSChecking_Click(sender As Object, e As EventArgs) Handles picSChecking.Click, Label3.Click
        RemoveHandler Me.FormClosing, AddressOf formSChecking_FormClosing
        Me.Close()
        formGReport.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
    End Sub

    Private Sub formSChecking_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
            RemoveHandler Me.FormClosing, AddressOf formSChecking_FormClosing
            Me.Close()
            formLogin.Show()
        End If
    End Sub
End Class
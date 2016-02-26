Public Class formEGST

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(43, 46, 52)
        Me.Focus()
        addProductType()
        cbPType.SelectedIndex = 0
        cbGSTType.SelectedIndex = 0
    End Sub

    Private Sub bDone_Click(sender As Object, e As EventArgs) Handles bDone.Click
        updateDefaultGSTType()
        MessageBox.Show("You had updated the product type " + cbPType.SelectedText, _
                        "Update successfully", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
        Me.Close()
    End Sub
    Private Sub addProductType()
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim productTypeDataAdapter As OleDb.OleDbDataAdapter
        Dim productTypeDataSet As New DataSet
        Dim SqlCommand As String

        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection
        SqlCommand = "SELECT productType FROM GSTRATE ;"
        productTypeDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        productTypeDataAdapter.Fill(productTypeDataSet, "ProductType")

        'Set the arrayList's element(s) with the product type get from database
        Dim productType As ArrayList = New ArrayList()
        If productTypeDataSet.Tables(0).Rows.Count > 0 Then
            For index As Integer = 0 To productTypeDataSet.Tables(0).Rows.Count - 1
                productType.Add(productTypeDataSet.Tables(0).Rows(index).Item(0))
            Next
        End If

        'Pass the array list to an array string
        Dim productTypeArr As String() = CType(productType.ToArray(GetType(String)), String())

        cbPType.Items.AddRange(productTypeArr)

        DBconnection.Close()
    End Sub

    Private Sub updateDefaultGSTType()
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand

        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection

        Dim gstType As String = ""
        If cbGSTType.SelectedIndex = 0 Then
            gstType = "STANDARD RATED"
        ElseIf cbGSTType.SelectedIndex = 1 Then
            gstType = "EXEMPTED"
        Else
            gstType = "ZERO RATED"
        End If

        cmd.CommandText = "UPDATE GSTRATE SET gstType = '" + gstType + "'WHERE productType = '" + cbPType.SelectedItem.ToString + "';"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        DBconnection.Close()
    End Sub
End Class
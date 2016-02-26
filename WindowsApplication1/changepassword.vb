Public Class changepassword

    Private Sub bDone_Click(sender As Object, e As EventArgs) Handles bDone.Click
        'Connect to database
        Dim DBconnection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim accountDataAdapter As OleDb.OleDbDataAdapter
        Dim accountDataSet As New DataSet
        Dim SqlCommand As String

        'Validate admin account and password
        DBconnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\projectDB.mdb"
        DBconnection.Open()
        cmd.Connection = DBconnection

        SqlCommand = "SELECT accountID FROM ACCOUNT WHERE accountID = '" + textUserName.Text.ToUpper + "' AND accountPassword = '" + textPassword.Text + "';"
        accountDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        accountDataAdapter.Fill(accountDataSet, "Account")

        'Check account detail
        If accountDataSet.Tables(0).Rows.Count > 0 Then
        Else
            MessageBox.Show("Account name or password is incorrect. Please retype again.", _
             "Invalid account detail", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Warning)
            resetAll()
            cmd.Dispose()
            DBconnection.Close()
            Exit Sub
        End If


        'Check password and retype password
        If textNUserPassword.Text = textRTypePassword.Text Then
        Else
            MessageBox.Show("Password does not match with retype password. Please retype again.", _
             "Invalid Password", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Warning)
            resetAll()
            cmd.Dispose()
            DBconnection.Close()
            Exit Sub
        End If

        'Input into database if all correct
        cmd.CommandText = "UPDATE ACCOUNT SET accountPassword = '" + textNUserPassword.Text + "' WHERE accountID = '" + textUserName.Text + "';"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        DBconnection.Close()
        MessageBox.Show("Account " + textUserName.Text.ToUpper + " password had been updated.", _
            "Changed to new password", _
           MessageBoxButtons.OK, _
           MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub changepassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub resetAll()
        textUserName.Text = "Username"
        textPassword.Text = "Password"
        textNUserPassword.Text = "New Password"
        textRTypePassword.Text = "Retype Password"

        textPassword.PasswordChar = ""
        textNUserPassword.PasswordChar = ""
        textRTypePassword.PasswordChar = ""
    End Sub

    Private Sub textUserName_Click(sender As Object, e As EventArgs) Handles textUserName.Click, textUserName.GotFocus
        textUserName.Text = ""
    End Sub

    Private Sub textPassword_Click(sender As Object, e As EventArgs) Handles textPassword.Click, textPassword.GotFocus
        textPassword.Text = ""
        textPassword.PasswordChar = "*"
    End Sub

    Private Sub textNUserPassword_Click(sender As Object, e As EventArgs) Handles textNUserPassword.Click, textNUserPassword.GotFocus
        textNUserPassword.Text = ""
        textNUserPassword.PasswordChar = "*"
    End Sub

    Private Sub textRTypePassword_Click(sender As Object, e As EventArgs) Handles textRTypePassword.Click, textRTypePassword.GotFocus
        textRTypePassword.Text = ""
        textRTypePassword.PasswordChar = "*"
    End Sub
End Class
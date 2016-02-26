Public Class formRNewUser


    Private Sub textPassword_TextChanged(sender As Object, e As EventArgs) Handles textPassword.TextChanged

    End Sub

    Private Sub textUserName_Click(sender As Object, e As EventArgs) Handles textUserName.Click, textUserName.GotFocus
        textUserName.Text = ""
    End Sub

    Private Sub textPassword_Click(sender As Object, e As EventArgs) Handles textPassword.Click, textPassword.GotFocus
        textPassword.Text = ""
        textPassword.PasswordChar = "*"
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles textNUserName.Click, textNUserName.GotFocus
        textNUserName.Text = ""
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles textNUserPassword.Click, textNUserPassword.GotFocus
        textNUserPassword.Text = ""
        textNUserPassword.PasswordChar = "*"
    End Sub

    Private Sub textRTypePassword_Click(sender As Object, e As EventArgs) Handles textRTypePassword.Click, textRTypePassword.GotFocus
        textRTypePassword.Text = ""
        textRTypePassword.PasswordChar = "*"
    End Sub

    Private Sub bDone_Click(sender As Object, e As EventArgs) Handles bDone.Click, bEnter.Click
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

        SqlCommand = "SELECT accountID FROM ACCOUNT WHERE accountID = '" + textUserName.Text.ToUpper + "' AND accountPassword = '" + textPassword.Text + "' AND accountType = 'ADMIN'"
        accountDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        accountDataAdapter.Fill(accountDataSet, "Account")


        If accountDataSet.Tables(0).Rows.Count > 0 Then
        Else
            MessageBox.Show("Admin account name or password is incorrect. Please retype again.", _
             "Invalid Admin detail", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Warning)
            resetAll()
            cmd.Dispose()
            DBconnection.Close()
            Exit Sub
        End If

        'Check existing username
        SqlCommand = "SELECT accountID FROM ACCOUNT WHERE accountID = '" + textNUserName.Text.ToUpper + "';"
        accountDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
        accountDataAdapter.Fill(accountDataSet, "CheckAccount")

        If accountDataSet.Tables(1).Rows.Count > 0 Then
            MessageBox.Show("Username had been choosen. Please retype again.", _
             "Invalid Username", _
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
        cmd.CommandText = "INSERT INTO ACCOUNT (accountID, accountType, accountPassword,accountStatus) VALUES ('" + textNUserName.Text.ToUpper + "','USER','" + textNUserPassword.Text + "','INACTIVE');"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        DBconnection.Close()
        MessageBox.Show("Account " + textNUserName.Text.ToUpper + " had been created.", _
            "New account created", _
           MessageBoxButtons.OK, _
           MessageBoxIcon.Asterisk)
        Me.Close()
    End Sub

    Private Sub resetAll()
        textUserName.Text = "Username"
        textPassword.Text = "Password"
        textNUserName.Text = "Username"
        textNUserPassword.Text = "Password"
        textRTypePassword.Text = "Retype Password"

        textPassword.PasswordChar = ""
        textNUserPassword.PasswordChar = ""
        textRTypePassword.PasswordChar = ""
    End Sub

    Private Sub formRNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
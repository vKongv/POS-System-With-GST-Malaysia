Public Class formLogin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(43, 46, 52)
        labelMsgWrong.ForeColor = Color.FromArgb(221, 23, 27)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picAdmin.Click
        picAdmin.Location = New Point(((Me.Size.Width) / 2) - 49, ((Me.Size.Height) / 2) - 96)
        picUser.Visible = False
        labelTitle.Visible = False
        textUserName.Visible = True
        textPassword.Visible = True
        textPassword.BackColor = Me.BackColor
        labelBack.Visible = True
        picAdmin.Cursor = Cursors.Default
        bLogin.Visible = True
    End Sub

    Private Sub textPassword_Enter(sender As Object, e As EventArgs)

    End Sub



    'Private Sub textPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textPassword.KeyPress
    'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
    '    If (textPassword.Text = "iamadmin" And picAdmin.Visible) Then
    '        formARestock.Show()
    '        resetAll(True)
    '    ElseIf (textPassword.Text = "iamuser" And picUser.Visible) Then
    '        formTransactions.Show()
    '        resetAll(True)
    '    Else
    '        labelMsgWrong.Visible = True
    '    End If

    'End If

    'End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picUser.Click
        picUser.Location = New Point(((Me.Size.Width) / 2) - 49, ((Me.Size.Height) / 2) - 96)
        picAdmin.Visible = False
        labelTitle.Visible = False
        textUserName.Visible = True
        textPassword.Visible = True
        textPassword.BackColor = Me.BackColor
        labelBack.Visible = True
        labelCPassword.Visible = True
        picUser.Cursor = Cursors.Default
        bLogin.Visible = True
    End Sub

    Private Sub labelBack_Click(sender As Object, e As EventArgs) Handles labelBack.Click
        resetAll(False)
    End Sub

    Private Sub textPassword_Click(sender As Object, e As EventArgs) Handles textPassword.Click, textPassword.GotFocus
        textPassword.Text = ""
        textPassword.PasswordChar = "*"
        labelMsgWrong.Visible = False
    End Sub

    Private Sub textPassword_TextChanged(sender As Object, e As EventArgs) Handles textPassword.TextChanged
        labelMsgWrong.Visible = False
    End Sub

    Private Sub resetAll(ByVal resetAndHide As Boolean)
        If resetAndHide Then
            Me.Hide()
        Else
            Me.Focus()
        End If
        picAdmin.Location = New Point(283, 175)
        picAdmin.Visible = True
        picUser.Cursor = Cursors.Hand
        picAdmin.Cursor = Cursors.Hand
        picUser.Location = New Point(532, 175)
        picUser.Visible = True
        labelBack.Visible = False
        textUserName.Visible = False
        textUserName.Text = "Username"
        textPassword.Visible = False
        textPassword.Text = "Password"
        textPassword.PasswordChar = ""
        labelTitle.Visible = True
        labelMsgWrong.Visible = False
        bLogin.Visible = False
    End Sub

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
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

        If (picAdmin.Visible) Then
            SqlCommand = "SELECT accountID FROM ACCOUNT WHERE accountID = '" + textUserName.Text.ToUpper + "' AND accountPassword = '" + textPassword.Text + "' AND accountType = 'ADMIN'"
            accountDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
            accountDataAdapter.Fill(accountDataSet, "Account")

            If accountDataSet.Tables(0).Rows.Count > 0 Then
                cmd.CommandText = "UPDATE ACCOUNT SET accountStatus = 'ACTIVE' WHERE accountID = '" + textUserName.Text.ToUpper + "';"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "UPDATE ACCOUNT SET accountStatus = 'ACTIVE' WHERE accountID = '" + textUserName.Text.ToUpper + "';"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "INSERT INTO ACCOUNTLOG (cashierID,logLoginTime, logLogoutTime) VALUES ('" + textUserName.Text.ToUpper + "','" + DateTime.Now.ToString + "','" + DateTime.Now.ToString + "');"
                cmd.ExecuteNonQuery()
                resetAll(True)
                formARestock.Show()
            Else
                labelMsgWrong.Visible = True
            End If
        ElseIf (picUser.Visible) Then
            SqlCommand = "SELECT accountID FROM ACCOUNT WHERE accountID = '" + textUserName.Text.ToUpper + "' AND accountPassword = '" + textPassword.Text + "' AND accountType = 'USER'"
            accountDataAdapter = New OleDb.OleDbDataAdapter(SqlCommand, DBconnection)
            accountDataAdapter.Fill(accountDataSet, "Account")

            If accountDataSet.Tables(0).Rows.Count > 0 Then
                cmd.CommandText = "UPDATE ACCOUNT SET accountStatus = 'INACTIVE';"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "UPDATE ACCOUNT SET accountStatus = 'ACTIVE' WHERE accountID = '" + textUserName.Text.ToUpper + "';"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "INSERT INTO ACCOUNTLOG (cashierID,logLoginTime, logLogoutTime) VALUES ('" + textUserName.Text.ToUpper + "','" + DateTime.Now.ToString + "','" + DateTime.Now.ToString + "');"
                cmd.ExecuteNonQuery()
                resetAll(True)
                formTransactions.Show()

            Else
                labelMsgWrong.Visible = True
            End If
            cmd.Dispose()
            DBconnection.Close()
        End If
    End Sub

    Private Sub textUserName_Click(sender As Object, e As EventArgs) Handles textUserName.Click, textUserName.GotFocus
        textUserName.Text = ""
        labelMsgWrong.Visible = False
    End Sub

    Private Sub labelRNewUser_Click(sender As Object, e As EventArgs) Handles labelRNewUser.Click
        formRNewUser.Show()
    End Sub

    Private Sub textUserName_TextChanged(sender As Object, e As EventArgs) Handles textUserName.TextChanged

    End Sub

    Private Sub labelCPassword_Click(sender As Object, e As EventArgs) Handles labelCPassword.Click
        changepassword.Show()
    End Sub
End Class

Public Class showSalesReport

    Private Sub showSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(My.Application.Info.DirectoryPath & "\salesreport.html")
        MessageBox.Show("Use hotkey CTRL + P to print report", _
   "Tips", _
   MessageBoxButtons.OK, _
   MessageBoxIcon.Asterisk)
    End Sub
End Class
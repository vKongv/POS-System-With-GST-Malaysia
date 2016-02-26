Public Class taxInvoice

    Private Sub taxInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(My.Application.Info.DirectoryPath & "\taxInvoice.html")
        MessageBox.Show("Use hotkey CTRL + P to print tax invoice", _
  "Tips", _
  MessageBoxButtons.OK, _
  MessageBoxIcon.Asterisk)
    End Sub
End Class
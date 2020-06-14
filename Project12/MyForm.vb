Imports System
Imports System.Windows.Forms

Public Class MyForm
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        MessageBox.Show("Unable To Connect With Server!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub
End Class

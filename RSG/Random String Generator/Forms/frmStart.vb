Public Class frmStart
    Private Sub frmStart_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If frm.Visible = True Then
            Hide()
            frm.Activate()
        End If
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text += Application.ProductVersion
        Try
            frm.Show()
        Catch ex As Exception
            Debug.WriteLine(ex.InnerException)
        End Try

    End Sub

    Private Sub lblEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblEmail.LinkClicked
        frm.Show()
        System.Diagnostics.Process.Start("reapsprgm@gmail.com")
    End Sub
End Class
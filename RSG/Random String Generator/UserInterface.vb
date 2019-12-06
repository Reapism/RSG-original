Public Class UserInterface
    Public Sub showStatistics()
        If var.getOptShowStatistics = True Then
            frm.Size = New Size(700, 400)
            frm.grpStatistics.Visible = True
            frm.grpGenerate.Dock = DockStyle.Fill
            frm.btnShowStatistics.Text = "Hide Statistics"
            var.setOptShowStatistics(False)

        Else
            frm.Size = New Size(450, 400)
            frm.grpStatistics.Visible = False
            frm.grpGenerate.Dock = DockStyle.Left
            frm.btnShowStatistics.Text = "Show Statistics"
            var.setOptShowStatistics(True)
        End If
    End Sub
End Class

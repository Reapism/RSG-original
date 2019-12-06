Public Class frmDeveloperMode
    Dim rnd As New Random

    Private Sub DeveloperMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmeTick.Enabled = True
        UserInterface.newTheme(My.Settings.optBckgrd, Me)
    End Sub

    Private Sub tmeTick_Tick(sender As Object, e As EventArgs) Handles tmeTick.Tick
        Dim val As Integer = trkFreq.Value + 1
        barVisual.Value = 0
        barVisual.Maximum = val * 10
        barVisual.Increment(rnd.Next(barVisual.Maximum) + 1)
        lblVal.Text = "Value: " & barVisual.Value & ", " & tmeTick.Interval & "milli."
        txtRandom.Text = func.generateString(rnd.Next(1, val * 3), var.getAllCharList(), var.getRndMethod())
        tmeTick.Interval = (rnd.Next((val * 2) * 50) + 1)
        lblFreq.Text = "Freq: " & tmeTick.Interval
        lblZoom.Text = "Zoom: " & trkFreq.Maximum & "x"
    End Sub

    Private Sub trkChangeFreq_Scroll(sender As Object, e As EventArgs) Handles trkChangeFreq.Scroll
        trkFreq.Maximum = trkChangeFreq.Value * rnd.Next(1, 6)
    End Sub
End Class
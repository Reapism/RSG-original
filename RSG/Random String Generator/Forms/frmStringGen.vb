Imports System.Numerics

Public Class frmStringGen
    Private tip As New ToolTip ' The tooltip for the forms.
    Private lstLog As New ListBox ' Used for generating the log
    Private s As frmSettings

    ''' <summary>
    ''' Title: The main frmStringGen Class
    ''' Description: Contains the program and controls.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub frmStringGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        func.AnimateButton()
        frm.lstGenerate.ContextMenuStrip = frm.ctxGenerate
        btnGenerate.PerformClick()
        UserInterface.updateInterface(lstGenerate, btnStringLength, btnIterations, lblStringLength, lblNumIterations)

        UserInterface.showStatus(stsStrGen, pnlStrGen, lstGenerate, btnGenerate)
        UserInterface.showStatus(stsStrGen, pnlStrGen, lstGenerate, btnGenerate)

        frm.btnAnimateMin.Text = "Animate Min Interval: " & var.getMinInterval()
        frm.btnAnimateMax.Text = "Animate Max Interval: " & var.getMaxInterval()
        UserInterface.newTheme(My.Settings.optBckgrd, frm)
        s = New frmSettings

    End Sub

    Private Sub frmStringGen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If My.Settings.optCheckUpdatesOnLoad Then func.checkUpdates(btnCheckForUpdates)
        btnGenerate.PerformClick()
        If My.Settings.firstTime Then
            Dim h As New frmHelp
            h.Show()
            h.Focus()
            My.Settings.firstTime = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnCheckForUpdates_Click(sender As Object, e As EventArgs)
        func.checkUpdates(frmSettings.btnCheckForUpdates)
        Text = var.getCharText
    End Sub

    Private Sub btnStringLength_Click(sender As Object, e As EventArgs) Handles btnStringLength.Click
        Dim s As String = InputBox("Please enter a positive, whole number.", "Edit String Length", var.getStringLength().ToString())
        Dim b As BigInteger = Functions.isBigInteger(s)

        If b > BigInteger.Zero Then
            var.setStringLength(b)
            If (var.getOptBndStrLgth() And b > 4680) Then
                var.setStringLength(4680)
                func = New Functions
                func.createToolTip(s & " is out of bound", "The option bound string length is enabled! " &
                                       "Go to settings/performance/check 'Disable Bound'.", "Critical", 6000, True)
            Else
            End If
        End If

        func.iterateString(var.getNumIterations())
        func.stringStatistics(lstStatistics)
    End Sub

    Private Sub btnIterations_Click(sender As Object, e As EventArgs) Handles btnIterations.Click
        Dim s As String = InputBox("Please enter a positive, whole number.", "Edit Iterations", var.getNumIterations().ToString())
        Dim b As BigInteger = Functions.isBigInteger(s)

        If b > BigInteger.Zero Then
            var.setNumIterations(b)
            func.iterateString(var.getNumIterations())
            func.stringStatistics(lstStatistics)
        End If
    End Sub

    Private Sub btnUppercase_Click(sender As Object, e As EventArgs) Handles btnUppercase.Click
        If btnUppercase.Checked = True Then
            var.setOptCapLetters(True)
        Else
            var.setOptCapLetters(False)
        End If
        func.updateCharList()
        func.iterateString(var.getNumIterations())
        func.stringStatistics(lstStatistics)
    End Sub

    Private Sub btnLowercase_Click(sender As Object, e As EventArgs) Handles btnLowercase.Click
        If btnLowercase.Checked = True Then
            var.setOptLowLetters(True)
        Else
            var.setOptLowLetters(False)
        End If
        func.updateCharList()
        func.iterateString(var.getNumIterations())
        func.stringStatistics(lstStatistics)
    End Sub

    Private Sub btnNum_Click(sender As Object, e As EventArgs) Handles btnNum.Click
        If btnNum.Checked = True Then
            var.setOptNumbers(True)
        Else
            var.setOptNumbers(False)
        End If
        func.updateCharList()
        func.iterateString(var.getNumIterations())
        func.stringStatistics(lstStatistics)
    End Sub

    Private Sub btnSymb_Click(sender As Object, e As EventArgs) Handles btnSymb.Click
        If btnSymb.Checked = True Then
            var.setOptSymbols(True)
        Else
            var.setOptSymbols(False)
        End If
        func.updateCharList()
        func.iterateString(var.getNumIterations())
        func.stringStatistics(lstStatistics)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        If btnSettings.Enabled Then
            s = New frmSettings
            s.Show(frm)
            btnSettings.Enabled = False
            btnSettings2.Enabled = False
        End If
    End Sub

    Private Sub btnShowStatistics_Click(sender As Object, e As EventArgs) Handles btnShowStatistics.Click
        UserInterface.showStatistics()
    End Sub

    Private Sub frmStringGen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmStart.Close()
    End Sub

    Private Sub frmStringGen_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        frmStart.Hide()

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        func.iterateString(var.getNumIterations())
        func.stringStatistics(lstStatistics)
    End Sub

    Private Sub tmeGenerate_Tick(sender As Object, e As EventArgs) Handles tmeGenerate.Tick
        Dim rndSelection As System.Random = New System.Random()

        tmeGenerate.Interval = rndSelection.Next(var.getMinInterval(), var.getMaxInterval())

        If btnGenerate.Text = var.getCharText() Then
            tmeGenerate.Enabled = True
            tmeGenerate.Start()
            btnGenerate.Text = ""
            var.setTextLength(0)
        Else
            btnGenerate.Text += var.getCharText().ElementAt(var.getTextLength())
            var.setTextLength(var.getTextLength() + 1)
        End If

        If My.Settings.optShowStatus Then
            Dim p As Process = Process.GetCurrentProcess
            lblThread.Text = "Threads: " & p.Threads.Count & " -  Priority: " &
           p.PriorityClass.ToString() & " - Affinity: " &
            System.Diagnostics.Process.GetCurrentProcess.ProcessorAffinity.ToString & " - Mem. Usg. (Working Set): " &
            p.WorkingSet64.ToString("n0") & " Bytes -  CPU Time: " &
            p.TotalProcessorTime.Duration.ToString
        End If
    End Sub

    Private Sub lstStatistics_Click(sender As Object, e As EventArgs) Handles lstStatistics.Click
        If lstStatistics.SelectedIndex > -1 Then
            btnCopy2.PerformClick()
        End If
    End Sub

    Private Sub lstGenerate_Click(sender As Object, e As EventArgs) Handles lstGenerate.Click
        If lstGenerate.SelectedIndex > -1 Then
            btnCopy.PerformClick()
        End If
    End Sub

    Private Sub lblStringLength_MouseWheel(sender As Object, e As MouseEventArgs) Handles lblStringLength.MouseWheel
        Dim original As String = lblStringLength.Text
        If e.Delta > 1 Then
            If var.getStringLength() >= 1 Then
                If ((var.getOptBndStrLgth()) And (var.getStringLength() >= 4680)) Then
                    func = New Functions
                    func.createToolTip("Out of display bound!", "The option bound string length is enabled! Go to settings > performance > check 'Disable Bound'.", "Critical", 4000, True)
                    var.setStringLength(4680)
                Else
                    var.setStringLength((var.getStringLength() + 1))
                    func.checkScroll(original, lblStringLength, e)
                End If
            End If
        Else
            If var.getStringLength() > 1 Then
                var.setStringLength((var.getStringLength() - 1))
                func.checkScroll(original, lblStringLength, e)
            End If
        End If

        func.iterateString(var.getNumIterations())
        If frm.lstStatistics.Visible = True Then func.stringStatistics(lstStatistics)
    End Sub


    Private Sub lblNumIterations_MouseWheel(sender As Object, e As MouseEventArgs) Handles lblNumIterations.MouseWheel
        Dim original As String = lblNumIterations.Text
        If e.Delta > 1 Then
            If var.getNumIterations() >= 1 Then
                var.setNumIterations((var.getNumIterations() + 1))
                func.checkScroll(original, lblNumIterations, e)

            End If
        Else
            If var.getNumIterations() > 1 Then
                var.setNumIterations((var.getNumIterations() - 1))
                func.checkScroll(original, lblNumIterations, e)
            End If
        End If

        func.iterateString(var.getNumIterations())
        func.stringStatistics(lstStatistics)
    End Sub

    Private Sub btnGenerate_MouseWheel(sender As Object, e As MouseEventArgs) Handles btnGenerate.MouseWheel
        If e.Delta > 1 Then
            func.iterateString(var.getNumIterations())
        Else
            func.iterateString(var.getNumIterations())
        End If
        func.stringStatistics(lstStatistics)
    End Sub

    Private Sub lblStringLength_Click(sender As Object, e As EventArgs) Handles lblStringLength.Click
        btnStringLength_Click(sender, e)
    End Sub

    Private Sub lblNumIterations_Click(sender As Object, e As EventArgs) Handles lblNumIterations.Click
        btnIterations_Click(sender, e)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim search As New frmSearch
        search.Show(frm)
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        func.findString(lstGenerate)
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If My.Settings.optClip Then
            func.copyText(lstGenerate)
        End If
    End Sub

    Private Sub btnDeveloperMode_Click(sender As Object, e As EventArgs) Handles btnDeveloperMode.Click
        MsgBox("This form has no intrinsic purpose yet. I was fooling around with some things. Play around with it and see what happens.", MsgBoxStyle.Information)
        Dim dev As New frmDeveloperMode
        dev.Show(frm)
    End Sub

    Private Sub btnAddChar_Click(sender As Object, e As EventArgs) Handles btnAddChar.Click
        Dim addChar As String = InputBox("Enter any amount of characters to add to the list. This will not override current selected or existing characters.", "Add Characters", "")
        func.addCharacters(addChar)
    End Sub

    Private Sub btnRemChar_Click(sender As Object, e As EventArgs) Handles btnRemChar.Click
        Dim remChar As String = InputBox("Enter any amount of characters to remove from the list. This will override current selected or existing characters.", "Remove Characters", var.getCharList())
        If var.getCharList().Length < 1 Or IsNothing(var.getCharList()) Then
            func.removeCharacters("")
        End If
        func.removeCharacters(remChar)
    End Sub

    Private Sub btnSetChar_Click(sender As Object, e As EventArgs) Handles btnSetChar.Click
        Dim setChar As String = InputBox("Enter any amount of characters to set the list. This will override all existing characters.", "Set Characters", "")
        var.setCharList(setChar)
    End Sub

    Private Sub btnResetChar_Click(sender As Object, e As EventArgs) Handles btnResetChar.Click
        var.resetCharList()
        MsgBox("The character list has been reset to nothing.", MsgBoxStyle.Exclamation, "Default Character List")
    End Sub

    Private Sub btnDispChar_Click(sender As Object, e As EventArgs) Handles btnDispChar.Click
        MsgBox("This is the custom character list in order of appearance: " & var.getCharList(), MsgBoxStyle.Exclamation, "Display Character List")
    End Sub

    Private Sub tmeGenerate_Disposed(sender As Object, e As EventArgs) Handles tmeGenerate.Disposed
        frm.btnGenerate.Text = var.getCharText()
    End Sub

    Private Sub btnAnimateMin_Click(sender As Object, e As EventArgs) Handles btnAnimateMin.Click
        Dim input As String = InputBox("Enter the minumum interval for the random button. Current value: " & var.getMinInterval(), "Animate Minimum Interval", "")
        If IsNumeric(input) And Not (IsNothing(input)) Then
            If (input > 0 And input < Integer.MaxValue) Then
                var.setMinInterval(input)
                frm.btnAnimateMin.Text = "Animate Min Interval: " & input
            Else
                MsgBox("Animate Minimum Interval Exception: The input is either smaller than 0, or greater than the animiate maximum interval value.", MsgBoxStyle.Critical, "Animate Minimum Interval Exception")
            End If
        End If
    End Sub

    Private Sub btnAnimateMax_Click(sender As Object, e As EventArgs) Handles btnAnimateMax.Click
        Dim input As String = InputBox("Enter the Maximum interval for the random button. Current value: " & var.getMaxInterval(), "Animate Maximum Interval ", "")
        If IsNumeric(input) And Not (IsNothing(input)) Then
            If (input > 0 And input < Integer.MaxValue) Then
                var.setMaxInterval(input)
                frm.btnAnimateMax.Text = "Animate Min Interval: " & input
            Else
                MsgBox("Animate Maximum Interval Exception: The input is either smaller than 0, or less than the animiate minimum interval value.", MsgBoxStyle.Critical, "Animate Maximum Interval Exception")
            End If
        End If
    End Sub

    Private Sub btnAutoGenerate_Click(sender As Object, e As EventArgs) Handles btnAutoGenerate.Click
        Dim gen As New frmAutoGen
        gen.Show(frm)
    End Sub

    Private Sub btnFindSpecificString_Click(sender As Object, e As EventArgs) Handles btnFindString.Click
        func.findString(lstGenerate)
    End Sub

    Private Sub btnCheckUpdates_Click(sender As Object, e As EventArgs) Handles btnCheckUpdates.Click
        func.checkUpdates(btnCheckUpdates)
    End Sub

    Private Sub btnCtxSettings_Click(sender As Object, e As EventArgs) Handles btnCtxSettings.Click
        btnSettings.PerformClick()
    End Sub

    Private Sub btnSleep_Click(sender As Object, e As EventArgs) Handles btnSleep.Click
        Hide()
    End Sub

    Private Sub btnGenerateLog_Click(sender As Object, e As EventArgs) Handles btnGenerateLog.Click
        Dim newFrm As Form = func.genForm("Auto Generated Log File", ctxLog)

        lstLog = func.genLog(lstLog)
        Dim p As New Panel
        Dim g As New GroupBox
        newFrm.Controls.Add(p)
        p.Dock = DockStyle.Fill
        p.Controls.Add(g)
        g.Dock = DockStyle.Fill
        g.Controls.Add(lstLog)

        UserInterface.newTheme(My.Settings.optBckgrd, newFrm)
        newFrm.Show(frm)
    End Sub

    ''' <summary>
    ''' btnSaveAs_Click() --
    ''' Creates a SaveDialog box and sets all its properties to save a log with date and time.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAsLog.Click
        Dim saveDiag As New SaveFileDialog

        With saveDiag
            .Title = "Choose where to save the file!"
            .DefaultExt = ".txt"
            .FilterIndex = 1
            .RestoreDirectory = True
            .Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            .FileName = "RSG - Log " & Date.Now.ToString("yyyy-MM-dd hh-mm-ss")
        End With

        If saveDiag.ShowDialog() = DialogResult.OK Then
            Dim sb As New System.Text.StringBuilder()

            For Each o As Object In lstLog.Items
                sb.AppendLine(o)
            Next

            System.IO.File.WriteAllText(saveDiag.FileName, sb.ToString())
        End If
    End Sub

    Private Sub btnFindLog_Click(sender As Object, e As EventArgs)
        func.findString(lstLog)
    End Sub

    Private Sub btnCopyLog_Click(sender As Object, e As EventArgs)
        btnCopy_Click(lstLog, e)
    End Sub

    Private Sub btnOpenStrGen_Click(sender As Object, e As EventArgs) Handles btnOpenStrGen.Click
        Show()
    End Sub

    Private Sub btnCheckForUpdates_Click_1(sender As Object, e As EventArgs) Handles btnCheckForUpdates.Click
        func.checkUpdates(btnCheckForUpdates)
    End Sub

    Private Sub btnPseudoRandom_Click(sender As Object, e As EventArgs) Handles btnPseudoRandom.Click
        var.setRndMethod(1)
        My.Settings.optRndMethod = 1
        My.Settings.Save()
        UserInterface.updateSettingsInterface(s)
        func.stringStatistics(frm.lstStatistics)
        UserInterface.updateInterface(lstGenerate, btnStringLength, btnIterations, lblStringLength, lblNumIterations)
        func.iterateString(var.getNumIterations())
    End Sub

    Private Sub btnReapRandom_Click(sender As Object, e As EventArgs) Handles btnReapRandom.Click
        var.setRndMethod(2)
        My.Settings.optRndMethod = 2
        My.Settings.Save()
        UserInterface.updateSettingsInterface(s)
        func.stringStatistics(frm.lstStatistics)
        UserInterface.updateInterface(lstGenerate, btnStringLength, btnIterations, lblStringLength, lblNumIterations)
        func.iterateString(var.getNumIterations())
    End Sub

    Private Sub btnDeselect_Click(sender As Object, e As EventArgs) Handles btnDeselect.Click
        If Not func.deselectItem(lstGenerate) Then
            func = New Functions
            func.createToolTip("Invalid Item Exception", "Cannot deselect an item that isn't selected", "Critical", 2000, True)
        End If
    End Sub

    Private Sub btnDictionary_Click(sender As Object, e As EventArgs) Handles btnDictionary.Click
        dict = New frmDictionary
        dict.Show(frm)

    End Sub

    Private Sub btnShowStatus_Click(sender As Object, e As EventArgs) Handles btnShowStatus.Click
        UserInterface.showStatus(stsStrGen, pnlStrGen, lstGenerate, btnGenerate)
    End Sub

    Private Sub lstStatistics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStatistics.SelectedIndexChanged

    End Sub

    Private Sub btnSettings2_Click(sender As Object, e As EventArgs) Handles btnSettings2.Click
        btnSettings.PerformClick()
    End Sub

    Private Sub btnCopy2_Click(sender As Object, e As EventArgs) Handles btnCopy2.Click
        If My.Settings.optClip Then
            func.copyText(lstStatistics)
        Else
            func = New Functions
            func.createToolTip("Copy text disabled", "Copy text on click is disabled. Go to settings/properties to enable!", "Info", 5000, True)
        End If
    End Sub

    Private Sub btnFind2_Click(sender As Object, e As EventArgs) Handles btnFind2.Click
        func.findString(lstStatistics)
    End Sub

    Private Sub btnDeselect2_Click(sender As Object, e As EventArgs) Handles btnDeselect2.Click
        If Not func.deselectItem(lstStatistics) Then
            func = New Functions
            func.createToolTip("Invalid Item Exception", "Cannot deselect an item that isn't selected", "Critical", 2000, True)
        End If
    End Sub

    ''' <summary>
    ''' Checks if the form is focused.
    ''' </summary>
    ''' <returns></returns>

    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    ''' <summary>
    ''' frmSettings_Move() --
    ''' Glues the RSG form to the settings form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub frmStringGen_Move(sender As Object, e As EventArgs) Handles Me.Move
        If (My.Settings.optGlue And Not btnSettings.Enabled) And GetActiveWindow.Equals(Me.Handle) Then
            s.Location = New Point((frm.Width + frm.Location.X) - 15, frm.Height - frm.Location.Y) '15 is a constant to move the form to the edge.
        End If
    End Sub

    Private Sub btnReportBug_Click(sender As Object, e As EventArgs) Handles btnReportBug.Click
        Dim b As New frmReportBug
        b.Show(frm)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim b As New frmReportBug
        b.Show(frm)
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim h As New frmHelp
        h.Show()
    End Sub

    Private Sub stsStrGen_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles stsStrGen.ItemClicked

    End Sub

    Private Sub btnShare_Click(sender As Object, e As EventArgs)

    End Sub
End Class

Imports System.ComponentModel
Imports System.Numerics
Public Class frmSettings

    Private l As Language

    Private Sub btnCheckForUpdates_Click(sender As Object, e As EventArgs) Handles btnCheckForUpdates.Click
        func.checkUpdates(btnCheckForUpdates)
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserInterface.updateSettingsInterface(Me)
        l = New Language
        cmbLanguage.SelectedIndex = 0
        updateProperties()
        grpChange.Text = "Changelog: " & My.Settings.version
        UserInterface.newTheme(My.Settings.optBckgrd, Me)
    End Sub

    ''' <summary>
    ''' Updates all the settings on the from based on previous settings from settings.
    ''' </summary>

    Private Sub updateProperties()
        cmbAppearance.SelectedIndex = My.Settings.optBckgrd
        chkUseBigInt.Checked = My.Settings.optBigInt
        chkBndStrLgth.Checked = My.Settings.optBound
        chkCopyToClipboard.Checked = My.Settings.optClip
        chkGlue.Checked = My.Settings.optGlue
        chkCheckUpdatesOnLoad.Checked = My.Settings.optCheckUpdatesOnLoad
    End Sub

    ''' <summary>
    ''' If enter is pressed, and the text is only numbers, then if its value is
    ''' greater than 0 and less than the integer max value, then change the string length.
    ''' Otherwise, display a tooltip saying its invalid and keeping the old value.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub txtStringLength_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStringLength.KeyDown

        If e.KeyCode = Keys.Enter Then
            Dim b As BigInteger = BigInteger.One
            If BigInteger.TryParse(txtStringLength.Text, b) Then
                If (b > BigInteger.Zero) Then
                    var.setStringLength(BigInteger.Parse(txtStringLength.Text))
                    txtStringLength.Text = "String Length: " & var.getStringLength().ToString("n0")
                    func = New Functions
                    func.createToolTip("String length updated", "Success! The string length is now " & var.getStringLength().ToString("n0") & ".", "Exclamation", 3500, True)
                    grpStringInfo.Focus()
                    func.iterateString(var.getNumIterations())
                    UserInterface.updateSettingsInterface(Me)
                Else
                    func = New Functions
                    func.createToolTip("Invalid number exception ", "The input number is not valid.", "Critical", 1500, True)
                    txtStringLength.Text = "String Length: " & var.getStringLength().ToString("n0")
                End If
            End If
        End If

    End Sub

    Private Sub txtStringLength_LostFocus(sender As Object, e As EventArgs) Handles txtStringLength.LostFocus
        txtStringLength.Text = "String Length: " & var.getStringLength().ToString("n0")
    End Sub

    Private Sub txtCharacterList_LostFocus(sender As Object, e As EventArgs) Handles txtCharacterList.LostFocus
        txtCharacterList.Text = "The new character list: " & var.getCharList()
    End Sub

    Private Sub txtIterations_LostFocus(sender As Object, e As EventArgs) Handles txtIterations.LostFocus
        txtIterations.Text = "Iterations: " & var.getNumIterations().ToString("n0")
    End Sub

    Private Sub txtAddCharacters_LostFocus(sender As Object, e As EventArgs) Handles txtAddCharacters.LostFocus
        txtAddCharacters.Text = "Add characters"
    End Sub

    Private Sub txtRemoveCharacters_LostFocus(sender As Object, e As EventArgs) Handles txtRemoveCharacters.LostFocus
        txtRemoveCharacters.Text = "Remove characters"
    End Sub

    ''' <summary>
    ''' txtBoxes_Click
    ''' Description: Handles all the click events for the txt boxes 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub txtBoxes_Click(sender As Object, e As EventArgs) Handles txtAddCharacters.Click, txtRemoveCharacters.Click, txtIterations.Click, txtStringLength.Click
        sender.Clear()
    End Sub

    Private Sub txtAddCharacters_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddCharacters.KeyDown
        If e.KeyCode = Keys.Enter Then
            func.addCharacters(txtAddCharacters.Text)
            func = New Functions
            func.createToolTip("Character list updated", "Success! Added " & txtAddCharacters.Text, "Exclamation", 1500, True)
            func.iterateString(var.getNumIterations())
            UserInterface.updateSettingsInterface(Me)
        End If
    End Sub

    Private Sub txtRemoveCharacters_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRemoveCharacters.KeyDown
        If e.KeyCode = Keys.Enter Then
            func.removeCharacters(txtRemoveCharacters.Text)
            func = New Functions
            func.createToolTip("Character list updated", "Success! Removed " & txtRemoveCharacters.Text, "Exclamation", 1500, True)
            func.iterateString(var.getNumIterations())
            UserInterface.updateSettingsInterface(Me)
        End If
    End Sub

    Private Sub txtIterations_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIterations.KeyDown
        If e.KeyCode = Keys.Enter Then
            If (IsNumeric(txtIterations.Text)) Then
                If (txtIterations.Text > 0 And txtIterations.Text < Integer.MaxValue) Then
                    var.setNumIterations(txtIterations.Text)
                    func = New Functions
                    func.createToolTip("Iterations updated", "Success! Iterations is now " & txtIterations.Text, "Exclamation", 1500, True)
                    grpStringInfo.Focus()
                    func.iterateString(var.getNumIterations())
                    UserInterface.updateSettingsInterface(Me)
                Else
                    GoTo GoHere 'Used explicitly to avoid repeation of code.
                End If
            Else
GoHere:
                func = New Functions
                func.createToolTip("Invalid number exception", "The input number is an invalid.", "Critical", 1500, True)
                txtIterations.Text = "Iterations: " & var.getNumIterations().ToString("n0")
            End If
        End If
    End Sub

    Private Sub chkUseBigInt_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseBigInt.CheckedChanged
        If chkUseBigInt.Checked Then
            var.setOptUseBigInteger(True)
            My.Settings.optBigInt = True
        Else
            var.setOptUseBigInteger(False)
            My.Settings.optBigInt = False
        End If
        My.Settings.Save()
        func.stringStatistics(frm.lstStatistics)
    End Sub

    Private Sub chkBndStrLgth_CheckedChanged(sender As Object, e As EventArgs) Handles chkBndStrLgth.CheckedChanged
        If chkBndStrLgth.Checked Then
            var.setOptBndStrLgth(True)
            My.Settings.optBound = True
        Else
            var.setOptBndStrLgth(False)
            My.Settings.optBound = False
        End If
        My.Settings.Save()
        func.stringStatistics(frm.lstStatistics)
    End Sub

    Private Sub chkCopyToClipboard_CheckedChanged(sender As Object, e As EventArgs) Handles chkCopyToClipboard.CheckedChanged
        If chkCopyToClipboard.Checked Then
            var.setOptClipboard(True)
            My.Settings.optClip = True
        Else
            var.setOptClipboard(False)
            My.Settings.optClip = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub cmbAppearance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppearance.SelectedIndexChanged
        ' Loops through each active form instance
        For Each f As Form In Application.OpenForms
            UserInterface.newTheme(cmbAppearance.SelectedIndex, f)
        Next

        If cmbAppearance.SelectedIndex = 6 Then
            btnInsanity.Visible = True
            lblInsanity.Visible = True
            barInsanity.Visible = True
            barInsanity.Value = 250
            tmeInsanity.Interval = barInsanity.Value
            Dim d As Double = tmeInsanity.Interval / 1000.0
            lblInsanity.Text = "Insanity: " & FormatNumber(d, 2) & "s."
        Else
            btnInsanity.Visible = False
            lblInsanity.Visible = False
            barInsanity.Visible = False
            If tmeInsanity.Enabled Then
                tmeInsanity.Enabled = False
                btnInsanity.Text = "Generate Insanity"
            End If
        End If
    End Sub

    Private Sub radPseudoRandom_CheckedChanged(sender As Object, e As EventArgs)
        var.setRndMethod(1)
        My.Settings.optRndMethod = 1
        My.Settings.Save()
        func.stringStatistics(frm.lstStatistics)
        UserInterface.updateInterface(frm.lstGenerate, frm.btnStringLength, frm.btnIterations, frm.lblStringLength, frm.lblNumIterations)
        func.iterateString(var.getNumIterations())
        UserInterface.updateSettingsInterface(Me)
    End Sub

    Private Sub radReapRandom_CheckedChanged(sender As Object, e As EventArgs)
        var.setRndMethod(2)
        My.Settings.optRndMethod = 2
        My.Settings.Save()
        func.stringStatistics(frm.lstStatistics)
        UserInterface.updateInterface(frm.lstGenerate, frm.btnStringLength, frm.btnIterations, frm.lblStringLength, frm.lblNumIterations)
        func.iterateString(var.getNumIterations())
        UserInterface.updateSettingsInterface(Me)
    End Sub

    Private Sub radCustomRandomization_CheckedChanged(sender As Object, e As EventArgs)
        var.setRndMethod(3)
        func.iterateString(var.getNumIterations())
        UserInterface.updateSettingsInterface(Me)
    End Sub

    Private Sub btnOpenStrGen_Click(sender As Object, e As EventArgs)
        frm.Show()
    End Sub

    Private Sub chkGlue_CheckedChanged(sender As Object, e As EventArgs) Handles chkGlue.CheckedChanged
        My.Settings.optGlue = chkGlue.Checked
        My.Settings.Save()
        frmSettings_Move(sender, e)
    End Sub

    Private Sub chkCheckUpdatesOnLoad_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheckUpdatesOnLoad.CheckedChanged
        My.Settings.optCheckUpdatesOnLoad = chkCheckUpdatesOnLoad.Checked
        My.Settings.Save()
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

    Public Sub frmSettings_Move(sender As Object, e As EventArgs) Handles Me.Move
        If My.Settings.optGlue And GetActiveWindow.Equals(Me.Handle) Then
            frm.Location = New Point((Width + Location.X) - 15, Height - Location.Y) '15 is a constant to move the form to the edge.
        End If
    End Sub

    Private Sub lnkPortfolio_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPortfolio.LinkClicked
        System.Diagnostics.Process.Start("http://reap.myportfolio.com")
    End Sub

    Private Sub frmSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub lstStringInformation_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAddLang_Click(sender As Object, e As EventArgs) Handles btnAddLang.Click
        Dim selection As String = cmbLanguage.SelectedItem.ToString

        If selection.Equals("Arabic") Then
            l.addLanguage((l.getArabic()))
        ElseIf selection.Equals("Czech") Then
            l.addLanguage(l.getCzech())
        ElseIf selection.Equals("Danish") Then
            l.addLanguage(l.getDanish())
        ElseIf selection.Equals("Dutch") Then
            l.addLanguage(l.getDutch())
        ElseIf selection.Equals("Esperanto") Then
            l.addLanguage(l.getEsperanto())
        ElseIf selection.Equals("Finnish") Then
            l.addLanguage(l.getFinnish())
        ElseIf selection.Equals("French") Then
            l.addLanguage(l.getFrench())
        ElseIf selection.Equals("German") Then
            l.addLanguage(l.getGerman())
        ElseIf selection.Equals("Greek") Then
            l.addLanguage(l.getGreek())
        ElseIf selection.Equals("Hungarian") Then
            l.addLanguage(l.getHungarian())
        ElseIf selection.Equals("Icelandic") Then
            l.addLanguage(l.getIcelandic())
        ElseIf selection.Equals("Italian") Then
            l.addLanguage(l.getItalian())
        ElseIf selection.Equals("Maori") Then
            l.addLanguage(l.getMaori())
        ElseIf selection.Equals("Norwegian") Then
            l.addLanguage(l.getNorwegian())
        ElseIf selection.Equals("Polish") Then
            l.addLanguage(l.getPolish())
        ElseIf selection.Equals("Portuguese") Then
            l.addLanguage(l.getPortuguese())
        ElseIf selection.Equals("Romanian") Then
            l.addLanguage(l.getRomanian())
        ElseIf selection.Equals("Russian") Then
            l.addLanguage(l.getRussian())
        ElseIf selection.Equals("Spanish") Then
            l.addLanguage(l.getSpanish())
        ElseIf selection.Equals("Swedish") Then
            l.addLanguage(l.getSwedish())
        ElseIf selection.Equals("Turkish") Then
            l.addLanguage(l.getTurkish())
        ElseIf selection.Equals("Welsh") Then
            l.addLanguage(l.getWelsh())
        ElseIf selection.Equals("Currencies") Then
            l.addLanguage(l.getCurrencies())
        ElseIf selection.Equals("The Mathematical Language") Then
            l.addLanguage(l.getMathLang())
        ElseIf selection.Equals("Symbols") Then
            l.addLanguage(l.getSymbol())
        Else
            func = New Functions
            func.createToolTip("No Language Exception", "The selection you made does not exist.", "Critical", 3000, True)
        End If

        func.iterateString(var.getNumIterations())
        UserInterface.updateSettingsInterface(Me)
    End Sub

    Private Sub btnResetLang_Click(sender As Object, e As EventArgs) Handles btnResetLang.Click
        l.resetLanguage()
        func.iterateString(var.getNumIterations())
        UserInterface.updateSettingsInterface(Me)
    End Sub

    Private Sub frmSettings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frm.btnSettings.Enabled = True
        frm.btnSettings2.Enabled = True
    End Sub

    Private Sub btnInsanity_Click(sender As Object, e As EventArgs) Handles btnInsanity.Click

        If btnInsanity.Text = "Stop Insanity" Then
            btnInsanity.Text = "Generate Insanity"
            tmeInsanity.Enabled = False
        Else
            If MsgBox("The random theme will now be applied on a specific interval. " &
                              "Default 250ms (1/4 a second), do you confirm this insanity. By " &
                              "clicking yes you agree the following may trigger a seizure or " &
                              "epilepsy. By clicking yes you acknowledge the risk and understand " &
                              "these terms.", MessageBoxButtons.YesNo, "Agree " &
                              "to this insanity") = MsgBoxResult.Yes Then
                If btnInsanity.Text = "Generate Insanity" Then
                    btnInsanity.Text = "Stop Insanity"
                    tmeInsanity.Enabled = True
                End If
            Else
                MsgBox("Good choice.", MsgBoxStyle.Information, "RSG")
            End If
        End If

    End Sub

    Private Sub tmeInsanity_Tick(sender As Object, e As EventArgs) Handles tmeInsanity.Tick
        For Each f As Form In Application.OpenForms
            UserInterface.newTheme(cmbAppearance.SelectedIndex, f)
        Next
    End Sub

    Private Sub barInsanity_Scroll(sender As Object, e As ScrollEventArgs) Handles barInsanity.Scroll
        tmeInsanity.Interval = barInsanity.Value
        Dim d As Double = tmeInsanity.Interval / 1000.0
        lblInsanity.Text = "Insanity: " & FormatNumber(d, 2) & "s."
    End Sub
End Class
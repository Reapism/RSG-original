Imports System.ComponentModel
Imports System.Net
Imports System.Numerics

Public Class frmDictionary
    Private d As RSGDictionary
    Private rnd As Random
    Private WithEvents w As WebClient

    Public Sub New()
        InitializeComponent()
        rnd = New Random(Date.Now.Millisecond)
        w = New WebClient
        d = New RSGDictionary(5) 'Instantiate the class with 5 words
    End Sub

    Private Sub frmDictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDictInfo.Clear()
        txtDictInfo.AppendText(UserInterface.decorateText(43))
        txtDictInfo.AppendText("To generate random words with this dictionary,")
        txtDictInfo.AppendText("you must load the dictionary.")
        txtDictInfo.AppendText(UserInterface.decorateText(43))
        d.loadSettings()
        d.firstTime()
        d.dispDictionaries(cmbWordList)

        txtNumWords_Leave(sender, e)

        cmbWordList.Focus()
        d.toggleGen(False)

        cmbAction.SelectedIndex = 0
        If cmbWordList.Items.Count > 0 Then
            cmbWordList_SelectedIndexChanged(sender, e)
        End If
        CheckForIllegalCrossThreadCalls = False
        My.Settings.Save()
        UserInterface.newTheme(My.Settings.optBckgrd, Me)
    End Sub

    Private Sub txtNumWords_Click(sender As Object, e As EventArgs) Handles txtNumWords.Click
        txtNumWords.Clear()
    End Sub

    Private Sub txtNumWords_Enter(sender As Object, e As EventArgs) Handles txtNumWords.Enter
        txtNumWords.Clear()
    End Sub

    Private Sub txtNumWords_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumWords.KeyDown
        If e.KeyCode = Keys.Enter And Not IsNothing(txtNumWords.Text) Then
            d.setNumWords(Functions.isBigInteger(txtNumWords.Text))
            txtNumWords.Text = "Number of words: " & d.getNumWords().ToString("n0")
        End If
    End Sub

    Private Sub txtNumWords_Leave(sender As Object, e As EventArgs) Handles txtNumWords.Leave
        txtNumWords.Text = "Number of words: " & d.getNumWords.ToString("n0")
    End Sub

    Private Sub chkUseNoise_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseNoise.CheckedChanged
        My.Settings.dictAppendNoise = chkUseNoise.Checked
        'If chkUseNoise.Checked Then
        '    chkHighlightNoise.Enabled = True
        'Else
        '    chkHighlightNoise.Enabled = False
        'End If
    End Sub

    Private Sub chkFirstLetterUp_CheckedChanged(sender As Object, e As EventArgs) Handles chkFirstLetterUp.CheckedChanged
        My.Settings.dictFirstLtrUp = chkFirstLetterUp.Checked
    End Sub

    Private Sub chkUseSpace_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseSpace.CheckedChanged, chkUseSpace.CheckedChanged
        My.Settings.dictUseSpace = chkUseSpace.Checked
    End Sub

    Private Sub chkUsePunc_CheckedChanged(sender As Object, e As EventArgs) Handles chkUsePunc.CheckedChanged, chkUsePunc.CheckedChanged
        My.Settings.dictUsePunc = chkUsePunc.Checked
    End Sub

    Private Sub chkDispStats_CheckedChanged(sender As Object, e As EventArgs) Handles chkDispStats.CheckedChanged
        My.Settings.dictDispStat = chkDispStats.Checked
    End Sub

    Private Sub chkUseAlliteration_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseAlliteration.CheckedChanged
        My.Settings.dictUseAlliterations = chkUseAlliteration.Checked
        If chkUseAlliteration.Checked Then
            Text += " - Aliterations in progress"
            Cursor.Current = Cursors.WaitCursor
            d.setDictionary(d.useAlliterations())
        Else
            d.readDictionary(My.Settings.dictPath(cmbWordList.SelectedIndex))
        End If
        Text = "Dictionary"
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub chkThread_CheckedChanged(sender As Object, e As EventArgs) Handles chkThread.CheckedChanged
        My.Settings.dictThreadTask = chkThread.Checked
    End Sub

    Private Sub radPseudo_CheckedChanged(sender As Object, e As EventArgs) Handles radPseudo.CheckedChanged
        My.Settings.dictRndMethod = 1
    End Sub

    Private Sub radReap_CheckedChanged(sender As Object, e As EventArgs) Handles radReap.CheckedChanged
        My.Settings.dictRndMethod = 2
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        txtOutput.Clear()

        If My.Settings.dictThreadTask Then
            d.toggleGen(False)
            If Not bgThread.IsBusy Then
                bgThread.RunWorkerAsync()
            End If
        Else
            d.genWords(d.getNumWords(), My.Settings.dictRndMethod)
        End If

    End Sub

    Private Sub lblChooseDir_Click(sender As Object, e As EventArgs) Handles lblChooseDir.Click
        If Not lblChooseDir.ForeColor.Equals(Color.DarkGreen) Then
            d.chooseDir()
        End If

    End Sub

    Private Sub tmeFlash_Tick(sender As Object, e As EventArgs) Handles tmeFlash.Tick
        If lblChooseDir.ForeColor.Equals(Color.Goldenrod) Then
            lblChooseDir.ForeColor = Color.Black
        Else
            lblChooseDir.ForeColor = Color.Goldenrod
        End If
        tmeFlash.Enabled = True
    End Sub

    Private Sub cmbAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAction.SelectedIndexChanged
        If cmbAction.SelectedIndex > 0 Then
            If cmbAction.SelectedItem.ToString.Equals("Remove a dictionary") Then
                btnAction.Text = "Remove the " & cmbWordList.SelectedItem.ToString & " dictionary"
            Else
                btnAction.Text = cmbAction.SelectedItem.ToString
            End If
            btnAction.Visible = True
        Else
            btnAction.Visible = False
        End If
    End Sub

    Private Sub cmbWordList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWordList.SelectedIndexChanged
        d.showDictStats(cmbWordList, txtDictInfo)
    End Sub

    Private Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        Dim index As Integer = cmbAction.SelectedIndex

        Select Case index
            Case 1 ' Add dictionary
                d.addDictionary(cmbWordList, d.getNextIndex(My.Settings.dictName))
            Case 2 'Remove dictionary
                Dim result As Integer = d.remDictionary(cmbWordList, CInt(cmbWordList.SelectedIndex))
                func = New Functions

                If result.Equals(2) Then
                    func.createToolTip("File exception", "File does not exist in this directory, removing from list.", "Info", 3500, True)
                ElseIf DialogResult.Equals(1) Then
                    func.createToolTip("Success", "Removed the dictionary.", "Exclamation", 5000, True)
                ElseIf result.Equals(0) Then
                    func.createToolTip("Captcha exception", "Invalid captcha.", "Critical", 5000, True)
                ElseIf result.Equals(-1) Then
                    func.createToolTip("Failed", "The selected dictionary doesn't exist or is a default dictionary.", "Critical", 5000, True)
                End If

            Case 3 'Generate log-file 

            Case 4 ' View default dictionary path
                MsgBox(d.getDir())
            Case 5 ' Set default dictionary path
                My.Settings.dictFirstTime = True
                d.firstTime()
                d.chooseDir() ' Remember downloadDict also is tied to downloadProgress.
            Case 6 ' Browse online for other dictionaries
                System.Diagnostics.Process.Start("http://www.reap.myportfolio.com")
            Case Else
                func = New Functions
                func.createToolTip("Action exception", "The following exception occurred when selecting an action.", "Critical", 5000, True)

        End Select
        cmbAction.SelectedIndex = 0
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        btnGoogle.PerformClick()
    End Sub

    Private Sub btnLMGTFY_Click(sender As Object, e As EventArgs) Handles btnLMGTFY.Click
        If txtOutput.SelectedText.Length > 0 Then
            Dim s As String = txtOutput.SelectedText
            Process.Start("http://lmgtfy.com/?q=" & s & "+definition")
        Else
            func = New Functions
            func.createToolTip("Selected text exception", "No text was selected to search for!", "", 4000, True)

        End If
    End Sub

    Private Sub btnGoogle_Click(sender As Object, e As EventArgs) Handles btnGoogle.Click
        If txtOutput.SelectedText.Length > 0 Then
            Dim s As String = txtOutput.SelectedText
            System.Diagnostics.Process.Start("http://www.google.com/search?q=" & s.Replace(" ", "+") & "+definition")
        Else
            func = New Functions
            func.createToolTip("Selected text exception", "No text was selected to search for!", "", 4000, True)

        End If
    End Sub

    Private Sub bgThread_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgThread.DoWork
        d.genWords(d.getNumWords(), My.Settings.dictRndMethod)
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        tsFirstTime.Visible = True
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        txtOutput.SelectAll()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If txtOutput.SelectedText.Length > 0 Then
            Clipboard.SetText(txtOutput.SelectedText)
        End If
    End Sub

    Private Sub bgThread_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgThread.RunWorkerCompleted
        d.toggleGen(True)
    End Sub

    Private Sub txtDictInfo_TextChanged(sender As Object, e As EventArgs) Handles txtDictInfo.TextChanged

    End Sub

    Private Sub txtDictInfo_Click(sender As Object, e As LinkClickedEventArgs) Handles txtDictInfo.LinkClicked
        Process.Start(e.LinkText)
    End Sub
End Class
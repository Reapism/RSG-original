Imports System.IO
Imports System.Numerics

Public Class frmAutoGen
    Private numIterations As BigInteger = 500 ' Number of iterations to generate
    Private threadState As Boolean
    Private strLength As BigInteger
    Private isFinite As Boolean ' If the generation type is finite or infinite
    Private rnd As Random
    Private saveBound As Integer ' Bound for how many items to save before message.
    Private timeStart As Date
    Private numIter As BigInteger 'Holding the number of iterations generated.

    Private Sub frmAutoGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        rnd = New Random
        saveBound = 10000
        strLength = BigInteger.Parse(var.getStringLength().ToString())
        cmbSelectIteration.SelectedIndex = 0
        lstStats.Items.Clear()
        btnStart.Enabled = True
        btnStop.Enabled = True
        txtNumIter.Text = "Number of iterations: " & numIterations.ToString("n0")
        txtStringLength.Text = "String Length: " & strLength.ToString("n0")
        grpStats.Text = "Statistics:"
        threadState = chkThread.CheckState
        Text = "Auto Generate"
        isFinite = True
        btnRefresh.Visible = False
        numIter = BigInteger.Zero

        UserInterface.newTheme(My.Settings.optBckgrd, Me)
    End Sub

    Private Sub frmAutoGen_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        lstStats.Items.Clear()
        showStatsPreview(isFinite)
        lstStats.Items.Add("")
    End Sub

    Private Sub showStatsPreview(ByVal b As Boolean)
        lstStats.Items.Clear()
        If b Then
            lstStats.Items.Add(UserInterface.decorateText(45))
            lstStats.Items.Add(UserInterface.addSpaces(9) & "Selected finite iterations")
            lstStats.Items.Add(UserInterface.decorateText(45))
            lstStats.Items.Add("")
            lstStats.Items.Add("String Length: " & strLength.ToString("n0"))
            lstStats.Items.Add("Iterations: " & numIterations.ToString("n0"))
            lstStats.Items.Add("Character List: " & var.getAllCharList())
            lstStats.Items.Add("Randomization Method: " & var.getRndMethod())
            lstStats.Items.Add("Auto generating with these settings...")
            lstStats.Items.Add("")
            lstStats.Items.Add("Press start to begin...")
        Else
            lstStats.Items.Add(UserInterface.decorateText(45))
            lstStats.Items.Add(UserInterface.addSpaces(8) & "Selected infinite iterations")
            lstStats.Items.Add(UserInterface.decorateText(45))
            lstStats.Items.Add("")
            lstStats.Items.Add("String Length: " & strLength.ToString("n0"))
            lstStats.Items.Add("Iterations: ∞")
            lstStats.Items.Add("Character List: " & var.getAllCharList())
            lstStats.Items.Add("Randomization Method: " & var.getRndMethod())
            lstStats.Items.Add("Auto generating with these settings...")
            lstStats.Items.Add("")
            lstStats.Items.Add("Press start to begin...")
        End If
    End Sub

    Private Sub cmbSelectIteration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectIteration.SelectedIndexChanged
        If cmbSelectIteration.SelectedIndex = 0 Then
            txtNumIter.ReadOnly = False
            isFinite = True

            btnStart.Image = My.Resources.stringRun
            picSelect.BackgroundImage = My.Resources.stringRun
        Else
            txtNumIter.ReadOnly = True
            isFinite = False

            btnStop.Enabled = False
            frmAutoGen_TextChanged(sender, e)
            btnStart.Image = My.Resources.stringInfinity
            picSelect.BackgroundImage = My.Resources.stringInfinity
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnRefresh.PerformClick()
        btnStart.Enabled = False
        btnStop.Enabled = True
        cmbSelectIteration.Enabled = False
        txtNumIter.Enabled = False
        txtStringLength.Enabled = False
        tmeUpdate.Enabled = True
        tmeUpdate.Start()

        If isFinite Then
            Text = "Auto Generate - Finite"
        Else
            Text = "Auto Generate - Infinite"
        End If

        lstStats.Items.Clear()
        lstStats.Items.Insert(0, "Auto generating with these settings...")
        lstStats.Items.Insert(1, "")
        lstStats.Items.Insert(2, "String Length: " & strLength.ToString("n0"))
        lstStats.Items.Insert(3, "Iterations: " & numIterations.ToString("n0"))
        lstStats.Items.Insert(4, "Character List: " & var.getAllCharList())
        lstStats.Items.Insert(5, "Randomization Method: " & var.getRndMethod())
        lstStats.Items.Insert(6, "")

        lstStats.Items.Insert(7, "")
        lstStats.Items.Insert(8, "Iterated " & numIter.ToString("n0") & " times.")
        thrWork.RunWorkerAsync()
    End Sub

    Private Sub thrWork_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles thrWork.DoWork
        numIter = BigInteger.One
        lstStats.Items.Add(func.generateString(strLength, var.getAllCharList(), var.getRndMethod()))
        timeStart = Date.Now

        If isFinite Then ' Selected finite iterations
            While ((numIter < numIterations) And btnStop.Enabled)
                lstStats.Items.Add(func.generateString(strLength, var.getAllCharList(), var.getRndMethod()))
                numIter = BigInteger.op_Increment(numIter)
            End While

            ' Selected infinite iterations
        Else
            While (btnStop.Enabled)
                numIter = BigInteger.op_Increment(numIter)
                lstStats.Items.Add(func.generateString(strLength, var.getAllCharList(), var.getRndMethod()))
            End While

            ' If condition is finished before stopping the process, stop it.
        End If

        If btnStop.Enabled Then
            stopAutoGen()
        End If
    End Sub

    Private Sub stopAutoGen()

        'Make sures the form becomes active if its minimized.
        If Not (WindowState = FormWindowState.Normal) Then
            WindowState = FormWindowState.Normal
        End If

        Dim timeEnd As Date = Date.Now
        Dim timeElapsed As TimeSpan = timeEnd.Subtract(timeStart)

        If isFinite Then
            grpStats.Text = "Auto Generate - Finite - Iterated " & numIter.ToString("n0") & " times."
        Else
            grpStats.Text = "Auto Generate - Infinite - Iterated " & numIter.ToString("n0") & " times."
        End If
        lstStats.Items.RemoveAt(8)
        lstStats.Items.Insert(8, "Iterated " & numIter.ToString("n0") & " times.")

        lstStats.Items.Insert(9, "Time elapsed: " & timeElapsed.TotalSeconds.ToString("0.000") & " second(s).")
        lstStats.Items.Insert(10, "")

        tmeUpdate.Enabled = False

        btnStart.Enabled = True
        btnStop.Enabled = False
        btnRefresh.Visible = True
    End Sub

    Private Sub tmeUpdate_Tick(sender As Object, e As EventArgs) Handles tmeUpdate.Tick
        If isFinite And chkUpdateIterations.Checked Then
            grpStats.Text = "Auto Generate - (finite) - Iterated " & numIter.ToString("n0") & " times."
        ElseIf Not isFinite And chkUpdateIterations.Checked Then
            grpStats.Text = "Auto Generate - (Infinite) - Iterated " & numIter.ToString("n0") & " times."
        End If

        lstStats.Items.RemoveAt(8)
        lstStats.Items.Insert(8, "Iterated " & numIter.ToString("n0") & " times.")
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        btnStop.Enabled = False
        stopAutoGen()
        tmeUpdate.Enabled = False
        tmeUpdate.Stop()
    End Sub

    Private Sub txtNumIter_Enter(sender As Object, e As EventArgs) Handles txtNumIter.Enter
        txtNumIter.Clear()
    End Sub

    Private Sub txtNumIter_Leave(sender As Object, e As EventArgs) Handles txtNumIter.Leave
        parseTextbox(txtNumIter)
        txtNumIter.Text = "Number of iterations: " & numIterations.ToString("n0")
    End Sub

    Private Sub txtStringLength_Enter(sender As Object, e As EventArgs) Handles txtStringLength.Enter
        txtStringLength.Clear()
    End Sub

    Private Sub txtStringLength_Leave(sender As Object, e As EventArgs) Handles txtStringLength.Leave
        parseTextbox(txtStringLength)
        txtStringLength.Text = "String Length: " & strLength.ToString("n0")
    End Sub

    ''' <summary>
    ''' Accepts a txtbox as parameter and parses it depending on if txtStringLength or txtNumIter
    ''' </summary>
    ''' <param name="txt"></param>

    Private Sub parseTextbox(ByRef txt As TextBox)
        If IsNumeric(txt.Text) And Not IsNothing(txt.Text) Then
            If BigInteger.Parse(txt.Text) > BigInteger.Zero Then

                If txt.Equals(txtStringLength) Then
                    strLength = txt.Text
                    txt.Text = "String length: " & strLength.ToString("n0")
                    showStatsPreview(Me.isFinite)
                ElseIf txt.Equals(txtNumIter) Then
                    numIterations = txt.Text
                    txt.Text = "Number of iterations: " & numIterations.ToString("n0")
                End If

            Else
                func = New Functions
                func.createToolTip("Conversion exception", "The following input cannot be converted to a number greater than 0.", "Critical", 4000, True)
                chkThread.Focus() ' Calling both the txtStringLength and txtNumIter leave events.
            End If

        End If

    End Sub

    Private Sub txtNumIter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumIter.KeyDown
        If e.KeyCode = Keys.Enter Then
            parseTextbox(txtNumIter)
        End If
    End Sub

    Private Sub txtStringLength_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStringLength.KeyDown
        If e.KeyCode = Keys.Enter Then
            parseTextbox(txtStringLength)
        End If
    End Sub

    Private Sub btnExportLog_Click(sender As Object, e As EventArgs) Handles btnExportLog.Click
        If lstStats.Items.Count >= saveBound Then
            GoTo StartPosition
        Else
StartPosition:
            Dim saveDiag As New SaveFileDialog

            With saveDiag
                .Title = "Choose where to save the file!"
                .DefaultExt = ".txt"
                .FilterIndex = 1
                .RestoreDirectory = True
                .Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*"
                .InitialDirectory = "C:\AppTemp"
                .FileName = "RSG - Autogen Log " & Date.Now.ToString().Replace("/", "-").Replace(":", ";")
            End With

            If saveDiag.ShowDialog() = DialogResult.OK Then
                Dim sb As New System.Text.StringBuilder()

                For Each o As Object In lstStats.Items
                    sb.AppendLine(o)
                Next

                System.IO.File.WriteAllText(saveDiag.FileName, sb.ToString())
            End If
        End If
    End Sub

    ''' <summary>
    ''' btnRefresh() --
    ''' Refresh the form for reuse.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        lstStats.Items.Clear()
        btnStart.Enabled = True
        btnStop.Enabled = True
        isFinite = True
        btnRefresh.Visible = False

        txtNumIter.Text = "Number of iterations: " & numIterations.ToString
        txtStringLength.Text = "String Length: " & strLength.ToString("n0")
        grpStats.Text = "Statistics:"
        Text = "Auto Generate"
        threadState = chkThread.CheckState
        cmbSelectIteration.Enabled = True
        txtNumIter.Enabled = True
        txtStringLength.Enabled = True
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        func.findString(lstStats)
    End Sub

    Private Sub frmAutoGen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        btnStop.PerformClick()
        btnRefresh.PerformClick()
        Dispose()
    End Sub
End Class
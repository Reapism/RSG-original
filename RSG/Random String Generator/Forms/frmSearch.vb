Imports System.ComponentModel
Imports System.Numerics

Public Class frmSearch
    Private s As RSGSearch
    Private WithEvents bg As ComponentModel.BackgroundWorker
    Private start As Date

    Public Sub New()
        InitializeComponent()
        s = New RSGSearch
        cmbCharLists.SelectedIndex = 0
        cmbSearchMethod.SelectedIndex = 0
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        s.loadSettings(Me)
        UserInterface.newTheme(My.Settings.optBckgrd, Me)
    End Sub

    Public Function getStartTime() As Date
        Return start
    End Function

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            If cmbCharLists.SelectedIndex = 0 Then
                s.dispCEM(txtSearch.Text, s.useCEM(txtSearch.Text), txtExpect)

            ElseIf cmbCharLists.SelectedIndex = 1 Then
                s.dispPswd(txtSearch.Text, s.usePswd(txtSearch.Text), txtExpect)
            End If
        Else
            txtExpect.Clear()
        End If

    End Sub

    Private Sub cmbCharLists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCharLists.SelectedIndexChanged
        txtSearch_TextChanged(sender, e)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        s.setString(txtSearch.Text)
        ' If the from wasn't refreshed for a previous search, refresh it before a new search.
        If btnRefresh.Enabled Then
            s.refresh(Me, bg)
        End If

        ' If their exists a string to search, search.
        If s.getString().Length > 0 Then

            btnStart.Enabled = False
            btnStop.Enabled = True
            btnRefresh.Enabled = False

            ' If this instance is a brand new search, instantiate it and refresh as well.
            If IsNothing(bg) Then
                bg = New BackgroundWorker
                bg.WorkerSupportsCancellation = True
                s.refresh(Me, bg)
                AddHandler bg.DoWork, AddressOf bg_DoWork
            End If

            'If a concurrent operation is still running (an old search), attempts to stop that execution.
            If bg.IsBusy Then
                func = New Functions
                func.createToolTip("Thread busy exception", "The recursive process isn't yet completed. Try again!", "Critical", 4000, True)
                bg.CancelAsync()
            Else
                start = Date.Now
                bg.RunWorkerAsync()
                timeSec.Start()
            End If

        Else
            ' If there is no string, display an exception.
            func = New Functions
            func.createToolTip("No string exception", "There is no string to search.", "Critical", 4000, True)
        End If
    End Sub

    ''' <summary>
    ''' Threaded recursive search on the string.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub bg_DoWork(sender As Object, e As DoWorkEventArgs)
        If s.search("", s.getCharList) Then
            s.setStats(txtResult)
            txtResult.AppendText(UserInterface.newLine() & s.getNumIterations().ToString("n0") &
                                 " iterations later, and we completed.")
            s.stopSearch(Me, bg)
        Else
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        s.stopSearch(Me, bg)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        s.refresh(Me, bg)
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        txtSearch.Clear()
    End Sub

    Private Sub timeSec_Tick(sender As Object, e As EventArgs) Handles timeSec.Tick
        s.setStats(txtResult)

        If Not btnStop.Enabled Then
            timeSec.Enabled = False
        End If

    End Sub

    Private Sub chkHeavy_CheckedChanged(sender As Object, e As EventArgs) Handles chkHeavy.CheckedChanged
        My.Settings.srchHeavyStatistics = chkHeavy.Checked
        My.Settings.Save()
    End Sub

    Private Sub frmSearch_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not IsNothing(bg) Then
            s.stopSearch(Me, bg)
        End If
    End Sub
End Class
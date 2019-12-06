Imports System.Security.Cryptography

''' <summary>
''' Report a bug form for RSG.
''' </summary>
Public Class frmReportBug

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmReportBug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = frm.Icon
        UserInterface.newTheme(My.Settings.optBckgrd, Me)
    End Sub

    Private Sub btnShowEmail_Click(sender As Object, e As EventArgs) Handles btnShowEmail.Click
        If btnShowEmail.Enabled Then
            If func.genCaptcha("Please enter the captcha to show the email.", 5) Then
                btnShowEmail.Enabled = False
                btnShowEmail.FlatStyle = FlatStyle.Popup
                btnShowEmail.Text = "Email: reapsprgm@gmail.com"
            Else
                func = New Functions
                func.createToolTip("Wrong captcha", "The captcha was wrong! Please try again (cAsE Sensitive)", "Critical", 5000, True)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Generate Internal Diagnostics by using the Process class on RSG.
    ''' </summary>
    ''' <param name="t"></param>

    Private Sub genIntDiag(ByRef t As RichTextBox)

        Dim now As Date = Date.Now
        Dim p As Process = Process.GetCurrentProcess
        t.Clear()
        t.AppendText("Email Format" & UserInterface.newLine)
        t.AppendText("Subject: RSG Bug Report - <something here>" & UserInterface.newLine)
        t.AppendText(UserInterface.newLine)
        t.AppendText("Generated Internal Diagnostics" & UserInterface.newLine)
        t.AppendText("Time: " & now.ToLongTimeString & UserInterface.newLine)
        t.AppendText(UserInterface.newLine)
        t.AppendText("Machine name: " & p.MachineName.ToUpper & UserInterface.newLine)
        t.AppendText("Handles: " & p.Handle.ToString("n0") & UserInterface.newLine)
        t.AppendText("Handles by RSG: " & p.HandleCount.ToString("n0") & UserInterface.newLine)
        t.AppendText("RSG process ID [PID]: " & p.Id & UserInterface.newLine)
        t.AppendText("Alive time since: " & p.StartTime.ToLongTimeString & UserInterface.newLine)
        t.AppendText("Main window: " & p.MainWindowTitle & UserInterface.newLine)
        t.AppendText("Minimum Working Set: " & p.MinWorkingSet.ToString("n0") & UserInterface.newLine)
        t.AppendText("Maximum Working Set: " & p.MaxWorkingSet.ToString("n0") & UserInterface.newLine)
        t.AppendText("Threads: " & p.Threads.Count & UserInterface.newLine)
        t.AppendText("Peak Working Set: " & p.PeakWorkingSet64.ToString("n0") & UserInterface.newLine)
        t.AppendText("Affinity: " & p.ProcessorAffinity.ToString("n0") & UserInterface.newLine)
        t.AppendText("Modules: " & UserInterface.newLine)

        For Each mdl In p.Modules
            t.AppendText(vbTab & mdl.ToString() & UserInterface.newLine)
        Next

    End Sub

    Private Sub btnIntDiag_Click(sender As Object, e As EventArgs) Handles btnIntDiag.Click
        genIntDiag(txtDiag)
    End Sub
End Class
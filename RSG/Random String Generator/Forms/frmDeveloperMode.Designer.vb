<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeveloperMode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.barVisual = New System.Windows.Forms.ProgressBar()
        Me.grpDev = New System.Windows.Forms.GroupBox()
        Me.lblZoom = New System.Windows.Forms.Label()
        Me.lblFreq = New System.Windows.Forms.Label()
        Me.trkChangeFreq = New System.Windows.Forms.TrackBar()
        Me.txtRandom = New System.Windows.Forms.TextBox()
        Me.trkFreq = New System.Windows.Forms.TrackBar()
        Me.lblVal = New System.Windows.Forms.Label()
        Me.tmeTick = New System.Windows.Forms.Timer(Me.components)
        Me.grpDev.SuspendLayout()
        CType(Me.trkChangeFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barVisual
        '
        Me.barVisual.Location = New System.Drawing.Point(12, 244)
        Me.barVisual.Name = "barVisual"
        Me.barVisual.Size = New System.Drawing.Size(482, 23)
        Me.barVisual.TabIndex = 0
        '
        'grpDev
        '
        Me.grpDev.Controls.Add(Me.lblZoom)
        Me.grpDev.Controls.Add(Me.lblFreq)
        Me.grpDev.Controls.Add(Me.trkChangeFreq)
        Me.grpDev.Controls.Add(Me.txtRandom)
        Me.grpDev.Controls.Add(Me.trkFreq)
        Me.grpDev.Controls.Add(Me.lblVal)
        Me.grpDev.Location = New System.Drawing.Point(12, 12)
        Me.grpDev.Name = "grpDev"
        Me.grpDev.Size = New System.Drawing.Size(482, 226)
        Me.grpDev.TabIndex = 1
        Me.grpDev.TabStop = False
        Me.grpDev.Text = "Developer Tools:"
        '
        'lblZoom
        '
        Me.lblZoom.AutoSize = True
        Me.lblZoom.Location = New System.Drawing.Point(12, 95)
        Me.lblZoom.Name = "lblZoom"
        Me.lblZoom.Size = New System.Drawing.Size(40, 13)
        Me.lblZoom.TabIndex = 5
        Me.lblZoom.Text = "Zoom: "
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.Location = New System.Drawing.Point(6, 194)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(34, 13)
        Me.lblFreq.TabIndex = 4
        Me.lblFreq.Text = "Freq: "
        '
        'trkChangeFreq
        '
        Me.trkChangeFreq.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.trkChangeFreq.Location = New System.Drawing.Point(9, 111)
        Me.trkChangeFreq.Maximum = 100
        Me.trkChangeFreq.Name = "trkChangeFreq"
        Me.trkChangeFreq.Size = New System.Drawing.Size(467, 45)
        Me.trkChangeFreq.TabIndex = 3
        Me.trkChangeFreq.Value = 4
        '
        'txtRandom
        '
        Me.txtRandom.Location = New System.Drawing.Point(9, 19)
        Me.txtRandom.Name = "txtRandom"
        Me.txtRandom.Size = New System.Drawing.Size(467, 20)
        Me.txtRandom.TabIndex = 2
        '
        'trkFreq
        '
        Me.trkFreq.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.trkFreq.Location = New System.Drawing.Point(9, 162)
        Me.trkFreq.Maximum = 8
        Me.trkFreq.Name = "trkFreq"
        Me.trkFreq.Size = New System.Drawing.Size(467, 45)
        Me.trkFreq.TabIndex = 1
        Me.trkFreq.Value = 4
        '
        'lblVal
        '
        Me.lblVal.AutoSize = True
        Me.lblVal.Location = New System.Drawing.Point(6, 210)
        Me.lblVal.Name = "lblVal"
        Me.lblVal.Size = New System.Drawing.Size(40, 13)
        Me.lblVal.TabIndex = 0
        Me.lblVal.Text = "Value: "
        '
        'tmeTick
        '
        Me.tmeTick.Interval = 1000
        '
        'frmDeveloperMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 279)
        Me.Controls.Add(Me.grpDev)
        Me.Controls.Add(Me.barVisual)
        Me.Name = "frmDeveloperMode"
        Me.Text = "developerMode"
        Me.grpDev.ResumeLayout(False)
        Me.grpDev.PerformLayout()
        CType(Me.trkChangeFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkFreq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents barVisual As ProgressBar
    Friend WithEvents grpDev As GroupBox
    Friend WithEvents tmeTick As Timer
    Friend WithEvents lblVal As Label
    Friend WithEvents trkFreq As TrackBar
    Friend WithEvents txtRandom As TextBox
    Friend WithEvents trkChangeFreq As TrackBar
    Friend WithEvents lblFreq As Label
    Friend WithEvents lblZoom As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoGen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoGen))
        Me.grpConfig = New System.Windows.Forms.GroupBox()
        Me.chkWriteToFile = New System.Windows.Forms.CheckBox()
        Me.chkUpdateIterations = New System.Windows.Forms.CheckBox()
        Me.picSelect = New System.Windows.Forms.PictureBox()
        Me.picNum = New System.Windows.Forms.PictureBox()
        Me.picLength = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtStringLength = New System.Windows.Forms.TextBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.chkThread = New System.Windows.Forms.CheckBox()
        Me.txtNumIter = New System.Windows.Forms.TextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.cmbSelectIteration = New System.Windows.Forms.ComboBox()
        Me.grpStats = New System.Windows.Forms.GroupBox()
        Me.lstStats = New System.Windows.Forms.ListBox()
        Me.ctxStats = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnExportLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmeUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.thrWork = New System.ComponentModel.BackgroundWorker()
        Me.grpConfig.SuspendLayout()
        CType(Me.picSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStats.SuspendLayout()
        Me.ctxStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpConfig
        '
        Me.grpConfig.Controls.Add(Me.chkWriteToFile)
        Me.grpConfig.Controls.Add(Me.chkUpdateIterations)
        Me.grpConfig.Controls.Add(Me.picSelect)
        Me.grpConfig.Controls.Add(Me.picNum)
        Me.grpConfig.Controls.Add(Me.picLength)
        Me.grpConfig.Controls.Add(Me.btnRefresh)
        Me.grpConfig.Controls.Add(Me.txtStringLength)
        Me.grpConfig.Controls.Add(Me.lblSelect)
        Me.grpConfig.Controls.Add(Me.chkThread)
        Me.grpConfig.Controls.Add(Me.txtNumIter)
        Me.grpConfig.Controls.Add(Me.btnStop)
        Me.grpConfig.Controls.Add(Me.btnStart)
        Me.grpConfig.Controls.Add(Me.cmbSelectIteration)
        Me.grpConfig.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpConfig.Location = New System.Drawing.Point(0, 0)
        Me.grpConfig.Name = "grpConfig"
        Me.grpConfig.Size = New System.Drawing.Size(242, 361)
        Me.grpConfig.TabIndex = 0
        Me.grpConfig.TabStop = False
        Me.grpConfig.Text = "Configuration:"
        '
        'chkWriteToFile
        '
        Me.chkWriteToFile.AutoSize = True
        Me.chkWriteToFile.Enabled = False
        Me.chkWriteToFile.Location = New System.Drawing.Point(5, 147)
        Me.chkWriteToFile.Name = "chkWriteToFile"
        Me.chkWriteToFile.Size = New System.Drawing.Size(136, 17)
        Me.chkWriteToFile.TabIndex = 15
        Me.chkWriteToFile.Text = "Write to file immediately"
        Me.tipHelp.SetToolTip(Me.chkWriteToFile, "Immediately write to file for a much larger output. Limited to HD space.")
        Me.chkWriteToFile.UseVisualStyleBackColor = True
        '
        'chkUpdateIterations
        '
        Me.chkUpdateIterations.AutoSize = True
        Me.chkUpdateIterations.Checked = True
        Me.chkUpdateIterations.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUpdateIterations.Location = New System.Drawing.Point(5, 124)
        Me.chkUpdateIterations.Name = "chkUpdateIterations"
        Me.chkUpdateIterations.Size = New System.Drawing.Size(106, 17)
        Me.chkUpdateIterations.TabIndex = 3
        Me.chkUpdateIterations.Text = "Update iterations"
        Me.tipHelp.SetToolTip(Me.chkUpdateIterations, "Update number of iterated strings to display while running auto gen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can tog" &
        "gle this while it runs.")
        Me.chkUpdateIterations.UseVisualStyleBackColor = True
        '
        'picSelect
        '
        Me.picSelect.BackgroundImage = Global.RSG.My.Resources.Resources.stringRun
        Me.picSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSelect.Location = New System.Drawing.Point(5, 71)
        Me.picSelect.Name = "picSelect"
        Me.picSelect.Size = New System.Drawing.Size(20, 20)
        Me.picSelect.TabIndex = 14
        Me.picSelect.TabStop = False
        '
        'picNum
        '
        Me.picNum.BackgroundImage = Global.RSG.My.Resources.Resources.stringNum
        Me.picNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picNum.Location = New System.Drawing.Point(5, 45)
        Me.picNum.Name = "picNum"
        Me.picNum.Size = New System.Drawing.Size(20, 20)
        Me.picNum.TabIndex = 13
        Me.picNum.TabStop = False
        '
        'picLength
        '
        Me.picLength.BackgroundImage = Global.RSG.My.Resources.Resources.stringLength
        Me.picLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLength.Location = New System.Drawing.Point(5, 19)
        Me.picLength.Name = "picLength"
        Me.picLength.Size = New System.Drawing.Size(20, 20)
        Me.picLength.TabIndex = 12
        Me.picLength.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRefresh.Image = Global.RSG.My.Resources.Resources.stringUpdate
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(6, 313)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(230, 40)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.tipHelp.SetToolTip(Me.btnRefresh, "Clear the fields!")
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtStringLength
        '
        Me.txtStringLength.Location = New System.Drawing.Point(31, 19)
        Me.txtStringLength.Name = "txtStringLength"
        Me.txtStringLength.Size = New System.Drawing.Size(201, 20)
        Me.txtStringLength.TabIndex = 0
        Me.txtStringLength.Text = "String Length: "
        Me.tipHelp.SetToolTip(Me.txtStringLength, "Edit the string length")
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(28, 78)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(108, 13)
        Me.lblSelect.TabIndex = 10
        Me.lblSelect.Text = "Select generate type:"
        '
        'chkThread
        '
        Me.chkThread.AutoSize = True
        Me.chkThread.Checked = True
        Me.chkThread.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkThread.Enabled = False
        Me.chkThread.Location = New System.Drawing.Point(5, 170)
        Me.chkThread.Name = "chkThread"
        Me.chkThread.Size = New System.Drawing.Size(83, 17)
        Me.chkThread.TabIndex = 4
        Me.chkThread.Text = "Thread task"
        Me.tipHelp.SetToolTip(Me.chkThread, "Run the task on another thread. This enables the form to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "be active while iterati" &
        "ng.")
        Me.chkThread.UseVisualStyleBackColor = True
        '
        'txtNumIter
        '
        Me.txtNumIter.Location = New System.Drawing.Point(31, 45)
        Me.txtNumIter.Name = "txtNumIter"
        Me.txtNumIter.Size = New System.Drawing.Size(201, 20)
        Me.txtNumIter.TabIndex = 2
        Me.txtNumIter.Text = "Number of iterations: "
        Me.tipHelp.SetToolTip(Me.txtNumIter, "Edit the number of iterations")
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Image = Global.RSG.My.Resources.Resources.stringClose
        Me.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStop.Location = New System.Drawing.Point(125, 267)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(110, 40)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop"
        Me.tipHelp.SetToolTip(Me.btnStop, "Cease auto generate!")
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Image = Global.RSG.My.Resources.Resources.stringRun
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.Location = New System.Drawing.Point(5, 267)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(110, 40)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.tipHelp.SetToolTip(Me.btnStart, "Run auto generate!")
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'cmbSelectIteration
        '
        Me.cmbSelectIteration.FormattingEnabled = True
        Me.cmbSelectIteration.Items.AddRange(New Object() {"Run (n) times.", "Run (∞) times."})
        Me.cmbSelectIteration.Location = New System.Drawing.Point(5, 97)
        Me.cmbSelectIteration.Name = "cmbSelectIteration"
        Me.cmbSelectIteration.Size = New System.Drawing.Size(227, 21)
        Me.cmbSelectIteration.TabIndex = 1
        Me.tipHelp.SetToolTip(Me.cmbSelectIteration, "Select to run a specific number of iterations or run indefinitely until stop")
        '
        'grpStats
        '
        Me.grpStats.Controls.Add(Me.lstStats)
        Me.grpStats.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpStats.Location = New System.Drawing.Point(248, 0)
        Me.grpStats.Name = "grpStats"
        Me.grpStats.Size = New System.Drawing.Size(336, 361)
        Me.grpStats.TabIndex = 0
        Me.grpStats.TabStop = False
        Me.grpStats.Text = "Statistics:"
        Me.tipHelp.SetToolTip(Me.grpStats, "Updated iterations displays here!")
        '
        'lstStats
        '
        Me.lstStats.ContextMenuStrip = Me.ctxStats
        Me.lstStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstStats.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStats.FormattingEnabled = True
        Me.lstStats.HorizontalScrollbar = True
        Me.lstStats.ItemHeight = 11
        Me.lstStats.Location = New System.Drawing.Point(3, 16)
        Me.lstStats.Name = "lstStats"
        Me.lstStats.Size = New System.Drawing.Size(330, 342)
        Me.lstStats.TabIndex = 8
        '
        'ctxStats
        '
        Me.ctxStats.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExportLog, Me.btnFind})
        Me.ctxStats.Name = "ctxStats"
        Me.ctxStats.Size = New System.Drawing.Size(164, 48)
        '
        'btnExportLog
        '
        Me.btnExportLog.Name = "btnExportLog"
        Me.btnExportLog.Size = New System.Drawing.Size(163, 22)
        Me.btnExportLog.Text = "Export stats log..."
        '
        'btnFind
        '
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(163, 22)
        Me.btnFind.Text = "Find..."
        '
        'tmeUpdate
        '
        Me.tmeUpdate.Interval = 1000
        '
        'tipHelp
        '
        Me.tipHelp.AutomaticDelay = 100
        Me.tipHelp.IsBalloon = True
        '
        'thrWork
        '
        '
        'frmAutoGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.grpStats)
        Me.Controls.Add(Me.grpConfig)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAutoGen"
        Me.Text = "Auto Generate String"
        Me.grpConfig.ResumeLayout(False)
        Me.grpConfig.PerformLayout()
        CType(Me.picSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStats.ResumeLayout(False)
        Me.ctxStats.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpConfig As GroupBox
    Friend WithEvents cmbSelectIteration As ComboBox
    Friend WithEvents grpStats As GroupBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents chkThread As CheckBox
    Friend WithEvents tipHelp As ToolTip
    Friend WithEvents txtNumIter As TextBox
    Friend WithEvents lstStats As ListBox
    Friend WithEvents tmeUpdate As Timer
    Friend WithEvents thrWork As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblSelect As Label
    Friend WithEvents txtStringLength As TextBox
    Friend WithEvents ctxStats As ContextMenuStrip
    Friend WithEvents btnExportLog As ToolStripMenuItem
    Friend WithEvents btnRefresh As Button
    Friend WithEvents picSelect As PictureBox
    Friend WithEvents picNum As PictureBox
    Friend WithEvents picLength As PictureBox
    Friend WithEvents chkUpdateIterations As CheckBox
    Friend WithEvents btnFind As ToolStripMenuItem
    Friend WithEvents chkWriteToFile As CheckBox
End Class

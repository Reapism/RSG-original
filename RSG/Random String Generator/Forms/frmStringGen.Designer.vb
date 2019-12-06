<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStringGen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStringGen))
        Me.strMain = New System.Windows.Forms.ToolStrip()
        Me.btnFile = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnAutoGenerate = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDictionary = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFindString = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGenerateLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSettings2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDeveloperMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.sep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnStringLength = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnIterations = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRandomizationMethod = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPseudoRandom = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnReapRandom = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAnimateMin = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAnimateMax = New System.Windows.Forms.ToolStripMenuItem()
        Me.sep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCharacters = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnUppercase = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLowercase = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNum = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSymb = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDispChar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddChar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRemChar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSetChar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnResetChar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSettings = New System.Windows.Forms.ToolStripButton()
        Me.sep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCheckForUpdates = New System.Windows.Forms.ToolStripButton()
        Me.sep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnView = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnShowStatistics = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnShowStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpGenerate = New System.Windows.Forms.GroupBox()
        Me.fntTitle = New System.Windows.Forms.Label()
        Me.picNum = New System.Windows.Forms.PictureBox()
        Me.picLength = New System.Windows.Forms.PictureBox()
        Me.lblNumIterations = New System.Windows.Forms.Label()
        Me.lblStringLength = New System.Windows.Forms.Label()
        Me.lstGenerate = New System.Windows.Forms.ListBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.grpStatistics = New System.Windows.Forms.GroupBox()
        Me.lstStatistics = New System.Windows.Forms.ListBox()
        Me.ctxStats = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnCopy2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFind2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDeselect2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxLog = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnSaveAsLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxGenerate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDeselect = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmeGenerate = New System.Windows.Forms.Timer(Me.components)
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.nfyMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ctxIconTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnOpenStrGen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSleep = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGenerateString = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnReportBug = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCtxSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCheckUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsStrGen = New System.Windows.Forms.StatusStrip()
        Me.lblThread = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlStrGen = New System.Windows.Forms.Panel()
        Me.strMain.SuspendLayout()
        Me.grpGenerate.SuspendLayout()
        CType(Me.picNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStatistics.SuspendLayout()
        Me.ctxStats.SuspendLayout()
        Me.ctxLog.SuspendLayout()
        Me.ctxGenerate.SuspendLayout()
        Me.ctxIconTray.SuspendLayout()
        Me.stsStrGen.SuspendLayout()
        Me.pnlStrGen.SuspendLayout()
        Me.SuspendLayout()
        '
        'strMain
        '
        Me.strMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.strMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFile, Me.sep1, Me.btnEdit, Me.sep2, Me.btnCharacters, Me.btnSettings, Me.sep4, Me.btnCheckForUpdates, Me.sep3, Me.btnView})
        Me.strMain.Location = New System.Drawing.Point(0, 0)
        Me.strMain.Name = "strMain"
        Me.strMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.strMain.Size = New System.Drawing.Size(684, 25)
        Me.strMain.TabIndex = 0
        Me.strMain.Text = "Main Toolstrip"
        '
        'btnFile
        '
        Me.btnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAutoGenerate, Me.btnDictionary, Me.btnFindString, Me.btnSearch, Me.btnGenerateLog, Me.btnSettings2, Me.btnDeveloperMode, Me.btnReport})
        Me.btnFile.Image = CType(resources.GetObject("btnFile.Image"), System.Drawing.Image)
        Me.btnFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(54, 22)
        Me.btnFile.Text = "File"
        '
        'btnAutoGenerate
        '
        Me.btnAutoGenerate.Image = Global.RSG.My.Resources.Resources.stringRun
        Me.btnAutoGenerate.Name = "btnAutoGenerate"
        Me.btnAutoGenerate.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.btnAutoGenerate.Size = New System.Drawing.Size(271, 22)
        Me.btnAutoGenerate.Text = "Auto Generate"
        '
        'btnDictionary
        '
        Me.btnDictionary.Image = Global.RSG.My.Resources.Resources.stringDictionary
        Me.btnDictionary.Name = "btnDictionary"
        Me.btnDictionary.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.btnDictionary.Size = New System.Drawing.Size(271, 22)
        Me.btnDictionary.Text = "Dictionary"
        '
        'btnFindString
        '
        Me.btnFindString.Image = Global.RSG.My.Resources.Resources.stringFind
        Me.btnFindString.Name = "btnFindString"
        Me.btnFindString.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.btnFindString.Size = New System.Drawing.Size(271, 22)
        Me.btnFindString.Text = "Find String"
        Me.btnFindString.ToolTipText = "Find a specific string in an existing generated string collection"
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.RSG.My.Resources.Resources.stringSearch
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.btnSearch.Size = New System.Drawing.Size(271, 22)
        Me.btnSearch.Text = "Search Specific String"
        Me.btnSearch.ToolTipText = "Search and iterate until the string is found using brute force"
        '
        'btnGenerateLog
        '
        Me.btnGenerateLog.Image = Global.RSG.My.Resources.Resources.stringLogFile
        Me.btnGenerateLog.Name = "btnGenerateLog"
        Me.btnGenerateLog.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.btnGenerateLog.Size = New System.Drawing.Size(271, 22)
        Me.btnGenerateLog.Text = "Generate Log File"
        Me.btnGenerateLog.ToolTipText = "Generate a log file"
        '
        'btnSettings2
        '
        Me.btnSettings2.Image = Global.RSG.My.Resources.Resources.stringSettings
        Me.btnSettings2.Name = "btnSettings2"
        Me.btnSettings2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.btnSettings2.Size = New System.Drawing.Size(271, 22)
        Me.btnSettings2.Text = "Settings"
        '
        'btnDeveloperMode
        '
        Me.btnDeveloperMode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeveloperMode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeveloperMode.Image = Global.RSG.My.Resources.Resources.stringLogo
        Me.btnDeveloperMode.Name = "btnDeveloperMode"
        Me.btnDeveloperMode.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.btnDeveloperMode.Size = New System.Drawing.Size(271, 22)
        Me.btnDeveloperMode.Text = "Developer Mode"
        Me.btnDeveloperMode.ToolTipText = "--Requires Developer--"
        '
        'btnReport
        '
        Me.btnReport.Image = Global.RSG.My.Resources.Resources.stringCritical
        Me.btnReport.Name = "btnReport"
        Me.btnReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.btnReport.Size = New System.Drawing.Size(271, 22)
        Me.btnReport.Text = "Report a Bug"
        '
        'sep1
        '
        Me.sep1.Name = "sep1"
        Me.sep1.Size = New System.Drawing.Size(6, 25)
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnStringLength, Me.btnIterations, Me.btnRandomizationMethod, Me.btnAnimateMin, Me.btnAnimateMax})
        Me.btnEdit.Image = Global.RSG.My.Resources.Resources.stringEdit
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(56, 22)
        Me.btnEdit.Text = "Edit"
        '
        'btnStringLength
        '
        Me.btnStringLength.Image = Global.RSG.My.Resources.Resources.stringLength
        Me.btnStringLength.Name = "btnStringLength"
        Me.btnStringLength.Size = New System.Drawing.Size(199, 22)
        Me.btnStringLength.Text = "String Length"
        Me.btnStringLength.ToolTipText = "Edit the string length"
        '
        'btnIterations
        '
        Me.btnIterations.Image = Global.RSG.My.Resources.Resources.stringNum
        Me.btnIterations.Name = "btnIterations"
        Me.btnIterations.Size = New System.Drawing.Size(199, 22)
        Me.btnIterations.Text = "Iterations"
        Me.btnIterations.ToolTipText = "Edit the # of iterations"
        '
        'btnRandomizationMethod
        '
        Me.btnRandomizationMethod.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPseudoRandom, Me.btnReapRandom})
        Me.btnRandomizationMethod.Image = Global.RSG.My.Resources.Resources.stringRandom
        Me.btnRandomizationMethod.Name = "btnRandomizationMethod"
        Me.btnRandomizationMethod.Size = New System.Drawing.Size(199, 22)
        Me.btnRandomizationMethod.Text = "Randomization Method"
        Me.btnRandomizationMethod.ToolTipText = "Randomization method for string generation"
        '
        'btnPseudoRandom
        '
        Me.btnPseudoRandom.Image = Global.RSG.My.Resources.Resources.stringRandom
        Me.btnPseudoRandom.Name = "btnPseudoRandom"
        Me.btnPseudoRandom.Size = New System.Drawing.Size(155, 22)
        Me.btnPseudoRandom.Text = "Pseudorandom"
        '
        'btnReapRandom
        '
        Me.btnReapRandom.Image = Global.RSG.My.Resources.Resources.stringReap
        Me.btnReapRandom.Name = "btnReapRandom"
        Me.btnReapRandom.Size = New System.Drawing.Size(155, 22)
        Me.btnReapRandom.Text = "Reap-random"
        '
        'btnAnimateMin
        '
        Me.btnAnimateMin.Image = Global.RSG.My.Resources.Resources.stringInterval
        Me.btnAnimateMin.Name = "btnAnimateMin"
        Me.btnAnimateMin.Size = New System.Drawing.Size(199, 22)
        Me.btnAnimateMin.Text = "Animate Min Interval: 0"
        '
        'btnAnimateMax
        '
        Me.btnAnimateMax.Image = Global.RSG.My.Resources.Resources.stringInterval
        Me.btnAnimateMax.Name = "btnAnimateMax"
        Me.btnAnimateMax.Size = New System.Drawing.Size(199, 22)
        Me.btnAnimateMax.Text = "Animate Max Interval: 0"
        '
        'sep2
        '
        Me.sep2.Name = "sep2"
        Me.sep2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCharacters
        '
        Me.btnCharacters.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnUppercase, Me.btnLowercase, Me.btnNum, Me.btnSymb, Me.btnDispChar, Me.btnAddChar, Me.btnRemChar, Me.btnSetChar, Me.btnResetChar})
        Me.btnCharacters.Image = Global.RSG.My.Resources.Resources.stringUppercase
        Me.btnCharacters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCharacters.Name = "btnCharacters"
        Me.btnCharacters.Size = New System.Drawing.Size(92, 22)
        Me.btnCharacters.Text = "Characters"
        '
        'btnUppercase
        '
        Me.btnUppercase.Checked = True
        Me.btnUppercase.CheckOnClick = True
        Me.btnUppercase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnUppercase.Image = Global.RSG.My.Resources.Resources.stringUppercase
        Me.btnUppercase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUppercase.Name = "btnUppercase"
        Me.btnUppercase.Size = New System.Drawing.Size(195, 22)
        Me.btnUppercase.Text = "Uppercase letters (A-Z)"
        '
        'btnLowercase
        '
        Me.btnLowercase.CheckOnClick = True
        Me.btnLowercase.Image = Global.RSG.My.Resources.Resources.stringLowercase
        Me.btnLowercase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLowercase.Name = "btnLowercase"
        Me.btnLowercase.Size = New System.Drawing.Size(195, 22)
        Me.btnLowercase.Text = "Lowercase letters (a-z)"
        '
        'btnNum
        '
        Me.btnNum.Checked = True
        Me.btnNum.CheckOnClick = True
        Me.btnNum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnNum.Image = Global.RSG.My.Resources.Resources.stringNum
        Me.btnNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNum.Name = "btnNum"
        Me.btnNum.Size = New System.Drawing.Size(195, 22)
        Me.btnNum.Text = "Numbers (0-9)"
        '
        'btnSymb
        '
        Me.btnSymb.CheckOnClick = True
        Me.btnSymb.Image = Global.RSG.My.Resources.Resources.stringSymbols
        Me.btnSymb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSymb.Name = "btnSymb"
        Me.btnSymb.Size = New System.Drawing.Size(195, 22)
        Me.btnSymb.Text = "Symbols ( .,?!)"
        '
        'btnDispChar
        '
        Me.btnDispChar.Image = Global.RSG.My.Resources.Resources.stringDisplay
        Me.btnDispChar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDispChar.Name = "btnDispChar"
        Me.btnDispChar.Size = New System.Drawing.Size(195, 22)
        Me.btnDispChar.Text = "Display Character List"
        '
        'btnAddChar
        '
        Me.btnAddChar.Image = Global.RSG.My.Resources.Resources.stringAdd
        Me.btnAddChar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddChar.Name = "btnAddChar"
        Me.btnAddChar.Size = New System.Drawing.Size(195, 22)
        Me.btnAddChar.Text = "Add characters"
        '
        'btnRemChar
        '
        Me.btnRemChar.Image = Global.RSG.My.Resources.Resources.stringRemove
        Me.btnRemChar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemChar.Name = "btnRemChar"
        Me.btnRemChar.Size = New System.Drawing.Size(195, 22)
        Me.btnRemChar.Text = "Remove characters"
        '
        'btnSetChar
        '
        Me.btnSetChar.Image = Global.RSG.My.Resources.Resources.stringSet
        Me.btnSetChar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetChar.Name = "btnSetChar"
        Me.btnSetChar.Size = New System.Drawing.Size(195, 22)
        Me.btnSetChar.Text = "Set characters"
        '
        'btnResetChar
        '
        Me.btnResetChar.Image = Global.RSG.My.Resources.Resources.stringReset
        Me.btnResetChar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResetChar.Name = "btnResetChar"
        Me.btnResetChar.Size = New System.Drawing.Size(195, 22)
        Me.btnResetChar.Text = "Reset characters"
        '
        'btnSettings
        '
        Me.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSettings.Image = Global.RSG.My.Resources.Resources.stringSettings
        Me.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(23, 22)
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.ToolTipText = "Display the settings window"
        '
        'sep4
        '
        Me.sep4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.sep4.Name = "sep4"
        Me.sep4.Size = New System.Drawing.Size(6, 25)
        '
        'btnCheckForUpdates
        '
        Me.btnCheckForUpdates.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCheckForUpdates.Image = Global.RSG.My.Resources.Resources.stringUpdate
        Me.btnCheckForUpdates.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheckForUpdates.Name = "btnCheckForUpdates"
        Me.btnCheckForUpdates.Size = New System.Drawing.Size(106, 22)
        Me.btnCheckForUpdates.Text = "Check Updates"
        Me.btnCheckForUpdates.ToolTipText = "Check for updates!"
        '
        'sep3
        '
        Me.sep3.Name = "sep3"
        Me.sep3.Size = New System.Drawing.Size(6, 25)
        '
        'btnView
        '
        Me.btnView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnShowStatistics, Me.btnShowStatus, Me.btnHelp})
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(61, 22)
        Me.btnView.Text = "View"
        '
        'btnShowStatistics
        '
        Me.btnShowStatistics.Image = Global.RSG.My.Resources.Resources.stringEye
        Me.btnShowStatistics.Name = "btnShowStatistics"
        Me.btnShowStatistics.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.btnShowStatistics.Size = New System.Drawing.Size(237, 22)
        Me.btnShowStatistics.Text = "Show/Hide Statistics"
        Me.btnShowStatistics.ToolTipText = "Show/Hide statistical information regarding the string(s)"
        '
        'btnShowStatus
        '
        Me.btnShowStatus.Image = Global.RSG.My.Resources.Resources.stringSet
        Me.btnShowStatus.Name = "btnShowStatus"
        Me.btnShowStatus.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.btnShowStatus.Size = New System.Drawing.Size(237, 22)
        Me.btnShowStatus.Text = "Show/Hide Status Bar"
        Me.btnShowStatus.ToolTipText = "A status bar showing process information on RSG and updates randomly with the ran" &
    "dom scrolling generate string button."
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.RSG.My.Resources.Resources.stringQuestion
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.btnHelp.Size = New System.Drawing.Size(237, 22)
        Me.btnHelp.Text = "Help"
        Me.btnHelp.ToolTipText = "Help wizard of RSG."
        '
        'grpGenerate
        '
        Me.grpGenerate.Controls.Add(Me.fntTitle)
        Me.grpGenerate.Controls.Add(Me.picNum)
        Me.grpGenerate.Controls.Add(Me.picLength)
        Me.grpGenerate.Controls.Add(Me.lblNumIterations)
        Me.grpGenerate.Controls.Add(Me.lblStringLength)
        Me.grpGenerate.Controls.Add(Me.lstGenerate)
        Me.grpGenerate.Controls.Add(Me.btnGenerate)
        Me.grpGenerate.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpGenerate.Location = New System.Drawing.Point(0, 0)
        Me.grpGenerate.Name = "grpGenerate"
        Me.grpGenerate.Size = New System.Drawing.Size(323, 351)
        Me.grpGenerate.TabIndex = 1
        Me.grpGenerate.TabStop = False
        Me.grpGenerate.Text = "Generate String:"
        '
        'fntTitle
        '
        Me.fntTitle.AutoSize = True
        Me.fntTitle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fntTitle.Location = New System.Drawing.Point(252, 16)
        Me.fntTitle.Name = "fntTitle"
        Me.fntTitle.Size = New System.Drawing.Size(68, 13)
        Me.fntTitle.TabIndex = 14
        Me.fntTitle.Text = "Font Preview"
        Me.fntTitle.Visible = False
        '
        'picNum
        '
        Me.picNum.BackgroundImage = Global.RSG.My.Resources.Resources.stringNum
        Me.picNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picNum.Location = New System.Drawing.Point(6, 42)
        Me.picNum.Name = "picNum"
        Me.picNum.Size = New System.Drawing.Size(16, 16)
        Me.picNum.TabIndex = 11
        Me.picNum.TabStop = False
        '
        'picLength
        '
        Me.picLength.BackgroundImage = Global.RSG.My.Resources.Resources.stringLength
        Me.picLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLength.Location = New System.Drawing.Point(6, 19)
        Me.picLength.Name = "picLength"
        Me.picLength.Size = New System.Drawing.Size(16, 16)
        Me.picLength.TabIndex = 10
        Me.picLength.TabStop = False
        '
        'lblNumIterations
        '
        Me.lblNumIterations.AutoSize = True
        Me.lblNumIterations.Location = New System.Drawing.Point(28, 45)
        Me.lblNumIterations.Name = "lblNumIterations"
        Me.lblNumIterations.Size = New System.Drawing.Size(53, 13)
        Me.lblNumIterations.TabIndex = 9
        Me.lblNumIterations.Text = "Iterations:"
        Me.tipHelp.SetToolTip(Me.lblNumIterations, "Scroll to inc/dec the length or click to change it manually.")
        '
        'lblStringLength
        '
        Me.lblStringLength.AutoSize = True
        Me.lblStringLength.Location = New System.Drawing.Point(28, 22)
        Me.lblStringLength.Name = "lblStringLength"
        Me.lblStringLength.Size = New System.Drawing.Size(73, 13)
        Me.lblStringLength.TabIndex = 8
        Me.lblStringLength.Text = "String Length:"
        Me.tipHelp.SetToolTip(Me.lblStringLength, "Scroll to inc/dec the length or click to change it manually.")
        '
        'lstGenerate
        '
        Me.lstGenerate.BackColor = System.Drawing.Color.White
        Me.lstGenerate.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGenerate.FormattingEnabled = True
        Me.lstGenerate.HorizontalScrollbar = True
        Me.lstGenerate.ItemHeight = 12
        Me.lstGenerate.Location = New System.Drawing.Point(6, 70)
        Me.lstGenerate.Name = "lstGenerate"
        Me.lstGenerate.Size = New System.Drawing.Size(311, 244)
        Me.lstGenerate.TabIndex = 7
        '
        'btnGenerate
        '
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerate.Location = New System.Drawing.Point(3, 325)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(317, 23)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate new random string(s)..."
        Me.tipHelp.SetToolTip(Me.btnGenerate, "Generate...")
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'grpStatistics
        '
        Me.grpStatistics.Controls.Add(Me.lstStatistics)
        Me.grpStatistics.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpStatistics.Location = New System.Drawing.Point(326, 0)
        Me.grpStatistics.Name = "grpStatistics"
        Me.grpStatistics.Size = New System.Drawing.Size(358, 351)
        Me.grpStatistics.TabIndex = 2
        Me.grpStatistics.TabStop = False
        Me.grpStatistics.Text = "Statistics:"
        '
        'lstStatistics
        '
        Me.lstStatistics.BackColor = System.Drawing.Color.White
        Me.lstStatistics.ContextMenuStrip = Me.ctxStats
        Me.lstStatistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstStatistics.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStatistics.FormattingEnabled = True
        Me.lstStatistics.HorizontalScrollbar = True
        Me.lstStatistics.ItemHeight = 12
        Me.lstStatistics.Location = New System.Drawing.Point(3, 16)
        Me.lstStatistics.Name = "lstStatistics"
        Me.lstStatistics.Size = New System.Drawing.Size(352, 332)
        Me.lstStatistics.TabIndex = 0
        '
        'ctxStats
        '
        Me.ctxStats.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCopy2, Me.btnFind2, Me.btnDeselect2})
        Me.ctxStats.Name = "ctxGenerate"
        Me.ctxStats.Size = New System.Drawing.Size(202, 70)
        '
        'btnCopy2
        '
        Me.btnCopy2.Image = Global.RSG.My.Resources.Resources.stringCopy
        Me.btnCopy2.Name = "btnCopy2"
        Me.btnCopy2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.btnCopy2.Size = New System.Drawing.Size(201, 22)
        Me.btnCopy2.Text = "Copy"
        '
        'btnFind2
        '
        Me.btnFind2.Image = Global.RSG.My.Resources.Resources.stringFind
        Me.btnFind2.Name = "btnFind2"
        Me.btnFind2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.btnFind2.Size = New System.Drawing.Size(201, 22)
        Me.btnFind2.Text = "Find"
        '
        'btnDeselect2
        '
        Me.btnDeselect2.Image = Global.RSG.My.Resources.Resources.stringClose
        Me.btnDeselect2.Name = "btnDeselect2"
        Me.btnDeselect2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.btnDeselect2.Size = New System.Drawing.Size(201, 22)
        Me.btnDeselect2.Text = "Deselect"
        Me.btnDeselect2.ToolTipText = "Deselect a selected item"
        '
        'ctxLog
        '
        Me.ctxLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSaveAsLog})
        Me.ctxLog.Name = "ctxLog"
        Me.ctxLog.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ctxLog.Size = New System.Drawing.Size(124, 26)
        '
        'btnSaveAsLog
        '
        Me.btnSaveAsLog.Image = Global.RSG.My.Resources.Resources.stringNew
        Me.btnSaveAsLog.Name = "btnSaveAsLog"
        Me.btnSaveAsLog.Size = New System.Drawing.Size(123, 22)
        Me.btnSaveAsLog.Text = "Save As..."
        '
        'ctxGenerate
        '
        Me.ctxGenerate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCopy, Me.btnFind, Me.btnDeselect})
        Me.ctxGenerate.Name = "ctxGenerate"
        Me.ctxGenerate.Size = New System.Drawing.Size(170, 70)
        '
        'btnCopy
        '
        Me.btnCopy.Image = Global.RSG.My.Resources.Resources.stringCopy
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.btnCopy.Size = New System.Drawing.Size(169, 22)
        Me.btnCopy.Text = "Copy"
        '
        'btnFind
        '
        Me.btnFind.Image = Global.RSG.My.Resources.Resources.stringFind
        Me.btnFind.Name = "btnFind"
        Me.btnFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.btnFind.Size = New System.Drawing.Size(169, 22)
        Me.btnFind.Text = "Find"
        '
        'btnDeselect
        '
        Me.btnDeselect.Image = Global.RSG.My.Resources.Resources.stringClose
        Me.btnDeselect.Name = "btnDeselect"
        Me.btnDeselect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.btnDeselect.Size = New System.Drawing.Size(169, 22)
        Me.btnDeselect.Text = "Deselect"
        Me.btnDeselect.ToolTipText = "Deselect a selected item"
        '
        'tmeGenerate
        '
        '
        'tipHelp
        '
        Me.tipHelp.AutomaticDelay = 1000
        Me.tipHelp.AutoPopDelay = 10000
        Me.tipHelp.InitialDelay = 0
        Me.tipHelp.IsBalloon = True
        Me.tipHelp.ReshowDelay = 200
        '
        'nfyMain
        '
        Me.nfyMain.BalloonTipTitle = "Random String Generator"
        Me.nfyMain.ContextMenuStrip = Me.ctxIconTray
        Me.nfyMain.Icon = CType(resources.GetObject("nfyMain.Icon"), System.Drawing.Icon)
        Me.nfyMain.Text = "Random String Generator"
        Me.nfyMain.Visible = True
        '
        'ctxIconTray
        '
        Me.ctxIconTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpenStrGen, Me.ToolStripSeparator10, Me.btnSleep, Me.btnGenerateString, Me.ToolStripSeparator11, Me.btnReportBug, Me.ToolStripSeparator12, Me.btnCtxSettings, Me.btnCheckUpdates, Me.btnExit})
        Me.ctxIconTray.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ctxIconTray.Name = "ctxIconTray"
        Me.ctxIconTray.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ctxIconTray.Size = New System.Drawing.Size(241, 176)
        '
        'btnOpenStrGen
        '
        Me.btnOpenStrGen.Image = Global.RSG.My.Resources.Resources.stringLogo
        Me.btnOpenStrGen.Name = "btnOpenStrGen"
        Me.btnOpenStrGen.Size = New System.Drawing.Size(240, 22)
        Me.btnOpenStrGen.Text = "Open Random String Generator"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(237, 6)
        '
        'btnSleep
        '
        Me.btnSleep.Image = Global.RSG.My.Resources.Resources.stringReset
        Me.btnSleep.Name = "btnSleep"
        Me.btnSleep.Size = New System.Drawing.Size(240, 22)
        Me.btnSleep.Text = "Sleep"
        Me.btnSleep.ToolTipText = " "
        '
        'btnGenerateString
        '
        Me.btnGenerateString.Image = Global.RSG.My.Resources.Resources.stringLogo
        Me.btnGenerateString.Name = "btnGenerateString"
        Me.btnGenerateString.Size = New System.Drawing.Size(240, 22)
        Me.btnGenerateString.Text = "Generate string..."
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(237, 6)
        '
        'btnReportBug
        '
        Me.btnReportBug.Name = "btnReportBug"
        Me.btnReportBug.Size = New System.Drawing.Size(240, 22)
        Me.btnReportBug.Text = "Report a bug"
        Me.btnReportBug.ToolTipText = "Send me an email regarding a bug."
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(237, 6)
        '
        'btnCtxSettings
        '
        Me.btnCtxSettings.Image = Global.RSG.My.Resources.Resources.stringSettings
        Me.btnCtxSettings.Name = "btnCtxSettings"
        Me.btnCtxSettings.Size = New System.Drawing.Size(240, 22)
        Me.btnCtxSettings.Text = "Settings"
        '
        'btnCheckUpdates
        '
        Me.btnCheckUpdates.Image = Global.RSG.My.Resources.Resources.stringUpdate
        Me.btnCheckUpdates.Name = "btnCheckUpdates"
        Me.btnCheckUpdates.Size = New System.Drawing.Size(240, 22)
        Me.btnCheckUpdates.Text = "Check for updates"
        '
        'btnExit
        '
        Me.btnExit.Image = Global.RSG.My.Resources.Resources.stringClose
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(240, 22)
        Me.btnExit.Text = "Exit"
        Me.btnExit.ToolTipText = "Close RSG"
        '
        'stsStrGen
        '
        Me.stsStrGen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblThread})
        Me.stsStrGen.Location = New System.Drawing.Point(0, 359)
        Me.stsStrGen.Name = "stsStrGen"
        Me.stsStrGen.Size = New System.Drawing.Size(684, 22)
        Me.stsStrGen.SizingGrip = False
        Me.stsStrGen.TabIndex = 3
        Me.stsStrGen.Text = "Thread Info:"
        '
        'lblThread
        '
        Me.lblThread.Name = "lblThread"
        Me.lblThread.Size = New System.Drawing.Size(47, 17)
        Me.lblThread.Text = "Thread:"
        Me.lblThread.ToolTipText = "All information updates randomly with the animated button text"
        '
        'pnlStrGen
        '
        Me.pnlStrGen.Controls.Add(Me.grpGenerate)
        Me.pnlStrGen.Controls.Add(Me.grpStatistics)
        Me.pnlStrGen.Location = New System.Drawing.Point(0, 28)
        Me.pnlStrGen.Name = "pnlStrGen"
        Me.pnlStrGen.Size = New System.Drawing.Size(684, 351)
        Me.pnlStrGen.TabIndex = 12
        '
        'frmStringGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(684, 381)
        Me.Controls.Add(Me.stsStrGen)
        Me.Controls.Add(Me.pnlStrGen)
        Me.Controls.Add(Me.strMain)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmStringGen"
        Me.Text = "Random String Generator"
        Me.strMain.ResumeLayout(False)
        Me.strMain.PerformLayout()
        Me.grpGenerate.ResumeLayout(False)
        Me.grpGenerate.PerformLayout()
        CType(Me.picNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStatistics.ResumeLayout(False)
        Me.ctxStats.ResumeLayout(False)
        Me.ctxLog.ResumeLayout(False)
        Me.ctxGenerate.ResumeLayout(False)
        Me.ctxIconTray.ResumeLayout(False)
        Me.stsStrGen.ResumeLayout(False)
        Me.stsStrGen.PerformLayout()
        Me.pnlStrGen.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents strMain As ToolStrip
    Friend WithEvents btnEdit As ToolStripDropDownButton
    Friend WithEvents sep2 As ToolStripSeparator
    Friend WithEvents btnView As ToolStripDropDownButton
    Friend WithEvents btnFile As ToolStripDropDownButton
    Friend WithEvents sep1 As ToolStripSeparator
    Friend WithEvents sep4 As ToolStripSeparator
    Friend WithEvents btnShowStatistics As ToolStripMenuItem
    Friend WithEvents btnStringLength As ToolStripMenuItem
    Friend WithEvents btnIterations As ToolStripMenuItem
    Friend WithEvents btnGenerateLog As ToolStripMenuItem
    Friend WithEvents btnSearch As ToolStripMenuItem
    Friend WithEvents btnRandomizationMethod As ToolStripMenuItem
    Friend WithEvents btnPseudoRandom As ToolStripMenuItem
    Friend WithEvents btnReapRandom As ToolStripMenuItem
    Friend WithEvents btnDeveloperMode As ToolStripMenuItem
    Friend WithEvents btnFindString As ToolStripMenuItem
    Friend WithEvents btnSettings As ToolStripButton
    Friend WithEvents grpGenerate As GroupBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents grpStatistics As GroupBox
    Friend WithEvents tmeGenerate As Timer
    Friend WithEvents lstGenerate As ListBox
    Friend WithEvents lblNumIterations As Label
    Friend WithEvents lblStringLength As Label
    Friend WithEvents picNum As PictureBox
    Friend WithEvents picLength As PictureBox
    Friend WithEvents lstStatistics As ListBox
    Friend WithEvents ctxGenerate As ContextMenuStrip
    Friend WithEvents btnCopy As ToolStripMenuItem
    Friend WithEvents btnFind As ToolStripMenuItem
    Friend WithEvents tipHelp As ToolTip
    Friend WithEvents btnAnimateMin As ToolStripMenuItem
    Friend WithEvents btnAnimateMax As ToolStripMenuItem
    Friend WithEvents btnAutoGenerate As ToolStripMenuItem
    Friend WithEvents nfyMain As NotifyIcon
    Friend WithEvents ctxIconTray As ContextMenuStrip
    Friend WithEvents btnOpenStrGen As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents btnSleep As ToolStripMenuItem
    Friend WithEvents btnGenerateString As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents btnReportBug As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents btnCtxSettings As ToolStripMenuItem
    Friend WithEvents btnCheckUpdates As ToolStripMenuItem
    Friend WithEvents btnExit As ToolStripMenuItem
    Friend WithEvents btnHelp As ToolStripMenuItem
    Friend WithEvents ctxLog As ContextMenuStrip
    Friend WithEvents btnSaveAsLog As ToolStripMenuItem
    Friend WithEvents btnCheckForUpdates As ToolStripButton
    Friend WithEvents btnDeselect As ToolStripMenuItem
    Friend WithEvents btnDictionary As ToolStripMenuItem
    Friend WithEvents stsStrGen As StatusStrip
    Friend WithEvents pnlStrGen As Panel
    Friend WithEvents lblThread As ToolStripStatusLabel
    Friend WithEvents btnShowStatus As ToolStripMenuItem
    Friend WithEvents fntTitle As Label
    Friend WithEvents btnSettings2 As ToolStripMenuItem
    Friend WithEvents ctxStats As ContextMenuStrip
    Friend WithEvents btnCopy2 As ToolStripMenuItem
    Friend WithEvents btnFind2 As ToolStripMenuItem
    Friend WithEvents btnDeselect2 As ToolStripMenuItem
    Friend WithEvents btnCharacters As ToolStripDropDownButton
    Friend WithEvents sep3 As ToolStripSeparator
    Friend WithEvents btnUppercase As ToolStripMenuItem
    Friend WithEvents btnLowercase As ToolStripMenuItem
    Friend WithEvents btnNum As ToolStripMenuItem
    Friend WithEvents btnSymb As ToolStripMenuItem
    Friend WithEvents btnDispChar As ToolStripMenuItem
    Friend WithEvents btnAddChar As ToolStripMenuItem
    Friend WithEvents btnRemChar As ToolStripMenuItem
    Friend WithEvents btnSetChar As ToolStripMenuItem
    Friend WithEvents btnResetChar As ToolStripMenuItem
    Friend WithEvents btnReport As ToolStripMenuItem
End Class

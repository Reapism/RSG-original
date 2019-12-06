<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDictionary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDictionary))
        Me.grpSettings = New System.Windows.Forms.GroupBox()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.picAction = New System.Windows.Forms.PictureBox()
        Me.cmbAction = New System.Windows.Forms.ComboBox()
        Me.picOutput = New System.Windows.Forms.PictureBox()
        Me.picLength = New System.Windows.Forms.PictureBox()
        Me.cmbWordList = New System.Windows.Forms.ComboBox()
        Me.txtNumWords = New System.Windows.Forms.TextBox()
        Me.grpRnd = New System.Windows.Forms.GroupBox()
        Me.picReapRnd = New System.Windows.Forms.PictureBox()
        Me.picPseudo = New System.Windows.Forms.PictureBox()
        Me.radReap = New System.Windows.Forms.RadioButton()
        Me.radPseudo = New System.Windows.Forms.RadioButton()
        Me.grpProperties = New System.Windows.Forms.GroupBox()
        Me.chkShowHeavy = New System.Windows.Forms.CheckBox()
        Me.picEdit = New System.Windows.Forms.PictureBox()
        Me.chkThread = New System.Windows.Forms.CheckBox()
        Me.chkUseAlliteration = New System.Windows.Forms.CheckBox()
        Me.chkDispStats = New System.Windows.Forms.CheckBox()
        Me.chkFirstLetterUp = New System.Windows.Forms.CheckBox()
        Me.picSettings = New System.Windows.Forms.PictureBox()
        Me.chkUseSpace = New System.Windows.Forms.CheckBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.chkUsePunc = New System.Windows.Forms.CheckBox()
        Me.chkUseNoise = New System.Windows.Forms.CheckBox()
        Me.barProgress = New System.Windows.Forms.ProgressBar()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.ctxDict = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExportLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLMGTFY = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGoogle = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDictInfo = New System.Windows.Forms.RichTextBox()
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.tsFirstTime = New System.Windows.Forms.ToolStrip()
        Me.lblInfo = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.barDownload = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblChooseDir = New System.Windows.Forms.ToolStripLabel()
        Me.tmeFlash = New System.Windows.Forms.Timer(Me.components)
        Me.bgwDownload = New System.ComponentModel.BackgroundWorker()
        Me.bgThread = New System.ComponentModel.BackgroundWorker()
        Me.grpSettings.SuspendLayout()
        CType(Me.picAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRnd.SuspendLayout()
        CType(Me.picReapRnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPseudo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProperties.SuspendLayout()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDisplay.SuspendLayout()
        Me.ctxDict.SuspendLayout()
        Me.tsFirstTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSettings
        '
        Me.grpSettings.Controls.Add(Me.btnAction)
        Me.grpSettings.Controls.Add(Me.picAction)
        Me.grpSettings.Controls.Add(Me.cmbAction)
        Me.grpSettings.Controls.Add(Me.picOutput)
        Me.grpSettings.Controls.Add(Me.picLength)
        Me.grpSettings.Controls.Add(Me.cmbWordList)
        Me.grpSettings.Controls.Add(Me.txtNumWords)
        Me.grpSettings.Location = New System.Drawing.Point(0, 25)
        Me.grpSettings.Name = "grpSettings"
        Me.grpSettings.Size = New System.Drawing.Size(297, 131)
        Me.grpSettings.TabIndex = 0
        Me.grpSettings.TabStop = False
        Me.grpSettings.Text = "Dictionary settings:"
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(6, 99)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(285, 23)
        Me.btnAction.TabIndex = 24
        Me.btnAction.UseVisualStyleBackColor = True
        '
        'picAction
        '
        Me.picAction.BackgroundImage = Global.RSG.My.Resources.Resources.stringRun
        Me.picAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAction.Location = New System.Drawing.Point(6, 72)
        Me.picAction.Name = "picAction"
        Me.picAction.Size = New System.Drawing.Size(20, 21)
        Me.picAction.TabIndex = 23
        Me.picAction.TabStop = False
        '
        'cmbAction
        '
        Me.cmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAction.FormattingEnabled = True
        Me.cmbAction.Items.AddRange(New Object() {"Optional select an action...", "Add a dictionary", "Remove a dictionary", "Generate a log-file for this instance", "View default dictionary path", "Set default dictionary path", "Browse online for other dictionaries"})
        Me.cmbAction.Location = New System.Drawing.Point(32, 72)
        Me.cmbAction.Name = "cmbAction"
        Me.cmbAction.Size = New System.Drawing.Size(259, 21)
        Me.cmbAction.TabIndex = 22
        Me.tipHelp.SetToolTip(Me.cmbAction, "Select an action regarding adding or removing dictionaries and other stuff!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'picOutput
        '
        Me.picOutput.BackgroundImage = Global.RSG.My.Resources.Resources.stringDictionary
        Me.picOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picOutput.Location = New System.Drawing.Point(6, 45)
        Me.picOutput.Name = "picOutput"
        Me.picOutput.Size = New System.Drawing.Size(20, 21)
        Me.picOutput.TabIndex = 10
        Me.picOutput.TabStop = False
        '
        'picLength
        '
        Me.picLength.BackgroundImage = Global.RSG.My.Resources.Resources.stringNum
        Me.picLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLength.Location = New System.Drawing.Point(6, 20)
        Me.picLength.Name = "picLength"
        Me.picLength.Size = New System.Drawing.Size(20, 19)
        Me.picLength.TabIndex = 7
        Me.picLength.TabStop = False
        '
        'cmbWordList
        '
        Me.cmbWordList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWordList.FormattingEnabled = True
        Me.cmbWordList.Location = New System.Drawing.Point(32, 45)
        Me.cmbWordList.Name = "cmbWordList"
        Me.cmbWordList.Size = New System.Drawing.Size(259, 21)
        Me.cmbWordList.TabIndex = 0
        Me.tipHelp.SetToolTip(Me.cmbWordList, "Select a dictionary to use for the generator.")
        '
        'txtNumWords
        '
        Me.txtNumWords.Location = New System.Drawing.Point(32, 19)
        Me.txtNumWords.Name = "txtNumWords"
        Me.txtNumWords.Size = New System.Drawing.Size(259, 20)
        Me.txtNumWords.TabIndex = 1
        Me.txtNumWords.Text = "Number of words: "
        Me.tipHelp.SetToolTip(Me.txtNumWords, "Enter the number of words to generate")
        '
        'grpRnd
        '
        Me.grpRnd.Controls.Add(Me.picReapRnd)
        Me.grpRnd.Controls.Add(Me.picPseudo)
        Me.grpRnd.Controls.Add(Me.radReap)
        Me.grpRnd.Controls.Add(Me.radPseudo)
        Me.grpRnd.Location = New System.Drawing.Point(0, 162)
        Me.grpRnd.Name = "grpRnd"
        Me.grpRnd.Size = New System.Drawing.Size(297, 54)
        Me.grpRnd.TabIndex = 15
        Me.grpRnd.TabStop = False
        Me.grpRnd.Text = "Randomization Method:"
        '
        'picReapRnd
        '
        Me.picReapRnd.BackColor = System.Drawing.Color.Transparent
        Me.picReapRnd.BackgroundImage = Global.RSG.My.Resources.Resources.stringReap
        Me.picReapRnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picReapRnd.Location = New System.Drawing.Point(164, 18)
        Me.picReapRnd.Name = "picReapRnd"
        Me.picReapRnd.Size = New System.Drawing.Size(20, 20)
        Me.picReapRnd.TabIndex = 17
        Me.picReapRnd.TabStop = False
        '
        'picPseudo
        '
        Me.picPseudo.BackColor = System.Drawing.Color.Transparent
        Me.picPseudo.BackgroundImage = Global.RSG.My.Resources.Resources.stringRandom
        Me.picPseudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPseudo.Location = New System.Drawing.Point(6, 17)
        Me.picPseudo.Name = "picPseudo"
        Me.picPseudo.Size = New System.Drawing.Size(20, 20)
        Me.picPseudo.TabIndex = 16
        Me.picPseudo.TabStop = False
        '
        'radReap
        '
        Me.radReap.AutoSize = True
        Me.radReap.Location = New System.Drawing.Point(190, 19)
        Me.radReap.Name = "radReap"
        Me.radReap.Size = New System.Drawing.Size(89, 17)
        Me.radReap.TabIndex = 1
        Me.radReap.TabStop = True
        Me.radReap.Text = "Reap-random"
        Me.tipHelp.SetToolTip(Me.radReap, "Randomize a randomized seed for every iteration.")
        Me.radReap.UseVisualStyleBackColor = True
        '
        'radPseudo
        '
        Me.radPseudo.AutoSize = True
        Me.radPseudo.Location = New System.Drawing.Point(32, 19)
        Me.radPseudo.Name = "radPseudo"
        Me.radPseudo.Size = New System.Drawing.Size(96, 17)
        Me.radPseudo.TabIndex = 0
        Me.radPseudo.TabStop = True
        Me.radPseudo.Text = "Pseudorandom"
        Me.tipHelp.SetToolTip(Me.radPseudo, "Basic randomization.")
        Me.radPseudo.UseVisualStyleBackColor = True
        '
        'grpProperties
        '
        Me.grpProperties.Controls.Add(Me.chkShowHeavy)
        Me.grpProperties.Controls.Add(Me.picEdit)
        Me.grpProperties.Controls.Add(Me.chkThread)
        Me.grpProperties.Controls.Add(Me.chkUseAlliteration)
        Me.grpProperties.Controls.Add(Me.chkDispStats)
        Me.grpProperties.Controls.Add(Me.chkFirstLetterUp)
        Me.grpProperties.Controls.Add(Me.picSettings)
        Me.grpProperties.Controls.Add(Me.chkUseSpace)
        Me.grpProperties.Controls.Add(Me.btnGenerate)
        Me.grpProperties.Controls.Add(Me.chkUsePunc)
        Me.grpProperties.Controls.Add(Me.chkUseNoise)
        Me.grpProperties.Controls.Add(Me.barProgress)
        Me.grpProperties.Location = New System.Drawing.Point(0, 216)
        Me.grpProperties.Name = "grpProperties"
        Me.grpProperties.Size = New System.Drawing.Size(297, 242)
        Me.grpProperties.TabIndex = 16
        Me.grpProperties.TabStop = False
        Me.grpProperties.Text = "Properties:"
        '
        'chkShowHeavy
        '
        Me.chkShowHeavy.AutoSize = True
        Me.chkShowHeavy.Location = New System.Drawing.Point(135, 69)
        Me.chkShowHeavy.Name = "chkShowHeavy"
        Me.chkShowHeavy.Size = New System.Drawing.Size(135, 17)
        Me.chkShowHeavy.TabIndex = 19
        Me.chkShowHeavy.Text = "Display heavy statistics"
        Me.tipHelp.SetToolTip(Me.chkShowHeavy, "Compute very computationally heavy data [more precise statistics].")
        Me.chkShowHeavy.UseVisualStyleBackColor = True
        '
        'picEdit
        '
        Me.picEdit.BackgroundImage = Global.RSG.My.Resources.Resources.stringEdit
        Me.picEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEdit.Location = New System.Drawing.Point(3, 19)
        Me.picEdit.Name = "picEdit"
        Me.picEdit.Size = New System.Drawing.Size(20, 21)
        Me.picEdit.TabIndex = 18
        Me.picEdit.TabStop = False
        '
        'chkThread
        '
        Me.chkThread.AutoSize = True
        Me.chkThread.Location = New System.Drawing.Point(135, 92)
        Me.chkThread.Name = "chkThread"
        Me.chkThread.Size = New System.Drawing.Size(83, 17)
        Me.chkThread.TabIndex = 17
        Me.chkThread.Text = "Thread task"
        Me.tipHelp.SetToolTip(Me.chkThread, "Threads the concurrent operation, if unthreaded, the form will be unresponsive du" &
        "ring generation but faster in its operation.")
        Me.chkThread.UseVisualStyleBackColor = True
        '
        'chkUseAlliteration
        '
        Me.chkUseAlliteration.AutoSize = True
        Me.chkUseAlliteration.Location = New System.Drawing.Point(3, 114)
        Me.chkUseAlliteration.Name = "chkUseAlliteration"
        Me.chkUseAlliteration.Size = New System.Drawing.Size(100, 17)
        Me.chkUseAlliteration.TabIndex = 16
        Me.chkUseAlliteration.Text = "Use alliterations"
        Me.tipHelp.SetToolTip(Me.chkUseAlliteration, "Chooses a random letter to begin each word")
        Me.chkUseAlliteration.UseVisualStyleBackColor = True
        '
        'chkDispStats
        '
        Me.chkDispStats.AutoSize = True
        Me.chkDispStats.Location = New System.Drawing.Point(135, 46)
        Me.chkDispStats.Name = "chkDispStats"
        Me.chkDispStats.Size = New System.Drawing.Size(103, 17)
        Me.chkDispStats.TabIndex = 5
        Me.chkDispStats.Text = "Display statistics"
        Me.tipHelp.SetToolTip(Me.chkDispStats, "Shows hardcore statistics regarding the results." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkDispStats.UseVisualStyleBackColor = True
        '
        'chkFirstLetterUp
        '
        Me.chkFirstLetterUp.AutoSize = True
        Me.chkFirstLetterUp.Location = New System.Drawing.Point(3, 46)
        Me.chkFirstLetterUp.Name = "chkFirstLetterUp"
        Me.chkFirstLetterUp.Size = New System.Drawing.Size(124, 17)
        Me.chkFirstLetterUp.TabIndex = 2
        Me.chkFirstLetterUp.Text = "First letter uppercase"
        Me.tipHelp.SetToolTip(Me.chkFirstLetterUp, "Capitalize the first letter in each word.")
        Me.chkFirstLetterUp.UseVisualStyleBackColor = True
        '
        'picSettings
        '
        Me.picSettings.BackgroundImage = Global.RSG.My.Resources.Resources.stringSettings
        Me.picSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSettings.Location = New System.Drawing.Point(135, 19)
        Me.picSettings.Name = "picSettings"
        Me.picSettings.Size = New System.Drawing.Size(20, 21)
        Me.picSettings.TabIndex = 8
        Me.picSettings.TabStop = False
        '
        'chkUseSpace
        '
        Me.chkUseSpace.AutoSize = True
        Me.chkUseSpace.Location = New System.Drawing.Point(3, 69)
        Me.chkUseSpace.Name = "chkUseSpace"
        Me.chkUseSpace.Size = New System.Drawing.Size(85, 17)
        Me.chkUseSpace.TabIndex = 3
        Me.chkUseSpace.Text = "Use spacing"
        Me.tipHelp.SetToolTip(Me.chkUseSpace, "Adds spaces between each word.")
        Me.chkUseSpace.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnGenerate.Location = New System.Drawing.Point(3, 199)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(291, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate random words with this ruleset"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'chkUsePunc
        '
        Me.chkUsePunc.AutoSize = True
        Me.chkUsePunc.Location = New System.Drawing.Point(3, 92)
        Me.chkUsePunc.Name = "chkUsePunc"
        Me.chkUsePunc.Size = New System.Drawing.Size(104, 17)
        Me.chkUsePunc.TabIndex = 4
        Me.chkUsePunc.Text = "Use punctuation"
        Me.tipHelp.SetToolTip(Me.chkUsePunc, "Randomly append punctuation characters after words. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "30% chance.")
        Me.chkUsePunc.UseVisualStyleBackColor = True
        '
        'chkUseNoise
        '
        Me.chkUseNoise.AutoSize = True
        Me.chkUseNoise.Location = New System.Drawing.Point(3, 137)
        Me.chkUseNoise.Name = "chkUseNoise"
        Me.chkUseNoise.Size = New System.Drawing.Size(73, 17)
        Me.chkUseNoise.TabIndex = 12
        Me.chkUseNoise.Text = "Use noise"
        Me.tipHelp.SetToolTip(Me.chkUseNoise, "Randomly append characters between words and before or after them. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "30% chance.")
        Me.chkUseNoise.UseVisualStyleBackColor = True
        '
        'barProgress
        '
        Me.barProgress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barProgress.Location = New System.Drawing.Point(3, 222)
        Me.barProgress.Name = "barProgress"
        Me.barProgress.Size = New System.Drawing.Size(291, 17)
        Me.barProgress.TabIndex = 20
        Me.barProgress.Visible = False
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.txtOutput)
        Me.grpDisplay.Controls.Add(Me.txtDictInfo)
        Me.grpDisplay.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpDisplay.Location = New System.Drawing.Point(300, 25)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(384, 436)
        Me.grpDisplay.TabIndex = 1
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Statistics and output:"
        '
        'txtOutput
        '
        Me.txtOutput.ContextMenuStrip = Me.ctxDict
        Me.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOutput.Font = New System.Drawing.Font("Lucida Console", 9.0!)
        Me.txtOutput.Location = New System.Drawing.Point(3, 122)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(378, 311)
        Me.txtOutput.TabIndex = 15
        Me.txtOutput.Text = ""
        '
        'ctxDict
        '
        Me.ctxDict.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExport, Me.btnFind, Me.btnSearch, Me.ToolStripSeparator3, Me.btnShow, Me.btnCopy, Me.btnSelectAll})
        Me.ctxDict.Name = "ContextMenuStrip1"
        Me.ctxDict.Size = New System.Drawing.Size(165, 142)
        '
        'btnExport
        '
        Me.btnExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExportLog})
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(164, 22)
        Me.btnExport.Text = "Export..."
        Me.btnExport.ToolTipText = "Export..."
        '
        'btnExportLog
        '
        Me.btnExportLog.Image = Global.RSG.My.Resources.Resources.stringLogFile
        Me.btnExportLog.Name = "btnExportLog"
        Me.btnExportLog.Size = New System.Drawing.Size(94, 22)
        Me.btnExportLog.Text = "Log"
        Me.btnExportLog.ToolTipText = "Export all the information within this box."
        '
        'btnFind
        '
        Me.btnFind.Image = Global.RSG.My.Resources.Resources.stringFind
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(164, 22)
        Me.btnFind.Text = "Find..."
        Me.btnFind.ToolTipText = "Find a specific item." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnSearch
        '
        Me.btnSearch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnLMGTFY, Me.btnGoogle})
        Me.btnSearch.Image = Global.RSG.My.Resources.Resources.stringSearch
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(164, 22)
        Me.btnSearch.Text = "Search..."
        Me.btnSearch.ToolTipText = "Search the web for a word."
        '
        'btnLMGTFY
        '
        Me.btnLMGTFY.Name = "btnLMGTFY"
        Me.btnLMGTFY.Size = New System.Drawing.Size(119, 22)
        Me.btnLMGTFY.Text = "LMGTFY"
        Me.btnLMGTFY.ToolTipText = "Let Me Google That For You"
        '
        'btnGoogle
        '
        Me.btnGoogle.Name = "btnGoogle"
        Me.btnGoogle.Size = New System.Drawing.Size(119, 22)
        Me.btnGoogle.Text = "Google"
        Me.btnGoogle.ToolTipText = "Search with the embedded google dictionary."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(161, 6)
        '
        'btnShow
        '
        Me.btnShow.Image = Global.RSG.My.Resources.Resources.stringEye
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(164, 22)
        Me.btnShow.Text = "Show Menu"
        '
        'btnCopy
        '
        Me.btnCopy.Image = Global.RSG.My.Resources.Resources.stringCopy
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.btnCopy.Size = New System.Drawing.Size(164, 22)
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.ToolTipText = "Copy selection to clipboard"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Image = Global.RSG.My.Resources.Resources.stringSet
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.btnSelectAll.Size = New System.Drawing.Size(164, 22)
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.ToolTipText = "Select all text"
        '
        'txtDictInfo
        '
        Me.txtDictInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDictInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDictInfo.Font = New System.Drawing.Font("Lucida Console", 9.0!)
        Me.txtDictInfo.Location = New System.Drawing.Point(3, 16)
        Me.txtDictInfo.Name = "txtDictInfo"
        Me.txtDictInfo.ReadOnly = True
        Me.txtDictInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtDictInfo.Size = New System.Drawing.Size(378, 106)
        Me.txtDictInfo.TabIndex = 16
        Me.txtDictInfo.Text = ""
        '
        'tipHelp
        '
        Me.tipHelp.BackColor = System.Drawing.Color.LightGray
        Me.tipHelp.IsBalloon = True
        '
        'tsFirstTime
        '
        Me.tsFirstTime.BackColor = System.Drawing.SystemColors.Control
        Me.tsFirstTime.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsFirstTime.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblInfo, Me.ToolStripSeparator1, Me.barDownload, Me.ToolStripSeparator2, Me.lblChooseDir})
        Me.tsFirstTime.Location = New System.Drawing.Point(0, 0)
        Me.tsFirstTime.Name = "tsFirstTime"
        Me.tsFirstTime.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsFirstTime.Size = New System.Drawing.Size(684, 25)
        Me.tsFirstTime.TabIndex = 14
        Me.tsFirstTime.Text = "First Time"
        '
        'lblInfo
        '
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(150, 22)
        Me.lblInfo.Text = "Setting dictionary directory"
        Me.lblInfo.ToolTipText = "Set a default directory for RSG to have jurisdiction in and let RSG download the " &
    "default dictionaries to get you started!"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'barDownload
        '
        Me.barDownload.MarqueeAnimationSpeed = 1
        Me.barDownload.Name = "barDownload"
        Me.barDownload.Size = New System.Drawing.Size(100, 22)
        Me.barDownload.ToolTipText = "Downloading the default dictionaries"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'lblChooseDir
        '
        Me.lblChooseDir.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblChooseDir.Name = "lblChooseDir"
        Me.lblChooseDir.Size = New System.Drawing.Size(137, 22)
        Me.lblChooseDir.Text = "Choose default directory"
        Me.lblChooseDir.ToolTipText = "Click here to download a default "
        '
        'tmeFlash
        '
        Me.tmeFlash.Interval = 500
        '
        'bgThread
        '
        '
        'frmDictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.grpProperties)
        Me.Controls.Add(Me.grpSettings)
        Me.Controls.Add(Me.tsFirstTime)
        Me.Controls.Add(Me.grpRnd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDictionary"
        Me.Text = "Dictionary"
        Me.grpSettings.ResumeLayout(False)
        Me.grpSettings.PerformLayout()
        CType(Me.picAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRnd.ResumeLayout(False)
        Me.grpRnd.PerformLayout()
        CType(Me.picReapRnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPseudo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProperties.ResumeLayout(False)
        Me.grpProperties.PerformLayout()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDisplay.ResumeLayout(False)
        Me.ctxDict.ResumeLayout(False)
        Me.tsFirstTime.ResumeLayout(False)
        Me.tsFirstTime.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSettings As GroupBox
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents picSettings As PictureBox
    Friend WithEvents picLength As PictureBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents cmbWordList As ComboBox
    Friend WithEvents txtNumWords As TextBox
    Friend WithEvents picOutput As PictureBox
    Friend WithEvents ctxDict As ContextMenuStrip
    Friend WithEvents btnExport As ToolStripMenuItem
    Friend WithEvents btnExportLog As ToolStripMenuItem
    Friend WithEvents btnFind As ToolStripMenuItem
    Friend WithEvents btnSearch As ToolStripMenuItem
    Friend WithEvents tipHelp As ToolTip
    Friend WithEvents grpProperties As GroupBox
    Friend WithEvents chkUseAlliteration As CheckBox
    Friend WithEvents chkDispStats As CheckBox
    Friend WithEvents chkFirstLetterUp As CheckBox
    Friend WithEvents chkUseSpace As CheckBox
    Friend WithEvents chkUsePunc As CheckBox
    Friend WithEvents chkUseNoise As CheckBox
    Friend WithEvents tsFirstTime As ToolStrip
    Friend WithEvents lblChooseDir As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents barDownload As ToolStripProgressBar
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents lblInfo As ToolStripLabel
    Friend WithEvents tmeFlash As Timer
    Friend WithEvents bgwDownload As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgThread As System.ComponentModel.BackgroundWorker
    Friend WithEvents chkThread As CheckBox
    Friend WithEvents picEdit As PictureBox
    Friend WithEvents cmbAction As ComboBox
    Friend WithEvents picAction As PictureBox
    Friend WithEvents btnAction As Button
    Friend WithEvents chkShowHeavy As CheckBox
    Friend WithEvents btnLMGTFY As ToolStripMenuItem
    Friend WithEvents btnGoogle As ToolStripMenuItem
    Friend WithEvents btnShow As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnCopy As ToolStripMenuItem
    Friend WithEvents btnSelectAll As ToolStripMenuItem
    Friend WithEvents grpRnd As GroupBox
    Friend WithEvents radReap As RadioButton
    Friend WithEvents radPseudo As RadioButton
    Friend WithEvents picReapRnd As PictureBox
    Friend WithEvents picPseudo As PictureBox
    Friend WithEvents txtOutput As RichTextBox
    Friend WithEvents barProgress As ProgressBar
    Friend WithEvents txtDictInfo As RichTextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.ctxSettings = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.lnkPortfolio = New System.Windows.Forms.LinkLabel()
        Me.txtChangelog = New System.Windows.Forms.TextBox()
        Me.chkGlue = New System.Windows.Forms.CheckBox()
        Me.chkCheckUpdatesOnLoad = New System.Windows.Forms.CheckBox()
        Me.chkUseBigInt = New System.Windows.Forms.CheckBox()
        Me.chkBndStrLgth = New System.Windows.Forms.CheckBox()
        Me.chkCopyToClipboard = New System.Windows.Forms.CheckBox()
        Me.txtStringLength = New System.Windows.Forms.TextBox()
        Me.txtIterations = New System.Windows.Forms.TextBox()
        Me.txtCharacterList = New System.Windows.Forms.TextBox()
        Me.txtAddCharacters = New System.Windows.Forms.TextBox()
        Me.txtRemoveCharacters = New System.Windows.Forms.TextBox()
        Me.cmbLanguage = New System.Windows.Forms.ComboBox()
        Me.picAbout = New System.Windows.Forms.PictureBox()
        Me.btnCheckForUpdates = New System.Windows.Forms.Button()
        Me.lblInsanity = New System.Windows.Forms.Label()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.tabChangeLog = New System.Windows.Forms.TabPage()
        Me.grpChange = New System.Windows.Forms.GroupBox()
        Me.tabProperties = New System.Windows.Forms.TabPage()
        Me.grpProperties = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picProperties = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.barInsanity = New System.Windows.Forms.HScrollBar()
        Me.btnInsanity = New System.Windows.Forms.Button()
        Me.picAppearance = New System.Windows.Forms.PictureBox()
        Me.lblAppearance = New System.Windows.Forms.Label()
        Me.cmbAppearance = New System.Windows.Forms.ComboBox()
        Me.tabStringOptions = New System.Windows.Forms.TabPage()
        Me.grpConfig = New System.Windows.Forms.GroupBox()
        Me.picNumIter = New System.Windows.Forms.PictureBox()
        Me.picStrLength = New System.Windows.Forms.PictureBox()
        Me.grpCharacterList = New System.Windows.Forms.GroupBox()
        Me.btnResetLang = New System.Windows.Forms.Button()
        Me.btnAddLang = New System.Windows.Forms.Button()
        Me.picRem = New System.Windows.Forms.PictureBox()
        Me.picAdd = New System.Windows.Forms.PictureBox()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.grpStringInfo = New System.Windows.Forms.GroupBox()
        Me.txtStringInformation = New System.Windows.Forms.TextBox()
        Me.tabSettings = New System.Windows.Forms.TabControl()
        Me.tmeInsanity = New System.Windows.Forms.Timer(Me.components)
        Me.ctxSettings.SuspendLayout()
        CType(Me.picAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAbout.SuspendLayout()
        Me.tabChangeLog.SuspendLayout()
        Me.grpChange.SuspendLayout()
        Me.tabProperties.SuspendLayout()
        Me.grpProperties.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.picAppearance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabStringOptions.SuspendLayout()
        Me.grpConfig.SuspendLayout()
        CType(Me.picNumIter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStrLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCharacterList.SuspendLayout()
        CType(Me.picRem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStringInfo.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'ctxSettings
        '
        Me.ctxSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator1})
        Me.ctxSettings.Name = "ctxSettings"
        Me.ctxSettings.Size = New System.Drawing.Size(145, 76)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = Global.RSG.My.Resources.Resources.stringCopy
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = Global.RSG.My.Resources.Resources.stringCut
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = Global.RSG.My.Resources.Resources.stringPaste
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'tipHelp
        '
        Me.tipHelp.IsBalloon = True
        '
        'lnkPortfolio
        '
        Me.lnkPortfolio.AutoSize = True
        Me.lnkPortfolio.Location = New System.Drawing.Point(337, 371)
        Me.lnkPortfolio.Name = "lnkPortfolio"
        Me.lnkPortfolio.Size = New System.Drawing.Size(208, 13)
        Me.lnkPortfolio.TabIndex = 3
        Me.lnkPortfolio.TabStop = True
        Me.lnkPortfolio.Text = "Click here to navigate to my other projects!"
        Me.tipHelp.SetToolTip(Me.lnkPortfolio, "Opens a new tab in your browser." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txtChangelog
        '
        Me.txtChangelog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChangelog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangelog.Location = New System.Drawing.Point(3, 16)
        Me.txtChangelog.Multiline = True
        Me.txtChangelog.Name = "txtChangelog"
        Me.txtChangelog.ReadOnly = True
        Me.txtChangelog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtChangelog.Size = New System.Drawing.Size(619, 368)
        Me.txtChangelog.TabIndex = 0
        Me.txtChangelog.Text = resources.GetString("txtChangelog.Text")
        Me.tipHelp.SetToolTip(Me.txtChangelog, "Changelog...")
        '
        'chkGlue
        '
        Me.chkGlue.AutoSize = True
        Me.chkGlue.Location = New System.Drawing.Point(254, 85)
        Me.chkGlue.Name = "chkGlue"
        Me.chkGlue.Size = New System.Drawing.Size(223, 17)
        Me.chkGlue.TabIndex = 8
        Me.chkGlue.Text = "Glue RSG form to the side of settings form"
        Me.tipHelp.SetToolTip(Me.chkGlue, "When you move the settings form, RSG glues nexts to it.")
        Me.chkGlue.UseVisualStyleBackColor = True
        '
        'chkCheckUpdatesOnLoad
        '
        Me.chkCheckUpdatesOnLoad.AutoSize = True
        Me.chkCheckUpdatesOnLoad.Location = New System.Drawing.Point(254, 62)
        Me.chkCheckUpdatesOnLoad.Name = "chkCheckUpdatesOnLoad"
        Me.chkCheckUpdatesOnLoad.Size = New System.Drawing.Size(151, 17)
        Me.chkCheckUpdatesOnLoad.TabIndex = 9
        Me.chkCheckUpdatesOnLoad.Text = "Check for updates on load"
        Me.tipHelp.SetToolTip(Me.chkCheckUpdatesOnLoad, "Have RSG check for updates when the program starts up.")
        Me.chkCheckUpdatesOnLoad.UseVisualStyleBackColor = True
        '
        'chkUseBigInt
        '
        Me.chkUseBigInt.AutoSize = True
        Me.chkUseBigInt.Location = New System.Drawing.Point(6, 85)
        Me.chkUseBigInt.Name = "chkUseBigInt"
        Me.chkUseBigInt.Size = New System.Drawing.Size(99, 17)
        Me.chkUseBigInt.TabIndex = 0
        Me.chkUseBigInt.Tag = ""
        Me.chkUseBigInt.Text = "Use Big Integer"
        Me.tipHelp.SetToolTip(Me.chkUseBigInt, "Permutations will be calculated to the exact figure.")
        Me.chkUseBigInt.UseVisualStyleBackColor = True
        '
        'chkBndStrLgth
        '
        Me.chkBndStrLgth.AutoSize = True
        Me.chkBndStrLgth.Location = New System.Drawing.Point(6, 108)
        Me.chkBndStrLgth.Name = "chkBndStrLgth"
        Me.chkBndStrLgth.Size = New System.Drawing.Size(117, 17)
        Me.chkBndStrLgth.TabIndex = 1
        Me.chkBndStrLgth.Tag = ""
        Me.chkBndStrLgth.Text = "Bound string length"
        Me.tipHelp.SetToolTip(Me.chkBndStrLgth, "Bound the string length to 4680 (the display maximum length) on the items.")
        Me.chkBndStrLgth.UseVisualStyleBackColor = True
        '
        'chkCopyToClipboard
        '
        Me.chkCopyToClipboard.AutoSize = True
        Me.chkCopyToClipboard.Location = New System.Drawing.Point(6, 62)
        Me.chkCopyToClipboard.Name = "chkCopyToClipboard"
        Me.chkCopyToClipboard.Size = New System.Drawing.Size(128, 17)
        Me.chkCopyToClipboard.TabIndex = 10
        Me.chkCopyToClipboard.Tag = ""
        Me.chkCopyToClipboard.Text = "Copy text to clipboard"
        Me.tipHelp.SetToolTip(Me.chkCopyToClipboard, "Clicking on items in the generation and statistics form will copy to clipboard.")
        Me.chkCopyToClipboard.UseVisualStyleBackColor = True
        '
        'txtStringLength
        '
        Me.txtStringLength.Location = New System.Drawing.Point(32, 19)
        Me.txtStringLength.Name = "txtStringLength"
        Me.txtStringLength.Size = New System.Drawing.Size(247, 20)
        Me.txtStringLength.TabIndex = 0
        Me.txtStringLength.Text = "String Length"
        Me.tipHelp.SetToolTip(Me.txtStringLength, "Edit the string length.")
        '
        'txtIterations
        '
        Me.txtIterations.Location = New System.Drawing.Point(32, 45)
        Me.txtIterations.Name = "txtIterations"
        Me.txtIterations.Size = New System.Drawing.Size(247, 20)
        Me.txtIterations.TabIndex = 1
        Me.txtIterations.Text = "Iterations"
        Me.tipHelp.SetToolTip(Me.txtIterations, "Edit the number of iterations.")
        '
        'txtCharacterList
        '
        Me.txtCharacterList.Location = New System.Drawing.Point(6, 19)
        Me.txtCharacterList.Name = "txtCharacterList"
        Me.txtCharacterList.ReadOnly = True
        Me.txtCharacterList.Size = New System.Drawing.Size(270, 20)
        Me.txtCharacterList.TabIndex = 1
        Me.tipHelp.SetToolTip(Me.txtCharacterList, "The current custom character list.")
        '
        'txtAddCharacters
        '
        Me.txtAddCharacters.Location = New System.Drawing.Point(32, 45)
        Me.txtAddCharacters.Name = "txtAddCharacters"
        Me.txtAddCharacters.Size = New System.Drawing.Size(244, 20)
        Me.txtAddCharacters.TabIndex = 2
        Me.txtAddCharacters.Text = "Add Characters"
        Me.tipHelp.SetToolTip(Me.txtAddCharacters, "Add characters to the character list.")
        '
        'txtRemoveCharacters
        '
        Me.txtRemoveCharacters.Location = New System.Drawing.Point(32, 71)
        Me.txtRemoveCharacters.Name = "txtRemoveCharacters"
        Me.txtRemoveCharacters.Size = New System.Drawing.Size(244, 20)
        Me.txtRemoveCharacters.TabIndex = 3
        Me.txtRemoveCharacters.Text = "Remove Characters"
        Me.tipHelp.SetToolTip(Me.txtRemoveCharacters, "Remove characters to the character list.")
        '
        'cmbLanguage
        '
        Me.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLanguage.FormattingEnabled = True
        Me.cmbLanguage.Items.AddRange(New Object() {"Select Language", "Czech", "Danish", "Dutch", "Esperanto", "Finnish", "French", "German", "Greek", "Hungarian", "Icelandic", "Maori", "Norwegian", "Polish", "Portuguese", "Romanian", "Russian", "Spanish", "Swedish", "Turkish", "Welsh", "Currencies", "The Mathematical Language", "Symbols"})
        Me.cmbLanguage.Location = New System.Drawing.Point(6, 122)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Size = New System.Drawing.Size(270, 21)
        Me.cmbLanguage.TabIndex = 8
        Me.tipHelp.SetToolTip(Me.cmbLanguage, "Add the language characters to the character list.")
        '
        'picAbout
        '
        Me.picAbout.BackgroundImage = Global.RSG.My.Resources.Resources.stringReap
        Me.picAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picAbout.Location = New System.Drawing.Point(257, 8)
        Me.picAbout.Name = "picAbout"
        Me.picAbout.Size = New System.Drawing.Size(366, 360)
        Me.picAbout.TabIndex = 2
        Me.picAbout.TabStop = False
        Me.tipHelp.SetToolTip(Me.picAbout, "That's me!")
        '
        'btnCheckForUpdates
        '
        Me.btnCheckForUpdates.Image = Global.RSG.My.Resources.Resources.stringUpdate
        Me.btnCheckForUpdates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckForUpdates.Location = New System.Drawing.Point(9, 73)
        Me.btnCheckForUpdates.Name = "btnCheckForUpdates"
        Me.btnCheckForUpdates.Size = New System.Drawing.Size(242, 40)
        Me.btnCheckForUpdates.TabIndex = 1
        Me.btnCheckForUpdates.Tag = ""
        Me.btnCheckForUpdates.Text = "Check for updates"
        Me.tipHelp.SetToolTip(Me.btnCheckForUpdates, "Check for RSG updates!")
        Me.btnCheckForUpdates.UseVisualStyleBackColor = True
        '
        'lblInsanity
        '
        Me.lblInsanity.AutoSize = True
        Me.lblInsanity.Location = New System.Drawing.Point(170, 16)
        Me.lblInsanity.Name = "lblInsanity"
        Me.lblInsanity.Size = New System.Drawing.Size(69, 13)
        Me.lblInsanity.TabIndex = 8
        Me.lblInsanity.Text = "Insanity: .25s"
        Me.tipHelp.SetToolTip(Me.lblInsanity, "Be more insane by changing its speed!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'tabAbout
        '
        Me.tabAbout.Controls.Add(Me.lnkPortfolio)
        Me.tabAbout.Controls.Add(Me.lblAbout)
        Me.tabAbout.Controls.Add(Me.picAbout)
        Me.tabAbout.Controls.Add(Me.btnCheckForUpdates)
        Me.tabAbout.Location = New System.Drawing.Point(4, 4)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAbout.Size = New System.Drawing.Size(631, 393)
        Me.tabAbout.TabIndex = 3
        Me.tabAbout.Text = "About"
        Me.tabAbout.UseVisualStyleBackColor = True
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(6, 5)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(245, 65)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.Tag = ""
        Me.lblAbout.Text = resources.GetString("lblAbout.Text")
        Me.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabChangeLog
        '
        Me.tabChangeLog.Controls.Add(Me.grpChange)
        Me.tabChangeLog.Location = New System.Drawing.Point(4, 4)
        Me.tabChangeLog.Name = "tabChangeLog"
        Me.tabChangeLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tabChangeLog.Size = New System.Drawing.Size(631, 393)
        Me.tabChangeLog.TabIndex = 4
        Me.tabChangeLog.Text = "Changelog"
        Me.tabChangeLog.UseVisualStyleBackColor = True
        '
        'grpChange
        '
        Me.grpChange.Controls.Add(Me.txtChangelog)
        Me.grpChange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpChange.Location = New System.Drawing.Point(3, 3)
        Me.grpChange.Name = "grpChange"
        Me.grpChange.Size = New System.Drawing.Size(625, 387)
        Me.grpChange.TabIndex = 1
        Me.grpChange.TabStop = False
        Me.grpChange.Text = "Changelog:"
        '
        'tabProperties
        '
        Me.tabProperties.Controls.Add(Me.grpProperties)
        Me.tabProperties.Controls.Add(Me.GroupBox6)
        Me.tabProperties.Location = New System.Drawing.Point(4, 4)
        Me.tabProperties.Name = "tabProperties"
        Me.tabProperties.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProperties.Size = New System.Drawing.Size(631, 393)
        Me.tabProperties.TabIndex = 2
        Me.tabProperties.Text = "Properties"
        Me.tabProperties.UseVisualStyleBackColor = True
        '
        'grpProperties
        '
        Me.grpProperties.Controls.Add(Me.PictureBox2)
        Me.grpProperties.Controls.Add(Me.chkCheckUpdatesOnLoad)
        Me.grpProperties.Controls.Add(Me.chkGlue)
        Me.grpProperties.Controls.Add(Me.chkCopyToClipboard)
        Me.grpProperties.Controls.Add(Me.chkBndStrLgth)
        Me.grpProperties.Controls.Add(Me.picProperties)
        Me.grpProperties.Controls.Add(Me.chkUseBigInt)
        Me.grpProperties.Location = New System.Drawing.Point(8, 111)
        Me.grpProperties.Name = "grpProperties"
        Me.grpProperties.Size = New System.Drawing.Size(620, 276)
        Me.grpProperties.TabIndex = 6
        Me.grpProperties.TabStop = False
        Me.grpProperties.Tag = ""
        Me.grpProperties.Text = "Properties:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.RSG.My.Resources.Resources.stringSettings
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(251, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'picProperties
        '
        Me.picProperties.BackgroundImage = Global.RSG.My.Resources.Resources.stringSet
        Me.picProperties.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picProperties.Location = New System.Drawing.Point(6, 16)
        Me.picProperties.Name = "picProperties"
        Me.picProperties.Size = New System.Drawing.Size(40, 40)
        Me.picProperties.TabIndex = 5
        Me.picProperties.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblInsanity)
        Me.GroupBox6.Controls.Add(Me.barInsanity)
        Me.GroupBox6.Controls.Add(Me.btnInsanity)
        Me.GroupBox6.Controls.Add(Me.picAppearance)
        Me.GroupBox6.Controls.Add(Me.lblAppearance)
        Me.GroupBox6.Controls.Add(Me.cmbAppearance)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(291, 97)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Tag = ""
        Me.GroupBox6.Text = "Appearance:"
        '
        'barInsanity
        '
        Me.barInsanity.Location = New System.Drawing.Point(118, 65)
        Me.barInsanity.Maximum = 1000
        Me.barInsanity.Minimum = 10
        Me.barInsanity.Name = "barInsanity"
        Me.barInsanity.Size = New System.Drawing.Size(139, 17)
        Me.barInsanity.SmallChange = 10
        Me.barInsanity.TabIndex = 7
        Me.barInsanity.Value = 250
        '
        'btnInsanity
        '
        Me.btnInsanity.Location = New System.Drawing.Point(6, 59)
        Me.btnInsanity.Name = "btnInsanity"
        Me.btnInsanity.Size = New System.Drawing.Size(109, 23)
        Me.btnInsanity.TabIndex = 6
        Me.btnInsanity.Text = "Generate Insanity"
        Me.btnInsanity.UseVisualStyleBackColor = True
        '
        'picAppearance
        '
        Me.picAppearance.BackgroundImage = Global.RSG.My.Resources.Resources.stringAppearance
        Me.picAppearance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAppearance.Location = New System.Drawing.Point(6, 16)
        Me.picAppearance.Name = "picAppearance"
        Me.picAppearance.Size = New System.Drawing.Size(40, 40)
        Me.picAppearance.TabIndex = 5
        Me.picAppearance.TabStop = False
        '
        'lblAppearance
        '
        Me.lblAppearance.AutoSize = True
        Me.lblAppearance.Location = New System.Drawing.Point(52, 16)
        Me.lblAppearance.Name = "lblAppearance"
        Me.lblAppearance.Size = New System.Drawing.Size(112, 13)
        Me.lblAppearance.TabIndex = 1
        Me.lblAppearance.Text = "Select an appearance"
        '
        'cmbAppearance
        '
        Me.cmbAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAppearance.FormattingEnabled = True
        Me.cmbAppearance.Items.AddRange(New Object() {"Light", "Dark", "Warm", "Blue", "Red", "Green", "Random"})
        Me.cmbAppearance.Location = New System.Drawing.Point(55, 32)
        Me.cmbAppearance.Name = "cmbAppearance"
        Me.cmbAppearance.Size = New System.Drawing.Size(202, 21)
        Me.cmbAppearance.TabIndex = 0
        '
        'tabStringOptions
        '
        Me.tabStringOptions.Controls.Add(Me.grpConfig)
        Me.tabStringOptions.Controls.Add(Me.grpStringInfo)
        Me.tabStringOptions.Location = New System.Drawing.Point(4, 4)
        Me.tabStringOptions.Name = "tabStringOptions"
        Me.tabStringOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStringOptions.Size = New System.Drawing.Size(631, 393)
        Me.tabStringOptions.TabIndex = 0
        Me.tabStringOptions.Text = "String Options"
        Me.tabStringOptions.UseVisualStyleBackColor = True
        '
        'grpConfig
        '
        Me.grpConfig.Controls.Add(Me.picNumIter)
        Me.grpConfig.Controls.Add(Me.picStrLength)
        Me.grpConfig.Controls.Add(Me.txtIterations)
        Me.grpConfig.Controls.Add(Me.txtStringLength)
        Me.grpConfig.Controls.Add(Me.grpCharacterList)
        Me.grpConfig.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpConfig.Location = New System.Drawing.Point(3, 3)
        Me.grpConfig.Name = "grpConfig"
        Me.grpConfig.Size = New System.Drawing.Size(285, 387)
        Me.grpConfig.TabIndex = 2
        Me.grpConfig.TabStop = False
        Me.grpConfig.Tag = ""
        Me.grpConfig.Text = "Configure:"
        '
        'picNumIter
        '
        Me.picNumIter.BackColor = System.Drawing.Color.Transparent
        Me.picNumIter.BackgroundImage = Global.RSG.My.Resources.Resources.stringNum
        Me.picNumIter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picNumIter.Location = New System.Drawing.Point(6, 45)
        Me.picNumIter.Name = "picNumIter"
        Me.picNumIter.Size = New System.Drawing.Size(20, 20)
        Me.picNumIter.TabIndex = 13
        Me.picNumIter.TabStop = False
        '
        'picStrLength
        '
        Me.picStrLength.BackColor = System.Drawing.Color.Transparent
        Me.picStrLength.BackgroundImage = Global.RSG.My.Resources.Resources.stringLength
        Me.picStrLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStrLength.Location = New System.Drawing.Point(6, 19)
        Me.picStrLength.Name = "picStrLength"
        Me.picStrLength.Size = New System.Drawing.Size(20, 20)
        Me.picStrLength.TabIndex = 12
        Me.picStrLength.TabStop = False
        '
        'grpCharacterList
        '
        Me.grpCharacterList.Controls.Add(Me.btnResetLang)
        Me.grpCharacterList.Controls.Add(Me.btnAddLang)
        Me.grpCharacterList.Controls.Add(Me.picRem)
        Me.grpCharacterList.Controls.Add(Me.picAdd)
        Me.grpCharacterList.Controls.Add(Me.lblLanguage)
        Me.grpCharacterList.Controls.Add(Me.cmbLanguage)
        Me.grpCharacterList.Controls.Add(Me.txtRemoveCharacters)
        Me.grpCharacterList.Controls.Add(Me.txtAddCharacters)
        Me.grpCharacterList.Controls.Add(Me.txtCharacterList)
        Me.grpCharacterList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpCharacterList.Location = New System.Drawing.Point(3, 71)
        Me.grpCharacterList.Name = "grpCharacterList"
        Me.grpCharacterList.Size = New System.Drawing.Size(279, 313)
        Me.grpCharacterList.TabIndex = 2
        Me.grpCharacterList.TabStop = False
        Me.grpCharacterList.Tag = ""
        Me.grpCharacterList.Text = "Character List:"
        '
        'btnResetLang
        '
        Me.btnResetLang.Image = Global.RSG.My.Resources.Resources.stringReset
        Me.btnResetLang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResetLang.Location = New System.Drawing.Point(6, 184)
        Me.btnResetLang.Name = "btnResetLang"
        Me.btnResetLang.Size = New System.Drawing.Size(270, 29)
        Me.btnResetLang.TabIndex = 14
        Me.btnResetLang.Text = "Reset language(s)"
        Me.btnResetLang.UseVisualStyleBackColor = True
        '
        'btnAddLang
        '
        Me.btnAddLang.Image = Global.RSG.My.Resources.Resources.stringAdd
        Me.btnAddLang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddLang.Location = New System.Drawing.Point(6, 149)
        Me.btnAddLang.Name = "btnAddLang"
        Me.btnAddLang.Size = New System.Drawing.Size(270, 29)
        Me.btnAddLang.TabIndex = 12
        Me.btnAddLang.Text = "Add language"
        Me.btnAddLang.UseVisualStyleBackColor = True
        '
        'picRem
        '
        Me.picRem.BackColor = System.Drawing.Color.Transparent
        Me.picRem.BackgroundImage = Global.RSG.My.Resources.Resources.stringRemove
        Me.picRem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRem.Location = New System.Drawing.Point(6, 71)
        Me.picRem.Name = "picRem"
        Me.picRem.Size = New System.Drawing.Size(20, 20)
        Me.picRem.TabIndex = 11
        Me.picRem.TabStop = False
        '
        'picAdd
        '
        Me.picAdd.BackColor = System.Drawing.Color.Transparent
        Me.picAdd.BackgroundImage = Global.RSG.My.Resources.Resources.stringAdd
        Me.picAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAdd.Location = New System.Drawing.Point(6, 45)
        Me.picAdd.Name = "picAdd"
        Me.picAdd.Size = New System.Drawing.Size(20, 20)
        Me.picAdd.TabIndex = 10
        Me.picAdd.TabStop = False
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(6, 106)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(82, 13)
        Me.lblLanguage.TabIndex = 9
        Me.lblLanguage.Text = "Add a language"
        '
        'grpStringInfo
        '
        Me.grpStringInfo.Controls.Add(Me.txtStringInformation)
        Me.grpStringInfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpStringInfo.Location = New System.Drawing.Point(290, 3)
        Me.grpStringInfo.Name = "grpStringInfo"
        Me.grpStringInfo.Size = New System.Drawing.Size(338, 387)
        Me.grpStringInfo.TabIndex = 0
        Me.grpStringInfo.TabStop = False
        Me.grpStringInfo.Text = "String Information:"
        '
        'txtStringInformation
        '
        Me.txtStringInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStringInformation.Font = New System.Drawing.Font("Lucida Console", 9.0!)
        Me.txtStringInformation.Location = New System.Drawing.Point(3, 16)
        Me.txtStringInformation.Multiline = True
        Me.txtStringInformation.Name = "txtStringInformation"
        Me.txtStringInformation.Size = New System.Drawing.Size(332, 368)
        Me.txtStringInformation.TabIndex = 4
        '
        'tabSettings
        '
        Me.tabSettings.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tabSettings.Controls.Add(Me.tabStringOptions)
        Me.tabSettings.Controls.Add(Me.tabProperties)
        Me.tabSettings.Controls.Add(Me.tabChangeLog)
        Me.tabSettings.Controls.Add(Me.tabAbout)
        Me.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabSettings.Location = New System.Drawing.Point(0, 0)
        Me.tabSettings.Multiline = True
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.SelectedIndex = 0
        Me.tabSettings.ShowToolTips = True
        Me.tabSettings.Size = New System.Drawing.Size(639, 419)
        Me.tabSettings.TabIndex = 0
        '
        'tmeInsanity
        '
        Me.tmeInsanity.Interval = 250
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(639, 419)
        Me.ContextMenuStrip = Me.ctxSettings
        Me.Controls.Add(Me.tabSettings)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmSettings"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Settings"
        Me.ctxSettings.ResumeLayout(False)
        CType(Me.picAbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAbout.ResumeLayout(False)
        Me.tabAbout.PerformLayout()
        Me.tabChangeLog.ResumeLayout(False)
        Me.grpChange.ResumeLayout(False)
        Me.grpChange.PerformLayout()
        Me.tabProperties.ResumeLayout(False)
        Me.grpProperties.ResumeLayout(False)
        Me.grpProperties.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.picAppearance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabStringOptions.ResumeLayout(False)
        Me.grpConfig.ResumeLayout(False)
        Me.grpConfig.PerformLayout()
        CType(Me.picNumIter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStrLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCharacterList.ResumeLayout(False)
        Me.grpCharacterList.PerformLayout()
        CType(Me.picRem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStringInfo.ResumeLayout(False)
        Me.grpStringInfo.PerformLayout()
        Me.tabSettings.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ctxSettings As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tipHelp As ToolTip
    Friend WithEvents tabAbout As TabPage
    Friend WithEvents lnkPortfolio As LinkLabel
    Friend WithEvents picAbout As PictureBox
    Friend WithEvents btnCheckForUpdates As Button
    Friend WithEvents lblAbout As Label
    Friend WithEvents tabChangeLog As TabPage
    Friend WithEvents txtChangelog As TextBox
    Friend WithEvents tabProperties As TabPage
    Friend WithEvents grpProperties As GroupBox
    Friend WithEvents chkCopyToClipboard As CheckBox
    Friend WithEvents chkBndStrLgth As CheckBox
    Friend WithEvents picProperties As PictureBox
    Friend WithEvents chkUseBigInt As CheckBox
    Friend WithEvents chkCheckUpdatesOnLoad As CheckBox
    Friend WithEvents chkGlue As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents picAppearance As PictureBox
    Friend WithEvents lblAppearance As Label
    Friend WithEvents cmbAppearance As ComboBox
    Friend WithEvents tabStringOptions As TabPage
    Friend WithEvents grpCharacterList As GroupBox
    Friend WithEvents picRem As PictureBox
    Friend WithEvents picAdd As PictureBox
    Friend WithEvents lblLanguage As Label
    Friend WithEvents cmbLanguage As ComboBox
    Friend WithEvents txtRemoveCharacters As TextBox
    Friend WithEvents txtAddCharacters As TextBox
    Friend WithEvents txtCharacterList As TextBox
    Friend WithEvents grpConfig As GroupBox
    Friend WithEvents picNumIter As PictureBox
    Friend WithEvents picStrLength As PictureBox
    Friend WithEvents txtIterations As TextBox
    Friend WithEvents txtStringLength As TextBox
    Friend WithEvents grpStringInfo As GroupBox
    Friend WithEvents tabSettings As TabControl
    Friend WithEvents btnAddLang As Button
    Friend WithEvents txtStringInformation As TextBox
    Friend WithEvents btnResetLang As Button
    Friend WithEvents grpChange As GroupBox
    Friend WithEvents btnInsanity As Button
    Friend WithEvents tmeInsanity As Timer
    Friend WithEvents lblInsanity As Label
    Friend WithEvents barInsanity As HScrollBar
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.picSearch = New System.Windows.Forms.PictureBox()
        Me.picCharList = New System.Windows.Forms.PictureBox()
        Me.picMethod = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearchMethod = New System.Windows.Forms.ComboBox()
        Me.cmbCharLists = New System.Windows.Forms.ComboBox()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.picProperties = New System.Windows.Forms.PictureBox()
        Me.chkThread = New System.Windows.Forms.CheckBox()
        Me.chkHeavy = New System.Windows.Forms.CheckBox()
        Me.txtExpect = New System.Windows.Forms.TextBox()
        Me.timeSec = New System.Windows.Forms.Timer(Me.components)
        Me.grpResult = New System.Windows.Forms.GroupBox()
        Me.txtResult = New System.Windows.Forms.RichTextBox()
        Me.ctxResult = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCharList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        CType(Me.picProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResult.SuspendLayout()
        Me.ctxResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'picSearch
        '
        Me.picSearch.BackgroundImage = Global.RSG.My.Resources.Resources.stringFind
        Me.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSearch.Location = New System.Drawing.Point(3, 14)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(25, 25)
        Me.picSearch.TabIndex = 4
        Me.picSearch.TabStop = False
        '
        'picCharList
        '
        Me.picCharList.BackgroundImage = Global.RSG.My.Resources.Resources.stringUppercase
        Me.picCharList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCharList.Location = New System.Drawing.Point(3, 45)
        Me.picCharList.Name = "picCharList"
        Me.picCharList.Size = New System.Drawing.Size(25, 25)
        Me.picCharList.TabIndex = 7
        Me.picCharList.TabStop = False
        '
        'picMethod
        '
        Me.picMethod.BackgroundImage = Global.RSG.My.Resources.Resources.stringRandom
        Me.picMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMethod.Location = New System.Drawing.Point(3, 76)
        Me.picMethod.Name = "picMethod"
        Me.picMethod.Size = New System.Drawing.Size(25, 25)
        Me.picMethod.TabIndex = 8
        Me.picMethod.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Enabled = False
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRefresh.Image = Global.RSG.My.Resources.Resources.stringUpdate
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(3, 453)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(323, 40)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "Refresh"
        Me.tipHelp.SetToolTip(Me.btnRefresh, "Refresh the form!")
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnStop.Image = Global.RSG.My.Resources.Resources.stringClose
        Me.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStop.Location = New System.Drawing.Point(173, 407)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(153, 40)
        Me.btnStop.TabIndex = 10
        Me.btnStop.Text = "Stop"
        Me.tipHelp.SetToolTip(Me.btnStop, "Stop the search!")
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Image = Global.RSG.My.Resources.Resources.stringSearch
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.Location = New System.Drawing.Point(3, 407)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(153, 40)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start"
        Me.tipHelp.SetToolTip(Me.btnStart, "Run the search!")
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(34, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(287, 20)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = "Enter a string to search..."
        Me.tipHelp.SetToolTip(Me.txtSearch, "Type a string to search!")
        '
        'cmbSearchMethod
        '
        Me.cmbSearchMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchMethod.FormattingEnabled = True
        Me.cmbSearchMethod.Items.AddRange(New Object() {"Smart Bruteforce"})
        Me.cmbSearchMethod.Location = New System.Drawing.Point(34, 80)
        Me.cmbSearchMethod.Name = "cmbSearchMethod"
        Me.cmbSearchMethod.Size = New System.Drawing.Size(287, 21)
        Me.cmbSearchMethod.TabIndex = 13
        Me.tipHelp.SetToolTip(Me.cmbSearchMethod, "Smart bruteforce essentially knows how long the string you want to bruteforce.")
        '
        'cmbCharLists
        '
        Me.cmbCharLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCharLists.FormattingEnabled = True
        Me.cmbCharLists.Items.AddRange(New Object() {"Use RSG CEM Character Expect Method (Recommended)", "Use a standard password character set"})
        Me.cmbCharLists.Location = New System.Drawing.Point(34, 49)
        Me.cmbCharLists.Name = "cmbCharLists"
        Me.cmbCharLists.Size = New System.Drawing.Size(287, 21)
        Me.cmbCharLists.TabIndex = 14
        Me.tipHelp.SetToolTip(Me.cmbCharLists, "Character list method.")
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.picProperties)
        Me.grpSearch.Controls.Add(Me.chkThread)
        Me.grpSearch.Controls.Add(Me.chkHeavy)
        Me.grpSearch.Controls.Add(Me.cmbCharLists)
        Me.grpSearch.Controls.Add(Me.cmbSearchMethod)
        Me.grpSearch.Controls.Add(Me.btnRefresh)
        Me.grpSearch.Controls.Add(Me.btnStop)
        Me.grpSearch.Controls.Add(Me.btnStart)
        Me.grpSearch.Controls.Add(Me.picMethod)
        Me.grpSearch.Controls.Add(Me.picCharList)
        Me.grpSearch.Controls.Add(Me.txtExpect)
        Me.grpSearch.Controls.Add(Me.picSearch)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpSearch.Location = New System.Drawing.Point(0, 0)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(329, 496)
        Me.grpSearch.TabIndex = 2
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search:"
        '
        'picProperties
        '
        Me.picProperties.BackgroundImage = Global.RSG.My.Resources.Resources.stringSettings
        Me.picProperties.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picProperties.Location = New System.Drawing.Point(3, 325)
        Me.picProperties.Name = "picProperties"
        Me.picProperties.Size = New System.Drawing.Size(25, 25)
        Me.picProperties.TabIndex = 17
        Me.picProperties.TabStop = False
        Me.tipHelp.SetToolTip(Me.picProperties, "Settings for the search")
        '
        'chkThread
        '
        Me.chkThread.AutoSize = True
        Me.chkThread.Checked = True
        Me.chkThread.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkThread.Enabled = False
        Me.chkThread.Location = New System.Drawing.Point(6, 382)
        Me.chkThread.Name = "chkThread"
        Me.chkThread.Size = New System.Drawing.Size(83, 17)
        Me.chkThread.TabIndex = 16
        Me.chkThread.Text = "Thread task"
        Me.tipHelp.SetToolTip(Me.chkThread, "The task runs recursively, this must be threaded to view information.")
        Me.chkThread.UseVisualStyleBackColor = True
        '
        'chkHeavy
        '
        Me.chkHeavy.AutoSize = True
        Me.chkHeavy.Location = New System.Drawing.Point(6, 359)
        Me.chkHeavy.Name = "chkHeavy"
        Me.chkHeavy.Size = New System.Drawing.Size(139, 17)
        Me.chkHeavy.TabIndex = 15
        Me.chkHeavy.Text = "Display Heavy Statistics"
        Me.tipHelp.SetToolTip(Me.chkHeavy, "Display full numbers in their massiveness, will reduce readability from the progr" &
        "am.")
        Me.chkHeavy.UseVisualStyleBackColor = True
        '
        'txtExpect
        '
        Me.txtExpect.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtExpect.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpect.Location = New System.Drawing.Point(3, 107)
        Me.txtExpect.Multiline = True
        Me.txtExpect.Name = "txtExpect"
        Me.txtExpect.ReadOnly = True
        Me.txtExpect.Size = New System.Drawing.Size(318, 212)
        Me.txtExpect.TabIndex = 5
        Me.tipHelp.SetToolTip(Me.txtExpect, "The expected characters list generated")
        '
        'timeSec
        '
        Me.timeSec.Interval = 1000
        '
        'grpResult
        '
        Me.grpResult.Controls.Add(Me.txtResult)
        Me.grpResult.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpResult.Location = New System.Drawing.Point(331, 0)
        Me.grpResult.Name = "grpResult"
        Me.grpResult.Size = New System.Drawing.Size(365, 496)
        Me.grpResult.TabIndex = 3
        Me.grpResult.TabStop = False
        Me.grpResult.Text = "Result:"
        '
        'txtResult
        '
        Me.txtResult.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtResult.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(3, 16)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(359, 477)
        Me.txtResult.TabIndex = 0
        Me.txtResult.Text = ""
        Me.tipHelp.SetToolTip(Me.txtResult, "Statistics for this search!")
        '
        'ctxResult
        '
        Me.ctxResult.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator1, Me.ExportLogToolStripMenuItem})
        Me.ctxResult.Name = "ContextMenuStrip1"
        Me.ctxResult.Size = New System.Drawing.Size(131, 76)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(127, 6)
        '
        'ExportLogToolStripMenuItem
        '
        Me.ExportLogToolStripMenuItem.Name = "ExportLogToolStripMenuItem"
        Me.ExportLogToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ExportLogToolStripMenuItem.Text = "Export Log"
        '
        'tipHelp
        '
        Me.tipHelp.AutomaticDelay = 0
        Me.tipHelp.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tipHelp.ForeColor = System.Drawing.SystemColors.Highlight
        Me.tipHelp.IsBalloon = True
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(696, 496)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpResult)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSearch"
        Me.Text = "Search"
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCharList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMethod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.picProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResult.ResumeLayout(False)
        Me.ctxResult.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents timeSec As Timer
    Friend WithEvents grpResult As GroupBox
    Friend WithEvents picSearch As PictureBox
    Friend WithEvents txtExpect As TextBox
    Friend WithEvents ctxResult As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExportLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picMethod As PictureBox
    Friend WithEvents picCharList As PictureBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents cmbCharLists As ComboBox
    Friend WithEvents cmbSearchMethod As ComboBox
    Friend WithEvents tipHelp As ToolTip
    Friend WithEvents txtResult As RichTextBox
    Friend WithEvents chkThread As CheckBox
    Friend WithEvents chkHeavy As CheckBox
    Friend WithEvents picProperties As PictureBox
End Class

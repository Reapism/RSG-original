<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.txtHelp = New System.Windows.Forms.RichTextBox()
        Me.picHelp = New System.Windows.Forms.PictureBox()
        CType(Me.picHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHelp
        '
        Me.txtHelp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelp.Location = New System.Drawing.Point(0, 436)
        Me.txtHelp.Name = "txtHelp"
        Me.txtHelp.ReadOnly = True
        Me.txtHelp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtHelp.Size = New System.Drawing.Size(1008, 93)
        Me.txtHelp.TabIndex = 3
        Me.txtHelp.Text = ""
        '
        'picHelp
        '
        Me.picHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picHelp.Dock = System.Windows.Forms.DockStyle.Top
        Me.picHelp.Location = New System.Drawing.Point(0, 0)
        Me.picHelp.Name = "picHelp"
        Me.picHelp.Size = New System.Drawing.Size(1008, 438)
        Me.picHelp.TabIndex = 4
        Me.picHelp.TabStop = False
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1008, 529)
        Me.Controls.Add(Me.picHelp)
        Me.Controls.Add(Me.txtHelp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHelp"
        Me.Text = "Help!"
        CType(Me.picHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtHelp As RichTextBox
    Friend WithEvents picHelp As PictureBox
End Class

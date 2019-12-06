<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportBug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportBug))
        Me.grpBug = New System.Windows.Forms.GroupBox()
        Me.btnShowEmail = New System.Windows.Forms.Button()
        Me.btnIntDiag = New System.Windows.Forms.Button()
        Me.txtDiag = New System.Windows.Forms.RichTextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.grpBug.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBug
        '
        Me.grpBug.Controls.Add(Me.btnShowEmail)
        Me.grpBug.Controls.Add(Me.btnIntDiag)
        Me.grpBug.Controls.Add(Me.txtDiag)
        Me.grpBug.Controls.Add(Me.lblMsg)
        Me.grpBug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBug.Location = New System.Drawing.Point(0, 0)
        Me.grpBug.Name = "grpBug"
        Me.grpBug.Size = New System.Drawing.Size(397, 266)
        Me.grpBug.TabIndex = 6
        Me.grpBug.TabStop = False
        Me.grpBug.Text = "Report Message:"
        '
        'btnShowEmail
        '
        Me.btnShowEmail.Location = New System.Drawing.Point(15, 81)
        Me.btnShowEmail.Name = "btnShowEmail"
        Me.btnShowEmail.Size = New System.Drawing.Size(369, 23)
        Me.btnShowEmail.TabIndex = 6
        Me.btnShowEmail.Text = "Show Email *******@***.***"
        Me.btnShowEmail.UseVisualStyleBackColor = True
        '
        'btnIntDiag
        '
        Me.btnIntDiag.Location = New System.Drawing.Point(15, 237)
        Me.btnIntDiag.Name = "btnIntDiag"
        Me.btnIntDiag.Size = New System.Drawing.Size(369, 23)
        Me.btnIntDiag.TabIndex = 5
        Me.btnIntDiag.Text = "Generate Internal Diagnostics"
        Me.btnIntDiag.UseVisualStyleBackColor = True
        '
        'txtDiag
        '
        Me.txtDiag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiag.Location = New System.Drawing.Point(15, 110)
        Me.txtDiag.Name = "txtDiag"
        Me.txtDiag.Size = New System.Drawing.Size(369, 121)
        Me.txtDiag.TabIndex = 4
        Me.txtDiag.Text = "Please generate the diagnostics and include this in your email"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(13, 16)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(372, 52)
        Me.lblMsg.TabIndex = 2
        Me.lblMsg.Text = resources.GetString("lblMsg.Text")
        '
        'frmReportBug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(397, 266)
        Me.Controls.Add(Me.grpBug)
        Me.MaximizeBox = False
        Me.Name = "frmReportBug"
        Me.Text = "Report a bug"
        Me.grpBug.ResumeLayout(False)
        Me.grpBug.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBug As GroupBox
    Friend WithEvents btnShowEmail As Button
    Friend WithEvents btnIntDiag As Button
    Friend WithEvents txtDiag As RichTextBox
    Friend WithEvents lblMsg As Label
End Class

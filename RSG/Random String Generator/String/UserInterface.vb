Public Class UserInterface
    'Instance var

    Public Sub New()

    End Sub

    ''' <summary>
    ''' Shows the status bar and changes the option.
    ''' </summary>
    ''' <param name="sts"></param>
    ''' <param name="pnl"></param>
    ''' <param name="lst"></param>
    ''' <param name="btn"></param>

    Public Shared Sub showStatus(ByRef sts As StatusStrip, ByRef pnl As Panel, ByRef lst As ListBox, ByRef btn As Button)
        If My.Settings.optShowStatus Then
            My.Settings.optShowStatus = False
            sts.Visible = False
            pnl.Height = pnl.Height + sts.Height
            lst.Height = lst.Height + 20
        Else
            My.Settings.optShowStatus = True
            sts.Visible = True
            pnl.Height = pnl.Height - sts.Height
            lst.Height = lst.Height - 1
            sts.BringToFront()
        End If
        My.Settings.Save()
    End Sub

    ''' <summary>
    ''' Show the statistics window and change form properties 
    ''' to match.
    ''' </summary>

    Public Shared Sub showStatistics()
        If var.getOptShowStatistics Then
            frm.Size = New Size(700, 420)
            frm.grpStatistics.Visible = True
            frm.grpGenerate.Dock = DockStyle.Fill
            frm.grpStatistics.Dock = DockStyle.Right
            var.setOptShowStatistics(False)
            func.stringStatistics(frm.lstStatistics)

        Else
            frm.Size = New Size(345, 420)
            frm.grpStatistics.Visible = False
            frm.grpGenerate.Dock = DockStyle.Left
            frm.grpStatistics.Dock = DockStyle.None
            var.setOptShowStatistics(True)
        End If
    End Sub

    ''' <summary>
    ''' <para>Updates all the toolstrip buttons and interface with
    ''' settings changes in the settings tab.</para>
    ''' </summary>
    ''' <param name="lst"></param>
    ''' <param name="btn"></param>
    ''' <param name="btn2"></param>
    ''' <param name="lbl"></param>
    ''' <param name="lbl2"></param>

    Public Shared Sub updateInterface(ByVal lst As ListBox, ByVal btn As Object, ByVal btn2 As Object, ByVal lbl As Object, ByVal lbl2 As Object)
        btn.Text = "String Length: " & var.getStringLength().ToString("n0")
        btn2.Text = "Iterations: " & var.getNumIterations().ToString("n0")
        lbl.Text = "String Length: " & var.getStringLength().ToString("n0")
        lbl2.Text = "Iterations: " & var.getNumIterations().ToString("n0")

        lst.Items.Clear()
        lst.Items.Add("Generating string(s) with these settings.")
        lst.Items.Add("String Length: " & var.getStringLength().ToString("n0"))
        lst.Items.Add("Iterations: " & var.getNumIterations.ToString("n0"))
        lst.Items.Add("Randomization Method: " & var.getRndMethod())
        lst.Items.Add(UserInterface.decorateText(42))
    End Sub

    ''' <summary>
    ''' Updates an instance of the settings form with information 
    ''' about the string properties.
    ''' </summary>

    Public Shared Sub updateSettingsInterface(ByRef s As frmSettings)
        s.txtStringInformation.Clear()
        s.txtStringInformation.AppendText(decorateText(45) & newLine())
        s.txtStringInformation.AppendText(addSpaces(12) & "String Properties: " & newLine())
        s.txtStringInformation.AppendText(decorateText(45) & newLine())
        s.txtStringInformation.AppendText(" String Length: " & var.getStringLength().ToString("n0") & newLine())
        s.txtStringInformation.AppendText(" Iterations: " & var.getNumIterations().ToString("n0") & newLine())
        s.txtStringInformation.AppendText(" Character List: " & newLine() & newLine() & " " & var.getAllCharList() & newLine() & newLine())
        s.txtStringInformation.AppendText(" Amount of characters: " & var.getAllCharList().Length & newLine())
        s.txtStringInformation.AppendText(" Randomization Method: " & var.getRndMethod() & newLine())

        s.txtStringLength.Text = "String Length: " & var.getStringLength().ToString("n0")
        s.txtCharacterList.Text = "The custom character list: " & var.getCharList() & var.getLanguage()
        s.txtIterations.Text = "Iterations: " & var.getNumIterations().ToString("n0")

        If var.getOptUseBigInteger() Then s.chkUseBigInt.Checked = True

        If var.getOptBndStrLgth() Then s.chkBndStrLgth.Checked = True

        If var.getOptClipboard() Then s.chkCopyToClipboard.Checked = True

    End Sub

    ''' <summary>
    ''' Returns a newline character. Can be used with any text component not collections or lists.
    ''' </summary>
    ''' <returns></returns>

    Public Shared Function newLine() As String
        Return vbCrLf
    End Function

    ''' <summary>
    ''' Add spaces of any length and returns it as a string.
    ''' </summary>
    ''' <param name="x"></param>
    ''' <returns>Returns a number of spaces.</returns>

    Public Shared Function addSpaces(ByVal x As Integer) As String
        Dim str As String = " "
        If x > 0 Then
            For i As Integer = 1 To x
                str += " "
            Next
        Else
            Return " "
        End If
        Return str

    End Function

    ''' <summary>
    ''' <para>*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*</para>
    ''' Add decorated text and return it as string.
    ''' <para>*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*</para>
    ''' </summary>
    ''' <param name="x">Number of decorated text</param>
    ''' <returns>Returns the decorated text as a string.</returns>

    Public Shared Function decorateText(ByVal x As Integer) As String
        Dim str As String = "*"
        Dim isStar As Boolean = True

        For i As Integer = 1 To x
            If isStar Then
                str += "-"
                isStar = False
            Else
                str += "*"
                isStar = True
            End If
        Next
        Return str

    End Function

    ''' <summary>
    ''' Changes the theme requiring what index of the
    ''' combobox is selected. Sets the theme based on the number
    ''' in the parameter. Also requires a parameter theFrm to
    ''' test if certain forms have specific objects.
    ''' </summary>
    ''' <param name="val">The new theme.
    ''' <para>0 = Default, 1 = Dark, 2 = Blue, 3 = Red, 4 = Green = </para></param>
    ''' <param name="theFrm"> the frm to set the .</param>

    Public Shared Sub newTheme(ByVal val As Integer, ByVal theFrm As Form)
        Dim frmBackColor As Color
        Dim frmForeColor As Color
        Dim grpForeColor As Color
        Dim grpBackColor As Color
        Dim lstForeColor As Color
        Dim lstBackColor As Color
        Dim btnForeColor As Color
        Dim btnBackColor As Color
        Dim txtForeColor As Color
        Dim txtBackColor As Color
        Dim lblForeColor As Color

        'Validates the input and sets the colors to the appropiate color var

        Select Case val
            Case 0 ' [Default] Light
                frmBackColor = Color.WhiteSmoke
                frmForeColor = Color.Black
                grpBackColor = Color.WhiteSmoke
                grpForeColor = Color.Black
                lstBackColor = Color.White
                lstForeColor = Color.Black
                btnBackColor = Color.WhiteSmoke
                btnForeColor = Color.Black
                txtBackColor = Color.WhiteSmoke
                txtForeColor = Color.Black
                lblForeColor = Color.Black
            Case 1 ' Dark
                frmBackColor = Color.FromArgb(255, 13, 15, 18)
                frmForeColor = Color.WhiteSmoke
                grpBackColor = Color.FromArgb(255, 29, 32, 42)
                grpForeColor = Color.WhiteSmoke
                lstBackColor = Color.FromArgb(255, 13, 15, 18)
                lstForeColor = Color.WhiteSmoke
                btnBackColor = Color.FromArgb(255, 13, 15, 18)
                btnForeColor = Color.WhiteSmoke
                txtBackColor = Color.FromArgb(255, 13, 15, 18)
                txtForeColor = Color.WhiteSmoke
                lblForeColor = Color.WhiteSmoke
            Case 2 ' Warm
                frmBackColor = Color.FromArgb(8, 35, 45)
                frmForeColor = Color.FromArgb(238, 208, 161)
                grpBackColor = Color.FromArgb(8, 35, 45)
                grpForeColor = Color.WhiteSmoke
                lstBackColor = Color.FromArgb(8, 30, 45)
                lstForeColor = Color.FromArgb(238, 208, 161)
                btnBackColor = Color.FromArgb(8, 35, 45)
                btnForeColor = Color.FromArgb(238, 208, 161)
                txtBackColor = Color.FromArgb(8, 35, 45)
                txtForeColor = Color.FromArgb(238, 208, 161)
                lblForeColor = Color.FromArgb(238, 208, 161)
            Case 3 ' Blue
                frmBackColor = Color.LightCyan
                frmForeColor = Color.Black
                grpBackColor = Color.LightCyan
                grpForeColor = Color.Black
                lstBackColor = Color.LightBlue
                lstForeColor = Color.Black
                btnBackColor = Color.LightCyan
                btnForeColor = Color.MidnightBlue
                txtBackColor = Color.LightBlue
                txtForeColor = Color.Black
                lblForeColor = Color.Black
            Case 4 ' Red
                frmBackColor = Color.Salmon
                frmForeColor = Color.Black
                grpBackColor = Color.Salmon
                grpForeColor = Color.DarkRed
                lstBackColor = Color.IndianRed
                lstForeColor = Color.Black
                btnBackColor = Color.Salmon
                btnForeColor = Color.Black
                txtBackColor = Color.IndianRed
                txtForeColor = Color.Black
                lblForeColor = Color.Black
            Case 5 ' Green
                frmBackColor = Color.LimeGreen
                frmForeColor = Color.Black
                grpBackColor = Color.LimeGreen
                grpForeColor = Color.Black
                lstBackColor = Color.ForestGreen
                lstForeColor = Color.Black
                btnBackColor = Color.LimeGreen
                btnForeColor = Color.Black
                txtBackColor = Color.ForestGreen
                txtForeColor = Color.Black
                lblForeColor = Color.Black
            Case 6 ' Rnd
                Dim r As New Random()
                frmBackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))
                frmForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))
                grpBackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))
                grpForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))
                lstBackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))
                lstForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))
                btnBackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))
                btnForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))
                txtBackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))
                txtForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))
                lblForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))
            Case Else

        End Select

        'Loops through each parent control in the frm.

        theFrm.ForeColor = frmForeColor
        theFrm.BackColor = frmBackColor

        For Each p As Control In theFrm.Controls ' Each parent control in the form.

            If (TypeOf p Is Panel) Then ' If first layer is Panel.
                For Each c As Control In p.Controls ' All children controls in panel
                    If (TypeOf c Is GroupBox) Then
                        c.ForeColor = grpForeColor
                        c.BackColor = grpBackColor
                        For Each d As Control In c.Controls ' Children of child groupbox.
                            If (TypeOf d Is ListBox) Then
                                d.ForeColor = lstForeColor
                                d.BackColor = lstBackColor
                            End If

                            If (TypeOf d Is Button) Then
                                d.ForeColor = btnForeColor
                                d.BackColor = btnBackColor
                            End If

                            If (TypeOf d Is TextBox) Then
                                d.ForeColor = txtForeColor
                                d.BackColor = txtBackColor
                            End If

                            If (TypeOf d Is ComboBox) Then
                                d.ForeColor = txtForeColor
                                d.BackColor = txtBackColor
                            End If

                            If (TypeOf d Is Label) Then
                                d.ForeColor = lblForeColor
                            End If

                            If (TypeOf d Is CheckBox) Then
                                d.ForeColor = lblForeColor
                            End If

                            If (TypeOf d Is RichTextBox) Then
                                d.ForeColor = txtForeColor
                                d.BackColor = txtBackColor
                            End If
                        Next
                    End If

                Next

            ElseIf (TypeOf p Is StatusStrip) Then ' If first layer is StatusStrip.
                p.ForeColor = frmForeColor
                p.BackColor = frmBackColor
            ElseIf (TypeOf p Is ToolStrip) Then ' If first layer is ToolStrip.
                p.ForeColor = frmForeColor
                p.BackColor = frmBackColor
                For Each o As Object In CType(p, ToolStrip).Items ' Children objects in Toolstrip.

                    If (TypeOf o Is ToolStripButton) Then
                        CType(o, ToolStripButton).ForeColor = frmForeColor
                        CType(o, ToolStripButton).BackColor = frmBackColor
                    ElseIf (TypeOf o Is ToolStripSeparator) Then
                        CType(o, ToolStripSeparator).ForeColor = Color.Transparent
                        CType(o, ToolStripSeparator).BackColor = Color.Transparent
                    ElseIf (TypeOf o Is ToolStripDropDownButton) Then
                        CType(o, ToolStripDropDownButton).ForeColor = btnForeColor
                        CType(o, ToolStripDropDownButton).BackColor = btnBackColor

                        For Each i As ToolStripItem In CType(o, ToolStripDropDownButton).DropDownItems 'Children of each ToolStripDropDownButton Ex: children for btnFile
                            i.ForeColor = btnForeColor
                            i.BackColor = btnBackColor
                            'If (TypeOf i Is ToolStripSeparator) Then
                            '    CType(i, ToolStripSeparator).Visible = False
                            '    CType(i, ToolStripSeparator).BackColor = Color.Transparent
                            'End If
                        Next
                    End If
                Next
            ElseIf (TypeOf p Is TabControl) Then ' (1) First layer is TabControl.
                p.ForeColor = grpForeColor
                p.BackColor = grpBackColor
                For Each c As Control In p.Controls ' (2) Children of the TabControl.
                    c.ForeColor = grpForeColor
                    c.BackColor = grpBackColor
                    For Each d As Control In c.Controls ' (3) Children of the child TabControl
                        d.ForeColor = grpForeColor
                        d.BackColor = grpBackColor
                        If (TypeOf d Is ListBox) Then
                            d.ForeColor = lstForeColor
                            d.BackColor = lstBackColor
                        End If

                        If (TypeOf d Is Button) Then
                            d.ForeColor = btnForeColor
                            d.BackColor = btnBackColor
                        End If

                        If (TypeOf d Is TextBox) Then
                            d.ForeColor = txtForeColor
                            d.BackColor = txtBackColor
                        End If

                        If (TypeOf d Is ComboBox) Then
                            d.ForeColor = txtForeColor
                            d.BackColor = txtBackColor
                        End If

                        If (TypeOf d Is Label) Then
                            d.ForeColor = lblForeColor
                        End If

                        If (TypeOf d Is CheckBox) Then
                            d.ForeColor = lblForeColor
                        End If
                        If (TypeOf d Is RichTextBox) Then
                            d.ForeColor = txtForeColor
                            d.BackColor = txtBackColor
                        End If

                        If (TypeOf d Is GroupBox) Then ' (4) Layer Children of the GroupBox with two parents.
                            For Each e As Control In d.Controls
                                If (TypeOf e Is ListBox) Then
                                    e.ForeColor = lstForeColor
                                    e.BackColor = lstBackColor
                                End If

                                If (TypeOf e Is Button) Then
                                    e.ForeColor = btnForeColor
                                    e.BackColor = btnBackColor
                                End If

                                If (TypeOf e Is TextBox) Then
                                    e.ForeColor = txtForeColor
                                    e.BackColor = txtBackColor
                                End If

                                If (TypeOf e Is ComboBox) Then
                                    e.ForeColor = txtForeColor
                                    e.BackColor = txtBackColor
                                End If

                                If (TypeOf e Is Label) Then
                                    e.ForeColor = lblForeColor
                                End If

                                If (TypeOf e Is CheckBox) Then
                                    e.ForeColor = lblForeColor
                                End If

                                If (TypeOf e Is RichTextBox) Then
                                    e.ForeColor = txtForeColor
                                    e.BackColor = txtBackColor
                                End If

                                If TypeOf e Is GroupBox Then ' (5 ) layer child of 4 generations.
                                    e.ForeColor = grpForeColor
                                    e.BackColor = grpBackColor
                                    For Each f As Control In e.Controls
                                        If (TypeOf f Is ListBox) Then
                                            f.ForeColor = lstForeColor
                                            f.BackColor = lstBackColor
                                        End If

                                        If (TypeOf f Is Button) Then
                                            f.ForeColor = btnForeColor
                                            f.BackColor = btnBackColor
                                        End If

                                        If (TypeOf f Is TextBox) Then
                                            f.ForeColor = txtForeColor
                                            f.BackColor = txtBackColor
                                        End If

                                        If (TypeOf f Is ComboBox) Then
                                            f.ForeColor = txtForeColor
                                            f.BackColor = txtBackColor
                                        End If

                                        If (TypeOf f Is Label) Then
                                            f.ForeColor = lblForeColor
                                        End If

                                        If (TypeOf f Is CheckBox) Then
                                            f.ForeColor = lblForeColor
                                        End If

                                        If (TypeOf f Is RichTextBox) Then
                                            f.ForeColor = txtForeColor
                                            f.BackColor = txtBackColor
                                        End If
                                    Next
                                End If
                            Next

                        End If
                    Next
                Next

            ElseIf (TypeOf p Is GroupBox) Then ' If first layer is groupbox.
                p.ForeColor = grpForeColor
                p.BackColor = grpBackColor
                For Each c As Control In p.Controls

                    If (TypeOf c Is ListBox) Then
                        c.ForeColor = lstForeColor
                        c.BackColor = lstBackColor
                    End If

                    If (TypeOf c Is Button) Then
                        c.ForeColor = btnForeColor
                        c.BackColor = btnBackColor
                    End If

                    If (TypeOf c Is TextBox) Then
                        c.ForeColor = txtForeColor
                        c.BackColor = txtBackColor
                    End If

                    If (TypeOf c Is ComboBox) Then
                        c.ForeColor = btnForeColor
                        c.BackColor = btnBackColor
                    End If

                    If (TypeOf c Is Label) Then
                        c.ForeColor = lblForeColor
                    End If

                    If (TypeOf c Is CheckBox) Then
                        c.ForeColor = lblForeColor
                    End If
                    ' 
                    If (TypeOf c Is RichTextBox) Then
                        c.ForeColor = txtForeColor
                        c.BackColor = txtBackColor
                    End If

                    If (TypeOf c Is GroupBox) Then
                        For Each d As Control In c.Controls
                            If (TypeOf d Is ListBox) Then
                                d.ForeColor = lstForeColor
                                d.BackColor = lstBackColor
                            End If

                            If (TypeOf d Is Button) Then
                                d.ForeColor = btnForeColor
                                d.BackColor = btnBackColor
                            End If

                            If (TypeOf d Is TextBox) Then
                                d.ForeColor = txtForeColor
                                d.BackColor = txtBackColor
                            End If

                            If (TypeOf d Is ComboBox) Then
                                d.ForeColor = btnForeColor
                                d.BackColor = btnBackColor
                            End If

                            If (TypeOf d Is Label) Then
                                d.ForeColor = lblForeColor
                            End If

                            If (TypeOf d Is CheckBox) Then
                                d.ForeColor = lblForeColor
                            End If

                            If (TypeOf d Is RichTextBox) Then
                                d.ForeColor = txtForeColor
                                d.BackColor = txtBackColor
                            End If
                        Next
                    End If
                Next
            End If
        Next

        My.Settings.optBckgrd = val
        My.Settings.Save()
    End Sub


End Class

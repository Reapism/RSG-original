Imports System.Net
Imports System.Numerics
Imports System.Security.Cryptography

''' <summary>
''' The Functions Class
''' <para>A class containing many functions for manipulating strings, checking updates, mutating character lists, and displaying stats. .</para>
''' <para>This class is a general class for most functions that are handled between many forms.</para>
''' </summary>

Public Class Functions
    Private rndSelection As System.Random
    Private rndReap As System.Random
    Private WithEvents time As Timer ' for createtooltip
    Private WithEvents theFrm As Form ' for createtooltip
    Private Const strBound As Short = 4680

    ''' <summary>
    ''' <para>Instantiate instance var.</para>
    ''' </summary>

    Public Sub New()
        rndSelection = New System.Random()
        rndReap = New System.Random(rndSelection.Next(rndSelection.Next(rndSelection.Next(Integer.MaxValue))))
        time = New Timer
    End Sub

    ''' <summary>
    ''' Checks if the path is a valid folder if it exists in your local filesystem.
    ''' <para>Ex. parameters: ("C:\Users\Reapism\ExampleFolder")</para>
    ''' </summary>
    ''' <param name="path"></param>
    ''' <returns></returns>

    Public Shared Function isValidFolder(ByVal path As String) As Boolean
        If My.Computer.FileSystem.DirectoryExists(path) Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Checks if the path is a valid if it exists in your local filesystem.
    ''' <para>Ex. parameters: ("C:\Users\Reapism\Reapism.txt")</para>
    ''' </summary>
    ''' <param name="path"></param>
    ''' <returns></returns>

    Public Shared Function isValidPath(ByVal path As String) As Boolean
        If My.Computer.FileSystem.FileExists(path) Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Checks to see if the string is a valid for all its characters
    ''' <para>1 = IsDigit, 
    ''' 2 = IsLetter
    ''' 3 = isUnicode</para>
    ''' </summary>
    ''' <param name="str"></param>
    ''' <param name="type"></param>
    ''' <returns></returns>

    Public Shared Function isValid(ByVal str As String, ByVal type As Integer) As Boolean
        If type.Equals(1) Then
            For Each c As Char In str
                If Not Char.IsDigit(c) Then
                    Return False
                End If
            Next
            Return True
        ElseIf type.Equals(2) Then
            For Each c As Char In str
                If Not (Char.IsLetter(c)) Then
                    Return False
                End If
            Next
            Return True
        ElseIf type.Equals(3) Then
            Return True
        Else

            Return False
        End If
    End Function

    ''' <summary>
    ''' Returns a string from the start character until the end character.
    ''' </summary>
    ''' <param name="str"></param>
    ''' <param name="start"> The start character.</param>
    ''' <param name="until"> The end character.</param>
    ''' <returns></returns>

    Public Function readUntil(ByVal str As String, ByVal start As Char, ByVal until As Char) As String
        If str.Contains(start) And str.Contains(until) Then
            Return str.Substring(str.IndexOf(start) + 1, str.IndexOf(until) - str.IndexOf(start) - 1)
        Else
            func = New Functions
            createToolTip("Parse String Exception", "Cannot find the specific characters to start and end the string. (" & start & until & ")", "Critical", 2000, True)
        End If
        Return str.Substring(str.IndexOf(start) + 1, str.IndexOf(until) - str.IndexOf(start) - 1)
    End Function

    ''' <summary>
    ''' <para>Requests and obtains the response of the update url. Reads the
    ''' text file from start to finish and compares that to the Application.ProductVersion
    ''' and either downloads the update or returns no updates found.</para>
    ''' </summary>
    ''' <param name="btn"></param>

    Public Sub checkUpdates(ByVal btn As Object)
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://goo.gl/orgKyK")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestVersion As String = sr.ReadToEnd()

        If newestVersion.Contains(My.Settings.version) Then
            btn.Text = "No updates found"
            btn.Enabled = False
        Else
            func = New Functions
            createToolTip("New update: [" & newestVersion & " ]", "View the changelog in the settings!", "Exclamation", 4000, True)
            Dim wb As New WebBrowser
            wb.Navigate("https://goo.gl/WrzfgR")
            btn.Text = "New version! " & newestVersion
        End If
    End Sub

    ''' <summary>
    ''' <para>Checks if the senders text property is unchanging while the mouse wheel is incrementing.</para>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <returns></returns>

    Public Function checkScroll(original As String, sender As Object, e As MouseEventArgs) As Boolean

        If e.Delta > 1 And sender.Text.Equals(original) And My.Settings.scrollErrorShown.Equals(False) Then
            func = New Functions
            createToolTip("Scrolling incrementing inoperative", "The scrolling feature seems to defective. Click the labels instead to change the values.", "Info", 2000, True)
            My.Settings.scrollErrorShown = True
            My.Settings.Save()
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' Download and return an image if the network is available.
    ''' </summary>
    ''' <param name="address"></param>
    ''' <returns></returns>

    Public Shared Function downloadImage(ByRef address As String) As Image
        Dim c As New WebClient
        If My.Computer.Network.IsAvailable Then
            Return Image.FromStream(New IO.MemoryStream(c.DownloadData(address)))
        Else
            func.createToolTip("Download exception", "Network unavailable. Could not download pictures, returning nothing.", "Critical", 4000, True)
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Returns a BigInteger if s could be converted to a BigInteger and is greater than 0 else return 1. 
    ''' </summary>
    ''' <param name="s"></param>
    ''' <returns></returns>

    Public Shared Function isBigInteger(ByRef s As String) As BigInteger
        Dim b As BigInteger = BigInteger.One

        If BigInteger.TryParse(s, b) Then
            If b > BigInteger.Zero Then
                b = BigInteger.Parse(s)
                Return b
            End If
        End If

        Return BigInteger.One
    End Function

    ''' <summary>
    ''' Computes the elapsed time of two timespan objects and returns the result as a string
    ''' formatted to 3 decimal points.
    ''' </summary>
    ''' <param name="s">Start time</param>
    ''' <param name="e">End time</param>
    ''' <returns></returns>

    Public Shared Function genElapsedTime(ByRef s As Date, ByRef e As Date) As String
        Dim result As TimeSpan = e.Subtract(s)
        Dim elapse As String = "Time elapsed: " & result.TotalSeconds.ToString("0.000") & " second(s)."
        Return elapse
    End Function

    ''' <summary>
    ''' <para>Runs the generateString() method as many times as numIter value is.</para>
    ''' Updates the interface.
    ''' </summary>

    Public Sub iterateString(ByVal numIter As BigInteger)
        If (numIter < BigInteger.One) Then
            numIter = BigInteger.One
        End If

        UserInterface.updateInterface(frm.lstGenerate, frm.btnStringLength, frm.btnIterations, frm.lblStringLength, frm.lblNumIterations)
        Dim b As BigInteger = BigInteger.One
        While b <= numIter
            frm.lstGenerate.Items.Add(generateString(var.getStringLength(), var.getAllCharList, var.getRndMethod()))
            b += BigInteger.One
        End While

        frm.lstGenerate.Items.Add(UserInterface.decorateText(42))
        frm.lstGenerate.Items.Add("Finished iterating...")
    End Sub

    ''' <summary>
    ''' <para>Generates a string of any length type int and the specific character list type string.
    ''' Returns the generated string.</para>
    ''' </summary>
    ''' <param name="length"> The length of the string to generate.</param>
    ''' <param name="theCharList"> The characters allowed to generate with.</param>
    ''' <param name= "rndMethod"> The random method.</param>>
    ''' <returns>Returns a random stringstring</returns>

    Public Function generateString(ByVal length As Integer, ByVal theCharList As String, ByVal rndMethod As String) As String
        ' Local var
        Dim charArray() As Char = theCharList.ToCharArray
        Dim theString As String = String.Empty

        If length > 0 Then
            If rndMethod.Equals("Pseudorandom") Then

                While theString.Length < length
                    theString &= charArray(rndSelection.Next(0, charArray.Length))
                End While
            ElseIf rndMethod.Equals("Reap-random") Then
                rndReap = New System.Random(rndSelection.Next(rndSelection.Next(rndSelection.Next())))

                While theString.Length < length
                    theString &= charArray(rndReap.Next(0, charArray.Length))
                End While
            ElseIf rndMethod.Equals("Custom Randomization") Then

            Else
                func = New Functions
                func.createToolTip("Unknown RND method exception", "Somehow the program tried to generate a string with an unknown randomization method.", "Critical", 1500, True)
                Stop

            End If

        Else
            func = New Functions
            func.createToolTip("Cannot parse into integer", "Please enter a valid whole number. Ex: x>0 where x is an integer.", "Critical", 1500, True)
            var.setStringLength(1)
            generateString(length, theCharList, rndMethod)
            UserInterface.updateInterface(frm.lstGenerate, frm.btnStringLength, frm.btnIterations, frm.lblStringLength, frm.lblNumIterations)
        End If

        Return theString
    End Function

    ''' <summary>
    ''' Finds if the string is contained in the listbox and returns the first index it finds it or if it doesn't.
    ''' </summary>
    ''' <param name="lst">Finds a string in the listbox.</param>

    Public Sub findString(ByVal lst As ListBox)
        lst.Focus() 'Makes it's so special keystrokes can register on the listbox.

        Dim str As String = InputBox("Please enter the string to find.", "Find")
        Dim numFound As Integer = 0

        If str <> String.Empty Then
            Dim index As Integer = lst.FindString(str)

            If index <> -1 Then
                lst.SetSelected(index, True)
            Else
                func = New Functions
                func.createToolTip("String isn't contained", "Couldn't find '" & str & "'", "", 5000, True)
            End If
        End If
    End Sub

    Public Sub copyText(ByRef lst As ListBox)
        If lst.SelectedItem.ToString.Length > 0 And (lst.SelectedIndex <> -1) And lst.Items.Item(lst.SelectedIndex).ToString.Length > 0 Then
            Clipboard.SetText(lst.Items.Item(lst.SelectedIndex))
        End If
    End Sub

    Public Sub AnimateButton()
        frm.tmeGenerate.Start()
        frm.btnGenerate.Text = ""
    End Sub

    Public Sub addCharacters(ByVal str As String)
        If str.Length < 1 Or IsNothing(str) Then
            MsgBox("Input is nothing or doesn't exist.", MsgBoxStyle.Critical, "Add Characters Exception")

        Else
            var.addCharList(str)
            updateCharList()
        End If

    End Sub

    Public Function removeCharacters(ByVal str As String) As Boolean
        If str.Length < 1 Or IsNothing(str) Then
            MsgBox("Remove Characters Exception: Input is nothing or doesn't exist.", MsgBoxStyle.Critical, "Remove Characters Exception")
            Return False
        Else
            For Each s As Char In str
                For Each n As Char In var.getCharList()
                    If s.Equals(n) Then
                        var.setCharList(var.getCharList().Replace(s, ""))
                    End If
                Next
            Next
        End If
        updateCharList()
        Return True
    End Function

    ''' <summary>
    ''' Updates the character list.
    ''' </summary>

    Public Sub updateCharList()
        frm.btnDispChar.DropDownItems.Clear()
        If IsNothing(var.getCharList()) Then
        Else
            For Each s As Char In var.getCharList()
                frm.btnDispChar.DropDownItems.Add(s)
            Next
        End If
    End Sub

    ''' <summary>
    ''' Gets the permutations by using the characterList length as the base and then the stringLength as
    ''' the exponent and computing the result to return the permutations..
    ''' </summary>
    ''' <param name="numChar">The character list length.</param>
    ''' <param name="stringLength">The string length of the string.</param>
    ''' <returns></returns>

    Public Function getPermutations(ByVal numChar As Integer, ByVal stringLength As Integer) As BigInteger
        Dim perm As Long
        Dim bigPerm As BigInteger

        If var.getOptUseBigInteger() Then
            bigPerm = BigInteger.Pow(numChar, stringLength)
            Try
                bigPerm = BigInteger.Pow(numChar, stringLength)
            Catch ex As Exception
                Return -1
            End Try
            Return bigPerm
        Else
            Try
                perm = Math.Pow(numChar, stringLength)
            Catch ex As Exception
                Return -1
            End Try
            ' Value is too large to be displayed
            If perm > Long.MaxValue Then
                Return 0
            End If
            Return perm
        End If
    End Function

    ''' <summary>
    ''' <para>Displays the statistical information for the string generator.</para>
    ''' </summary>
    ''' <param name="lst"> The listbox to display the information too.</param>

    Public Sub stringStatistics(lst As ListBox)
        If lst.Visible Then
            lst.Items.Clear()
            lst.Items.Add(UserInterface.decorateText(48))
            lst.Items.Add(UserInterface.addSpaces(19) & "Statistics")
            lst.Items.Add(UserInterface.decorateText(48))
            lst.Items.Add("")
            lst.Items.Add(" String Length: " & var.getStringLength().ToString("n0"))
            lst.Items.Add(" Iterations: " & var.getNumIterations().ToString("n0"))
            lst.Items.Add(" Character List: " & var.getAllCharList())
            lst.Items.Add(" Randomization Method: " & var.getRndMethod())
            lst.Items.Add("")

            Dim str As String = String.Empty
            Dim iterate As Integer = 0
            Dim start As Integer = 5

            For i As Integer = start To ((var.getNumIterations() - 1) + start)
                str += frm.lstGenerate.Items(i)
                iterate += 1
            Next

            Dim maxCount As Integer = str.Max(Function(c1) str.Count(Function(c2) c2 = c1))
            Dim theChar As String = str.First(Function(c1) str.Count(Function(c2) c2 = c1) = maxCount).ToString()

            lst.Items.Add(" Most frequent character: " & theChar & " [" & maxCount & " occurrence(s)]")
            lst.Items.Add("")
            lst.Items.Add(" Permutations of each iteration:")
            Dim perm As BigInteger = BigInteger.Zero

            Try
                perm = getPermutations(var.getAllCharList.Length, var.getString().Length)

                If perm = BigInteger.Zero And perm <> BigInteger.Parse("-1") Then
                    lst.Items.Add(" " & var.getAllCharList().Length() & " ^ " & var.getStringLength().ToString("n0") &
                                  " (" & perm.ToString().Length() & " digit(s))")
                    lst.Items.Add(" The value is too large. Please enable 'BigInteger' in the settings.")
                Else
                    lst.Items.Add(" " & var.getAllCharList().Length() & " ^ " & var.getStringLength().ToString("n0") &
                                  " (" & perm.ToString().Length() & " digit(s))")
                    If perm = BigInteger.Parse("-1") Then
                        lst.Items.Add(" The value is too large. Please enable 'BigInteger' in the settings.")
                    Else
                        lst.Items.Add(" " & perm.ToString("n0"))

                    End If

                    If perm.ToString.Length > 3510 Then
                        lst.Items.Add(" *Display exception*. But you can copy to clipboard!")
                    End If
                End If

                lst.Items.Add("")
                lst.Items.Add("")
                lst.Items.Add(" Probability of each iteration occurring:")

                If perm = BigInteger.Parse("-1") Then
                    lst.Items.Add(" The value is too large. Please enable 'BigInteger' in the settings.")
                    ' lst.Items.Add(" (1 / " & perm.ToString("n0") & ")")
                Else
                    lst.Items.Add(" ( 1 / " & perm.ToString("n0") & ")")
                    If perm.ToString("n0").Length > 3510 Then
                        lst.Items.Add(" *Display exception*. But you can copy to clipboard!")
                    End If
                End If
            Catch ex As Exception
                func = New Functions
                func.createToolTip("Internal exception generating permutations", "If you get this error, " &
                                   "please take a screenshot of your RSG screen!" & ex.Message, "", 10000, True)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' formatBigInteger()
    ''' <para>Formats theStr to add commas to the string using the n0 format.</para>
    ''' </summary>
    ''' <param name="theStr"> The string to format</param>
    ''' <returns></returns>

    Public Function formatBigInteger(ByVal theStr As String) As String
        Return BigInteger.Parse(theStr).ToString("n0")
    End Function

    ''' <summary>
    ''' genLog()
    ''' <para>Accepts a listbox as a parameter and fills it with the log information.</para>
    ''' </summary>
    ''' <param name="lst"></param>

    Public Function genLog(ByVal lst As ListBox) As ListBox
        lst = New ListBox
        stringStatistics(lst)

        lst.Items.Insert(0, "")
        lst.Items.Insert(0, "Time: " & Date.Now)
        lst.Items.Insert(0, "")
        lst.Items.Insert(0, "Autogenerated log file")
        lst.Size = New Size(50, 50)
        lst.Dock = DockStyle.Fill

        Return lst
    End Function

    ''' <summary>
    ''' genForm() --
    ''' Generates a basic form with the option to add context menu of your choice.
    ''' </summary>
    ''' <param name="ctx"></param>
    ''' <returns>Returns the newly created form.</returns>

    Public Function genForm(ByVal title As String, ByVal ctx As ContextMenuStrip) As Form
        Dim newFrm As New Form

        newFrm.Text = title
        newFrm.Size = New Size(400, 400)
        newFrm.Icon = My.Forms.frmStringGen.Icon
        newFrm.ContextMenuStrip = ctx
        newFrm.AutoSize = AutoSizeMode.GrowAndShrink
        newFrm.MaximizeBox = False

        Return newFrm
    End Function

    ''' <summary>
    ''' Prompts the caller to enter a captcha and returns its result as boolean.
    ''' </summary>
    ''' <param name="desc">Describing what the captcha will do.</param>
    ''' <param name="captchaLength">How many characters for the captcha.</param>
    ''' <returns></returns>

    Public Function genCaptcha(ByRef desc As String, ByRef captchaLength As Integer) As Boolean
        If captchaLength < 1 Then
            Return False
        Else
            Dim captcha As String = String.Empty
            For i As Integer = 1 To captchaLength
                captcha += generateString(1, "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", "Reap-random")
            Next

            Dim input As String = InputBox(desc & System.Environment.NewLine & captcha, "Enter the captcha")

            If input.Equals(captcha) Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    ''' <summary>
    ''' Deselects the item selected in the listbox and returns its result.
    ''' </summary>
    ''' <param name="lst"></param>
    ''' <returns></returns>

    Public Function deselectItem(ByVal lst As ListBox) As Boolean
        If lst.SelectedIndex > -1 Then
            lst.SelectedItem = Nothing
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Creates a tooltip window with various information and returns the tooltip as type form.
    ''' <para>Types: 'Info', 'Critical', and 'Exclamation'</para>
    ''' </summary>
    ''' <param name="title">The title of the tooltip.</param>
    ''' <param name="desc">The description of the tooltip.</param>
    ''' <param name="type">Critical, Info, and Exclamation</param>
    ''' <param name="life">Lifetime of the tooltip in milliseconds. If -1, it lasts forever.</param>
    ''' <param name="showForm">Display the form immediately.</param>
    ''' <returns></returns>

    Public Function createToolTip(ByRef title As String, ByRef desc As String, ByRef type As String, ByRef life As Integer, ByRef showForm As Boolean) As Form
        'Contants of sizes of the X, Y's of the controls used.
        Const frmX As Integer = 250
        Const frmY As Integer = 100
        Const picXY As Integer = 30

        'Controls within the form and a font
        Dim txtTitle As New TextBox
        Dim txtDesc As New TextBox
        Dim picType As New PictureBox
        Dim pnlTitle As New Panel
        Dim pnlDesc As New Panel
        Dim fnt As Font
        Dim tip As New ToolTip

        'Assign var values
        If life.Equals(-1) Then
            time.Interval = Integer.MaxValue - 1
        Else
            time.Interval = life
        End If

        txtTitle.Text = title
        txtDesc.Text = desc
        fnt = frm.fntTitle.Font

        theFrm = New Form
        theFrm.KeyPreview = True
        theFrm.Icon = My.Forms.frmStringGen.Icon
        theFrm.BackColor = Color.Silver
        theFrm.FormBorderStyle = FormBorderStyle.None
        theFrm.Size = New Size(frmX, frmY)
        theFrm.TopMost = True
        theFrm.Text = "Autogenerated tooltip"
        theFrm.Cursor = Cursors.Hand

        tip.SetToolTip(theFrm, "Click to close this tooltip.")
        tip.IsBalloon = True

        txtTitle.Font = New Font(fnt.Name, fnt.Size, FontStyle.Bold)
        txtTitle.Dock = DockStyle.Top
        txtTitle.Multiline = False
        txtTitle.ReadOnly = True
        txtTitle.SelectionStart = 0
        txtTitle.BackColor = Color.Silver
        txtTitle.Cursor = Cursors.Hand

        txtDesc.BackColor = Color.Silver
        txtDesc.Multiline = True
        txtDesc.ReadOnly = True
        txtDesc.SelectionStart = 0
        txtDesc.Size = New Size(frmX, frmY - 35)
        txtDesc.Dock = DockStyle.Bottom
        txtDesc.Font = New Font(fnt.Name, 8, FontStyle.Regular)
        txtDesc.Cursor = Cursors.Hand

        pnlTitle.Size = New Size(frmX - picXY, frmY - picXY - (picXY / 0.75))
        pnlTitle.Left += picXY
        pnlDesc.Size = New Size(frmX, frmY)
        pnlTitle.Controls.Add(txtTitle)
        pnlDesc.Controls.Add(txtDesc)

        picType.Size = New Size(picXY, picXY)
        picType.BackgroundImageLayout = ImageLayout.Stretch

        txtTitle.SendToBack()
        picType.BringToFront()

        If type.Equals("Info") Then
            picType.BackgroundImage = My.Resources.stringInfo
            txtTitle.ForeColor = Color.Black
        ElseIf type.Equals("Critical") Then
            picType.BackgroundImage = My.Resources.stringCritical
            txtTitle.ForeColor = Color.DarkRed
        ElseIf type.Equals("Exclamation") Then
            picType.BackgroundImage = My.Resources.stringExclamation
            txtTitle.ForeColor = Color.DarkGreen
        End If

        theFrm.Controls.Add(picType)
        theFrm.Controls.Add(pnlTitle)
        theFrm.Controls.Add(pnlDesc)

        'Tag each control to be used by the click event
        For Each c As Control In theFrm.Controls
            AddHandler c.MouseClick, AddressOf theFrm_ClickHandler
            AddHandler txtTitle.Click, AddressOf theFrm_ClickHandler
            AddHandler txtDesc.Click, AddressOf theFrm_ClickHandler
        Next

        If showForm Then
            theFrm.Show()
        End If

        theFrm.Location = New Point(Cursor.Position.X + 10, Cursor.Position.Y - 35)
        time.Start()
        time.Enabled = True

        Return theFrm
    End Function

    ''' <summary>
    ''' Timer_Tick
    ''' <para>Handles the global varibles time tick method. Used for createToolTip</para>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time.Tick
        time.Stop()
        theFrm.Close()
    End Sub

    ''' <summary>
    ''' theFrm_ClickHandler
    ''' <para> Handles click events for theFrm</para>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub theFrm_ClickHandler(sender As Object, e As MouseEventArgs) Handles theFrm.MouseClick
        If e.Button = MouseButtons.Left Then
            theFrm.Close()
        End If
    End Sub
End Class

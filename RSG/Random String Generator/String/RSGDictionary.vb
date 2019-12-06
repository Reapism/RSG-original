Imports System.Numerics
Imports System
Imports System.IO
Imports System.Net

Public Class RSGDictionary
    Private numWords As BigInteger
    Private theDictionary As Specialized.StringCollection
    Private rnd As System.Random

    Private dictName As String
    Private dictNumWords As Long
    Private dictSize As Long
    Private dictPath As String
    Private dictDesc As String
    Private selectedDict As Integer
    Private numDefDicts As Integer
    Private numAppendedNoise As Integer
    Private numPunc As Integer
    Private numChars As BigInteger
    Private WithEvents w As WebClient
    Private WithEvents ctx As ContextMenuStrip

    ''' <summary>
    ''' Default constructor to defaulty initialize the variables.
    ''' </summary>

    Public Sub New()
        numDefDicts = 6
        dictName = String.Empty
        dictNumWords = 0
        dictSize = 0
        dictPath = String.Empty
        dictDesc = String.Empty
        numWords = 5
        rnd = New System.Random()
        theDictionary = New Specialized.StringCollection
        numAppendedNoise = 0
        numPunc = 0
        numChars = BigInteger.Zero
    End Sub

    ''' <summary>
    ''' Parameterized constructor to initialize the variables with different values.
    ''' </summary>
    ''' <param name="numWords"></param>

    Public Sub New(ByRef numWords As BigInteger)
        numDefDicts = 6
        dictName = String.Empty
        dictNumWords = 0
        dictSize = 0
        dictPath = String.Empty
        dictDesc = String.Empty
        rnd = New System.Random()
        theDictionary = New Specialized.StringCollection
        numAppendedNoise = 0
        numPunc = 0
        numChars = BigInteger.Zero

        Me.numWords = numWords
    End Sub

    ''' <summary>
    ''' If it's the first time opening the dictionary window, instantiate all the dictionary properties.
    ''' <para>This will remove all previous data within them.</para>
    ''' </summary>

    Public Sub firstTime()
        If My.Settings.dictFirstTime Then
            My.Settings.dictName = New Specialized.StringCollection()
            My.Settings.dictNumWords = New Specialized.StringCollection()
            My.Settings.dictSize = New Specialized.StringCollection()
            My.Settings.dictPath = New Specialized.StringCollection()
            My.Settings.dictDesc = New Specialized.StringCollection()

            dict.lblChooseDir.Text = "Choose default directory"
            dict.barDownload.Value = 0
            dict.tsFirstTime.Visible = True
            dict.grpProperties.Enabled = False
            dict.grpDisplay.Enabled = False
            dict.grpSettings.Enabled = False
            dict.tmeFlash.Enabled = True
            getDefaultDicts()
            My.Settings.dictFirstTime = False
            My.Settings.Save()
        Else
            dict.tsFirstTime.Visible = False
        End If
    End Sub

    Public Sub chooseDir()
        If getDir().Equals("") Then
            MsgBox("Browse for a folder to save all the dictionaries. This will be " &
                   "the default folder to read and create all your dictionaries.",
                   MsgBoxStyle.Information, "Choose a directory")
        End If

        If setDir() Then
            dict.tmeFlash.Enabled = False
            dict.lblChooseDir.ForeColor = Color.DarkGreen
            dict.lblChooseDir.Text = "Default directory saved!"
            downloadDict()
            dispDictionaries(dict.cmbWordList)

        End If
    End Sub

    ''' <summary>
    ''' Downloads the default dictionaries
    ''' </summary>

    Public Sub downloadDict()
        If My.Computer.Network.IsAvailable Then
            Dim theUri As New Uri(My.Settings.dictPath.Item(0))
            w = New WebClient
            w.DownloadFileAsync(theUri, getDir() & "\" & My.Settings.dictName.Item(0) & ".txt")
            Dim i As Integer = 1

            While i < 6
                theUri = New Uri(My.Settings.dictPath.Item(i))
                w = New WebClient
                w.DownloadFileAsync(theUri, getDir() & "\" & My.Settings.dictName.Item(i) & ".txt")
                i += 1
            End While
        Else
            func = New Functions
            func.createToolTip("Network Disconected", "There seems to be an issue with your network. Cannot download default dictionaries", "Critical", 6000, True)
            My.Settings.dictFirstTime = True
            dict.Close()
        End If
    End Sub

    ''' <summary>
    ''' Parent method: downloadDict()
    ''' <para>Gets and sets the progress bar of the dictionary to the progress of the download</para>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub downloadProgress(sender As Object, e As DownloadProgressChangedEventArgs) Handles w.DownloadProgressChanged
        dict.barDownload.Value = e.ProgressPercentage
        dict.barDownload.ToolTipText = "Download progress: {" & e.BytesReceived & "/" & e.TotalBytesToReceive & "}"

        If e.BytesReceived.Equals(e.TotalBytesToReceive) Then
            setDefLoc()
            dict.grpDisplay.Enabled = True
            dict.grpProperties.Enabled = True
            dict.grpSettings.Enabled = True
            dict.tsFirstTime.Visible = False
            showDictStats(dict.cmbWordList, dict.txtDictInfo)

        End If
    End Sub

    ''' <summary>
    ''' Show information regarding the selected dictionary.
    ''' </summary>
    ''' <param name="cmb">The combobox to get the selected dictionary.</param>
    ''' <param name="txt">The textbox to display the information.</param>

    Public Sub showDictStats(ByRef cmb As ComboBox, ByRef txt As RichTextBox)
        txt.Clear()
        toggleGen(readDictionary(My.Settings.dictPath(cmb.SelectedIndex)))

        For Each item In getDictStats(cmb.SelectedIndex)
            txt.AppendText(item + System.Environment.NewLine)
        Next

        txt.SelectionStart = 1
        txt.ScrollToCaret()

    End Sub

    ''' <summary>
    ''' Replace the current dictionary with a new dictionary into memory.
    ''' </summary>
    ''' <param name="theDictionary"></param>
    ''' <returns></returns>

    Public Function setDictionary(ByRef theDictionary As Specialized.StringCollection) As Boolean
        Me.theDictionary = theDictionary
        Return True
    End Function

    ''' <summary>
    ''' Reads the selected dictionary into memory and stores it in theDictionary.
    ''' </summary>
    ''' <returns></returns>

    Public Function readDictionary(ByRef path As String) As Boolean
        theDictionary = New Specialized.StringCollection
        If Functions.isValidPath(path) Then
            Dim readText() As String = File.ReadAllLines(path)

            For Each i In readText
                theDictionary.Add(i)
            Next

            Return True
        Else
            Return False

        End If
    End Function

    ''' <summary>
    ''' Enables and disables the generate button based on if the dictionary is the north.
    ''' </summary>
    ''' <param name="enable"></param>

    Public Sub toggleGen(ByRef enable As Boolean)
        If enable Then
            dict.btnGenerate.Text = "Generate random words with this ruleset"
            dict.btnGenerate.Enabled = True
        Else
            dict.btnGenerate.Text = "You must load a dictionary generate"
            dict.btnGenerate.Enabled = False
        End If
    End Sub

    Public Function useAlliterations() As Specialized.StringCollection
        Dim newDict As New Specialized.StringCollection ' the new dictionary resulting from the use of aliterations
        Dim oldC As Char = theDictionary.Item(0).Substring(0, 1) 'Old character
        Dim charList() As Char
        Dim s As String = String.Empty
        Dim r As Char = ""
        Dim rnd As New Random

        For Each newC In theDictionary 'loops through each word in the dictonary
            If Not newC.Substring(0, 1).Equals(oldC) Then ' checks the first letter of each word.
                s += newC
            End If
        Next
        charList = s.ToCharArray()
        r = charList.ElementAt(rnd.Next(charList.Count))
        func = New Functions
        func.createToolTip("Random character", "The random character selected is " & r, "Info", 3000, True)

        For Each word In theDictionary ' loop through each word in the dictionary
            If word.Substring(0, 1).Equals(r) Then ' gets all words that start with the random character
                newDict.Add(word)
            End If
        Next
        Return newDict
    End Function

    ''' <summary>
    ''' Display's the passed [words] into a specific textbox.
    ''' </summary>

    Public Sub displayWords(ByRef words As Specialized.StringCollection, ByRef txt As RichTextBox)
        If My.Settings.dictDispStat Then

            For Each s In getStats()
                txt.AppendText(s & UserInterface.newLine())
            Next
        End If

        For Each word In words
            txt.AppendText(word)
        Next

        'txt.AppendText(UserInterface.newLine() & UserInterface.newLine() & UserInterface.decorateText(49) & UserInterface.newLine())
        'txt.AppendText(UserInterface.addSpaces(15) & "Generated " & getNumWords().ToString("n0") & " word(s)!" & UserInterface.newLine())
        'txt.AppendText(UserInterface.decorateText(49))

    End Sub

    ''' <summary>
    ''' Formats the word collection from the parameter and then returns it.
    ''' </summary>
    ''' <param name="words">Generated word list to format.</param>

    Public Sub formatWords(ByRef words As Specialized.StringCollection)
        numAppendedNoise = 0
        numPunc = 0

        If My.Settings.dictFirstLtrUp Then
            Dim newWords As New Specialized.StringCollection

            For Each word In words
                newWords.Add(word.Substring(0, 1).ToUpper & word.Substring(1, word.Length - 1))
            Next

            words = newWords
        End If

        If My.Settings.dictUsePunc Then
            Dim p() As Char = ",.?!:;'".ToCharArray()
            Dim newWords As New Specialized.StringCollection
            Dim rnd As New System.Random
            numPunc = 0

            For Each word In words
                rnd = New Random(rnd.Next)
                Dim usePunc As Boolean = (rnd.Next(100) Mod 3).Equals(rnd.Next(3))
                If usePunc Then
                    newWords.Add(word & p(rnd.Next(p.Length)))
                    numPunc += 1
                Else
                    newWords.Add(word)
                End If
            Next

            words = newWords
        End If

        If My.Settings.dictAppendNoise Then
            Dim n() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789`~?<>,.:;'[]{}\|-=_+".ToCharArray()
            Dim newWords As New Specialized.StringCollection
            Dim rnd As New System.Random
            numAppendedNoise = 0

            For Each word In words
                rnd = New Random(rnd.Next)
                Dim useNoise As Boolean = (rnd.Next(100) Mod 3).Equals(rnd.Next(3))
                If useNoise Then
                    newWords.Add(word.Insert(rnd.Next(word.Length), n(rnd.Next(n.Length))))
                    numAppendedNoise += 1
                Else
                    newWords.Add(word)
                End If
            Next
            words = newWords
        End If

        If My.Settings.dictUseSpace Then
            Dim newWords As New Specialized.StringCollection
            For Each word In words
                newWords.Add(word & " ")
            Next
            words = newWords
        End If

        displayWords(words, dict.txtOutput)
    End Sub

    ''' <summary>
    ''' Generates a specific number of words using the dictionary instance variable.
    ''' </summary>
    ''' <param name="numWords">The number of words to generate.</param>

    Public Sub genWords(ByRef numWords As BigInteger, ByRef rndMethod As Short)
        Dim i As BigInteger = BigInteger.One
        Dim w As New Specialized.StringCollection 'A collection of words

        Dim r As New Random(4)

        While i <= numWords
            If rndMethod.Equals(CShort(1)) Then
                w.Add(theDictionary.Item(rnd.Next(theDictionary.Count))) 'Add a random word to w.
            ElseIf rndMethod.Equals(CShort(2)) Then
                rnd = New Random(rnd.Next(theDictionary.Count))
                w.Add(theDictionary.Item(rnd.Next(theDictionary.Count))) 'Add a random word to w.
            Else
                rndMethod = 1
            End If

            i = BigInteger.op_Increment(i)
        End While

        'count the number of characters in the generated words
        If My.Settings.dictAppendNoise Or My.Settings.dictUsePunc Then
            numChars = BigInteger.Zero
            For Each c As String In w
                numChars += c.Length
            Next
        End If
        formatWords(w)
    End Sub

    ''' <summary>
    ''' Returns the number of words to generate.
    ''' </summary>
    ''' <returns></returns>

    Public Function getNumWords() As BigInteger
        Return numWords
    End Function

    ''' <summary>
    ''' Sets the instance variable 'numWords' to s and returns its result.
    ''' </summary>
    ''' <param name="b">The number to set the number of words to.</param>

    Public Sub setNumWords(ByRef b As BigInteger)
        numWords = b
    End Sub

    ''' <summary>
    ''' Loads the dictionary settings from the app config and sets the checkbox state to the current setting.
    ''' </summary>

    Public Sub loadSettings()
        dict.chkFirstLetterUp.Checked = My.Settings.dictFirstLtrUp
        dict.chkUseSpace.Checked = My.Settings.dictUseSpace
        dict.chkUsePunc.Checked = My.Settings.dictUsePunc
        dict.chkDispStats.Checked = My.Settings.dictDispStat
        dict.chkUseNoise.Checked = My.Settings.dictAppendNoise
        dict.chkThread.Checked = My.Settings.dictThreadTask
        dict.radPseudo.Checked = My.Settings.dictRndMethod.Equals(CShort(1))
        dict.radReap.Checked = My.Settings.dictRndMethod.Equals(CShort(2))
    End Sub

    ''' <summary>
    '''
    ''' </summary>
    ''' <param name="cmb">The combo box to read and set.</param>
    ''' <param name="index">The new index for the dictionary.</param>
    ''' <param name="name"></param>
    ''' <param name="desc"></param>

    Public Sub addDictionary(ByRef cmb As ComboBox, ByRef index As Integer, Optional ByRef name As String = "", Optional ByRef desc As String = "")
        dictName = name
        dictDesc = desc

        'If nothing is entered into the name and desc parameters, reinstantiate them.

        If name.Equals("") Or desc.Equals("") Then
            dictName = InputBox("Please enter a name for your dictionary.", "Please name your dictionary", "DictionaryName")
            dictDesc = InputBox("Please enter a description for your dictionary.", "Describe your dictionary", "This dictionary contains plurals words, hypenated words, and names of Twitch emotes...")
        End If

        'Choose the local path to save and read all future dictionaries.

        If Not getDirExists() Then
            MsgBox("Browse for a folder to save this dictionary. This will be the default folder to read all your custom dictionaries.", MsgBoxStyle.Information, "Browse for location")

            setDir()
        End If
        'Browse for the dictionary to add.

        Dim browseDict As New OpenFileDialog

        With browseDict
            .Title = "Browse for a dictionary"
            .DefaultExt = ".txt"
            .FilterIndex = 1
            .RestoreDirectory = True
            .Filter = "Text Files (*.txt)|*.txt"
            .InitialDirectory = getDir()
            .ShowDialog(dict)
        End With

        'Makes a copy of the previous dictionary and saves it into the default directory.
        Dim sb As New System.Text.StringBuilder()
        Dim reader As New System.IO.StreamReader(browseDict.FileName)
        Dim numWords As Integer = 0

        If Functions.isValidPath(browseDict.FileName) Then
            For Each line As String In reader.ReadToEnd
                sb.Append(line)
            Next
            setDictNumWords(getNextIndex(My.Settings.dictName), numWords)

        Else

        End If

        dictPath = getDir() & "\" & dictName & ".txt"
        System.IO.File.WriteAllText(dictPath, sb.ToString(), System.Text.Encoding.Unicode)

        ' Sets the rest of the dictionary properties.

        dictSize = FileLen(dictPath)
        dictNumWords = calcNumWords(sb.ToString())

        'Adds the new dictionary in the settings.
        My.Settings.dictName.Insert(index, dictName)
        My.Settings.dictNumWords.Insert(index, dictNumWords)
        My.Settings.dictSize.Insert(index, dictSize)
        My.Settings.dictPath.Insert(index, dictPath)
        My.Settings.dictDesc.Insert(index, dictDesc)



        cmb.Items.Add(dictName)
        dispDictionaries(cmb)
        My.Settings.Save()
    End Sub

    ''' <summary>
    ''' Create and return the statistics for this case.
    ''' </summary>
    ''' <returns></returns>

    Public Function getStats() As Specialized.StringCollection
        Dim s As New Specialized.StringCollection

        s.Add(UserInterface.decorateText(49))
        s.Add(UserInterface.addSpaces(8) & "Generating statistics for this case.")
        s.Add(UserInterface.decorateText(49))
        s.Add(" Dictionary: " & CStr(dict.cmbWordList.SelectedItem))
        s.Add(" Number of words: " & getNumWords().ToString("n0"))

        If My.Settings.dictRndMethod.Equals(CShort(1)) Then
            s.Add(" Randomization: Pseudorandom")
        ElseIf My.Settings.dictRndMethod.Equals(CShort(2)) Then
            s.Add(" Randomization: Reap-random")
        End If
        s.Add(" Number of punctuation appended: " & numPunc)
        s.Add(" Number of noise appended: " & numAppendedNoise)
        s.Add(" Permutations of " & getNumWords().ToString("n0") & " words")
        s.Add("")

        Dim b As BigInteger = BigInteger.Zero
        Dim exp As Integer = 0

        If Integer.TryParse(getNumWords().ToString, exp) Then
            exp = Integer.Parse(getNumWords().ToString)
            b = BigInteger.Pow(My.Settings.dictNumWords.Item(dict.cmbWordList.SelectedIndex), exp)
            s.Add(" Permutations of this dictionary ruleset is " & My.Settings.dictNumWords.Item(dict.cmbWordList.SelectedIndex) & "^" &
                    exp & " (" & b.ToString.Length.ToString("n0") & ") digit(s)")
            s.Add("")

            If dict.chkShowHeavy.Checked Then
                s.Add(b.ToString("n0"))
            Else
                s.Add("")
            End If
            Dim noisePerm As BigInteger = BigInteger.Pow(26, CInt(numChars))
            If dict.chkUseNoise.Checked Then
                s.Add(" Given an a-z dictionary, Permutations with noise is " & 82 & "^" &
                   numChars.ToString("n0") & " (" & noisePerm.ToString.Length.ToString("n0") & ") digit(s)" & UserInterface.newLine())
            End If

        Else
            s.Add(" Permutations of dictionary is " & My.Settings.dictNumWords.Item(dict.cmbWordList.SelectedIndex) & "^" &
        exp & " (many...) digit(s)")
            s.Add("")

            If dict.chkShowHeavy.Checked Then
                s.Add(b.ToString("n0"))
                s.Add("")
            Else
                s(11) = " Value too large to really display here, trust me."
                s.Add("")

            End If

            If dict.chkUseNoise.Checked Then
                s.Add(" Given an a-z dictionary, Permutations with noise is ~ " & 82 & "^" &
                   numChars.ToString("n0") & " (many...) digit(s)" & UserInterface.newLine())
            End If
        End If

        Return s
    End Function

    ''' <summary>
    ''' Generates a log file based on a string collection and displays it to the user with a context menu strip.
    ''' </summary>
    ''' <param name="s">The string collection to use to populate the listbox.</param>

    Public Sub genLog(ByRef s As Specialized.StringCollection)
        Dim f As New Form
        Dim l As New ListBox

        f.Size = New Size(700, 500)
        f.Text = "Autogenerated log-file for this instance"
        f.Controls.Add(l)

        ctx.Items.Add("Export Log...")


        l.ContextMenuStrip = ctx
        l.Dock = DockStyle.Fill

        For Each txt In s
            l.Items.Add(txt)
        Next
        f.Show()

    End Sub

    ''' <summary>
    ''' Gets the next available index in a string collection
    ''' </summary>
    ''' <param name="s">The string collection to get the next index.</param>
    ''' <returns></returns>

    Public Function getNextIndex(ByRef s As Specialized.StringCollection) As Integer
        Return s.Count
    End Function

    ''' <summary>
    ''' Prompts user for a captcha and if entered correctly removes the dictionary.
    ''' <para>Returns 2 if file doesn't exist to be removed.</para>
    ''' <para>Returns 1 if moved to recyclebin.</para>
    ''' <para>Returns 0 if captcha was wrong.</para>
    ''' <para>Returns -1 if the selected dictionary is not in the appdata settings.</para>
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns></returns>

    Public Function remDictionary(ByRef cmb As ComboBox, ByRef index As Integer) As Integer
        If Not IsNothing(My.Settings.dictName.Item(index)) And CInt(cmb.SelectedIndex > 5) Then
            If func.genCaptcha("Are you sure you want to delete the '" & cmb.SelectedItem.ToString() & "' dictionary?", 5) Then
                If My.Computer.FileSystem.FileExists(My.Settings.dictPath.Item(index)) Then
                    My.Computer.FileSystem.DeleteFile(My.Settings.dictPath.Item(index))
                    My.Settings.dictName.RemoveAt(index)
                    My.Settings.dictNumWords.RemoveAt(index)
                    My.Settings.dictSize.RemoveAt(index)
                    My.Settings.dictPath.RemoveAt(index)
                    My.Settings.dictDesc.RemoveAt(index)
                    cmb.Items.RemoveAt(index)
                    cmb.SelectedIndex = 0
                    Return 1
                Else
                    My.Settings.dictName.RemoveAt(index)
                    My.Settings.dictNumWords.RemoveAt(index)
                    My.Settings.dictSize.RemoveAt(index)
                    My.Settings.dictPath.RemoveAt(index)
                    My.Settings.dictDesc.RemoveAt(index)
                    cmb.Items.RemoveAt(index)
                    cmb.SelectedIndex = 0
                    Return 2
                End If
            Else
                Return 0
            End If
        Else
            Return -1
        End If
    End Function

    ''' <summary>
    ''' Displays the dictionary stats into a string array for the specified dictionary in the array.
    ''' </summary>
    ''' <param name="index"></param>

    Public Function getDictStats(ByRef index As Integer) As String()
        If Functions.isValidPath(My.Settings.dictPath(index)) Then
            Dim str(5) As String

            str(0) = "Dictionary name: " & My.Settings.dictName.Item(index).ToString
            str(1) = String.Empty
            str(2) = "Number of words: " & FormatNumber(My.Settings.dictNumWords.Item(index), 0)
            str(3) = "Size: " & FormatNumber(My.Settings.dictSize.Item(index), 0) & " bytes"
            str(4) = String.Empty
            str(5) = "Description: " & My.Settings.dictDesc.Item(index)
            toggleGen(True)
            Return str
        Else
            Dim str(1) As String
            str(0) = "The path to this dictionary is not valid."
            str(1) = "Please remove & create the dictionary."
            toggleGen(False)
            Return str
        End If

    End Function

    ''' <summary>
    ''' Sets the path of the specified dictionary in the settings.
    ''' </summary>
    ''' <param name="index">The index to set the path.</param>
    ''' <param name="path">Path can be a URL or a local location on a HD.</param>

    Public Sub setPath(ByRef index As Integer, ByRef path As String)
        My.Settings.dictPath(index) = path
    End Sub

    ''' <summary>
    ''' Returns the path of the specified dictionary. 
    ''' </summary>
    ''' <param name="index">Index of the dictionary.</param>
    ''' <returns></returns>

    Public Function getPath(ByRef index As Integer) As String
        Return My.Settings.dictPath.Item(index)
    End Function

    ''' <summary>
    ''' Prompts the user to choose a directory for the default dictionary until it succeeds and sets the settings property.
    ''' </summary>

    Public Function setDir() As Boolean
        theDictionary = New Specialized.StringCollection

        toggleGen(False)
        'Clear all dictionaries from the current directory.
        Dim result As Integer
        'Check if there was a previous directory, then display the dialog.
        If getDir().Length > 0 Then
            result = MessageBox.Show("In order for the dictionary to work properly, it needs to wipe this directory clean. " &
            "Confirm this is the previous/current directory and there exists nothing of importance in it." &
            System.Environment.NewLine & System.Environment.NewLine & "Confirm to wipe this directory?" &
            System.Environment.NewLine & getDir(), "Confirm RSG jurisdiction", MessageBoxButtons.YesNo)
        End If

        'Check if the previous directory is valid, and wipes the old directory.
        If Functions.isValidFolder(getDir()) And result.Equals(DialogResult.Yes) Then
            Dim allFiles() As String = Directory.GetFiles(getDir())

            For Each path In allFiles 'Over here u can check if its a file made by RSG and then delete it.
                Try
                    My.Computer.FileSystem.DeleteFile(path, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                Catch ex As Exception
                    func = New Functions
                    func.createToolTip("Delete exception.", "Can't delete current files in directory. " & ex.Message, "Critical", 5000, True)
                End Try
            Next

            My.Settings.dictDir = ""
            My.Settings.dictDirExists = False
        End If

        Dim browseDir As New FolderBrowserDialog
        With browseDir
            .SelectedPath = Nothing
            .Description = "Select a folder to save your local dictionaries. Please note: By selecting " &
            "a folder, you give RSG full jurisdiction in this directory, it can add files And remove any file."
            .ShowNewFolderButton = True
            .RootFolder = Environment.SpecialFolder.Desktop
            .ShowDialog(dict)
        End With

        If Functions.isValidFolder(browseDir.SelectedPath) Then
            My.Settings.dictDir = browseDir.SelectedPath
            My.Settings.dictDirExists = True
            func = New Functions
            func.createToolTip("Success", "Default directory saved.", "Exclamation", 2500, True)

            Return True
        Else
            func = New Functions
            func.createToolTip("Selected Path Exception", "The path you selected Or didn't doesn't exist on the file system.", "Critical", 6000, True)
            setDir()
            Return False
        End If
    End Function

    ''' <summary>
    ''' Returns the local path for all custom dictionaries from the settings.
    ''' </summary>
    ''' <returns></returns>

    Public Function getDir() As String
        Return My.Settings.dictDir
    End Function

    ''' <summary>
    ''' Returns if a default dictionary directory exists.
    ''' </summary>
    ''' <returns></returns>

    Public Function getDirExists() As Boolean
        Return My.Settings.dictDirExists
    End Function

    ''' <summary>
    ''' Gets the file size of the specified dictionary as long.
    ''' </summary>
    ''' <param name="index">The number of bytes as type long.</param>
    ''' <returns></returns>

    Public Function getBytes(ByRef index As Integer) As Long
        Return CInt(My.Settings.dictSize.Item(index))
    End Function

    ''' <summary>
    ''' Counts the number of lines in a string builder. Typically what the dictionary is read into.
    ''' </summary>
    ''' <param name="s">The string to check.</param>
    ''' <returns></returns>
    Public Function calcNumWords(ByVal s As String) As Long
        Dim c As System.Text.RegularExpressions.MatchCollection = System.Text.RegularExpressions.Regex.Matches(s, "\S+")
        Return c.Count
    End Function

    ''' <summary>
    ''' Sets the number of words in the dictionary.
    ''' </summary>
    ''' <param name="index">The index of the dictionary.</param>
    ''' <param name="num">The number to set in the index.</param>
    ''' <returns></returns>

    Public Function setDictNumWords(ByRef index As Integer, ByRef num As Long) As Boolean
        My.Settings.dictNumWords.Insert(index, num)
        Return True
    End Function

    ''' <summary>
    ''' Gets the number of words contained in the specified dictionary.
    ''' </summary>
    ''' <param name="index">The index of the dictionary.</param>
    ''' <returns></returns>

    Public Function getNumWords(ByRef index As Integer) As Long
        Return CInt(My.Settings.dictNumWords.Item(index))
    End Function

    ''' <summary>
    ''' Adds the list of dictionaries to the argument passed into the parameter cmb.
    ''' </summary>
    ''' <param name="cmb">The combobox to add the dictionaries too.</param>

    Public Sub dispDictionaries(ByRef cmb As ComboBox)
        cmb.Items.Clear()

        For Each i In My.Settings.dictName
            cmb.Items.Add(i)
        Next
        If cmb.Items.Count > 0 Then
            cmb.SelectedIndex = 0
        End If
    End Sub

    Public Sub setDefLoc()
        Dim dictPath(5) As String

        dictPath(0) = getDir() & "\" & My.Settings.dictName(0) & ".txt"
        dictPath(1) = getDir() & "\" & My.Settings.dictName(1) & ".txt"
        dictPath(2) = getDir() & "\" & My.Settings.dictName(2) & ".txt"
        dictPath(3) = getDir() & "\" & My.Settings.dictName(3) & ".txt"
        dictPath(4) = getDir() & "\" & My.Settings.dictName(4) & ".txt"
        dictPath(5) = getDir() & "\" & My.Settings.dictName(5) & ".txt"

        My.Settings.dictPath.Clear()

        For i As Integer = 0 To 5 ' For 6 default dictionaries
            My.Settings.dictPath.Insert(i, dictPath(i))
        Next

    End Sub


    ''' <summary>
    ''' Instantiate all default dictionaries and set them in the settings.
    ''' </summary>

    Public Sub getDefaultDicts()
        ' Default Dictionaries:
        ' Corncob, Jlawler, MD5, Moby, Ridyhew, and Scowl.
        My.Settings.dictName = New Specialized.StringCollection
        My.Settings.dictNumWords = New Specialized.StringCollection
        My.Settings.dictSize = New Specialized.StringCollection
        My.Settings.dictPath = New Specialized.StringCollection
        My.Settings.dictDesc = New Specialized.StringCollection

        Dim dictName(5) As String
        Dim dictNumWords(5) As Long
        Dim dictSize(5) As Long
        Dim dictPath(5) As String
        Dim dictDesc(5) As String

        dictName(0) = "Corncob"
        dictNumWords(0) = 58100
        dictSize(0) = 600806
        dictPath(0) = "https://drive.google.com/uc?export=download&id=1WR002XgSPtw37xNob-obmnzzyC6sLmN5"
        dictDesc(0) = "Corncob Is a wordlist made by http://www.mieliestronk.com/wordlist.html. " &
                      "With a humble wordlist of about 58,000 words, word groups are included And hyphenated " &
                      "words are included without the hypen."

        dictName(1) = "Jlawler"
        dictNumWords(1) = 69903
        dictSize(1) = 735585
        dictPath(1) = "https://drive.google.com/uc?export=download&id=1BBGxh6-wqRmvRup-AL4lNQ1bjqWLy20L"
        dictDesc(1) = "Jlawler Is a wordlist made by John Lawler (http://www-personal.umich.edu/~" &
                      "jlawler/wordlist.html). The wordlist mentions having most of the words are rare, And " &
                      "obsolete. Doesn't include apostrophes."

        dictName(2) = "MD5"
        dictNumWords(2) = 291612
        dictSize(2) = 3320693
        dictPath(2) = "https://drive.google.com/uc?export=download&id=1kBLZGbHv18um4X8yof21wFQyXEd1PzVv"
        dictDesc(2) = "MD5 is a wordlist made by http://www.md5this.com/tools/wordlists.html. There are many wordlists on this site " &
                      "but this Is the English version modified And removed a chunk of nouns. This huge wordlist " &
                      "contains so much words. Doesn’t include apostrophes."

        dictName(3) = "Moby"
        dictNumWords(3) = 370099
        dictSize(3) = 4234874
        dictPath(3) = "https://drive.google.com/uc?export=download&id=1Ro4JtPkTGx6Pub6yUQBrsAGNLXPbBRm4"
        dictDesc(3) = "Moby is a wordlist made by Grady Ward on (http://www.gutenberg.org/ebooks/3201). " &
            "This wordlist is gigantic and just has so many words its kinda hard to describe what it " &
            "contains and doesn't. The webpage doesn't have too much information on it."

        dictName(4) = "Ridyhew"
        dictNumWords(4) = 459026
        dictSize(4) = 5504530
        dictPath(4) = "https://drive.google.com/uc?export=download&id=1z7I_y-3EPoBg_UwzfW34Uv-M8HE3IbxG"
        dictDesc(4) = "Ridyhew is a wordlist created on the website (http://www.codehappy.net/wordlist.htm). " &
            "Ridyhew stands for RIDiculouslY Huge English Wordlist. The webpage clearly indicates whats included " &
            "and excluded so I'll just say this is the largest default list I offer in the program and it contains " &
            "so many words its incredible."

        dictName(5) = "Scowl"
        dictNumWords(5) = 219495
        dictSize(5) = 2681981
        dictPath(5) = "https://drive.google.com/uc?export=download&id=1CQUFpva_ZENaOocliyrAnZf1e62kSylu"
        dictDesc(5) = "Scowl is a wordlist created by (http://wordlist.aspell.net/). Scowl stands for Spell " &
            "Checker Oriented Word Lists. It's used to test how common a word is and etc. They have a neat " &
            "wordlist though. You can also create your own wordlist on this page, maybe worth checking out!"

        For i As Integer = 0 To 5 ' For 6 default dictionaries
            My.Settings.dictName.Add(dictName(i))
            My.Settings.dictNumWords.Add(dictNumWords(i).ToString())
            My.Settings.dictSize.Add(dictSize(i).ToString())
            My.Settings.dictPath.Add(dictPath(i))
            My.Settings.dictDesc.Add(dictDesc(i))
        Next

    End Sub

End Class

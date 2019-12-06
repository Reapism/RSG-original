Imports System.Numerics

Public Class RSGSearch
    Private expectedCharList As String 'The expected character list
    Private searchIterations As BigInteger 'Number of iterations of bruteforcing
    Private searchText As String 'The string you're searching
    Private computePerm As Boolean 'If true, will compute the permutations and store it in numDigits.
    Private numDigits As ULong ' Stores the number of digits the permutations is for the search.
    Private runSrch As Boolean ' Used to determine whether the search() function should run or terminate.
    Private msg As Specialized.StringCollection ' The message displaying whether the bruteforcing is feasible or not.

    Public Sub New()
        expectedCharList = String.Empty
        searchText = String.Empty
        searchIterations = BigInteger.One
        computePerm = True
        RunSearch = True
        msg = New Specialized.StringCollection
    End Sub

    Public Property RunSearch As Boolean
        Get
            Return runSrch
        End Get
        Set(value As Boolean)
            runSrch = value
        End Set
    End Property

    ''' <summary>
    ''' Return the expected character list.
    ''' </summary>
    ''' <returns></returns>

    Public Function getCharList() As String
        Return expectedCharList
    End Function

    ''' <summary>
    ''' Displays information regarding the string in 
    ''' </summary>
    ''' <param name="charList"></param>
    ''' <param name="txt"></param>

    Public Sub dispCEM(ByRef s As String, ByRef charList As String, ByRef txt As TextBox)
        txt.Clear()
        txt.AppendText("Statistics for this string: " & UserInterface.newLine() & UserInterface.newLine())
        txt.AppendText("String to search: " & s & UserInterface.newLine())
        txt.AppendText("String length: " & s.Length & UserInterface.newLine() & UserInterface.newLine())
        txt.AppendText("Expected character list:" & UserInterface.newLine())
        txt.AppendText(charList)
        txt.AppendText(UserInterface.newLine() & UserInterface.newLine() & "Character List Length: " & expectedCharList.Length)
    End Sub

    ''' <summary>
    ''' Gets the character list from s and returns the character list as string.
    ''' </summary>
    ''' <param name="s">String to figure out the character list.</param>
    ''' <returns></returns>

    Public Function useCEM(ByVal s As String) As String
        Dim capital As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim lowercase As String = "abcdefghijklmnopqrstuvwxyz"
        Dim number As String = "0123456789"
        Dim symbol As String = " ,.?!"

        Dim capsPresent = capital.Any(Function(ch) s.Contains(ch))
        Dim lowercasePresent = lowercase.Any(Function(ch) s.Contains(ch))
        Dim numberPresent = number.Any(Function(ch) s.Contains(ch))
        Dim symbolPresent = symbol.Any(Function(ch) s.Contains(ch))
        expectedCharList = String.Empty

        If capsPresent Then
            expectedCharList += capital.ToString
        End If

        If lowercasePresent Then
            expectedCharList += lowercase
        End If

        If numberPresent Then
            expectedCharList += number
        End If

        If symbolPresent Then
            expectedCharList += symbol
        End If

        ' Check if a character does not appear in s
        For Each c As String In s
            If Not expectedCharList.Contains(c) Then
                expectedCharList += c
            End If
        Next

        Return expectedCharList
    End Function

    ''' <summary>
    ''' Display the password character list in the textbox.
    ''' </summary>
    ''' <param name="s">The string searching</param>
    ''' <param name="c">The character list</param>
    ''' <param name="txt">The textbox to use.</param>

    Public Sub dispPswd(ByRef s As String, ByRef c As String, ByRef txt As TextBox)
        txt.Clear()
        txt.AppendText("Statistics for this string: " & UserInterface.newLine() & UserInterface.newLine())
        txt.AppendText("String to search: " & s & UserInterface.newLine())
        txt.AppendText("String length: " & s.Length & UserInterface.newLine() & UserInterface.newLine())
        txt.AppendText("Expected character list: " & expectedCharList & UserInterface.newLine() & UserInterface.newLine())
        txt.AppendText("Character List Length: " & expectedCharList.Length)
    End Sub

    ''' <summary>
    ''' Sets the character list to a custom string.
    ''' </summary>

    Public Function usePswd(ByRef s As String) As String
        expectedCharList = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 {}()[]#;:^,.?!|&_`~@$%/\=+-*'"""
        For Each c As String In s
            If Not expectedCharList.Contains(c) Then
                expectedCharList += c
            End If
        Next
        Return expectedCharList
    End Function

    ''' <summary>
    ''' Sets the search string.
    ''' </summary>
    ''' <param name="s"></param>

    Public Sub setString(ByRef s As String)
        searchText = s
    End Sub

    Public Function getString() As String
        Return searchText
    End Function

    ''' <summary>
    ''' Performs a recursive search on the private member variable searchText.
    ''' </summary>
    ''' <param name="s">Temporary string to search.</param>
    ''' <param name="c">The character list to bruteforce through.</param>
    ''' <returns></returns>

    Public Function search(ByRef s As String, ByRef c As String) As Boolean
        If RunSearch Then

            For i As Integer = 0 To c.Length() - 1
                If ((s + c.ElementAt(i)).Equals(getString())) Then
                    Return True
                Else
                    searchIterations = BigInteger.op_Increment(searchIterations)
                    If (s.Length + 1 < getString().Length()) Then
                        If search(s + c.ElementAt(i), c) Then
                            Return True
                        End If
                    End If
                End If
            Next
        Else
            Return False
        End If

        Return False
    End Function

    ''' <summary>
    ''' Returns the current iterations of the string.
    ''' </summary>
    ''' <returns></returns>

    Public Function getNumIterations() As BigInteger
        Return searchIterations
    End Function

    Public Sub resetNumIterations()
        searchIterations = BigInteger.One
    End Sub

    Public Sub stopSearch(ByRef s As frmSearch, ByRef bg As ComponentModel.BackgroundWorker)
        Dim e As Date = Date.Now
        s.timeSec.Enabled = False
        computePerm = True
        RunSearch = False
        resetNumIterations()
        s.btnStop.Enabled = False
        s.btnStart.Enabled = True
        s.btnRefresh.Enabled = True

        s.txtResult.AppendText(UserInterface.newLine() & Functions.genElapsedTime(s.getStartTime(), e))

        If bg.IsBusy Then
            bg.CancelAsync()
        End If
    End Sub

    Public Sub refresh(ByRef s As frmSearch, ByRef bg As ComponentModel.BackgroundWorker)
        s.txtResult.Clear()
        s.timeSec.Enabled = False
        computePerm = True
        RunSearch = True
        resetNumIterations()
        s.btnRefresh.Enabled = False
        bg.CancelAsync()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="txt"></param>
    Public Sub setStats(ByRef txt As RichTextBox)
        Static start As Date

        txt.Clear()
        txt.AppendText(UserInterface.decorateText(49) & UserInterface.newLine())
        txt.AppendText(UserInterface.addSpaces(11) & "Statistics for this search:" & UserInterface.newLine())
        txt.AppendText(UserInterface.decorateText(49) & UserInterface.newLine())
        txt.AppendText("" & UserInterface.newLine())
        txt.AppendText("Searching for: " & getString() & UserInterface.newLine())
        txt.AppendText("Character list: " & getCharList() & UserInterface.newLine())
        txt.AppendText("" & UserInterface.newLine())


        ' Calculates the permuatations only once for high performance.
        If computePerm Then
            start = Date.Now ' resets the time to now only once.
            numDigits = func.getPermutations(getCharList().Length, getString().Length).ToString().Length
            txt.AppendText("Permutations is " & getCharList().Length & " ^ " & getString().Length &
                           "[ " & numDigits & " digit(s) ]" & UserInterface.newLine())
            If My.Settings.srchHeavyStatistics Then
                txt.AppendText("Permutations: " & func.getPermutations(getCharList().Length, getString().Length).ToString("n0") & UserInterface.newLine())
            End If

            createMessage(getNumIterations(), msg, My.Settings.srchHeavyStatistics)
            computePerm = False
        Else
            txt.AppendText("Permutations is " & getCharList().Length & " ^ " & getString().Length &
                           "[ " & numDigits & " digit(s) ]" & UserInterface.newLine())
            If My.Settings.srchHeavyStatistics Then
                txt.AppendText("Permutations: " & func.getPermutations(getCharList().Length, getString().Length).ToString("n0") & UserInterface.newLine())
            End If
        End If

        txt.AppendText("" & UserInterface.newLine())
        txt.AppendText("Iterated: " & getNumIterations().ToString("n0") & UserInterface.newLine())

        Dim e As Date = Date.Now
        txt.AppendText(UserInterface.newLine() & Functions.genElapsedTime(start, e) & UserInterface.newLine())

        ' Writes the message.
        For Each item In msg
            txt.AppendText(item & UserInterface.newLine())
        Next
    End Sub

    Public Sub loadSettings(ByRef s As frmSearch)
        s.chkHeavy.Checked = My.Settings.srchHeavyStatistics
    End Sub

    ''' <summary>
    ''' Using the average number of iterations and how many orders of magnitude the permuations is...
    ''' <para> Returns a message based on estimated time left and </para></summary>
    ''' <param name = "iter">iterations</param>
    ''' <param name="m">The string collection to add the message to.</param>
    ''' <param name="hvy">Will display heavy statistics.</param>

    Public Sub createMessage(ByRef iter As BigInteger, ByRef m As Specialized.StringCollection,
                             ByRef hvy As Boolean)
        m = New Specialized.StringCollection

        Dim perMin As BigInteger = BigInteger.Multiply(iter, BigInteger.Parse("60"))
        Dim perHour As BigInteger = BigInteger.Multiply(perMin, BigInteger.Parse("60"))
        Dim perDay As BigInteger = BigInteger.Multiply(perHour, BigInteger.Parse("24"))
        Dim perYear As BigInteger = BigInteger.Multiply(perDay, BigInteger.Parse("365"))

        If hvy Then
            m.Add("*Special Heavy Statistics*")
            m.Add("You will iterate " & perMin.ToString("n0") & " times per minute.")
            m.Add("You will iterate " & perHour.ToString("n0") & " times per hour.")
            m.Add("You will iterate " & perDay.ToString("n0") & " times per day")
            m.Add("You will iterate " & perYear.ToString("n0") & " times per year")
            m.Add("")
        Else
            m.Add("General Statistics:")
            m.Add("You will iterate ~1.0 x 10^" & perMin.ToString().Length.ToString("n0") & " times per minute.")
            m.Add("You will iterate ~1.0 x 10^" & perHour.ToString().Length.ToString("n0") & " times per hour.")
            m.Add("You will iterate ~1.0 x 10^" & perDay.ToString().Length.ToString("n0") & " times per day.")
            m.Add("You will iterate ~1.0 x 10^" & perYear.ToString().Length.ToString("n0") & " times per year.")
            m.Add("")
        End If

    End Sub

    Public Function getMessage() As Specialized.StringCollection
        Return msg
    End Function

End Class

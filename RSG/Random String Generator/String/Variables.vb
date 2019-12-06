Imports System.Numerics

Public Class Variables

    ''' <summary>
    ''' Title: The Variable Class
    ''' Description: Contains all the global var and their respective
    ''' accessor and mutator methods.
    ''' </summary>
    '''

    Private optAdvancedInfo As Boolean
    Private optAnimate As Boolean
    Private optBoundStringLength As Boolean
    Private optCapLetters As Boolean
    Private optClipboard As Boolean
    Private optLowLetters As Boolean
    Private optNumbers As Boolean
    Private optShowStatistics As Boolean
    Private optSymbols As Boolean
    Private optUseBigInteger As Boolean

    Private allCharList As String
    Private charList As String
    Private animText As String
    Private devMode As String
    Private langStr As String

    Private maxInterval As Short
    Private minInterval As Short
    Private numIterations As BigInteger
    Private textLength As Short
    Private rndMethod As Integer
    Private stringLength As BigInteger

    Private rnd As New System.Random

    Public Sub New()
        optAdvancedInfo = False
        optAnimate = True
        optBoundStringLength = My.Settings.optBound
        optCapLetters = True
        optClipboard = My.Settings.optClip
        optLowLetters = False
        optNumbers = True
        optShowStatistics = False
        optSymbols = False
        optUseBigInteger = My.Settings.optBigInt
        rndMethod = My.Settings.optRndMethod

        allCharList = String.Empty
        charList = String.Empty
        animText = "Generate new random string(s)..."
        devMode = "ReapismDev"
        langStr = String.Empty
        'dictName = My.Settings.dictName
        'dictAddress = String.Empty

        maxInterval = 300
        minInterval = 20
        numIterations = 1
        textLength = 0
        stringLength = 10
    End Sub

    Public Function getOptAdvancedInfo() As Boolean
        Return optAdvancedInfo
    End Function

    Public Function getOptAnimate() As Boolean
        Return optAnimate
    End Function

    Public Function getOptBndStrLgth() As Boolean
        Return optBoundStringLength
    End Function

    Public Function getOptCapLetters() As Boolean
        Return optCapLetters
    End Function

    Public Function getOptClipboard() As Boolean
        Return optClipboard
    End Function

    Public Function getOptLowLetters() As Boolean
        Return optLowLetters
    End Function

    Public Function getOptNumbers() As Boolean
        Return optNumbers
    End Function

    Public Function getOptShowStatistics() As Boolean
        Return optShowStatistics
    End Function

    Public Function getOptSymbols() As Boolean
        Return optSymbols
    End Function

    Public Function getOptUseBigInteger() As Boolean
        Return optUseBigInteger
    End Function

    ''' <summary>
    ''' Gets the entire character list.
    ''' </summary>
    ''' <returns></returns>

    Public Function getAllCharList() As String
        allCharList = String.Empty
        If optCapLetters Then
            allCharList += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        End If
        If optLowLetters Then
            allCharList += "abcdefghijklmnopqrstuvwxyz"
        End If

        If optNumbers Then
            allCharList += "0123456789"
        End If

        If optSymbols Then
            allCharList += " ,.?!"
        End If

        allCharList += getCharList()
        allCharList += getLanguage()
        If allCharList.Length < 1 Then

            MsgBox("Somehow there is no characters to generate with. Reverting to default list (A-Z, 0-9).", MsgBoxStyle.Critical, "No Character List Exception")
            allCharList += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            allCharList += "0123456789"
            optCapLetters = True
            optNumbers = True
            frm.btnUppercase.Checked = True
            frm.btnNum.Checked = True
        End If
        Return allCharList
    End Function

    Public Function getLanguage() As String
        Return langStr
    End Function

    ''' <summary>
    ''' Gets only the custom character list.
    ''' </summary>
    ''' <returns></returns>

    Public Function getCharList() As String
        Return charList
    End Function

    Public Function getCharText() As String
        Return animText
    End Function

    Public Function getDevMode() As String
        Return devMode
    End Function

    Public Function getMinInterval() As Short
        Return minInterval
    End Function

    Public Function getMaxInterval() As Short
        Return maxInterval
    End Function

    Public Function getNumIterations() As BigInteger
        Return numIterations
    End Function

    Public Function getTextLength() As Short
        Return textLength
    End Function

    Public Function getRndMethod() As String
        Dim str As String = String.Empty
        If rndMethod = 1 Then
            str = "Pseudorandom"
        ElseIf rndMethod = 2 Then
            str = "Reap-random"
        ElseIf rndMethod = 3 Then
            str = "Custom Randomization"
        Else
            str = "Pseudorandom"
        End If

        Return str
    End Function

    Public Function getStringLength() As BigInteger
        Return stringLength
    End Function

    Public Function getString() As String
        Return frm.lstGenerate.Items(5).ToString ' the sixth index is the first generated string.
    End Function

    ''' ================ '''
    ''' MUTATORS METHODS '''
    ''' ================ '''

    Public Function setOptAdvancedInfo(ByVal bool As Boolean) As Boolean
        optAdvancedInfo = bool
        Return optAdvancedInfo
    End Function

    Public Function setOptAnimate(ByVal bool As Boolean) As Boolean
        optAnimate = bool
        Return optAnimate
    End Function

    Public Function setOptBndStrLgth(ByVal bool As Boolean) As Boolean
        optBoundStringLength = bool
        Return optBoundStringLength
    End Function

    Public Function setOptCapLetters(ByVal bool As Boolean) As Boolean
        optCapLetters = bool
        Return optCapLetters
    End Function

    Public Function setOptClipboard(ByVal bool As Boolean) As Boolean
        optClipboard = bool
        Return optClipboard
    End Function

    Public Function setOptLowLetters(ByVal bool As Boolean) As Boolean
        optLowLetters = bool
        Return optLowLetters
    End Function

    Public Function setOptNumbers(ByVal bool As Boolean) As Boolean
        optNumbers = bool
        Return optNumbers
    End Function

    Public Function setOptShowStatistics(ByVal bool As Boolean) As Boolean
        optShowStatistics = bool
        Return optShowStatistics
    End Function

    Public Function setOptSymbols(ByVal bool As Boolean) As Boolean
        optSymbols = bool
        Return optSymbols
    End Function

    Public Function setOptUseBigInteger(ByVal bool As Boolean) As Boolean
        optUseBigInteger = bool
        Return optUseBigInteger
    End Function

    Public Function setCharList(ByVal str As String) As String
        charList = str
        func.updateCharList()
        func.stringStatistics(frm.lstStatistics)
        Return charList
    End Function

    Public Function addCharList(ByVal str As String) As String
        charList += str
        func.updateCharList()
        func.stringStatistics(frm.lstStatistics)
        Return charList
    End Function

    Public Function removeCharList(ByVal str As String) As Boolean
        'The removeCharacters() function in the functions class seems to be working. Saving this method for backup in the future.
        MsgBox("var")
        Dim c As Integer = 0
        For Each s As Char In str
            For Each n As Char In charList
                If s.Equals(n) Then
                    charList.Remove(charList.IndexOf(n))
                    c += 1
                End If
            Next
        Next
        If c > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub resetCharList()
        charList = Nothing
        func.updateCharList()
        func.stringStatistics(frm.lstStatistics)
    End Sub

    Public Function setCharText(ByVal str As String) As String
        animText = str
        Return animText
    End Function

    Public Sub resetCharText(ByVal str As String)
        animText = Nothing
        func.stringStatistics(frm.lstStatistics)
    End Sub

    Public Function setMinInterval(ByVal sh As Short) As Short
        minInterval = sh
        Return minInterval
    End Function

    Public Function setMaxInterval(ByVal sh As Short) As Short
        maxInterval = sh
        Return maxInterval
    End Function

    Public Sub setNumIterations(ByVal b As BigInteger)
        numIterations = b
    End Sub

    Public Function setTextLength(ByVal sh As Short) As Short
        textLength = sh
        Return textLength
    End Function

    ''' <summary>
    ''' setRndMethod() --
    '''<para>1 = "Pseudorandom"</para>
    '''<para>2 = "Reap-random"</para>
    '''<para>3 = "Custom Randomization"</para>
    '''<para>Else = "Pseudorandom"</para> 
    ''' </summary>
    ''' <param name="int"></param>
    ''' <returns></returns>

    Public Function setRndMethod(ByVal int As Integer) As Boolean
        If int.Equals(1) Or int.Equals(2) Or int.Equals(3) Then
            rndMethod = int
            Return True
        Else
            rndMethod = 1
            Return False
        End If
    End Function

    Public Sub setStringLength(ByRef b As BigInteger)
        stringLength = b
    End Sub
End Class

Public Class frmHelp

    Private link(8) As String
    Private index As Short

    Public Sub New()
        InitializeComponent()
        index = 7
    End Sub

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles Me.Load
        picHelp.BackgroundImageLayout = ImageLayout.Stretch
        setLinks()
        nextPic(index)
        setText(index, txtHelp)
    End Sub

    Private Sub setLinks()
        link(0) = "https://drive.google.com/uc?export=download&id=1y1Rz26uIJ3izUEmZKEozShn9vs8h9bja" ' autogen
        link(1) = "https://drive.google.com/uc?export=download&id=1J3ZzytaBdq2JnWKiytKAljupADLjw3N9" ' change strings
        link(2) = "https://drive.google.com/uc?export=download&id=1dLhROUgYw5mnZ19c9_Lv7rm5qvseqDR7" ' dictionary
        link(3) = "https://drive.google.com/uc?export=download&id=1S-r1tcGN9J7Vq_nyF-WtOCaykljBSlKF" ' search
        link(4) = "https://drive.google.com/uc?export=download&id=1easFYwlNt0wk5PWupDNbS8Yj-ezUk2E3" ' settings
        link(5) = "https://drive.google.com/uc?export=download&id=1eir1DF6FP_6UmmTOFHKp1nJMj2pA-aPE" ' statistics
        link(6) = "https://drive.google.com/uc?export=download&id=1UvXpa27D4Dqtx67wCuTy_huOVjh_-0Jc" ' tooltips
        link(7) = "https://drive.google.com/uc?export=download&id=1db3972il3RvFV6U7EdgiCKhE7114W90T" ' welcome
    End Sub

    Private Sub setText(ByRef s As Short, ByRef txt As RichTextBox)
        txt.Clear()

        Select Case s
            Case 0
                txt.AppendText("(2/8) The autogenerate form: A form used solely to generate random strings " &
                               "from (n --> unending). Click  ") ' autogen
            Case 1
                txt.AppendText("(3/8) You may scroll over the highlighted areas to change the string length " &
                               "or iterations or click to change the values. You may also do so in " &
                               "various places within the program") 'change strings
            Case 2
                txt.AppendText("(4/8) The dictionary: A form used to generate random words of any size " &
                               "using the six default dictionaries, or one you create from your " &
                               "own. In red is where the generated words are, and highlighted are " &
                               "various properties to tweak.") ' dictionary
            Case 3
                txt.AppendText("(5/8) Search: A form used to search for a specific string using a form of " &
                               "bruteforce.") ' search
            Case 4
                txt.AppendText("(6/8) Control various settings within the generator and other application " &
                               "settings such as checking updates on load.") ' settings
            Case 5
                txt.AppendText("(7/8) Statistics is common among the different forms to display various " &
                               "information about the task.") ' statistics
            Case 6
                txt.AppendText("(8/8) Not sure what something does? Likely each control will have a help tip " &
                               "when you hover over it.") ' tooltips
            Case 7
                txt.AppendText("(1/8) Welcome to RSG! Click on the image to cycle through each picture!") ' welcome
                s = -1
        End Select
        nextIndex(index)
    End Sub

    Private Sub nextPic(ByRef s As Short)
        If s <= link.Length - 1 Then
            picHelp.BackgroundImage = Functions.downloadImage(link(s))
        End If
    End Sub

    Private Sub picHelp_Click(sender As Object, e As EventArgs) Handles picHelp.Click
        nextPic(index)
        setText(index, txtHelp)
    End Sub

    Private Sub nextIndex(ByRef s As Short)
        If s >= link.Length Then
            s = 0
        Else
            s += 1
        End If
    End Sub

    Private Sub frmHelp_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Finalize() ' call destructor
    End Sub
End Class
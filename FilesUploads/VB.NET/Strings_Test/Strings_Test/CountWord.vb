Public Class CountWord

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim sentence As String
        ''Dim i As Integer
        'Dim wc As Integer
        'sentence = TextBox1.Text
        'Dim obj As New CountWords

        ''Dim arr() As Char = sentence.ToCharArray
        ''For i = 0 To arr.Length - 1

        ''    If arr(i) = " " Then
        ''        wc = wc + 1
        ''    End If
        ''Next
        ''MsgBox("Total Words : " & wc + 1)
        'wc = obj.wordCount(sentence)

        'MessageBox.Show("Total Word Count is " & wc)

        Dim s As String


        s = TextBox1.Text
        Dim strSplit() As String
        strSplit = s.Split(" ")
        'MsgBox(strSplit)
        MsgBox("Number of words: " & strSplit.Length)

    End Sub
End Class

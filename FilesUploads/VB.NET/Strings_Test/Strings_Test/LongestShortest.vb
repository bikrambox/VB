Public Class LongestShortest

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As String = TextBox1.Text
        Dim words() = s.Split(" ")

        Dim max As String = words(0), min As String = words(0)

        Dim w As String
        For Each w In words
            If (w.Length > max.Length) Then
                max = w
            End If
            If (w.Length < min.Length) Then
                min = w
            End If
        Next
        TextBox2.Text = min
        TextBox3.Text = max


    End Sub
End Class
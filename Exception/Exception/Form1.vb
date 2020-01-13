Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        a = TextBox1.Text

        If a > 130 Then
            Throw New System.Exception("age cannot be greater than 130")
        Else
            MsgBox("your age" & a)
        End If
    End Sub
End Class

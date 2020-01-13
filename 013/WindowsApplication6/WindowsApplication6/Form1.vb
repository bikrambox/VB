Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x, g, n, i, sum As Integer
        n = Val(TextBox1.Text)
        x = 0
        y = 1
        Print(x)
        Print(y)
        For i = 3 To n
            sum = x + y
            Print(sum)
            x = y
            y = sum
            y = sum
        Next i
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class

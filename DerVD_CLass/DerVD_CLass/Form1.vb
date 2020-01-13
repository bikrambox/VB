Public Class Oculus
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, ans As Byte
        Try
            n = TextBox1.Text
            ans = 2 / n
        Catch ex As System.OverflowException
            MsgBox("Please Enter a Number other than Zero")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class

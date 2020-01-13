Public Class Form1

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim num, num1, reman As Integer, res As Integer = 0

        num = Val(TextBox1.Text)
        num1 = num
        While (num1 <> 0)
            reman = num1 Mod 10
            res = res + (reman * reman * reman)
            num1 = num1 \ 10
        End While

        If num = res Then
            MsgBox(num & " is an armstrong number")

        Else
            MsgBox(num & " is not an armstrong number")

        End If





    End Sub
End Class

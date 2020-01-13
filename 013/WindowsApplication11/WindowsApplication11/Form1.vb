Public Class Form1

    Sub armfunc(ByVal Val As Integer)

        Dim num, num1, reminder As Integer, res As Integer = 0
        num = Val
        num1 = num
        If TextBox1.Text = Nothing Then
            MsgBox("textbox cannot be empty")
            Me.Close()
        End If

        While (num1 <> 0)
            reminder = num1 Mod 10
            res = res + (reminder * reminder * reminder)
            num1 = num1 \ 10


        End While
        If num = res Then
            MsgBox(num & " is a armstrong number")

        Else

            MsgBox(num & " not a armstrong number")


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        armfunc(Val(TextBox1.Text))
    End Sub
End Class

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim check As Integer

        check = 1

        Dim num As Integer

        num = TextBox1.Text

        For i = 2 To (num - 1)

            If num Mod i = 0 Then

                check = 0

                Exit For

            End If

        Next

        If check = 0 Then

            MsgBox("Not prime")

        Else

            MsgBox("prime")

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        MsgBox("clear")
    End Sub
End Class

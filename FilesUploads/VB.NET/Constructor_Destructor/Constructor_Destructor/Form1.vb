Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As New ConstrDestr(3)

        MsgBox(c.area)

    End Sub
End Class

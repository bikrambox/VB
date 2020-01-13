Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p As New Person()
        p.BaseMethod()


        Dim c As New Customer()
        c.BaseMethod()
        c.DerivedMethod()

    End Sub
End Class

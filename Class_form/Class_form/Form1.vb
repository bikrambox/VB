Public Class Oculus
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obh As New Class_lib.classics
        obh.opus = 9
        '... ' MsgBox(obh.opus)
        MsgBox(obh.minus())
    End Sub
End Class
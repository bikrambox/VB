Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        isprime = "The Number is Prime"
        notprime = "The Number is not Prime"
        primeness = True
        For x = 2 To Sqr(N)
            If N / x = Int(N / x) Then primeness = False : Exit For
        Next
        Status = IIf(primeness, isprime, notprime)
    End Sub
End Class

Public Class ConstrDestr
    Dim s As Double
    Sub New(ByVal side As Double)
        s = side
    End Sub

    Public Function area() As Double
        Return (s * s)
    End Function

    Protected Overrides Sub Finalize()
        'creating a Destructor
        MsgBox("I am a destructor")

    End Sub

End Class


Public Class Person
    Public Sub BaseMethod()
        MsgBox("Person")
    End Sub
End Class

Public Class Customer
    Inherits Person
    Public Sub DerivedMethod()
        MyBase.BaseMethod()
    End Sub
End Class




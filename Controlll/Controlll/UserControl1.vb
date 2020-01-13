Public Class Managen


    Property number1() As Integer
        Get
            Return number1
        End Get
        Set(ByVal value As Integer)
            TextBox1.Text = value
        End Set
    End Property

    Property number2() As Integer

        Set(ByVal value As Integer)
            TextBox2.Text = value
        End Set
        Get
            number2 = value
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = Val(TextBox1.Text) + Val(TextBox2.Text)
        MsgBox(n)

    End Sub
End Class

Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i1, i2, i3 As Integer


        i1 = Val(TextBox1.Text)
        i2 = Val(TextBox2.Text)
        i3 = i1 + i2
        TextBox3.Text = i3
        If TextBox1.Text = Nothing And TextBox2.Text = Nothing Then
            MsgBox("empty")

        End If


    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = ""
        TextBox3.Text = " "
        MsgBox("clear")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

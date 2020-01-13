Public Class Form1
    Dim arr(,) As Integer
    Dim x, y, z As Integer
    Dim r, c As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        r = TextBox1.Text
        c = TextBox2.Text
        ReDim arr(r, c)
        TextBox3.Focus()
        x = 0
        y = 0
        z = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        arr(x, y) = TextBox3.Text
        TextBox3.Focus()
        TextBox3.Text = ""
        MsgBox(x & " " & y)
        If x = r - 1 And y = c - 1 Then
            Button2.Enabled = False
            TextBox3.Enabled = False
            For x = 0 To r - 1
                For y = 0 To c - 1
                    ListBox1.Items.Add(arr(x, y))
                Next
            Next
        End If
        If (y < c - 1) Then
            y = y + 1
        Else
            x = x + 1
            y = z
        End If
    End Sub
End Class

Public Class Form5
    Dim dt As DataTable
    Dim dr As DataRow


    ' Private Sub Form1_Load(……) Handles Me.Load
    '   Module1.connect()
    '  End Sub
    Private Sub Form5_Load() Handles Me.Load
        Module1.connect()
        dt = Module1.ds.Tables.Item(“mandex")
        For Each dr In dt.Rows
            ListBox1.Items.Add(dr.Item("ID"))
        Next

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim found As Boolean

        For Each dr In dt.Rows
            If dr.Item("ID") = CInt(ListBox1.SelectedItem) Then
                TextBox1.Text = dr.Item("maName")
                TextBox2.Text = dr.Item("maMark")
                found = True
            End If
        Next

        If Not found Then
            MsgBox("Any student with this ID does not exist", MsgBoxStyle.OkOnly, "Error")
            TextBox2.Clear()
            TextBox1.Clear()
            ListBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Oculus.Show()
        Me.Close()

    End Sub

End Class
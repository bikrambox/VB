Public Class Form4
    Dim dt As DataTable
    Dim dr As DataRow
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = Module1.ds.Tables.Item(“mandex")
        For Each dr In dt.Rows
            ListBox1.Items.Add(dr.Item("ID"))
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For Each dr In dt.Rows
            If dr.Item("ID") = CInt(ListBox1.SelectedItem) Then
                TextBox1.Text = dr.Item("maName")
                TextBox2.Text = dr.Item("maMark")
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim index As Integer
        Dim ans As Integer
        index = CInt(ListBox1.SelectedIndex)
        ans = MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo, "Message Info")
        If ans = vbYes Then
            dt.Rows.Item(index).Delete()
        End If
        TextBox1.Clear()
        TextBox2.Clear()
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button1.Enabled = False Then
            Module1.update(dt)
        End If
        Me.Close()
        Oculus.Show()
    End Sub
End Class

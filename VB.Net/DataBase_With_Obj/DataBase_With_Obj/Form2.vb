Imports System.Data.OleDb

Public Class Form2

    Dim dID As Integer
    Dim dmaName As String
    Dim dmaMarks As Integer
    Dim dt As DataTable
    Dim dr As DataRow


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim n As Integer
        dt = Module1.ds.Tables.Item(“mandex")
        For Each dr In dt.Rows
            n = dr.Item("ID")
        Next
        n = n + 1
        TextBox3.Text = n

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Enabled = False Then
            Module1.update(dt)
        End If
        Me.Close()
        Oculus.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dID = CInt(TextBox1.Text)
        dmaName = TextBox2.Text
        dmaMarks = CInt(TextBox3.Text)
        dt = Module1.ds.Tables.Item(“mandex")
        dr = dt.NewRow()
        dr.Item("ID") = dID
        dr.Item("maName") = dmaName
        dr.Item("maMark") = dmaMarks
        dt.Rows.Add(dr)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
        Button2.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("you wanna bang? oh sorry Hang", MsgBoxStyle.YesNo, "Message info")
    End Sub
End Class
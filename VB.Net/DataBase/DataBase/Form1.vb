Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3DataSet.mandex' table. You can move, or remove it, as needed.
        Me.MandexTableAdapter.Fill(Me.Database3DataSet.mandex)

    End Sub
End Class

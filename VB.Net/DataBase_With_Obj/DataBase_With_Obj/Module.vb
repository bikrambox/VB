Imports System.Data.OleDb

Module Module1
    Public conn As New OleDbConnection()
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter()
    Public ds As New DataSet("mandexSet")

    Public Sub connect()
        conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\mandex\Documents\Database3.accdb"
        conn.Open()
        conn.Close()
        cmd.CommandText = "Select * from mandex"
        cmd.Connection = conn
        da.SelectCommand = cmd
        da.Fill(ds, “mandex")

    End Sub

    Public Sub update(ByVal dt As DataTable)
        Dim comBld As New OleDbCommandBuilder(da)
        Dim ndt As DataTable
        ndt = dt.GetChanges()
        dt.AcceptChanges()
        Module1.da.Update(ndt)
    End Sub

End Module

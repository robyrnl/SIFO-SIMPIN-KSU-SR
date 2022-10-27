Imports System.Data.SqlClient
Module KoneksiDB
    Public conn As SqlConnection
    Public trc As SqlTransaction
    Public cmd As SqlCommand
    Public ds As DataSet
    Public dt As DataTable
    Public adapter As SqlDataAdapter
    Public rd As SqlDataReader
    Public dr As SqlDataReader
    Public lokasidb As String

    Public Sub mulaiKoneksi()
        lokasidb = "Data Source=ROBYRNL\SQLEXPRESS;Initial Catalog=TesProgramming;Integrated Security=True"

        conn = New SqlConnection(lokasidb)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            Else
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "ERROR Koneksi")
        End Try
    End Sub
End Module

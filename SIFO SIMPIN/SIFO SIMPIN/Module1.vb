Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module KoneksiDB
    Public conn As MySqlConnection
    Public trc As MySqlTransaction
    Public cmd As MySqlCommand
    Public ds As DataSet
    Public dt As DataTable
    Public adapter As MySqlDataAdapter
    Public rd As MySqlDataReader
    Public dr As SqlDataReader
    Public lokasidb As String

    Public Sub MulaiKoneksi()
        lokasidb = "server=127.0.0.1;user=root;password=;database=dbsimpin"
        'lokasidb = "Data Source=192.168.1.10\SQLEXPRESS;Initial Catalog=db_SIPKUD;Persist Security Info=True;User ID=SIPKUD;Password=SIPKUD"


        conn = New MySqlConnection(lokasidb)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MsgBox("Koneksi biasa", MsgBoxStyle.Information, "Informasi")
            Else
                'MsgBox("Koneksi Gagal", MsgBoxStyle.Exclamation, "Perhatian")
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

End Module

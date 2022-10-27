Imports System.Data.SqlClient

Module koneksi
    Public conn As SqlConnection
    Public trc As SqlTransaction
    Public cmd As SqlCommand
    Public ds As DataSet
    Public dt As DataTable
    Public adapter As SqlDataAdapter
    Public rd As SqlDataReader
    Public dr As SqlDataReader
    Public lokasidb As String

    Public Sub MulaiKoneksi()
        lokasidb = "Data Source=ROBYRNL\SQLEXPRESS;Initial Catalog=hafith_syukri;Integrated Security=True"
        'lokasidb = "Data Source=192.168.1.10\SQLEXPRESS;Initial Catalog=db_SIPKUD;Persist Security Info=True;User ID=SIPKUD;Password=SIPKUD"


        conn = New SqlConnection(lokasidb)
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

Imports MySql.Data.MySqlClient

Module CmbAgtCode

    Public Sub AgtTampil()
        Dim CmbKT As String = FrmBeranda.CmbKtTS.SelectedItem.ToString
        Dim KodeKT As String = Microsoft.VisualBasic.Left(CmbKT, 14)
        'FrmBeranda.Label24.Text = KodeKT
        MulaiKoneksi()
        cmd = New MySqlCommand("SELECT * FROM tb_anggota WHERE id_kt = '" & KodeKT & "'", conn)
        rd = cmd.ExecuteReader


        While rd.Read
            FrmBeranda.CmbKdAngTS.Items.Add(rd("id_anggota") & " || " & rd("nm_anggota"))
        End While
        rd.Close()
    End Sub
End Module

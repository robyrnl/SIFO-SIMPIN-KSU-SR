Imports MySql.Data.MySqlClient

Module TmbhKT
    Public Sub IdKT()
        Dim urtan As String
        Dim hitung, cari As Long

        MulaiKoneksi()
        cmd = New MySqlCommand("SELECT * FROM tb_kt WHERE id_kt in " & "(select max(id_kt) FROM tb_kt)", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urtan = "KSU-SR/KT/" & "0001"
            rd.Close()
        Else
            cari = Microsoft.VisualBasic.Right(rd.GetString(0), 4)
            If Microsoft.VisualBasic.Left(rd.GetString(0), 10) <> "KSU-SR/KT/" Then
                urtan = "KSU-SR/KT/" & "0001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 4) + 1
                urtan = "KSU-SR/KT/" & Microsoft.VisualBasic.Right("0000" & hitung, 4)
            End If
        End If
        rd.Close()
        FrmBeranda.TxtKdKtTmbh.Text = urtan
    End Sub

    Public Sub TmbhKTCode()
        If FrmBeranda.TxtKdKtTmbh.Text = "" Or FrmBeranda.TxtNmKTTmbh.Text = "" Or FrmBeranda.TxtTahapTmbhKT.Text = "" Then
            MsgBox("Pastikan Seluruh Data Sudah Terisi", MsgBoxStyle.Critical, "Gagal")
        Else
            MulaiKoneksi()
            cmd = New MySqlCommand("SELECT * FROM tb_kt WHERE id_kt ='" & FrmBeranda.TxtKdKtTmbh.Text & "' AND tahap = '" & FrmBeranda.TxtTahapTmbhKT.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                MsgBox("Data Sudah Ada", MsgBoxStyle.Information, "Perhatian")
                rd.Close()
            Else
                rd.Close()
                cmd = New MySqlCommand("INSERT INTO tb_kt VALUES ('" & FrmBeranda.TxtKdKtTmbh.Text & "','" & FrmBeranda.TxtNmKTTmbh.Text & "','" & FrmBeranda.TxtTahapTmbhKT.Text & "')", conn)
                cmd.ExecuteNonQuery()
                rd.Close()
                FrmBeranda.TxtNmKTTmbh.ResetText()
                FrmBeranda.TxtKdKtTmbh.ResetText()
                FrmBeranda.TxtTahapTmbhKT.ResetText()
                IdKT()
                MsgBox("Data Berhasil Ditambahakan", MsgBoxStyle.Information, "Berhasil")
            End If

        End If

    End Sub
End Module

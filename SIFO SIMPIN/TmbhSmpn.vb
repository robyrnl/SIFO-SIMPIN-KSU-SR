Imports MySql.Data.MySqlClient

Module TmbhSmpn

    Public Sub KdPnjmn()
        Dim urtan As String
        Dim hitung, cari As Long

        MulaiKoneksi()
        cmd = New MySqlCommand("SELECT * FROM tbl_peminjam WHERE id_pinjaman in " & "(select max(id_pinjaman) FROM tbl_peminjam)", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urtan = "KSU-SR/PNJMN/" & "0001"
            rd.Close()
        Else
            cari = Microsoft.VisualBasic.Right(rd.GetString(0), 4)
            If Microsoft.VisualBasic.Left(rd.GetString(0), 13) <> "KSU-SR/PNJMN/" Then
                urtan = "KSU-SR/PNJMN/" & "0001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 4) + 1
                urtan = "KSU-SR/PNJMN/" & Microsoft.VisualBasic.Right("0000" & hitung, 4)
            End If
        End If
        rd.Close()
        FrmBeranda.TxtKdPnjmnTS.Text = urtan
    End Sub

    Public Sub KdAngsur()
        MulaiKoneksi()
        cmd = New MySqlCommand("SELECT * FROM tb_angsur", conn)
        rd = cmd.ExecuteReader

        While rd.Read
            FrmBeranda.CmbKdAngsrTS.Items.Add(rd("id_angsur") & " || " & rd("JmlhPnjm"))
        End While
        rd.Close()
    End Sub

    Public Sub TmbhSmpnBar()
        Dim KdPinjman As String = FrmBeranda.TxtKdPnjmnTS.Text
        Dim CmbAngsuran As String = FrmBeranda.CmbKdAngsrTS.Text
        Dim CmbKdKt As String = FrmBeranda.CmbKtTS.Text
        Dim CmbKdAng As String = Microsoft.VisualBasic.Left(FrmBeranda.CmbKdAngTS.Text, 16)

        If KdPinjman = "" Or CmbAngsuran = "Pilih Angsuran" Or CmbKdKt = "Pilih Ketua Kelompok" Or CmbKdAng = "Pilih Anggota" Then
            MsgBox("Pastikan Semua Data Sudah Terisi Dengan Benar", MsgBoxStyle.Critical, "Gagal")

        Else
            MulaiKoneksi()
            cmd = New MySqlCommand("SELECT * FROM tbl_peminjam", conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                MsgBox("Data Sudah Ada", MsgBoxStyle.Information, "Perhatian")
                rd.Close()
            Else
                rd.Close()
                cmd = New MySqlCommand("INSERT INTO tbl_peminjam VALUES('" & KdPinjman & "','" & CmbAngsuran & "','" & CmbKdKt & "')", conn)
                cmd.ExecuteNonQuery()
                rd.Close()
                FrmBeranda.TxtKdPnjmnTS.ResetText()
                FrmBeranda.CmbKdAngsrTS.ResetText()
                FrmBeranda.CmbKtTS.ResetText()
                FrmBeranda.CmbKdAngTS.ResetText()
            End If
            rd.Close()
        End If
    End Sub

End Module

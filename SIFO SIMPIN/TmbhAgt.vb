Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module TmbhAgt
    Public Sub TmbhAnggt()
        Dim KdKTConvert As String

        KdKTConvert = Microsoft.VisualBasic.Left(FrmBeranda.CmbKdKT.SelectedItem, 14)
        'FrmBeranda.Label25.Text = KdKTConvert

        MulaiKoneksi()
        cmd = New MySqlCommand("SELECT * FROM tb_anggota WHERE id_anggota ='" & FrmBeranda.TxtKdAgt.Text & "' AND id_kt ='" & FrmBeranda.CmbKdKT.SelectedItem & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            MsgBox("Data Sudah Ada", MsgBoxStyle.Information, "Perhatian")
            rd.Close()
        Else
            rd.Close()
            cmd = New MySqlCommand("INSERT INTO tb_anggota VALUES ('" & FrmBeranda.TxtKdAgt.Text & "','" & KdKTConvert & "','" & FrmBeranda.TxtNmAgt.Text & "')", conn)
            cmd.ExecuteNonQuery()
            rd.Close()
            MsgBox("Data Anggota Berhasil Ditambahkan", MsgBoxStyle.Information, "Succes")
            FrmBeranda.CmbKdKT.ResetText()
            FrmBeranda.TxtNmAgt.Clear()
            FrmBeranda.TxtKdAgt.ResetText()
            IdAgtOtomatis()
        End If

    End Sub

    Public Sub IdAgtOtomatis()
        Dim urtan As String
        Dim hitung, cari As Long

        MulaiKoneksi()
        cmd = New MySqlCommand("SELECT * FROM tb_anggota WHERE id_anggota in " & "(select max(id_anggota) FROM tb_anggota)", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urtan = "KSU-SR/AGT/" & "00001"
            rd.Close()
        Else
            cari = Microsoft.VisualBasic.Right(rd.GetString(0), 5)
            If Microsoft.VisualBasic.Left(rd.GetString(0), 11) <> "KSU-SR/AGT/" Then
                urtan = "KSU-SR/AGT/" & "00001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 5) + 1
                urtan = "KSU-SR/AGT/" & Microsoft.VisualBasic.Right("00000" & hitung, 5)
            End If
        End If
        rd.Close()
        FrmBeranda.TxtKdAgt.Text = urtan

    End Sub

    Public Sub KdKT()
        MulaiKoneksi()
        cmd = New MySqlCommand("SELECT * FROM tb_kt", conn)
        rd = cmd.ExecuteReader


        While rd.Read
            FrmBeranda.CmbKdKT.Items.Add(rd("id_kt") & " || " & rd("nama_kt"))
            FrmBeranda.CmbKtTS.Items.Add(rd("id_kt") & " || " & rd("nama_kt"))
        End While
        rd.Close()

    End Sub


End Module

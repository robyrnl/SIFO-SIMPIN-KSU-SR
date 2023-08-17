Imports System.Drawing.Text
Imports System.Runtime.Intrinsics.X86
Imports MySql.Data.MySqlClient
Module TmbhAngsuran
    Dim KodeAngsuran As String = FrmBeranda.TxtKdAngsrnTmbh.Text
    Dim JmlhPnjm As Integer = FrmBeranda.TxtJmlhPnjmTB.Text
    Dim JmlhAngsuran As Integer = FrmBeranda.TxtJlhAnsurTB.Text
    Dim BngAngsur As Integer = FrmBeranda.TxtBngAnsurTmbh.Text

    Public Sub TmbhAngsur()

        If KodeAngsuran = "" Or JmlhAngsuran = "" Or JmlhPnjm = "" Or BngAngsur = "" Then
            MsgBox("Pastikan Semua Data Sudah Terisi", MsgBoxStyle.Critical, "Gagal")
        Else
            cmd = New MySqlCommand("SELECT * FROM tb_angsur WHERE id_angsur ='" & KodeAngsuran & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                MsgBox("Data Sudah Ada", MsgBoxStyle.Information, "Perhatian")
                rd.Close()
            Else
                rd.Close()
                cmd = New MySqlCommand("INSERT INTO tb_angsur VALUES'" & KodeAngsuran & "','" & JmlhAngsuran & "','" & JmlhPnjm & "','" & BngAngsur & "')", conn)
                cmd.ExecuteNonQuery()
                rd.Close()
                MsgBox("Data Berhasil Ditambahkan", MsgBoxStyle.Information, "Succes")
            End If

        End If
    End Sub

    Public Sub KdAngsurOtomatis()
        Dim kode1 As Integer = Microsoft.VisualBasic.Left(JmlhPnjm, 3)
        Dim kode2 As Integer = Microsoft.VisualBasic.Left(JmlhAngsuran, 3)

        'If kode1 = "" Or kode2 = "" Then
        '    JmlhAngsuran = "000"
        '    JmlhPnjm = "000"
        'Else
        FrmBeranda.TxtKdAngsrnTmbh.Text = "KSR/ANG/" & kode1 & "/" & kode2 & ""
        'FrmBeranda.BtnSmpnAngsurTmbh.Enabled = True
        'End If

    End Sub
End Module

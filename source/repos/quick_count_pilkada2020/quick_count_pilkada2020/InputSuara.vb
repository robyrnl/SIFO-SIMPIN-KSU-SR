Imports System.Data.SqlClient

Public Class InputSuara
    Private Sub InputSuara_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Dim formWidth As Integer = Me.Width
        'Dim formHeight As Integer = Me.Height
        'Dim tWidth As Label = lebar
        'Dim tTinggi As Label = tinggi

        'tWidth.Text = formWidth
        'tTinggi.Text = formHeight
    End Sub

    Private Sub InputSuara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MulaiKoneksi()
        TampilDesa()
        'TampilPaslon()
    End Sub

    Private Sub TampilDesa()
        cmd = New SqlCommand("SELECT nm_desa FROM data_desa", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        Do While rd.Read
            CmbDesa.Items.Add(rd("nm_desa"))
        Loop
        rd.Close()
    End Sub

    Private Sub TampilPaslon()
        cmd = New SqlCommand("SELECT nmr_paslon FROM data_paslon")
        rd = cmd.ExecuteReader
        rd.Read()

        Do While rd.Read
            CmbPaslon.Items.Add(rd("nmr_paslon"))
        Loop
        rd.Close()
    End Sub

    Private Sub TambahData()
        cmd = New SqlCommand("INSERT INTO history VALUES('" & CmbTPS.SelectedItem & "','" & CmbPaslon.SelectedItem & "','" & TxtJlhSuara.Text & "','" & lblkddesa.Text & "')", conn)
        cmd.ExecuteNonQuery()
        MsgBox("BERHASIL", MsgBoxStyle.Information, "BERHASIL")

    End Sub

    Private Sub CmbDesa_TextChanged(sender As Object, e As EventArgs) Handles CmbDesa.TextChanged
        'Dim kddesa As VariantType
        cmd = New SqlCommand("SELECT kd_desa FROM data_desa WHERE CONVERT(VARCHAR,nm_desa) = '" & CmbDesa.SelectedItem & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            lblkddesa.Text = rd.Item("kd_desa")
            rd.Close()
        End If
        rd.Close()


        cmd = New SqlCommand("SELECT kd_tps FROM data_tps WHERE kd_desa ='" & lblkddesa.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        Do While rd.Read
            CmbTPS.Items.Add(rd("kd_tps"))
        Loop
        rd.Close()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        TambahData()
        ShowPersentase.TampilDataMasuk()
        ShowPersentase.TampilPersentase01()
        ShowPersentase.TampilPersentase02()
        ShowPersentase.TampilPersentase03()

    End Sub
End Class
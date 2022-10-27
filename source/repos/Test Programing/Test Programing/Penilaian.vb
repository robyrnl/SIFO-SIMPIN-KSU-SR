Imports System.Data.SqlClient
Public Class Penilaian
    Sub TampilData()
        Try
            mulaiKoneksi()
            cmd = New SqlCommand("SELECT * FROM Tabel_Nilai", conn)
            adapter = New SqlDataAdapter
            adapter.SelectCommand = cmd
            ds = New DataSet
            adapter.Fill(ds, "Tabel_Nilai")

            DvNilai.DataSource = ds
            DvNilai.DataMember = "Tabel_Nilai"
            Atur()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub TampilHasil()
        Try
            mulaiKoneksi()
            cmd = New SqlCommand("SELECT Nomor, NIK, Nama, Nilai," &
                                 "CASE WHEN nilai >= 0 AND Nilai <= 50 THEN 'E' " &
                                 "WHEN Nilai >= 51 AND Nilai <=80 THEN 'C' " &
                                 "WHEN Nilai >=81 AND Nilai <=100 THEN 'A' " &
                                 "END AS Point, " &
                                 "CASE WHEN nilai >= 0 AND Nilai <= 50 THEN 'Tidak Lulus' " &
                                 "WHEN Nilai >= 51 AND Nilai <=80 THEN 'Cukup' " &
                                 "WHEN Nilai >=81 AND Nilai <=100 THEN 'Sangat Memuaskan' " &
                                 "END AS Keterangan " &
                                 "FROM Tabel_Nilai", conn)
            adapter = New SqlDataAdapter
            adapter.SelectCommand = cmd
            ds = New DataSet
            adapter.Fill(ds, "hasil")
            DvHasil.DataSource = ds.Tables("hasil")
            AturHasil()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AturHasil()
        With DvHasil.ColumnHeadersDefaultCellStyle
            DvHasil.Columns(0).Width = 88
            DvHasil.Columns(0).HeaderText = "No"
            DvHasil.Columns(1).Width = 88
            DvHasil.Columns(1).HeaderText = "NIK"
            DvHasil.Columns(2).Width = 88
            DvHasil.Columns(2).HeaderText = "Nama"
            DvHasil.Columns(3).Width = 88
            DvHasil.Columns(3).HeaderText = "Nilai"
            DvHasil.Columns(4).Width = 88
            DvHasil.Columns(4).HeaderText = "Point"
            DvHasil.Columns(5).Width = 120
            DvHasil.Columns(5).HeaderText = "Keterangan"

            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size,
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            .Font = New Font("roboto", 11)
        End With
    End Sub
    Sub Atur()
        With DvNilai.ColumnHeadersDefaultCellStyle
            DvNilai.Columns(0).Width = 88
            DvNilai.Columns(0).HeaderText = "No"
            DvNilai.Columns(1).Width = 88
            DvNilai.Columns(1).HeaderText = "NIK"
            DvNilai.Columns(2).Width = 88
            DvNilai.Columns(2).HeaderText = "Nama"
            DvNilai.Columns(2).Width = 88
            DvNilai.Columns(2).HeaderText = "Nilai"

            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size,
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            .Font = New Font("roboto", 11)
        End With
    End Sub

    Private Sub Penilaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TampilHasil()
    End Sub
End Class
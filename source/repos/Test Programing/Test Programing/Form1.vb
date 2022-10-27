Imports System.Data.SqlClient

Public Class soal1
    Sub Atur()
        With DvNama.ColumnHeadersDefaultCellStyle
            DvNama.Columns(0).Width = 120
            DvNama.Columns(0).HeaderText = "NIK"
            DvNama.Columns(1).Width = 120
            DvNama.Columns(1).HeaderText = "Nama"

            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size,
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            .Font = New Font("roboto", 11)
        End With
    End Sub

    Sub Atur2()
        With DvNilai.ColumnHeadersDefaultCellStyle
            DvNilai.Columns(0).Width = 120
            DvNilai.Columns(0).HeaderText = "NIK"
            DvNilai.Columns(1).Width = 120
            DvNilai.Columns(1).HeaderText = "Kode Pelajaran"
            DvNilai.Columns(2).Width = 120
            DvNilai.Columns(2).HeaderText = "Nilai"

            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size,
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            .Font = New Font("roboto", 11)
        End With
    End Sub

    Sub AturHasil()
        With DvHasil.ColumnHeadersDefaultCellStyle
            DvHasil.Columns(0).Width = 88
            DvHasil.Columns(0).HeaderText = "NIK"
            DvHasil.Columns(1).Width = 88
            DvHasil.Columns(1).HeaderText = "Kode Pelajaran"
            DvHasil.Columns(2).Width = 88
            DvHasil.Columns(2).HeaderText = "Rata Rata"

            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size,
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            .Font = New Font("roboto", 11)
        End With
    End Sub

    Sub TampilData()
        Try
            mulaiKoneksi()
            cmd = New SqlCommand("SELECT * FROM Tabel1", conn)
            adapter = New SqlDataAdapter
            adapter.SelectCommand = cmd
            ds = New DataSet
            adapter.Fill(ds, "Tabel1")

            DvNama.DataSource = ds
            DvNama.DataMember = "Tabel1"
            Atur()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub TampilData2()
        Try
            mulaiKoneksi()
            cmd = New SqlCommand("SELECT * FROM Table2", conn)
            adapter = New SqlDataAdapter
            adapter.SelectCommand = cmd
            ds = New DataSet
            adapter.Fill(ds, "Table2")

            DvNilai.DataSource = ds
            DvNilai.DataMember = "Table2"
            Atur2()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Hasil()
        Try
            mulaiKoneksi()
            cmd = New SqlCommand("SELECT Tabel1.NIK, Tabel1.Nama, AVG(Table2.Nilai) AS RataRata FROM Tabel1, Table2 WHERE Tabel1.NIK = Table2.NIK GROUP BY Tabel1.NIK, Tabel1.Nama", conn)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hasil()
    End Sub

    Private Sub soal1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        TampilData2()

    End Sub

    Private Sub DvNilai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DvNilai.CellContentClick

    End Sub
End Class

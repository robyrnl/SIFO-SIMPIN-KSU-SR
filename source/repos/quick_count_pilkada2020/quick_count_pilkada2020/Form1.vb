Imports System.Data.SqlClient
Imports System.Math

Public Class ShowPersentase
    Private Const TS As Integer = 24579
    Public angkapersen01 As Double
    Public angkapersen02 As Double
    Public angkapersen03 As Double
    Dim con As Long

    Public Sub Converter()
        con = CLng(persenmasuk.Text)
    End Sub




    Sub TampilDataMasuk()
        Dim Persen As Double
        cmd = New SqlCommand("SELECT SUM(jlhsuara) AS jumlahMasuk FROM history", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            lblTotal.Text = rd.Item("jumlahMasuk")
            rd.Close()
        Else
            rd.Close()
            MsgBox("Data Tidak Ada", MsgBoxStyle.Exclamation, "PERHATIAN")
        End If

        Persen = lblTotal.Text / 24579 * 100%
        persenmasuk.Text = "" & Round(Persen) & "%"
        persenmasuk.Width = 707 * Persen / 100


    End Sub
    Sub TampilPersentase01()
        Dim persendata01 As Double
        cmd = New SqlCommand("SELECT SUM(jlhsuara) AS Jumlah01 FROM history WHERE nmr_calon = 1", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            lblSuara01.Text = rd.Item("Jumlah01")
            rd.Close()
        Else
            rd.Close()
        End If

        persendata01 = lblSuara01.Text / lblTotal.Text * 100%
        persen01.Text = "" & Round(persendata01) & "%"
        persen01.Width = 707 * persendata01 / 100


    End Sub

    Sub TampilPersentase02()
        Dim persendata02 As Double
        cmd = New SqlCommand("SELECT SUM(jlhsuara) AS Jumlah02 FROM history WHERE nmr_calon = 2", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            lblSuara02.Text = rd.Item("Jumlah02")
            rd.Close()
        Else
            rd.Close()
        End If

        persendata02 = lblSuara02.Text / lblTotal.Text * 100%
        persen02.Text = "" & Round(persendata02) & "%"
        persen02.Width = 707 * persendata02 / 100


    End Sub

    Sub TampilPersentase03()
        Dim persendata03 As Double
        cmd = New SqlCommand("SELECT SUM(jlhsuara) AS Jumlah03 FROM history WHERE nmr_calon = 3", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            lblSuara03.Text = rd.Item("Jumlah03")
            rd.Close()
        Else
            rd.Close()
        End If

        persendata03 = lblSuara03.Text / lblTotal.Text * 100%
        persen03.Text = "" & Round(persendata03) & "%"
        persen03.Width = 707 * persendata03 / 100


    End Sub

    Private Sub ShowPersentase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MulaiKoneksi()
        TampilDataMasuk()
        TampilPersentase01()
        TampilPersentase02()
        TampilPersentase03()

    End Sub
End Class

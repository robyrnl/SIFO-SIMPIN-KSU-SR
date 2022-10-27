Imports MySql.Data.MySqlClient

Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MulaiKoneksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        cmd = New MySqlCommand("SELECT * FROM tb_usr WHERE usrnm = '" & Txt_Usr.Text & "' and pw = '" & TxtPw.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            rd.Close()
            FrmBeranda.Show()
            Me.Hide()
        Else
            MsgBox("Username Atau Password Tidak Ditemukan", MsgBoxStyle.Exclamation, "Perahatian")
            rd.Close()
        End If


    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub
End Class

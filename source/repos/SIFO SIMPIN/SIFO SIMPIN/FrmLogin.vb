Imports MySql.Data.MySqlClient

Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MulaiKoneksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New MySqlCommand("SELECT * FROM tb_usr WHERE usrnm = '" & Txt_Usr.Text & "' and pw = '" & TxtPw.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            MsgBox("Login Bergasil", MsgBoxStyle.Information, "Perhatian")
            rd.Close()
        Else
            MsgBox("Login Gagal", MsgBoxStyle.Critical, "Perhatian")
            rd.Close()
        End If


    End Sub
End Class

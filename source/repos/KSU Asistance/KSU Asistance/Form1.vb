Imports MySql.Data.MySqlClient
Public Class Form1

    Public Sub dbkoneksi()
        Dim constr As String = "data source=localhost;userid=root;password=;database=dbpenggajian"
        Dim koneksi As New MySqlConnection(constr)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbkoneksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Dim tWidth As Label = lebar
        Dim tTinggi As Label = tinggi

        tWidth.Text = formWidth
        tTinggi.Text = formHeight

    End Sub
End Class

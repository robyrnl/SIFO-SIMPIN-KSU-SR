Public Class FrmBeranda

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        FrmLogin.Show()
    End Sub

    Private Sub FrmBeranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = True

        Me.Close()

        FrmLogin.Show()
        FrmLogin.TxtPw.Clear()
        FrmLogin.Txt_Usr.Clear()
        FrmLogin.Txt_Usr.Focus()
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        Label3.Visible = True
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False

        PnlTmbhPmnjm.Visible = False
        PnlDash.Visible = True
        PnlTmbhSmpn.Visible = False
    End Sub

    Private Sub BtnTmbhSmpn_Click(sender As Object, e As EventArgs) Handles BtnTmbhSmpn.Click
        Label3.Visible = False
        Label4.Visible = True
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False

        PnlTmbhPmnjm.Visible = False
        PnlDash.Visible = False
        PnlTmbhSmpn.Visible = True
    End Sub

    Private Sub BtnCkSmpn_Click(sender As Object, e As EventArgs) Handles BtnCkSmpn.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = True
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
    End Sub

    Private Sub BtnGenrtSpn_Click(sender As Object, e As EventArgs) Handles BtnGenrtSpn.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = True
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
    End Sub

    Private Sub BtnTmbhAng_Click(sender As Object, e As EventArgs) Handles BtnTmbhAng.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = True
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
    End Sub

    Private Sub BtnTmbhPnjm_Click(sender As Object, e As EventArgs) Handles BtnTmbhPnjm.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = True
        Label9.Visible = False
        Label10.Visible = False

        PnlTmbhPmnjm.Visible = True
        PnlDash.Visible = False
        PnlTmbhSmpn.Visible = False
    End Sub

    Private Sub BtnCtk_Click(sender As Object, e As EventArgs) Handles BtnCtk.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = True
        Label10.Visible = False
    End Sub

    Private Sub PnlTmbhPmnjm_Resize(sender As Object, e As EventArgs) Handles PnlTmbhPmnjm.Resize

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_Wkt.Text = DateTime.Now.ToString("HH:mm")
    End Sub

End Class
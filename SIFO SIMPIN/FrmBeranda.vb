Public Class FrmBeranda
    Dim f As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        FrmLogin.Show()
    End Sub

    Private Sub FrmBeranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        KdKT()


    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label9.Visible = False
        Label10.Visible = True
        Label17.Visible = False
        Label18.Visible = False

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
        Label9.Visible = False
        Label10.Visible = False
        Label17.Visible = False
        Label18.Visible = False

        PnlDash.Visible = True
        PnlTmbhSmpn.Visible = False
        PnlCkSMPN.Visible = False
        PnlCtkSmpn.Visible = False
        PnlGnrtSmpn.Visible = False
        PnlTmbhAnggota.Visible = False
        PnlTmbhAngsur.Visible = False
        PnlTmbhKT.Visible = False
    End Sub

    Private Sub BtnTmbhSmpn_Click(sender As Object, e As EventArgs) Handles BtnTmbhSmpn.Click
        Label3.Visible = False
        Label4.Visible = True
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label17.Visible = False
        Label18.Visible = False

        PnlDash.Visible = False
        PnlTmbhSmpn.Visible = True
        PnlCkSMPN.Visible = False
        PnlCtkSmpn.Visible = False
        PnlGnrtSmpn.Visible = False
        PnlTmbhAnggota.Visible = False
        PnlTmbhAngsur.Visible = False
        PnlTmbhKT.Visible = False

        KdPnjmn()


    End Sub

    Private Sub BtnCkSmpn_Click(sender As Object, e As EventArgs) Handles BtnCkSmpn.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = True
        Label6.Visible = False
        Label7.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label17.Visible = False
        Label18.Visible = False

        PnlDash.Visible = False
        PnlTmbhSmpn.Visible = False
        PnlCkSMPN.Visible = True
        PnlCtkSmpn.Visible = False
        PnlGnrtSmpn.Visible = False
        PnlTmbhAnggota.Visible = False
        PnlTmbhAngsur.Visible = False
        PnlTmbhKT.Visible = False
    End Sub

    Private Sub BtnGenrtSpn_Click(sender As Object, e As EventArgs) Handles BtnGenrtSpn.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = True
        Label7.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label17.Visible = False
        Label18.Visible = False

        PnlDash.Visible = False
        PnlTmbhSmpn.Visible = False
        PnlCkSMPN.Visible = False
        PnlCtkSmpn.Visible = False
        PnlGnrtSmpn.Visible = True
        PnlTmbhAnggota.Visible = False
        PnlTmbhAngsur.Visible = False
        PnlTmbhKT.Visible = False
    End Sub

    Private Sub BtnTmbhAng_Click(sender As Object, e As EventArgs) Handles BtnTmbhAng.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = True
        Label9.Visible = False
        Label10.Visible = False
        Label17.Visible = False
        Label18.Visible = False

        PnlDash.Visible = False
        PnlTmbhSmpn.Visible = False
        PnlCkSMPN.Visible = False
        PnlCtkSmpn.Visible = False
        PnlGnrtSmpn.Visible = False
        PnlTmbhAnggota.Visible = False
        PnlTmbhAngsur.Visible = True
        PnlTmbhKT.Visible = False

        TxtJmlhPnjmTB.Clear()
        TxtJlhAnsurTB.Clear()
        TxtKdAngsrnTmbh.Clear()
        TxtBngAnsurTmbh.Clear()
    End Sub

    Private Sub BtnTmbhPnjm_Click(sender As Object, e As EventArgs)
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label17.Visible = False
        Label18.Visible = False

        PnlDash.Visible = False
        PnlTmbhSmpn.Visible = False
        PnlCkSMPN.Visible = False
        PnlCtkSmpn.Visible = False
        PnlGnrtSmpn.Visible = False
        PnlTmbhAnggota.Visible = False
        PnlTmbhAngsur.Visible = False
        PnlTmbhKT.Visible = False
    End Sub

    Private Sub BtnCtk_Click(sender As Object, e As EventArgs) Handles BtnCtk.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label9.Visible = True
        Label10.Visible = False
        Label17.Visible = False
        Label18.Visible = False

        PnlDash.Visible = False
        PnlTmbhSmpn.Visible = False
        PnlCkSMPN.Visible = False
        PnlCtkSmpn.Visible = True
        PnlGnrtSmpn.Visible = False
        PnlTmbhAnggota.Visible = False
        PnlTmbhAngsur.Visible = False
        PnlTmbhKT.Visible = False
    End Sub

    Private Sub PnlTmbhPmnjm_Resize(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_Wkt.Text = DateTime.Now.ToString("HH:mm")
    End Sub

    Private Sub BtnTmhAgt_Click(sender As Object, e As EventArgs) Handles BtnTmhAgt.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label17.Visible = False
        Label18.Visible = True

        PnlDash.Visible = False
        PnlTmbhSmpn.Visible = False
        PnlCkSMPN.Visible = False
        PnlCtkSmpn.Visible = False
        PnlGnrtSmpn.Visible = False
        PnlTmbhAnggota.Visible = True
        PnlTmbhAngsur.Visible = False
        PnlTmbhKT.Visible = False

        TmbhAgt.IdAgtOtomatis()


    End Sub

    Private Sub BtnTmbhKT_Click(sender As Object, e As EventArgs) Handles BtnTmbhKT.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label17.Visible = True
        Label18.Visible = False

        PnlDash.Visible = False
        PnlTmbhSmpn.Visible = False
        PnlCkSMPN.Visible = False
        PnlCtkSmpn.Visible = False
        PnlGnrtSmpn.Visible = False
        PnlTmbhAnggota.Visible = False
        PnlTmbhAngsur.Visible = False
        PnlTmbhKT.Visible = True

        IdKT()

    End Sub

    Private Sub BtnSmpnAgt_Click(sender As Object, e As EventArgs) Handles BtnSmpnAgt.Click

        If TxtNmAgt.Text = "" Or CmbKdKT.SelectedItem = "" Then
            MsgBox("Pastikan Data Sudah Terisi Semua", MsgBoxStyle.Critical, "Perhatian")
        Else
            TmbhAgt.TmbhAnggt()
            CmbKdAngTS.Items.Clear()

        End If

    End Sub

    Private Sub BtnSmpnKT_Click(sender As Object, e As EventArgs) Handles BtnSmpnKT.Click
        TmbhKTCode()
        CmbKtTS.Items.Clear()
        KdKT()
    End Sub

    Private Sub BtnCekKdAngsurTmbh_Click(sender As Object, e As EventArgs) Handles BtnCekKdAngsurTmbh.Click
        If TxtJlhAnsurTB.Text = "" Or TxtJmlhPnjmTB.Text = "" Or TxtBngAnsurTmbh.Text = "" Then
            MsgBox("Perhatikan Data yang Belum Terisi", MsgBoxStyle.Exclamation, "Perhatian")
        Else
            TxtKdAngsrnTmbh.ResetText()
            KdAngsurOtomatis()
        End If
    End Sub

    Private Sub BtnTmbhSmpnBaru_Click(sender As Object, e As EventArgs) Handles BtnTmbhSmpnBaru.Click
        TmbhSmpnBar()
    End Sub


    Private Sub CmbKtTS_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbKtTS.SelectedValueChanged
        CmbKdAngTS.Items.Clear()
        AgtTampil()
    End Sub

    Private Sub TxtJmlhPnjmTB_TextChanged(sender As Object, e As EventArgs) Handles TxtJmlhPnjmTB.TextChanged
        If TxtJmlhPnjmTB.Text = "" Or Not IsNumeric(TxtJmlhPnjmTB.Text) Then
            Exit Sub
        End If

        f = TxtJmlhPnjmTB.Text
        TxtJmlhPnjmTB.Text = Format(Val(f), "###,###")
        TxtJmlhPnjmTB.SelectionStart = Len(TxtJmlhPnjmTB.Text)
        TxtKdAngsrnTmbh.Text = "KSR/PNJM/" & TxtJmlhPnjmTB.Text
    End Sub

    Private Sub TxtJlhAnsurTmbh_TextChanged(sender As Object, e As EventArgs) Handles TxtJlhAnsurTB.TextChanged
        If TxtJlhAnsurTB.Text = "" Or Not IsNumeric(TxtJlhAnsurTB.Text) Then
            Exit Sub
        End If

        f = TxtJlhAnsurTB.Text
        TxtJlhAnsurTB.Text = Format(Val(f), "###,###")
        TxtJlhAnsurTB.SelectionStart = Len(TxtJlhAnsurTB.Text)
    End Sub

    Private Sub TxtBngAnsurTmbh_TextChanged(sender As Object, e As EventArgs) Handles TxtBngAnsurTmbh.TextChanged
        If TxtBngAnsurTmbh.Text = "" Or Not IsNumeric(TxtBngAnsurTmbh.Text) Then
            Exit Sub
        End If

        f = TxtBngAnsurTmbh.Text
        TxtBngAnsurTmbh.Text = Format(Val(f), "###,###")
        TxtBngAnsurTmbh.SelectionStart = Len(TxtBngAnsurTmbh.Text)

    End Sub

    Private Sub TxtKdAngsrnTmbh_TextChanged(sender As Object, e As EventArgs) Handles TxtKdAngsrnTmbh.TextChanged

    End Sub

    'Private Sub CmbKtTS_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbKtTS.SelectionChangeCommitted
    '    CmbKdAngTS.Items.Clear()
    '    AgtTampil()
    'End Sub
End Class
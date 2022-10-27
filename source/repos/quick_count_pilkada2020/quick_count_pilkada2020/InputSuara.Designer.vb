<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputSuara
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtJlhSuara = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbDesa = New System.Windows.Forms.ComboBox()
        Me.CmbPaslon = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.CmbTPS = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblkddesa = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtJlhSuara
        '
        Me.TxtJlhSuara.Location = New System.Drawing.Point(161, 143)
        Me.TxtJlhSuara.Name = "TxtJlhSuara"
        Me.TxtJlhSuara.Size = New System.Drawing.Size(133, 20)
        Me.TxtJlhSuara.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DESA"
        '
        'CmbDesa
        '
        Me.CmbDesa.FormattingEnabled = True
        Me.CmbDesa.Items.AddRange(New Object() {"KOTALAMA"})
        Me.CmbDesa.Location = New System.Drawing.Point(161, 39)
        Me.CmbDesa.Name = "CmbDesa"
        Me.CmbDesa.Size = New System.Drawing.Size(203, 21)
        Me.CmbDesa.TabIndex = 1
        '
        'CmbPaslon
        '
        Me.CmbPaslon.FormattingEnabled = True
        Me.CmbPaslon.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbPaslon.Location = New System.Drawing.Point(161, 108)
        Me.CmbPaslon.Name = "CmbPaslon"
        Me.CmbPaslon.Size = New System.Drawing.Size(203, 21)
        Me.CmbPaslon.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PASLON"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "JUMLAH SUARA"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(273, 185)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(91, 34)
        Me.BtnTambah.TabIndex = 7
        Me.BtnTambah.Text = "TAMBAH"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'CmbTPS
        '
        Me.CmbTPS.DropDownHeight = 80
        Me.CmbTPS.FormattingEnabled = True
        Me.CmbTPS.IntegralHeight = False
        Me.CmbTPS.Items.AddRange(New Object() {"1"})
        Me.CmbTPS.Location = New System.Drawing.Point(161, 71)
        Me.CmbTPS.Name = "CmbTPS"
        Me.CmbTPS.Size = New System.Drawing.Size(203, 21)
        Me.CmbTPS.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "NO TPS"
        '
        'lblkddesa
        '
        Me.lblkddesa.AutoSize = True
        Me.lblkddesa.Location = New System.Drawing.Point(28, 222)
        Me.lblkddesa.Name = "lblkddesa"
        Me.lblkddesa.Size = New System.Drawing.Size(39, 13)
        Me.lblkddesa.TabIndex = 10
        Me.lblkddesa.Text = "Label5"
        Me.lblkddesa.Visible = False
        '
        'InputSuara
        '
        Me.AcceptButton = Me.BtnTambah
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 247)
        Me.Controls.Add(Me.lblkddesa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbTPS)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbPaslon)
        Me.Controls.Add(Me.CmbDesa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtJlhSuara)
        Me.Name = "InputSuara"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InputSuara"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtJlhSuara As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbDesa As ComboBox
    Friend WithEvents CmbPaslon As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents CmbTPS As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblkddesa As Label
End Class

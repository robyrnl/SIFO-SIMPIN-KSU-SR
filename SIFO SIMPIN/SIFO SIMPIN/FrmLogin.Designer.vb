<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Txt_Usr = New System.Windows.Forms.TextBox()
        Me.TxtPw = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Usr
        '
        Me.Txt_Usr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Usr.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_Usr.Location = New System.Drawing.Point(45, 176)
        Me.Txt_Usr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Usr.Name = "Txt_Usr"
        Me.Txt_Usr.PlaceholderText = "Username"
        Me.Txt_Usr.Size = New System.Drawing.Size(219, 20)
        Me.Txt_Usr.TabIndex = 0
        '
        'TxtPw
        '
        Me.TxtPw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPw.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPw.Location = New System.Drawing.Point(46, 229)
        Me.TxtPw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPw.Name = "TxtPw"
        Me.TxtPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPw.PlaceholderText = "Password"
        Me.TxtPw.Size = New System.Drawing.Size(219, 20)
        Me.TxtPw.TabIndex = 1
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLogin.Location = New System.Drawing.Point(45, 293)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(219, 35)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "Masuk"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BtnKeluar.FlatAppearance.BorderSize = 0
        Me.BtnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKeluar.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnKeluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnKeluar.Location = New System.Drawing.Point(45, 339)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(219, 32)
        Me.BtnKeluar.TabIndex = 5
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIFO_SIMPIN.My.Resources.Resources.Untitled_1
        Me.PictureBox1.Location = New System.Drawing.Point(82, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(45, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 2)
        Me.Label1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(43, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 2)
        Me.Label2.TabIndex = 8
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(303, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPw)
        Me.Controls.Add(Me.Txt_Usr)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to SIFO SIMPIN APP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Usr As TextBox
    Friend WithEvents TxtPw As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

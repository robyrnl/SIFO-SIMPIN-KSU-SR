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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_Usr
        '
        Me.Txt_Usr.Location = New System.Drawing.Point(192, 99)
        Me.Txt_Usr.Multiline = True
        Me.Txt_Usr.Name = "Txt_Usr"
        Me.Txt_Usr.Size = New System.Drawing.Size(192, 31)
        Me.Txt_Usr.TabIndex = 0
        '
        'TxtPw
        '
        Me.TxtPw.Location = New System.Drawing.Point(192, 153)
        Me.TxtPw.Multiline = True
        Me.TxtPw.Name = "TxtPw"
        Me.TxtPw.Size = New System.Drawing.Size(192, 31)
        Me.TxtPw.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(297, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPw)
        Me.Controls.Add(Me.Txt_Usr)
        Me.Name = "FrmLogin"
        Me.Text = "Welcome to SIFO SIMPIN APP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Usr As TextBox
    Friend WithEvents TxtPw As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class

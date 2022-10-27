<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lebar = New System.Windows.Forms.Label()
        Me.tinggi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(66, 152)
        Me.Label1.MaximumSize = New System.Drawing.Size(70, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 400)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(367, 115)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'lebar
        '
        Me.lebar.AutoSize = True
        Me.lebar.Location = New System.Drawing.Point(545, 276)
        Me.lebar.Name = "lebar"
        Me.lebar.Size = New System.Drawing.Size(39, 13)
        Me.lebar.TabIndex = 3
        Me.lebar.Text = "Label2"
        '
        'tinggi
        '
        Me.tinggi.AutoSize = True
        Me.tinggi.Location = New System.Drawing.Point(545, 361)
        Me.tinggi.Name = "tinggi"
        Me.tinggi.Size = New System.Drawing.Size(39, 13)
        Me.tinggi.TabIndex = 3
        Me.tinggi.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 561)
        Me.Controls.Add(Me.tinggi)
        Me.Controls.Add(Me.lebar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lebar As Label
    Friend WithEvents tinggi As Label
End Class

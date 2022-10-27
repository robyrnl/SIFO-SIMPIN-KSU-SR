<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penilaian
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
        Me.DvNilai = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DvHasil = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DvNilai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DvNilai
        '
        Me.DvNilai.AllowUserToAddRows = False
        Me.DvNilai.AllowUserToDeleteRows = False
        Me.DvNilai.AllowUserToResizeColumns = False
        Me.DvNilai.AllowUserToResizeRows = False
        Me.DvNilai.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvNilai.Location = New System.Drawing.Point(113, 91)
        Me.DvNilai.Name = "DvNilai"
        Me.DvNilai.ReadOnly = True
        Me.DvNilai.RowHeadersVisible = False
        Me.DvNilai.Size = New System.Drawing.Size(372, 152)
        Me.DvNilai.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PENILAIAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tabel Nilai"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(113, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(373, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "TAMPILKAN HASIL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DvHasil
        '
        Me.DvHasil.AllowUserToAddRows = False
        Me.DvHasil.AllowUserToDeleteRows = False
        Me.DvHasil.AllowUserToResizeColumns = False
        Me.DvHasil.AllowUserToResizeRows = False
        Me.DvHasil.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DvHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvHasil.Location = New System.Drawing.Point(20, 329)
        Me.DvHasil.Name = "DvHasil"
        Me.DvHasil.ReadOnly = True
        Me.DvHasil.RowHeadersVisible = False
        Me.DvHasil.Size = New System.Drawing.Size(565, 152)
        Me.DvHasil.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasil"
        '
        'Penilaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 498)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DvHasil)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DvNilai)
        Me.Name = "Penilaian"
        Me.Text = "Penilaian"
        CType(Me.DvNilai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvHasil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DvNilai As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DvHasil As DataGridView
    Friend WithEvents Label3 As Label
End Class

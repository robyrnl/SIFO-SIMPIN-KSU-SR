<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class soal1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DvNama = New System.Windows.Forms.DataGridView()
        Me.DvNilai = New System.Windows.Forms.DataGridView()
        Me.DvHasil = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DvNama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvNilai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(465, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "LIHAT HASIL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(280, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TES QUERY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tabel 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(12, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tabel 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DvNama
        '
        Me.DvNama.AllowUserToAddRows = False
        Me.DvNama.AllowUserToDeleteRows = False
        Me.DvNama.AllowUserToResizeColumns = False
        Me.DvNama.AllowUserToResizeRows = False
        Me.DvNama.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DvNama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvNama.Location = New System.Drawing.Point(15, 66)
        Me.DvNama.MultiSelect = False
        Me.DvNama.Name = "DvNama"
        Me.DvNama.ReadOnly = True
        Me.DvNama.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DvNama.RowHeadersVisible = False
        Me.DvNama.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DvNama.ShowEditingIcon = False
        Me.DvNama.Size = New System.Drawing.Size(243, 132)
        Me.DvNama.TabIndex = 6
        '
        'DvNilai
        '
        Me.DvNilai.AllowUserToAddRows = False
        Me.DvNilai.AllowUserToDeleteRows = False
        Me.DvNilai.AllowUserToResizeColumns = False
        Me.DvNilai.AllowUserToResizeRows = False
        Me.DvNilai.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvNilai.Location = New System.Drawing.Point(15, 230)
        Me.DvNilai.Name = "DvNilai"
        Me.DvNilai.ReadOnly = True
        Me.DvNilai.RowHeadersVisible = False
        Me.DvNilai.Size = New System.Drawing.Size(383, 292)
        Me.DvNilai.TabIndex = 7
        '
        'DvHasil
        '
        Me.DvHasil.AllowUserToAddRows = False
        Me.DvHasil.AllowUserToDeleteRows = False
        Me.DvHasil.AllowUserToResizeColumns = False
        Me.DvHasil.AllowUserToResizeRows = False
        Me.DvHasil.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DvHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvHasil.Location = New System.Drawing.Point(465, 85)
        Me.DvHasil.Name = "DvHasil"
        Me.DvHasil.ReadOnly = True
        Me.DvHasil.RowHeadersVisible = False
        Me.DvHasil.Size = New System.Drawing.Size(270, 437)
        Me.DvHasil.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Location = New System.Drawing.Point(404, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(42, 481)
        Me.Panel1.TabIndex = 9
        '
        'soal1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 539)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DvHasil)
        Me.Controls.Add(Me.DvNilai)
        Me.Controls.Add(Me.DvNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "soal1"
        Me.Text = "Form1"
        CType(Me.DvNama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvNilai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvHasil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DvNilai As DataGridView
    Friend WithEvents DvNama As DataGridView
    Friend WithEvents DvHasil As DataGridView
    Friend WithEvents Panel1 As Panel
End Class

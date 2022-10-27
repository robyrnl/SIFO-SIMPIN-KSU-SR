<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowPersentase
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
        Me.persen01 = New System.Windows.Forms.Label()
        Me.persen02 = New System.Windows.Forms.Label()
        Me.persen03 = New System.Windows.Forms.Label()
        Me.persenmasuk = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSuara01 = New System.Windows.Forms.Label()
        Me.lblSuara02 = New System.Windows.Forms.Label()
        Me.lblSuara03 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'persen01
        '
        Me.persen01.BackColor = System.Drawing.Color.Yellow
        Me.persen01.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.persen01.Location = New System.Drawing.Point(30, 27)
        Me.persen01.Name = "persen01"
        Me.persen01.Size = New System.Drawing.Size(707, 52)
        Me.persen01.TabIndex = 0
        Me.persen01.Text = "%"
        Me.persen01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'persen02
        '
        Me.persen02.BackColor = System.Drawing.Color.Red
        Me.persen02.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.persen02.Location = New System.Drawing.Point(30, 102)
        Me.persen02.Name = "persen02"
        Me.persen02.Size = New System.Drawing.Size(707, 52)
        Me.persen02.TabIndex = 1
        Me.persen02.Text = "%"
        Me.persen02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'persen03
        '
        Me.persen03.BackColor = System.Drawing.Color.Green
        Me.persen03.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.persen03.Location = New System.Drawing.Point(30, 183)
        Me.persen03.Name = "persen03"
        Me.persen03.Size = New System.Drawing.Size(707, 52)
        Me.persen03.TabIndex = 2
        Me.persen03.Text = "%"
        Me.persen03.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'persenmasuk
        '
        Me.persenmasuk.BackColor = System.Drawing.Color.Gray
        Me.persenmasuk.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.persenmasuk.Location = New System.Drawing.Point(29, 255)
        Me.persenmasuk.Name = "persenmasuk"
        Me.persenmasuk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.persenmasuk.Size = New System.Drawing.Size(707, 52)
        Me.persenmasuk.TabIndex = 3
        Me.persenmasuk.Text = "%"
        Me.persenmasuk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(540, 387)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "HISTORY DATA MASUK"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(413, 38)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Hamulian-Topan"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 500)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(413, 38)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Sukiman-Gunawan"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Green
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 559)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(413, 38)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Hafith-Erizal"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSuara01
        '
        Me.lblSuara01.BackColor = System.Drawing.Color.Yellow
        Me.lblSuara01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSuara01.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuara01.Location = New System.Drawing.Point(169, 444)
        Me.lblSuara01.Name = "lblSuara01"
        Me.lblSuara01.Size = New System.Drawing.Size(273, 38)
        Me.lblSuara01.TabIndex = 9
        Me.lblSuara01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSuara02
        '
        Me.lblSuara02.BackColor = System.Drawing.Color.Red
        Me.lblSuara02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSuara02.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuara02.Location = New System.Drawing.Point(171, 500)
        Me.lblSuara02.Name = "lblSuara02"
        Me.lblSuara02.Size = New System.Drawing.Size(273, 38)
        Me.lblSuara02.TabIndex = 10
        Me.lblSuara02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSuara03
        '
        Me.lblSuara03.BackColor = System.Drawing.Color.Green
        Me.lblSuara03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSuara03.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuara03.Location = New System.Drawing.Point(171, 559)
        Me.lblSuara03.Name = "lblSuara03"
        Me.lblSuara03.Size = New System.Drawing.Size(273, 38)
        Me.lblSuara03.TabIndex = 11
        Me.lblSuara03.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 406)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 25)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Jumlah Suara :"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Gray
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(171, 619)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(273, 38)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 619)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(413, 38)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Total Suara"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(545, 444)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(420, 251)
        Me.DataGridView1.TabIndex = 4
        '
        'ShowPersentase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1024, 745)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSuara03)
        Me.Controls.Add(Me.lblSuara02)
        Me.Controls.Add(Me.lblSuara01)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.persenmasuk)
        Me.Controls.Add(Me.persen03)
        Me.Controls.Add(Me.persen02)
        Me.Controls.Add(Me.persen01)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ShowPersentase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quick Count PILKADA 2020"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents persen01 As Label
    Friend WithEvents persen02 As Label
    Friend WithEvents persen03 As Label
    Friend WithEvents persenmasuk As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblSuara01 As Label
    Friend WithEvents lblSuara02 As Label
    Friend WithEvents lblSuara03 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class

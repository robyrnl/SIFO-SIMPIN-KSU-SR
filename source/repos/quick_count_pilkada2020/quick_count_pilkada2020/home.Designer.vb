<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnTampilPersen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(122, 62)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(125, 47)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "MASUKKAN DATA"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnTampilPersen
        '
        Me.btnTampilPersen.Location = New System.Drawing.Point(122, 128)
        Me.btnTampilPersen.Name = "btnTampilPersen"
        Me.btnTampilPersen.Size = New System.Drawing.Size(125, 47)
        Me.btnTampilPersen.TabIndex = 1
        Me.btnTampilPersen.Text = "TAMPIL PERSENTASE"
        Me.btnTampilPersen.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 345)
        Me.Controls.Add(Me.btnTampilPersen)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "home"
        Me.Text = "home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInput As Button
    Friend WithEvents btnTampilPersen As Button
End Class

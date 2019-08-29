<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TempatTidurTambahForm
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
        Me.tbRuangan = New System.Windows.Forms.TextBox()
        Me.tbKelas = New System.Windows.Forms.TextBox()
        Me.rbRuangan = New System.Windows.Forms.RadioButton()
        Me.rbKelas = New System.Windows.Forms.RadioButton()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbRuangan
        '
        Me.tbRuangan.Location = New System.Drawing.Point(143, 12)
        Me.tbRuangan.Name = "tbRuangan"
        Me.tbRuangan.Size = New System.Drawing.Size(140, 20)
        Me.tbRuangan.TabIndex = 1
        '
        'tbKelas
        '
        Me.tbKelas.Location = New System.Drawing.Point(143, 38)
        Me.tbKelas.Name = "tbKelas"
        Me.tbKelas.Size = New System.Drawing.Size(140, 20)
        Me.tbKelas.TabIndex = 4
        '
        'rbRuangan
        '
        Me.rbRuangan.AutoSize = True
        Me.rbRuangan.Location = New System.Drawing.Point(12, 13)
        Me.rbRuangan.Name = "rbRuangan"
        Me.rbRuangan.Size = New System.Drawing.Size(111, 17)
        Me.rbRuangan.TabIndex = 6
        Me.rbRuangan.TabStop = True
        Me.rbRuangan.Text = "Tambah Ruangan"
        Me.rbRuangan.UseVisualStyleBackColor = True
        '
        'rbKelas
        '
        Me.rbKelas.AutoSize = True
        Me.rbKelas.Location = New System.Drawing.Point(12, 39)
        Me.rbKelas.Name = "rbKelas"
        Me.rbKelas.Size = New System.Drawing.Size(93, 17)
        Me.rbKelas.TabIndex = 7
        Me.rbKelas.TabStop = True
        Me.rbKelas.Text = "Tambah Kelas"
        Me.rbKelas.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(61, 82)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(153, 82)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btnBersihkan.TabIndex = 5
        Me.btnBersihkan.Text = "Bersihkan"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'TempatTidurTambahForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 124)
        Me.Controls.Add(Me.rbKelas)
        Me.Controls.Add(Me.rbRuangan)
        Me.Controls.Add(Me.btnBersihkan)
        Me.Controls.Add(Me.tbKelas)
        Me.Controls.Add(Me.tbRuangan)
        Me.Controls.Add(Me.btnTambah)
        Me.Name = "TempatTidurTambahForm"
        Me.Text = "Tambah Ruangan/Kelas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbRuangan As System.Windows.Forms.TextBox
    Friend WithEvents tbKelas As System.Windows.Forms.TextBox
    Friend WithEvents rbRuangan As System.Windows.Forms.RadioButton
    Friend WithEvents rbKelas As System.Windows.Forms.RadioButton
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
End Class

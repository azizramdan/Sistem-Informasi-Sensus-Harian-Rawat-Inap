<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TempatTidurEditForm
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
        Me.rbRuangan = New System.Windows.Forms.RadioButton()
        Me.rbKelas = New System.Windows.Forms.RadioButton()
        Me.lbLama = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lbBaru = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbRuangan
        '
        Me.rbRuangan.AutoSize = True
        Me.rbRuangan.Location = New System.Drawing.Point(79, 12)
        Me.rbRuangan.Name = "rbRuangan"
        Me.rbRuangan.Size = New System.Drawing.Size(90, 17)
        Me.rbRuangan.TabIndex = 0
        Me.rbRuangan.TabStop = True
        Me.rbRuangan.Text = "Edit Ruangan"
        Me.rbRuangan.UseVisualStyleBackColor = True
        '
        'rbKelas
        '
        Me.rbKelas.AutoSize = True
        Me.rbKelas.Location = New System.Drawing.Point(192, 12)
        Me.rbKelas.Name = "rbKelas"
        Me.rbKelas.Size = New System.Drawing.Size(72, 17)
        Me.rbKelas.TabIndex = 1
        Me.rbKelas.TabStop = True
        Me.rbKelas.Text = "Edit Kelas"
        Me.rbKelas.UseVisualStyleBackColor = True
        '
        'lbLama
        '
        Me.lbLama.AutoSize = True
        Me.lbLama.Location = New System.Drawing.Point(10, 50)
        Me.lbLama.Name = "lbLama"
        Me.lbLama.Size = New System.Drawing.Size(111, 13)
        Me.lbLama.TabIndex = 2
        Me.lbLama.Text = "Nama Ruangan Lama"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 20)
        Me.TextBox1.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(140, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'lbBaru
        '
        Me.lbBaru.AutoSize = True
        Me.lbBaru.Location = New System.Drawing.Point(10, 77)
        Me.lbBaru.Name = "lbBaru"
        Me.lbBaru.Size = New System.Drawing.Size(107, 13)
        Me.lbBaru.TabIndex = 5
        Me.lbBaru.Text = "Nama Ruangan Baru"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(116, 111)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'TempatTidurEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 150)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.lbBaru)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbLama)
        Me.Controls.Add(Me.rbKelas)
        Me.Controls.Add(Me.rbRuangan)
        Me.Name = "TempatTidurEditForm"
        Me.Text = "Edit Ruangan/Kelas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbRuangan As System.Windows.Forms.RadioButton
    Friend WithEvents rbKelas As System.Windows.Forms.RadioButton
    Friend WithEvents lbLama As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbBaru As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
End Class

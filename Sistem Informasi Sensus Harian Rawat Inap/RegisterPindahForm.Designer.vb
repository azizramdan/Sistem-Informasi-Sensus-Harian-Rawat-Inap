<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterPindahForm
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
        Me.btnCek = New System.Windows.Forms.Button()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMedrec = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbKelas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.cbRuangan = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbRuanganLama = New System.Windows.Forms.TextBox()
        Me.tbKelasLama = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.btnPindah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(273, 4)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(38, 23)
        Me.btnCek.TabIndex = 53
        Me.btnCek.Text = "Cek"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(129, 6)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(138, 20)
        Me.tbId.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "ID Register Masuk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "No. Medrec"
        '
        'tbMedrec
        '
        Me.tbMedrec.Enabled = False
        Me.tbMedrec.Location = New System.Drawing.Point(129, 32)
        Me.tbMedrec.Name = "tbMedrec"
        Me.tbMedrec.ReadOnly = True
        Me.tbMedrec.Size = New System.Drawing.Size(181, 20)
        Me.tbMedrec.TabIndex = 47
        '
        'tbNama
        '
        Me.tbNama.Enabled = False
        Me.tbNama.Location = New System.Drawing.Point(129, 58)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.ReadOnly = True
        Me.tbNama.Size = New System.Drawing.Size(181, 20)
        Me.tbNama.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Nama Pasien"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Kelas Baru"
        '
        'cbKelas
        '
        Me.cbKelas.FormattingEnabled = True
        Me.cbKelas.Location = New System.Drawing.Point(130, 163)
        Me.cbKelas.Name = "cbKelas"
        Me.cbKelas.Size = New System.Drawing.Size(182, 21)
        Me.cbKelas.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Tanggal Pindah"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(130, 190)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(182, 20)
        Me.dtpTanggal.TabIndex = 57
        '
        'cbRuangan
        '
        Me.cbRuangan.FormattingEnabled = True
        Me.cbRuangan.Location = New System.Drawing.Point(130, 136)
        Me.cbRuangan.Name = "cbRuangan"
        Me.cbRuangan.Size = New System.Drawing.Size(182, 21)
        Me.cbRuangan.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Ruangan Baru"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Ruangan Lama"
        '
        'tbRuanganLama
        '
        Me.tbRuanganLama.Enabled = False
        Me.tbRuanganLama.Location = New System.Drawing.Point(130, 84)
        Me.tbRuanganLama.Name = "tbRuanganLama"
        Me.tbRuanganLama.ReadOnly = True
        Me.tbRuanganLama.Size = New System.Drawing.Size(181, 20)
        Me.tbRuanganLama.TabIndex = 60
        '
        'tbKelasLama
        '
        Me.tbKelasLama.Enabled = False
        Me.tbKelasLama.Location = New System.Drawing.Point(130, 110)
        Me.tbKelasLama.Name = "tbKelasLama"
        Me.tbKelasLama.ReadOnly = True
        Me.tbKelasLama.Size = New System.Drawing.Size(181, 20)
        Me.tbKelasLama.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Kelas Lama"
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(174, 232)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btnBersihkan.TabIndex = 65
        Me.btnBersihkan.Text = "Bersihkan"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'btnPindah
        '
        Me.btnPindah.Location = New System.Drawing.Point(81, 232)
        Me.btnPindah.Name = "btnPindah"
        Me.btnPindah.Size = New System.Drawing.Size(75, 23)
        Me.btnPindah.TabIndex = 64
        Me.btnPindah.Text = "Pindah"
        Me.btnPindah.UseVisualStyleBackColor = True
        '
        'RegisterPindahForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 273)
        Me.Controls.Add(Me.btnBersihkan)
        Me.Controls.Add(Me.btnPindah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbRuanganLama)
        Me.Controls.Add(Me.tbKelasLama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbKelas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.cbRuangan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCek)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMedrec)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label2)
        Me.Name = "RegisterPindahForm"
        Me.Text = "Register Pindah Pasien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCek As System.Windows.Forms.Button
    Friend WithEvents tbId As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbMedrec As System.Windows.Forms.TextBox
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbKelas As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbRuangan As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbRuanganLama As System.Windows.Forms.TextBox
    Friend WithEvents tbKelasLama As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
    Friend WithEvents btnPindah As System.Windows.Forms.Button
End Class

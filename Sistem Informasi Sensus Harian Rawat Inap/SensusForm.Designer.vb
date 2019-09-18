<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SensusForm
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
        Me.rbHarian = New System.Windows.Forms.RadioButton()
        Me.rbBulanan = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.cbKelas = New System.Windows.Forms.ComboBox()
        Me.cbRuangan = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbPasienPindahan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbJumlahDirawat = New System.Windows.Forms.TextBox()
        Me.tbPasienMasuk = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbPasienAwal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbJumlahKeluarHidup = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbMelarikanDiri = New System.Windows.Forms.TextBox()
        Me.tbPulangPaksa = New System.Windows.Forms.TextBox()
        Me.tbDipindahkan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbPindahRS = New System.Windows.Forms.TextBox()
        Me.tbDirujuk = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbDiizinkan = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbJumlahKeluarMati = New System.Windows.Forms.TextBox()
        Me.tbLebih48 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbKurang48 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbKeluarMasuk = New System.Windows.Forms.TextBox()
        Me.tbLamaRawat = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cKelas = New System.Windows.Forms.CheckBox()
        Me.cRuangan = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbHarian
        '
        Me.rbHarian.AutoSize = True
        Me.rbHarian.Location = New System.Drawing.Point(73, 11)
        Me.rbHarian.Name = "rbHarian"
        Me.rbHarian.Size = New System.Drawing.Size(56, 17)
        Me.rbHarian.TabIndex = 0
        Me.rbHarian.TabStop = True
        Me.rbHarian.Text = "Harian"
        Me.rbHarian.UseVisualStyleBackColor = True
        '
        'rbBulanan
        '
        Me.rbBulanan.AutoSize = True
        Me.rbBulanan.Location = New System.Drawing.Point(167, 11)
        Me.rbBulanan.Name = "rbBulanan"
        Me.rbBulanan.Size = New System.Drawing.Size(52, 17)
        Me.rbBulanan.TabIndex = 1
        Me.rbBulanan.TabStop = True
        Me.rbBulanan.Text = "Bulan"
        Me.rbBulanan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(73, 34)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggal.TabIndex = 2
        '
        'cbKelas
        '
        Me.cbKelas.Enabled = False
        Me.cbKelas.FormattingEnabled = True
        Me.cbKelas.Location = New System.Drawing.Point(380, 37)
        Me.cbKelas.Name = "cbKelas"
        Me.cbKelas.Size = New System.Drawing.Size(164, 21)
        Me.cbKelas.TabIndex = 4
        '
        'cbRuangan
        '
        Me.cbRuangan.Enabled = False
        Me.cbRuangan.FormattingEnabled = True
        Me.cbRuangan.Location = New System.Drawing.Point(380, 10)
        Me.cbRuangan.Name = "cbRuangan"
        Me.cbRuangan.Size = New System.Drawing.Size(164, 21)
        Me.cbRuangan.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbPasienPindahan)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbJumlahDirawat)
        Me.GroupBox1.Controls.Add(Me.tbPasienMasuk)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbPasienAwal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 132)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Pasien Dirawat"
        '
        'tbPasienPindahan
        '
        Me.tbPasienPindahan.Location = New System.Drawing.Point(105, 71)
        Me.tbPasienPindahan.Name = "tbPasienPindahan"
        Me.tbPasienPindahan.ReadOnly = True
        Me.tbPasienPindahan.Size = New System.Drawing.Size(100, 20)
        Me.tbPasienPindahan.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pasien pindahan"
        '
        'tbJumlahDirawat
        '
        Me.tbJumlahDirawat.Location = New System.Drawing.Point(105, 97)
        Me.tbJumlahDirawat.Name = "tbJumlahDirawat"
        Me.tbJumlahDirawat.ReadOnly = True
        Me.tbJumlahDirawat.Size = New System.Drawing.Size(100, 20)
        Me.tbJumlahDirawat.TabIndex = 2
        '
        'tbPasienMasuk
        '
        Me.tbPasienMasuk.Location = New System.Drawing.Point(105, 45)
        Me.tbPasienMasuk.Name = "tbPasienMasuk"
        Me.tbPasienMasuk.ReadOnly = True
        Me.tbPasienMasuk.Size = New System.Drawing.Size(100, 20)
        Me.tbPasienMasuk.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Jumlah"
        '
        'tbPasienAwal
        '
        Me.tbPasienAwal.Location = New System.Drawing.Point(105, 19)
        Me.tbPasienAwal.Name = "tbPasienAwal"
        Me.tbPasienAwal.ReadOnly = True
        Me.tbPasienAwal.Size = New System.Drawing.Size(100, 20)
        Me.tbPasienAwal.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Pasien awal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Pasien masuk"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbJumlahKeluarHidup)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.tbMelarikanDiri)
        Me.GroupBox2.Controls.Add(Me.tbPulangPaksa)
        Me.GroupBox2.Controls.Add(Me.tbDipindahkan)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbPindahRS)
        Me.GroupBox2.Controls.Add(Me.tbDirujuk)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tbDiizinkan)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(306, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 211)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Pasien Keluar Hidup"
        '
        'tbJumlahKeluarHidup
        '
        Me.tbJumlahKeluarHidup.Location = New System.Drawing.Point(99, 175)
        Me.tbJumlahKeluarHidup.Name = "tbJumlahKeluarHidup"
        Me.tbJumlahKeluarHidup.ReadOnly = True
        Me.tbJumlahKeluarHidup.Size = New System.Drawing.Size(100, 20)
        Me.tbJumlahKeluarHidup.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Dipindahkan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Melarikan diri"
        '
        'tbMelarikanDiri
        '
        Me.tbMelarikanDiri.Location = New System.Drawing.Point(99, 123)
        Me.tbMelarikanDiri.Name = "tbMelarikanDiri"
        Me.tbMelarikanDiri.ReadOnly = True
        Me.tbMelarikanDiri.Size = New System.Drawing.Size(100, 20)
        Me.tbMelarikanDiri.TabIndex = 13
        '
        'tbPulangPaksa
        '
        Me.tbPulangPaksa.Location = New System.Drawing.Point(99, 97)
        Me.tbPulangPaksa.Name = "tbPulangPaksa"
        Me.tbPulangPaksa.ReadOnly = True
        Me.tbPulangPaksa.Size = New System.Drawing.Size(100, 20)
        Me.tbPulangPaksa.TabIndex = 12
        '
        'tbDipindahkan
        '
        Me.tbDipindahkan.Location = New System.Drawing.Point(99, 149)
        Me.tbDipindahkan.Name = "tbDipindahkan"
        Me.tbDipindahkan.ReadOnly = True
        Me.tbDipindahkan.Size = New System.Drawing.Size(100, 20)
        Me.tbDipindahkan.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Pulang paksa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Pindah RS lain"
        '
        'tbPindahRS
        '
        Me.tbPindahRS.Location = New System.Drawing.Point(99, 71)
        Me.tbPindahRS.Name = "tbPindahRS"
        Me.tbPindahRS.ReadOnly = True
        Me.tbPindahRS.Size = New System.Drawing.Size(100, 20)
        Me.tbPindahRS.TabIndex = 2
        '
        'tbDirujuk
        '
        Me.tbDirujuk.Location = New System.Drawing.Point(99, 45)
        Me.tbDirujuk.Name = "tbDirujuk"
        Me.tbDirujuk.ReadOnly = True
        Me.tbDirujuk.Size = New System.Drawing.Size(100, 20)
        Me.tbDirujuk.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Jumlah"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Diizinkan pulang"
        '
        'tbDiizinkan
        '
        Me.tbDiizinkan.Location = New System.Drawing.Point(99, 19)
        Me.tbDiizinkan.Name = "tbDiizinkan"
        Me.tbDiizinkan.ReadOnly = True
        Me.tbDiizinkan.Size = New System.Drawing.Size(100, 20)
        Me.tbDiizinkan.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Dirujuk"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(165, 69)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 5
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(277, 69)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbJumlahKeluarMati)
        Me.GroupBox3.Controls.Add(Me.tbLebih48)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.tbKurang48)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(225, 103)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Pasien Keluar Mati"
        '
        'tbJumlahKeluarMati
        '
        Me.tbJumlahKeluarMati.Location = New System.Drawing.Point(93, 71)
        Me.tbJumlahKeluarMati.Name = "tbJumlahKeluarMati"
        Me.tbJumlahKeluarMati.ReadOnly = True
        Me.tbJumlahKeluarMati.Size = New System.Drawing.Size(100, 20)
        Me.tbJumlahKeluarMati.TabIndex = 2
        '
        'tbLebih48
        '
        Me.tbLebih48.Location = New System.Drawing.Point(93, 45)
        Me.tbLebih48.Name = "tbLebih48"
        Me.tbLebih48.ReadOnly = True
        Me.tbLebih48.Size = New System.Drawing.Size(100, 20)
        Me.tbLebih48.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Jumlah"
        '
        'tbKurang48
        '
        Me.tbKurang48.Location = New System.Drawing.Point(93, 19)
        Me.tbKurang48.Name = "tbKurang48"
        Me.tbKurang48.ReadOnly = True
        Me.tbKurang48.Size = New System.Drawing.Size(100, 20)
        Me.tbKurang48.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "< 48 jam"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "> 48 jam"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(35, 391)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(187, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Pasien keluar masuk dihari yang sama"
        '
        'tbKeluarMasuk
        '
        Me.tbKeluarMasuk.Location = New System.Drawing.Point(236, 388)
        Me.tbKeluarMasuk.Name = "tbKeluarMasuk"
        Me.tbKeluarMasuk.ReadOnly = True
        Me.tbKeluarMasuk.Size = New System.Drawing.Size(100, 20)
        Me.tbKeluarMasuk.TabIndex = 4
        '
        'tbLamaRawat
        '
        Me.tbLamaRawat.Location = New System.Drawing.Point(236, 362)
        Me.tbLamaRawat.Name = "tbLamaRawat"
        Me.tbLamaRawat.ReadOnly = True
        Me.tbLamaRawat.Size = New System.Drawing.Size(100, 20)
        Me.tbLamaRawat.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(35, 365)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Lama dirawat"
        '
        'cKelas
        '
        Me.cKelas.AutoSize = True
        Me.cKelas.Location = New System.Drawing.Point(297, 39)
        Me.cKelas.Name = "cKelas"
        Me.cKelas.Size = New System.Drawing.Size(52, 17)
        Me.cKelas.TabIndex = 32
        Me.cKelas.Text = "Kelas"
        Me.cKelas.UseVisualStyleBackColor = True
        '
        'cRuangan
        '
        Me.cRuangan.AutoSize = True
        Me.cRuangan.Location = New System.Drawing.Point(297, 12)
        Me.cRuangan.Name = "cRuangan"
        Me.cRuangan.Size = New System.Drawing.Size(70, 17)
        Me.cRuangan.TabIndex = 31
        Me.cRuangan.Text = "Ruangan"
        Me.cRuangan.UseVisualStyleBackColor = True
        '
        'SensusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 419)
        Me.Controls.Add(Me.cKelas)
        Me.Controls.Add(Me.cRuangan)
        Me.Controls.Add(Me.tbLamaRawat)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tbKeluarMasuk)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.rbBulanan)
        Me.Controls.Add(Me.rbHarian)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbRuangan)
        Me.Controls.Add(Me.cbKelas)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SensusForm"
        Me.Text = "Sensus"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbKelas As System.Windows.Forms.ComboBox
    Friend WithEvents cbRuangan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbPasienAwal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents rbHarian As System.Windows.Forms.RadioButton
    Friend WithEvents rbBulanan As System.Windows.Forms.RadioButton
    Friend WithEvents tbJumlahDirawat As System.Windows.Forms.TextBox
    Friend WithEvents tbPasienMasuk As System.Windows.Forms.TextBox
    Friend WithEvents tbPindahRS As System.Windows.Forms.TextBox
    Friend WithEvents tbDirujuk As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbDiizinkan As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents tbJumlahKeluarHidup As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbDipindahkan As System.Windows.Forms.TextBox
    Friend WithEvents tbMelarikanDiri As System.Windows.Forms.TextBox
    Friend WithEvents tbPulangPaksa As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbJumlahKeluarMati As System.Windows.Forms.TextBox
    Friend WithEvents tbLebih48 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbKurang48 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbKeluarMasuk As System.Windows.Forms.TextBox
    Friend WithEvents tbLamaRawat As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cKelas As System.Windows.Forms.CheckBox
    Friend WithEvents cRuangan As System.Windows.Forms.CheckBox
    Friend WithEvents tbPasienPindahan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterMasukTambahForm
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
        Me.tbMedrec = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.cbRuangan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbKelas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.cbCaraMasuk = New System.Windows.Forms.ComboBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnCek = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "No. Medrec"
        '
        'tbMedrec
        '
        Me.tbMedrec.Location = New System.Drawing.Point(129, 6)
        Me.tbMedrec.MaxLength = 6
        Me.tbMedrec.Name = "tbMedrec"
        Me.tbMedrec.Size = New System.Drawing.Size(181, 20)
        Me.tbMedrec.TabIndex = 9
        '
        'tbNama
        '
        Me.tbNama.Enabled = False
        Me.tbNama.Location = New System.Drawing.Point(129, 32)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(225, 20)
        Me.tbNama.TabIndex = 10
        '
        'cbRuangan
        '
        Me.cbRuangan.FormattingEnabled = True
        Me.cbRuangan.Location = New System.Drawing.Point(129, 58)
        Me.cbRuangan.Name = "cbRuangan"
        Me.cbRuangan.Size = New System.Drawing.Size(225, 21)
        Me.cbRuangan.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nama Ruangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama Pasien"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Kelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Cara Pasien Masuk"
        '
        'cbKelas
        '
        Me.cbKelas.FormattingEnabled = True
        Me.cbKelas.Location = New System.Drawing.Point(129, 85)
        Me.cbKelas.Name = "cbKelas"
        Me.cbKelas.Size = New System.Drawing.Size(225, 21)
        Me.cbKelas.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Tanggal Masuk"
        '
        'dtpTanggalMasuk
        '
        Me.dtpTanggalMasuk.Location = New System.Drawing.Point(129, 112)
        Me.dtpTanggalMasuk.Name = "dtpTanggalMasuk"
        Me.dtpTanggalMasuk.Size = New System.Drawing.Size(225, 20)
        Me.dtpTanggalMasuk.TabIndex = 16
        '
        'cbCaraMasuk
        '
        Me.cbCaraMasuk.FormattingEnabled = True
        Me.cbCaraMasuk.Items.AddRange(New Object() {"Rujukan", "UGD", "OPD/POLI"})
        Me.cbCaraMasuk.Location = New System.Drawing.Point(129, 138)
        Me.cbCaraMasuk.Name = "cbCaraMasuk"
        Me.cbCaraMasuk.Size = New System.Drawing.Size(225, 21)
        Me.cbCaraMasuk.TabIndex = 17
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(108, 181)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 21
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(316, 4)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(38, 23)
        Me.btnCek.TabIndex = 22
        Me.btnCek.Text = "Cek"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(201, 181)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btnBersihkan.TabIndex = 42
        Me.btnBersihkan.Text = "Bersihkan"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'RegisterMasukTambahForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 216)
        Me.Controls.Add(Me.btnBersihkan)
        Me.Controls.Add(Me.btnCek)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbKelas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpTanggalMasuk)
        Me.Controls.Add(Me.cbCaraMasuk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMedrec)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.cbRuangan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "RegisterMasukTambahForm"
        Me.Text = "Tambah Data Pasien Masuk Rawat Inap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbMedrec As System.Windows.Forms.TextBox
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents cbRuangan As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbKelas As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalMasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbCaraMasuk As System.Windows.Forms.ComboBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnCek As System.Windows.Forms.Button
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
End Class

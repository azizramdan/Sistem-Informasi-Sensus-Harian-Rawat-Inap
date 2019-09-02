<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DokterTambahForm
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
        Me.cbSpesialis = New System.Windows.Forms.ComboBox()
        Me.tbTelp = New System.Windows.Forms.TextBox()
        Me.rtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSip = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbSpesialis
        '
        Me.cbSpesialis.FormattingEnabled = True
        Me.cbSpesialis.Items.AddRange(New Object() {"Dokter Umum", "Medical Check Up", "Psikolog", "Spesialis", "Spesialis Akupuntur", "Spesialis Anak", "Spesialis Anak Konsultan Gastro Hepatologi", "Spesialis Anak Konsultan Jantung Anak", "Spesialis Bedah Anak", "Spesialis Bedah Onkologi", "Spesialis Bedah Ortopedi & Traumatologi", "Spesialis Bedah Pencernaan", "Spesialis Bedah Plastik", "Spesialis Bedah Saraf", "Spesialis Bedah Thorax & Cardiovascular", "Spesialis Bedah Umum", "Spesialis Bedah Urologi", "Spesialis Dokter Gigi", "Spesialis Fisiologi Olahraga", "Spesialis Gizi Klinik", "Spesialis Internist Endokrin-Metabolik-Diabetes", "Spesialis Internist Gastro-Entero-Hepatologi", "Spesialis Internist Ginjal Dan Hipertensi", "Spesialis Internist Onkologi-Hematologi", "Spesialis Internist Rheumatologi", "Spesialis Jantung", "Spesialis Kandungan", "Spesialis Kandungan Konsultan Onkologi", "Spesialis Kesehatan Jiwa-Psychiatry", "Spesialis Kulit & Kecantikan", "Spesialis Mata", "Spesialis Nyeri Intervensi", "Spesialis Paru", "Spesialis Penyakit Dalam", "Spesialis Radiologi Intervensi", "Spesialis Rehabilitasi Medik", "Spesialis Saraf", "Spesialis THT"})
        Me.cbSpesialis.Location = New System.Drawing.Point(139, 138)
        Me.cbSpesialis.Name = "cbSpesialis"
        Me.cbSpesialis.Size = New System.Drawing.Size(173, 21)
        Me.cbSpesialis.TabIndex = 24
        '
        'tbTelp
        '
        Me.tbTelp.Location = New System.Drawing.Point(139, 112)
        Me.tbTelp.Name = "tbTelp"
        Me.tbTelp.Size = New System.Drawing.Size(173, 20)
        Me.tbTelp.TabIndex = 23
        '
        'rtbAlamat
        '
        Me.rtbAlamat.Location = New System.Drawing.Point(139, 58)
        Me.rtbAlamat.Name = "rtbAlamat"
        Me.rtbAlamat.Size = New System.Drawing.Size(173, 48)
        Me.rtbAlamat.TabIndex = 22
        Me.rtbAlamat.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Spesialis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "No. Telpon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nama Lengkap"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "No. SIP"
        '
        'tbSip
        '
        Me.tbSip.Location = New System.Drawing.Point(139, 6)
        Me.tbSip.MaxLength = 10
        Me.tbSip.Name = "tbSip"
        Me.tbSip.Size = New System.Drawing.Size(173, 20)
        Me.tbSip.TabIndex = 15
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(139, 32)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(173, 20)
        Me.tbNama.TabIndex = 16
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(167, 221)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btnBersihkan.TabIndex = 41
        Me.btnBersihkan.Text = "Bersihkan"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(74, 221)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 40
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Aktif", "Tidak aktif", "Cuti", "Perjanjian"})
        Me.cbStatus.Location = New System.Drawing.Point(139, 167)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(173, 21)
        Me.cbStatus.TabIndex = 43
        '
        'DokterTambahForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 269)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBersihkan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.cbSpesialis)
        Me.Controls.Add(Me.tbTelp)
        Me.Controls.Add(Me.rtbAlamat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSip)
        Me.Controls.Add(Me.tbNama)
        Me.Name = "DokterTambahForm"
        Me.Text = "Tambah Data Dokter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbSpesialis As System.Windows.Forms.ComboBox
    Friend WithEvents tbTelp As System.Windows.Forms.TextBox
    Friend WithEvents rtbAlamat As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSip As System.Windows.Forms.TextBox
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
End Class

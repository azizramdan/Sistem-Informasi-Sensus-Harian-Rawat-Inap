<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasienTambahForm
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
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.tbTempatLahir = New System.Windows.Forms.TextBox()
        Me.rtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.tbPasien = New System.Windows.Forms.TextBox()
        Me.tbMedrec = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbTelp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbAgama = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbPekerjaan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbAyah = New System.Windows.Forms.TextBox()
        Me.tbIbu = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "No. Medrec"
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(151, 87)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(211, 20)
        Me.dtpTanggalLahir.TabIndex = 19
        '
        'tbTempatLahir
        '
        Me.tbTempatLahir.Location = New System.Drawing.Point(151, 61)
        Me.tbTempatLahir.Name = "tbTempatLahir"
        Me.tbTempatLahir.Size = New System.Drawing.Size(211, 20)
        Me.tbTempatLahir.TabIndex = 18
        '
        'rtbAlamat
        '
        Me.rtbAlamat.Location = New System.Drawing.Point(151, 113)
        Me.rtbAlamat.Name = "rtbAlamat"
        Me.rtbAlamat.Size = New System.Drawing.Size(211, 52)
        Me.rtbAlamat.TabIndex = 20
        Me.rtbAlamat.Text = ""
        '
        'tbPasien
        '
        Me.tbPasien.Location = New System.Drawing.Point(151, 35)
        Me.tbPasien.Name = "tbPasien"
        Me.tbPasien.Size = New System.Drawing.Size(211, 20)
        Me.tbPasien.TabIndex = 17
        '
        'tbMedrec
        '
        Me.tbMedrec.Location = New System.Drawing.Point(151, 6)
        Me.tbMedrec.MaxLength = 6
        Me.tbMedrec.Name = "tbMedrec"
        Me.tbMedrec.Size = New System.Drawing.Size(211, 20)
        Me.tbMedrec.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nama Pasien"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "No. Telpon"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Nama Ibu Kandung"
        '
        'tbTelp
        '
        Me.tbTelp.Location = New System.Drawing.Point(151, 172)
        Me.tbTelp.Name = "tbTelp"
        Me.tbTelp.Size = New System.Drawing.Size(211, 20)
        Me.tbTelp.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 281)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Nama Ayah Kandung"
        '
        'cbAgama
        '
        Me.cbAgama.FormattingEnabled = True
        Me.cbAgama.Items.AddRange(New Object() {"Islam", "Buddha", "Protestan", "Hindu", "Katolik", "Khonghucu"})
        Me.cbAgama.Location = New System.Drawing.Point(151, 198)
        Me.cbAgama.Name = "cbAgama"
        Me.cbAgama.Size = New System.Drawing.Size(211, 21)
        Me.cbAgama.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Pekerjaan"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Menikah", "Belum menikah", "Cerai hidup", "Cerai mati"})
        Me.cbStatus.Location = New System.Drawing.Point(151, 225)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(211, 21)
        Me.cbStatus.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Status"
        '
        'tbPekerjaan
        '
        Me.tbPekerjaan.Location = New System.Drawing.Point(151, 252)
        Me.tbPekerjaan.Name = "tbPekerjaan"
        Me.tbPekerjaan.Size = New System.Drawing.Size(211, 20)
        Me.tbPekerjaan.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Agama"
        '
        'tbAyah
        '
        Me.tbAyah.Location = New System.Drawing.Point(151, 278)
        Me.tbAyah.Name = "tbAyah"
        Me.tbAyah.Size = New System.Drawing.Size(211, 20)
        Me.tbAyah.TabIndex = 30
        '
        'tbIbu
        '
        Me.tbIbu.Location = New System.Drawing.Point(151, 304)
        Me.tbIbu.Name = "tbIbu"
        Me.tbIbu.Size = New System.Drawing.Size(211, 20)
        Me.tbIbu.TabIndex = 31
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(93, 342)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 38
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(186, 342)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btnBersihkan.TabIndex = 39
        Me.btnBersihkan.Text = "Bersihkan"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'PasienTambahForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 386)
        Me.Controls.Add(Me.btnBersihkan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbTelp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbAgama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbPekerjaan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbAyah)
        Me.Controls.Add(Me.tbIbu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpTanggalLahir)
        Me.Controls.Add(Me.tbTempatLahir)
        Me.Controls.Add(Me.rtbAlamat)
        Me.Controls.Add(Me.tbPasien)
        Me.Controls.Add(Me.tbMedrec)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Name = "PasienTambahForm"
        Me.Text = "Tambah Data Pasien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbTempatLahir As System.Windows.Forms.TextBox
    Friend WithEvents rtbAlamat As System.Windows.Forms.RichTextBox
    Friend WithEvents tbPasien As System.Windows.Forms.TextBox
    Friend WithEvents tbMedrec As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbTelp As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbAgama As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbPekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbAyah As System.Windows.Forms.TextBox
    Friend WithEvents tbIbu As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
End Class

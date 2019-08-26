<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterKeluarTambahForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.cbCaraKeluar = New System.Windows.Forms.ComboBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.btnCek = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "No. Medrec"
        '
        'tbMedrec
        '
        Me.tbMedrec.Enabled = False
        Me.tbMedrec.Location = New System.Drawing.Point(129, 32)
        Me.tbMedrec.Name = "tbMedrec"
        Me.tbMedrec.Size = New System.Drawing.Size(181, 20)
        Me.tbMedrec.TabIndex = 8
        '
        'tbNama
        '
        Me.tbNama.Enabled = False
        Me.tbNama.Location = New System.Drawing.Point(129, 58)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(181, 20)
        Me.tbNama.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama Pasien"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cara Pasien Keluar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tanggal Keluar"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(129, 84)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(181, 20)
        Me.dtpTanggal.TabIndex = 12
        '
        'cbCaraKeluar
        '
        Me.cbCaraKeluar.FormattingEnabled = True
        Me.cbCaraKeluar.Items.AddRange(New Object() {"Diizinkan pulang", "Dirujuk", "Pindah RS lain", "Pulang paksa", "Melarikan diri", "Dipindahkan", "Meninggal <48 jam", "Meninggal >48 jam"})
        Me.cbCaraKeluar.Location = New System.Drawing.Point(129, 110)
        Me.cbCaraKeluar.Name = "cbCaraKeluar"
        Me.cbCaraKeluar.Size = New System.Drawing.Size(181, 21)
        Me.cbCaraKeluar.TabIndex = 13
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(79, 148)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 16
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(173, 148)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btnBersihkan.TabIndex = 43
        Me.btnBersihkan.Text = "Bersihkan"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "ID Register Masuk"
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(129, 6)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(138, 20)
        Me.tbId.TabIndex = 45
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(273, 4)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(38, 23)
        Me.btnCek.TabIndex = 46
        Me.btnCek.Text = "Cek"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'RegisterKeluarTambahForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 183)
        Me.Controls.Add(Me.btnCek)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBersihkan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.cbCaraKeluar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMedrec)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label2)
        Me.Name = "RegisterKeluarTambahForm"
        Me.Text = "Tambah Data Pasien Keluar Rawat Inap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbMedrec As System.Windows.Forms.TextBox
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbCaraKeluar As System.Windows.Forms.ComboBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbId As System.Windows.Forms.TextBox
    Friend WithEvents btnCek As System.Windows.Forms.Button
End Class

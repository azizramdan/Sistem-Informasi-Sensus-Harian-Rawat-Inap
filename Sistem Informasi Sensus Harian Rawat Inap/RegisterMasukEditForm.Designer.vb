<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterMasukEditForm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.tbMedrec = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.cbRuangan = New System.Windows.Forms.ComboBox()
        Me.cbKelas = New System.Windows.Forms.ComboBox()
        Me.cbCaraMasuk = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Kelas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tanggal Masuk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "No. Medrec"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nama Ruangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama Pasien"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Cara Masuk"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(128, 186)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 56
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'tbMedrec
        '
        Me.tbMedrec.Location = New System.Drawing.Point(110, 12)
        Me.tbMedrec.Name = "tbMedrec"
        Me.tbMedrec.ReadOnly = True
        Me.tbMedrec.Size = New System.Drawing.Size(200, 20)
        Me.tbMedrec.TabIndex = 57
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(110, 38)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.ReadOnly = True
        Me.tbNama.Size = New System.Drawing.Size(200, 20)
        Me.tbNama.TabIndex = 58
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(110, 64)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggal.TabIndex = 59
        '
        'cbRuangan
        '
        Me.cbRuangan.FormattingEnabled = True
        Me.cbRuangan.Location = New System.Drawing.Point(110, 90)
        Me.cbRuangan.Name = "cbRuangan"
        Me.cbRuangan.Size = New System.Drawing.Size(200, 21)
        Me.cbRuangan.TabIndex = 60
        '
        'cbKelas
        '
        Me.cbKelas.FormattingEnabled = True
        Me.cbKelas.Location = New System.Drawing.Point(110, 117)
        Me.cbKelas.Name = "cbKelas"
        Me.cbKelas.Size = New System.Drawing.Size(200, 21)
        Me.cbKelas.TabIndex = 61
        '
        'cbCaraMasuk
        '
        Me.cbCaraMasuk.FormattingEnabled = True
        Me.cbCaraMasuk.Items.AddRange(New Object() {"Rujukan", "UGD", "OPD/POLI", "Pindahan"})
        Me.cbCaraMasuk.Location = New System.Drawing.Point(110, 144)
        Me.cbCaraMasuk.Name = "cbCaraMasuk"
        Me.cbCaraMasuk.Size = New System.Drawing.Size(200, 21)
        Me.cbCaraMasuk.TabIndex = 62
        '
        'RegisterMasukEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 235)
        Me.Controls.Add(Me.cbCaraMasuk)
        Me.Controls.Add(Me.cbKelas)
        Me.Controls.Add(Me.cbRuangan)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.tbMedrec)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Name = "RegisterMasukEditForm"
        Me.Text = "Edit Data Pasien Masuk Rawat Inap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents tbMedrec As System.Windows.Forms.TextBox
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbRuangan As System.Windows.Forms.ComboBox
    Friend WithEvents cbKelas As System.Windows.Forms.ComboBox
    Friend WithEvents cbCaraMasuk As System.Windows.Forms.ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanMasukForm
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
        Me.components = New System.ComponentModel.Container()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbBulanan = New System.Windows.Forms.RadioButton()
        Me.rbHarian = New System.Windows.Forms.RadioButton()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.cbRuangan = New System.Windows.Forms.ComboBox()
        Me.cbKelas = New System.Windows.Forms.ComboBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Register_masuk_QueryTableAdapter = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.register_masuk_QueryTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Register_masuk_QueryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pasien_nama_lengkap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dokter_nama_lengkap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Register_masuk_QueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbCaraMasuk = New System.Windows.Forms.ComboBox()
        Me.cRuangan = New System.Windows.Forms.CheckBox()
        Me.cKelas = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDokter = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Register_masuk_QueryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Register_masuk_QueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(343, 130)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 21
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(361, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Kelas"
        '
        'rbBulanan
        '
        Me.rbBulanan.AutoSize = True
        Me.rbBulanan.Location = New System.Drawing.Point(226, 15)
        Me.rbBulanan.Name = "rbBulanan"
        Me.rbBulanan.Size = New System.Drawing.Size(52, 17)
        Me.rbBulanan.TabIndex = 14
        Me.rbBulanan.TabStop = True
        Me.rbBulanan.Text = "Bulan"
        Me.rbBulanan.UseVisualStyleBackColor = True
        '
        'rbHarian
        '
        Me.rbHarian.AutoSize = True
        Me.rbHarian.Location = New System.Drawing.Point(132, 15)
        Me.rbHarian.Name = "rbHarian"
        Me.rbHarian.Size = New System.Drawing.Size(56, 17)
        Me.rbHarian.TabIndex = 12
        Me.rbHarian.TabStop = True
        Me.rbHarian.Text = "Harian"
        Me.rbHarian.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(233, 130)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 20
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'cbRuangan
        '
        Me.cbRuangan.Enabled = False
        Me.cbRuangan.FormattingEnabled = True
        Me.cbRuangan.Location = New System.Drawing.Point(470, 42)
        Me.cbRuangan.Name = "cbRuangan"
        Me.cbRuangan.Size = New System.Drawing.Size(164, 21)
        Me.cbRuangan.TabIndex = 18
        '
        'cbKelas
        '
        Me.cbKelas.Enabled = False
        Me.cbKelas.FormattingEnabled = True
        Me.cbKelas.Location = New System.Drawing.Point(470, 69)
        Me.cbKelas.Name = "cbKelas"
        Me.cbKelas.Size = New System.Drawing.Size(164, 21)
        Me.cbKelas.TabIndex = 19
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(132, 38)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggal.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(361, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Ruangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Periode"
        '
        'Register_masuk_QueryTableAdapter
        '
        Me.Register_masuk_QueryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.dokterTableAdapter = Nothing
        Me.TableAdapterManager.kelasTableAdapter = Nothing
        Me.TableAdapterManager.pasienTableAdapter = Nothing
        Me.TableAdapterManager.register_keluarTableAdapter = Nothing
        Me.TableAdapterManager.register_masukTableAdapter = Nothing
        Me.TableAdapterManager.ruanganTableAdapter = Nothing
        Me.TableAdapterManager.tempat_tidurTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 509)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(689, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'Register_masuk_QueryDataGridView
        '
        Me.Register_masuk_QueryDataGridView.AllowUserToAddRows = False
        Me.Register_masuk_QueryDataGridView.AllowUserToDeleteRows = False
        Me.Register_masuk_QueryDataGridView.AutoGenerateColumns = False
        Me.Register_masuk_QueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Register_masuk_QueryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.pasien_nama_lengkap, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.dokter_nama_lengkap, Me.DataGridViewTextBoxColumn10})
        Me.Register_masuk_QueryDataGridView.DataSource = Me.Register_masuk_QueryBindingSource
        Me.Register_masuk_QueryDataGridView.Location = New System.Drawing.Point(12, 163)
        Me.Register_masuk_QueryDataGridView.Name = "Register_masuk_QueryDataGridView"
        Me.Register_masuk_QueryDataGridView.ReadOnly = True
        Me.Register_masuk_QueryDataGridView.Size = New System.Drawing.Size(664, 336)
        Me.Register_masuk_QueryDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Register"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "no_medrec"
        Me.DataGridViewTextBoxColumn2.HeaderText = "No. Medrec"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'pasien_nama_lengkap
        '
        Me.pasien_nama_lengkap.DataPropertyName = "pasien_nama_lengkap"
        Me.pasien_nama_lengkap.HeaderText = "Nama Pasien"
        Me.pasien_nama_lengkap.Name = "pasien_nama_lengkap"
        Me.pasien_nama_lengkap.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tanggal_masuk"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tanggal Masuk"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ruangan"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ruangan"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "kelas"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Kelas"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'dokter_nama_lengkap
        '
        Me.dokter_nama_lengkap.DataPropertyName = "dokter_nama_lengkap"
        Me.dokter_nama_lengkap.HeaderText = "Nama Dokter"
        Me.dokter_nama_lengkap.Name = "dokter_nama_lengkap"
        Me.dokter_nama_lengkap.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "cara_pasien_masuk"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cara Masuk"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'Register_masuk_QueryBindingSource
        '
        Me.Register_masuk_QueryBindingSource.DataMember = "register_masuk Query"
        Me.Register_masuk_QueryBindingSource.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Cara Masuk"
        '
        'cbCaraMasuk
        '
        Me.cbCaraMasuk.FormattingEnabled = True
        Me.cbCaraMasuk.Items.AddRange(New Object() {"Semua", "Rujukan", "UGD", "OPD/POLI", "Pindahan"})
        Me.cbCaraMasuk.Location = New System.Drawing.Point(132, 70)
        Me.cbCaraMasuk.Name = "cbCaraMasuk"
        Me.cbCaraMasuk.Size = New System.Drawing.Size(200, 21)
        Me.cbCaraMasuk.TabIndex = 26
        '
        'cRuangan
        '
        Me.cRuangan.AutoSize = True
        Me.cRuangan.Location = New System.Drawing.Point(470, 17)
        Me.cRuangan.Name = "cRuangan"
        Me.cRuangan.Size = New System.Drawing.Size(70, 17)
        Me.cRuangan.TabIndex = 28
        Me.cRuangan.Text = "Ruangan"
        Me.cRuangan.UseVisualStyleBackColor = True
        '
        'cKelas
        '
        Me.cKelas.AutoSize = True
        Me.cKelas.Location = New System.Drawing.Point(566, 17)
        Me.cKelas.Name = "cKelas"
        Me.cKelas.Size = New System.Drawing.Size(52, 17)
        Me.cKelas.TabIndex = 29
        Me.cKelas.Text = "Kelas"
        Me.cKelas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(361, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Ruangan && Kelas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Nama Dokter"
        '
        'tbDokter
        '
        Me.tbDokter.Location = New System.Drawing.Point(132, 97)
        Me.tbDokter.Name = "tbDokter"
        Me.tbDokter.ReadOnly = True
        Me.tbDokter.Size = New System.Drawing.Size(118, 20)
        Me.tbDokter.TabIndex = 32
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(256, 95)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(22, 23)
        Me.btnClear.TabIndex = 33
        Me.btnClear.Text = "X"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPilih
        '
        Me.btnPilih.Location = New System.Drawing.Point(284, 95)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(48, 23)
        Me.btnPilih.TabIndex = 34
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'LaporanMasukForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 531)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.tbDokter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cKelas)
        Me.Controls.Add(Me.cRuangan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbCaraMasuk)
        Me.Controls.Add(Me.Register_masuk_QueryDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rbBulanan)
        Me.Controls.Add(Me.rbHarian)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.cbRuangan)
        Me.Controls.Add(Me.cbKelas)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LaporanMasukForm"
        Me.Text = "Laporan Pasien Masuk"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Register_masuk_QueryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Register_masuk_QueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbBulanan As System.Windows.Forms.RadioButton
    Friend WithEvents rbHarian As System.Windows.Forms.RadioButton
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents cbRuangan As System.Windows.Forms.ComboBox
    Friend WithEvents cbKelas As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DBDataSet As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSet
    Friend WithEvents Register_masuk_QueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Register_masuk_QueryTableAdapter As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.register_masuk_QueryTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Register_masuk_QueryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbCaraMasuk As System.Windows.Forms.ComboBox
    Friend WithEvents cRuangan As System.Windows.Forms.CheckBox
    Friend WithEvents cKelas As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pasien_nama_lengkap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dokter_nama_lengkap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbDokter As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnPilih As System.Windows.Forms.Button
End Class

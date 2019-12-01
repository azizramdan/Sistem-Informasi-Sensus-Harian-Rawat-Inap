<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanKeluarForm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Laporan_keluar_QueryTableAdapter = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.laporan_keluar_QueryTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager()
        Me.Laporan_keluar_QueryDataGridView = New System.Windows.Forms.DataGridView()
        Me.Laporan_keluar_QueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSet()
        Me.cbCaraKeluar = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cKelas = New System.Windows.Forms.CheckBox()
        Me.cRuangan = New System.Windows.Forms.CheckBox()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tbDokter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pasien_nama_lengkap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dokter_nama_lengkap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Laporan_keluar_QueryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Laporan_keluar_QueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(355, 133)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 32
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(369, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Kelas"
        '
        'rbBulanan
        '
        Me.rbBulanan.AutoSize = True
        Me.rbBulanan.Location = New System.Drawing.Point(226, 18)
        Me.rbBulanan.Name = "rbBulanan"
        Me.rbBulanan.Size = New System.Drawing.Size(52, 17)
        Me.rbBulanan.TabIndex = 25
        Me.rbBulanan.TabStop = True
        Me.rbBulanan.Text = "Bulan"
        Me.rbBulanan.UseVisualStyleBackColor = True
        '
        'rbHarian
        '
        Me.rbHarian.AutoSize = True
        Me.rbHarian.Location = New System.Drawing.Point(132, 18)
        Me.rbHarian.Name = "rbHarian"
        Me.rbHarian.Size = New System.Drawing.Size(56, 17)
        Me.rbHarian.TabIndex = 23
        Me.rbHarian.TabStop = True
        Me.rbHarian.Text = "Harian"
        Me.rbHarian.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(245, 133)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 31
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'cbRuangan
        '
        Me.cbRuangan.Enabled = False
        Me.cbRuangan.FormattingEnabled = True
        Me.cbRuangan.Location = New System.Drawing.Point(478, 44)
        Me.cbRuangan.Name = "cbRuangan"
        Me.cbRuangan.Size = New System.Drawing.Size(164, 21)
        Me.cbRuangan.TabIndex = 29
        '
        'cbKelas
        '
        Me.cbKelas.Enabled = False
        Me.cbKelas.FormattingEnabled = True
        Me.cbKelas.Location = New System.Drawing.Point(478, 71)
        Me.cbKelas.Name = "cbKelas"
        Me.cbKelas.Size = New System.Drawing.Size(164, 21)
        Me.cbKelas.TabIndex = 30
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(132, 41)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggal.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(369, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Ruangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Periode"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 602)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(689, 22)
        Me.StatusStrip1.TabIndex = 35
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'Laporan_keluar_QueryTableAdapter
        '
        Me.Laporan_keluar_QueryTableAdapter.ClearBeforeFill = True
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
        'Laporan_keluar_QueryDataGridView
        '
        Me.Laporan_keluar_QueryDataGridView.AllowUserToAddRows = False
        Me.Laporan_keluar_QueryDataGridView.AllowUserToDeleteRows = False
        Me.Laporan_keluar_QueryDataGridView.AutoGenerateColumns = False
        Me.Laporan_keluar_QueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Laporan_keluar_QueryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.pasien_nama_lengkap, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.dokter_nama_lengkap, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Laporan_keluar_QueryDataGridView.DataSource = Me.Laporan_keluar_QueryBindingSource
        Me.Laporan_keluar_QueryDataGridView.Location = New System.Drawing.Point(12, 167)
        Me.Laporan_keluar_QueryDataGridView.Name = "Laporan_keluar_QueryDataGridView"
        Me.Laporan_keluar_QueryDataGridView.ReadOnly = True
        Me.Laporan_keluar_QueryDataGridView.Size = New System.Drawing.Size(666, 423)
        Me.Laporan_keluar_QueryDataGridView.TabIndex = 36
        '
        'Laporan_keluar_QueryBindingSource
        '
        Me.Laporan_keluar_QueryBindingSource.DataMember = "laporan keluar Query"
        Me.Laporan_keluar_QueryBindingSource.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbCaraKeluar
        '
        Me.cbCaraKeluar.FormattingEnabled = True
        Me.cbCaraKeluar.Items.AddRange(New Object() {"Semua", "Diizinkan pulang", "Dirujuk", "Pindah RS lain", "Pulang paksa", "Melarikan diri", "Dipindahkan", "Meninggal <48 jam", "Meninggal >48 jam"})
        Me.cbCaraKeluar.Location = New System.Drawing.Point(132, 67)
        Me.cbCaraKeluar.Name = "cbCaraKeluar"
        Me.cbCaraKeluar.Size = New System.Drawing.Size(200, 21)
        Me.cbCaraKeluar.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Cara Keluar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Ruangan && Kelas"
        '
        'cKelas
        '
        Me.cKelas.AutoSize = True
        Me.cKelas.Location = New System.Drawing.Point(574, 20)
        Me.cKelas.Name = "cKelas"
        Me.cKelas.Size = New System.Drawing.Size(52, 17)
        Me.cKelas.TabIndex = 40
        Me.cKelas.Text = "Kelas"
        Me.cKelas.UseVisualStyleBackColor = True
        '
        'cRuangan
        '
        Me.cRuangan.AutoSize = True
        Me.cRuangan.Location = New System.Drawing.Point(478, 20)
        Me.cRuangan.Name = "cRuangan"
        Me.cRuangan.Size = New System.Drawing.Size(70, 17)
        Me.cRuangan.TabIndex = 39
        Me.cRuangan.Text = "Ruangan"
        Me.cRuangan.UseVisualStyleBackColor = True
        '
        'btnPilih
        '
        Me.btnPilih.Location = New System.Drawing.Point(284, 92)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(48, 23)
        Me.btnPilih.TabIndex = 45
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(256, 92)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(22, 23)
        Me.btnClear.TabIndex = 44
        Me.btnClear.Text = "X"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'tbDokter
        '
        Me.tbDokter.Location = New System.Drawing.Point(132, 94)
        Me.tbDokter.Name = "tbDokter"
        Me.tbDokter.ReadOnly = True
        Me.tbDokter.Size = New System.Drawing.Size(118, 20)
        Me.tbDokter.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Nama Dokter"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_register_masuk"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID Register Masuk"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 89
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "no_medrec"
        Me.DataGridViewTextBoxColumn3.HeaderText = "No. Medrec"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 89
        '
        'pasien_nama_lengkap
        '
        Me.pasien_nama_lengkap.DataPropertyName = "pasien_nama_lengkap"
        Me.pasien_nama_lengkap.HeaderText = "Nama Pasien"
        Me.pasien_nama_lengkap.Name = "pasien_nama_lengkap"
        Me.pasien_nama_lengkap.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ruangan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ruangan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 89
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "kelas"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Kelas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 89
        '
        'dokter_nama_lengkap
        '
        Me.dokter_nama_lengkap.DataPropertyName = "dokter_nama_lengkap"
        Me.dokter_nama_lengkap.HeaderText = "Nama Dokter"
        Me.dokter_nama_lengkap.Name = "dokter_nama_lengkap"
        Me.dokter_nama_lengkap.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tanggal_keluar"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tanggal Keluar"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 89
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cara_pasien_keluar"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cara Pasien Keluar"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 89
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "deleted_at"
        Me.DataGridViewTextBoxColumn9.HeaderText = "deleted_at"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'LaporanKeluarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 624)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.tbDokter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cKelas)
        Me.Controls.Add(Me.cRuangan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbCaraKeluar)
        Me.Controls.Add(Me.Laporan_keluar_QueryDataGridView)
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
        Me.Name = "LaporanKeluarForm"
        Me.Text = "Laporan Pasien Keluar"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Laporan_keluar_QueryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Laporan_keluar_QueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DBDataSet As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSet
    Friend WithEvents Laporan_keluar_QueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Laporan_keluar_QueryTableAdapter As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.laporan_keluar_QueryTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Laporan_keluar_QueryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cbCaraKeluar As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cKelas As System.Windows.Forms.CheckBox
    Friend WithEvents cRuangan As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents tbDokter As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pasien_nama_lengkap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dokter_nama_lengkap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

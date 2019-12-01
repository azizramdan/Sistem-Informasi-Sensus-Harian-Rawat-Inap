<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterMasukForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.No_medrecTextBox = New System.Windows.Forms.TextBox()
        Me.Register_masuk_QueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSet()
        Me.Pasien_nama_lengkapTextBox = New System.Windows.Forms.TextBox()
        Me.RuanganTextBox = New System.Windows.Forms.TextBox()
        Me.Tanggal_masukTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KelasTextBox = New System.Windows.Forms.TextBox()
        Me.Cara_pasien_masukTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Register_masuk_QueryTableAdapter = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.register_masuk_QueryTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager()
        Me.Register_masuk_QueryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pasien_nama_lengkap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dokter_nama_lengkap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dokter_nama_lengkapTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Register_masuk_QueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Register_masuk_QueryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 187)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(346, 150)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 26
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(238, 150)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 19)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.No_medrecTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KelasTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Pasien_nama_lengkapTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RuanganTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Dokter_nama_lengkapTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Tanggal_masukTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Cara_pasien_masukTextBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(646, 120)
        Me.SplitContainer1.SplitterDistance = 321
        Me.SplitContainer1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No. Medrec"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama Ruangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Pasien"
        '
        'No_medrecTextBox
        '
        Me.No_medrecTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_masuk_QueryBindingSource, "no_medrec", True))
        Me.No_medrecTextBox.Location = New System.Drawing.Point(107, 10)
        Me.No_medrecTextBox.Name = "No_medrecTextBox"
        Me.No_medrecTextBox.ReadOnly = True
        Me.No_medrecTextBox.Size = New System.Drawing.Size(200, 20)
        Me.No_medrecTextBox.TabIndex = 23
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
        'Pasien_nama_lengkapTextBox
        '
        Me.Pasien_nama_lengkapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_masuk_QueryBindingSource, "pasien_nama_lengkap", True))
        Me.Pasien_nama_lengkapTextBox.Location = New System.Drawing.Point(107, 36)
        Me.Pasien_nama_lengkapTextBox.Name = "Pasien_nama_lengkapTextBox"
        Me.Pasien_nama_lengkapTextBox.ReadOnly = True
        Me.Pasien_nama_lengkapTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pasien_nama_lengkapTextBox.TabIndex = 25
        '
        'RuanganTextBox
        '
        Me.RuanganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_masuk_QueryBindingSource, "ruangan", True))
        Me.RuanganTextBox.Location = New System.Drawing.Point(107, 62)
        Me.RuanganTextBox.Name = "RuanganTextBox"
        Me.RuanganTextBox.ReadOnly = True
        Me.RuanganTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RuanganTextBox.TabIndex = 29
        '
        'Tanggal_masukTextBox
        '
        Me.Tanggal_masukTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_masuk_QueryBindingSource, "tanggal_masuk", True))
        Me.Tanggal_masukTextBox.Location = New System.Drawing.Point(108, 36)
        Me.Tanggal_masukTextBox.Name = "Tanggal_masukTextBox"
        Me.Tanggal_masukTextBox.ReadOnly = True
        Me.Tanggal_masukTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tanggal_masukTextBox.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cara Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tanggal Masuk"
        '
        'KelasTextBox
        '
        Me.KelasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_masuk_QueryBindingSource, "kelas", True))
        Me.KelasTextBox.Location = New System.Drawing.Point(107, 88)
        Me.KelasTextBox.Name = "KelasTextBox"
        Me.KelasTextBox.ReadOnly = True
        Me.KelasTextBox.Size = New System.Drawing.Size(200, 20)
        Me.KelasTextBox.TabIndex = 31
        '
        'Cara_pasien_masukTextBox
        '
        Me.Cara_pasien_masukTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_masuk_QueryBindingSource, "cara_pasien_masuk", True))
        Me.Cara_pasien_masukTextBox.Location = New System.Drawing.Point(108, 62)
        Me.Cara_pasien_masukTextBox.Name = "Cara_pasien_masukTextBox"
        Me.Cara_pasien_masukTextBox.ReadOnly = True
        Me.Cara_pasien_masukTextBox.Size = New System.Drawing.Size(201, 20)
        Me.Cara_pasien_masukTextBox.TabIndex = 33
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TambahToolStripMenuItem
        '
        Me.TambahToolStripMenuItem.Name = "TambahToolStripMenuItem"
        Me.TambahToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.TambahToolStripMenuItem.Text = "Tambah"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbCari)
        Me.GroupBox2.Controls.Add(Me.btnCari)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(664, 63)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari data"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(532, 26)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(29, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "X"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(236, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cari berdasarkan No. Medrec atau Nama Pasien"
        '
        'tbCari
        '
        Me.tbCari.Location = New System.Drawing.Point(248, 26)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(278, 20)
        Me.tbCari.TabIndex = 5
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(579, 26)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 3
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 618)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(690, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
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
        'Register_masuk_QueryDataGridView
        '
        Me.Register_masuk_QueryDataGridView.AllowUserToAddRows = False
        Me.Register_masuk_QueryDataGridView.AllowUserToDeleteRows = False
        Me.Register_masuk_QueryDataGridView.AutoGenerateColumns = False
        Me.Register_masuk_QueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Register_masuk_QueryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.pasien_nama_lengkap, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.dokter_nama_lengkap, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Register_masuk_QueryDataGridView.DataSource = Me.Register_masuk_QueryBindingSource
        Me.Register_masuk_QueryDataGridView.Location = New System.Drawing.Point(12, 289)
        Me.Register_masuk_QueryDataGridView.Name = "Register_masuk_QueryDataGridView"
        Me.Register_masuk_QueryDataGridView.ReadOnly = True
        Me.Register_masuk_QueryDataGridView.Size = New System.Drawing.Size(664, 321)
        Me.Register_masuk_QueryDataGridView.TabIndex = 20
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
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "deleted_at"
        Me.DataGridViewTextBoxColumn11.HeaderText = "deleted_at"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'Dokter_nama_lengkapTextBox
        '
        Me.Dokter_nama_lengkapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_masuk_QueryBindingSource, "dokter_nama_lengkap", True))
        Me.Dokter_nama_lengkapTextBox.Location = New System.Drawing.Point(108, 10)
        Me.Dokter_nama_lengkapTextBox.Name = "Dokter_nama_lengkapTextBox"
        Me.Dokter_nama_lengkapTextBox.ReadOnly = True
        Me.Dokter_nama_lengkapTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Dokter_nama_lengkapTextBox.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Nama Dokter"
        '
        'RegisterMasukForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 640)
        Me.Controls.Add(Me.Register_masuk_QueryDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RegisterMasukForm"
        Me.Text = "Master Data Pasien Masuk Rawat Inap"
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Register_masuk_QueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Register_masuk_QueryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TambahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents No_medrecTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Register_masuk_QueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DBDataSet As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSet
    Friend WithEvents Pasien_nama_lengkapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RuanganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal_masukTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KelasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cara_pasien_masukTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Register_masuk_QueryTableAdapter As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.register_masuk_QueryTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Register_masuk_QueryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pasien_nama_lengkap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dokter_nama_lengkap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dokter_nama_lengkapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class

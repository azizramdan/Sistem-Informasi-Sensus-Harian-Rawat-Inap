<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TempatTidurForm
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
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RuanganComboBox = New System.Windows.Forms.ComboBox()
        Me.Get_semua_tempat_tidurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSet()
        Me.KelasComboBox = New System.Windows.Forms.ComboBox()
        Me.JumlahTextBox = New System.Windows.Forms.TextBox()
        Me.KosongTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRuanganKelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Get_semua_tempat_tidurTableAdapter = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.get_semua_tempat_tidurTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager()
        Me.Get_semua_tempat_tidurDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Get_semua_tempat_tidurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Get_semua_tempat_tidurDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RuanganComboBox)
        Me.GroupBox1.Controls.Add(Me.KelasComboBox)
        Me.GroupBox1.Controls.Add(Me.JumlahTextBox)
        Me.GroupBox1.Controls.Add(Me.KosongTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 136)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(370, 31)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 33
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(369, 60)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 9
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jumlah tempat tidur kosong"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jumlah Tempat Tidur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kelas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama Ruangan"
        '
        'RuanganComboBox
        '
        Me.RuanganComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Get_semua_tempat_tidurBindingSource, "ruangan", True))
        Me.RuanganComboBox.Enabled = False
        Me.RuanganComboBox.FormattingEnabled = True
        Me.RuanganComboBox.Location = New System.Drawing.Point(159, 22)
        Me.RuanganComboBox.Name = "RuanganComboBox"
        Me.RuanganComboBox.Size = New System.Drawing.Size(185, 21)
        Me.RuanganComboBox.TabIndex = 24
        '
        'Get_semua_tempat_tidurBindingSource
        '
        Me.Get_semua_tempat_tidurBindingSource.DataMember = "get_semua_tempat_tidur"
        Me.Get_semua_tempat_tidurBindingSource.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KelasComboBox
        '
        Me.KelasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Get_semua_tempat_tidurBindingSource, "kelas", True))
        Me.KelasComboBox.Enabled = False
        Me.KelasComboBox.FormattingEnabled = True
        Me.KelasComboBox.Location = New System.Drawing.Point(159, 49)
        Me.KelasComboBox.Name = "KelasComboBox"
        Me.KelasComboBox.Size = New System.Drawing.Size(185, 21)
        Me.KelasComboBox.TabIndex = 28
        '
        'JumlahTextBox
        '
        Me.JumlahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Get_semua_tempat_tidurBindingSource, "jumlah", True))
        Me.JumlahTextBox.Location = New System.Drawing.Point(159, 75)
        Me.JumlahTextBox.Name = "JumlahTextBox"
        Me.JumlahTextBox.Size = New System.Drawing.Size(185, 20)
        Me.JumlahTextBox.TabIndex = 30
        '
        'KosongTextBox
        '
        Me.KosongTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Get_semua_tempat_tidurBindingSource, "kosong", True))
        Me.KosongTextBox.Location = New System.Drawing.Point(159, 101)
        Me.KosongTextBox.Name = "KosongTextBox"
        Me.KosongTextBox.ReadOnly = True
        Me.KosongTextBox.Size = New System.Drawing.Size(185, 20)
        Me.KosongTextBox.TabIndex = 32
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahToolStripMenuItem, Me.EditRuanganKelasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(493, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TambahToolStripMenuItem
        '
        Me.TambahToolStripMenuItem.Name = "TambahToolStripMenuItem"
        Me.TambahToolStripMenuItem.Size = New System.Drawing.Size(143, 20)
        Me.TambahToolStripMenuItem.Text = "Tambah Ruangan/Kelas"
        '
        'EditRuanganKelasToolStripMenuItem
        '
        Me.EditRuanganKelasToolStripMenuItem.Name = "EditRuanganKelasToolStripMenuItem"
        Me.EditRuanganKelasToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.EditRuanganKelasToolStripMenuItem.Text = "Edit Ruangan/Kelas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbCari)
        Me.GroupBox2.Controls.Add(Me.btnCari)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(469, 63)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari data"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(370, 23)
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
        Me.Label7.Size = New System.Drawing.Size(210, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cari berdasarkan nama ruangan atau kelas"
        '
        'tbCari
        '
        Me.tbCari.Location = New System.Drawing.Point(222, 26)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(142, 20)
        Me.tbCari.TabIndex = 5
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(405, 23)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(49, 23)
        Me.btnCari.TabIndex = 3
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Get_semua_tempat_tidurTableAdapter
        '
        Me.Get_semua_tempat_tidurTableAdapter.ClearBeforeFill = True
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
        'Get_semua_tempat_tidurDataGridView
        '
        Me.Get_semua_tempat_tidurDataGridView.AllowUserToAddRows = False
        Me.Get_semua_tempat_tidurDataGridView.AllowUserToDeleteRows = False
        Me.Get_semua_tempat_tidurDataGridView.AutoGenerateColumns = False
        Me.Get_semua_tempat_tidurDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Get_semua_tempat_tidurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Get_semua_tempat_tidurDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Get_semua_tempat_tidurDataGridView.DataSource = Me.Get_semua_tempat_tidurBindingSource
        Me.Get_semua_tempat_tidurDataGridView.Location = New System.Drawing.Point(12, 238)
        Me.Get_semua_tempat_tidurDataGridView.Name = "Get_semua_tempat_tidurDataGridView"
        Me.Get_semua_tempat_tidurDataGridView.ReadOnly = True
        Me.Get_semua_tempat_tidurDataGridView.Size = New System.Drawing.Size(469, 282)
        Me.Get_semua_tempat_tidurDataGridView.TabIndex = 18
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_ruangan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "id_ruangan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ruangan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ruangan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_kelas"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_kelas"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "kelas"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kelas"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "jumlah"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Jumlah Tempat Tidur"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "kosong"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tempat Tidur Kosong"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "deleted_at"
        Me.DataGridViewTextBoxColumn8.HeaderText = "deleted_at"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 523)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(493, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'TempatTidurForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 545)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Get_semua_tempat_tidurDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "TempatTidurForm"
        Me.Text = "Data Tempat Tidur"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Get_semua_tempat_tidurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Get_semua_tempat_tidurDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TambahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents DBDataSet As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSet
    Friend WithEvents Get_semua_tempat_tidurBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Get_semua_tempat_tidurTableAdapter As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.get_semua_tempat_tidurTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Get_semua_tempat_tidurDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RuanganComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KelasComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents JumlahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KosongTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents EditRuanganKelasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTambah As System.Windows.Forms.Button
End Class

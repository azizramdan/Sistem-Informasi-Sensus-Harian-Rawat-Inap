<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterKeluarForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.No_medrecTextBox = New System.Windows.Forms.TextBox()
        Me.Register_keluar_QueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSet()
        Me.Nama_lengkapTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tanggal_keluarTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cara_pasien_keluarTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Register_keluar_QueryTableAdapter = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.register_keluar_QueryTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager()
        Me.Register_keluar_QueryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Register_keluar_QueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Register_keluar_QueryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(688, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TambahToolStripMenuItem
        '
        Me.TambahToolStripMenuItem.Name = "TambahToolStripMenuItem"
        Me.TambahToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.TambahToolStripMenuItem.Text = "Tambah"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 121)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(346, 88)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 26
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(238, 88)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.No_medrecTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Nama_lengkapTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Tanggal_keluarTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Cara_pasien_keluarTextBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(646, 63)
        Me.SplitContainer1.SplitterDistance = 311
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
        Me.No_medrecTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_keluar_QueryBindingSource, "no_medrec", True))
        Me.No_medrecTextBox.Location = New System.Drawing.Point(85, 10)
        Me.No_medrecTextBox.Name = "No_medrecTextBox"
        Me.No_medrecTextBox.ReadOnly = True
        Me.No_medrecTextBox.Size = New System.Drawing.Size(203, 20)
        Me.No_medrecTextBox.TabIndex = 27
        '
        'Register_keluar_QueryBindingSource
        '
        Me.Register_keluar_QueryBindingSource.DataMember = "register_keluar Query"
        Me.Register_keluar_QueryBindingSource.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nama_lengkapTextBox
        '
        Me.Nama_lengkapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_keluar_QueryBindingSource, "nama_lengkap", True))
        Me.Nama_lengkapTextBox.Location = New System.Drawing.Point(85, 36)
        Me.Nama_lengkapTextBox.Name = "Nama_lengkapTextBox"
        Me.Nama_lengkapTextBox.ReadOnly = True
        Me.Nama_lengkapTextBox.Size = New System.Drawing.Size(203, 20)
        Me.Nama_lengkapTextBox.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cara Pasien Keluar"
        '
        'Tanggal_keluarTextBox
        '
        Me.Tanggal_keluarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_keluar_QueryBindingSource, "tanggal_keluar", True))
        Me.Tanggal_keluarTextBox.Location = New System.Drawing.Point(118, 10)
        Me.Tanggal_keluarTextBox.Name = "Tanggal_keluarTextBox"
        Me.Tanggal_keluarTextBox.ReadOnly = True
        Me.Tanggal_keluarTextBox.Size = New System.Drawing.Size(191, 20)
        Me.Tanggal_keluarTextBox.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tanggal Keluar"
        '
        'Cara_pasien_keluarTextBox
        '
        Me.Cara_pasien_keluarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_keluar_QueryBindingSource, "cara_pasien_keluar", True))
        Me.Cara_pasien_keluarTextBox.Location = New System.Drawing.Point(118, 36)
        Me.Cara_pasien_keluarTextBox.Name = "Cara_pasien_keluarTextBox"
        Me.Cara_pasien_keluarTextBox.ReadOnly = True
        Me.Cara_pasien_keluarTextBox.Size = New System.Drawing.Size(191, 20)
        Me.Cara_pasien_keluarTextBox.TabIndex = 33
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbCari)
        Me.GroupBox2.Controls.Add(Me.btnCari)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(664, 63)
        Me.GroupBox2.TabIndex = 19
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 549)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(688, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Register_keluar_QueryTableAdapter
        '
        Me.Register_keluar_QueryTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.UpdateOrder = Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'Register_keluar_QueryDataGridView
        '
        Me.Register_keluar_QueryDataGridView.AllowUserToAddRows = False
        Me.Register_keluar_QueryDataGridView.AllowUserToDeleteRows = False
        Me.Register_keluar_QueryDataGridView.AutoGenerateColumns = False
        Me.Register_keluar_QueryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Register_keluar_QueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Register_keluar_QueryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Register_keluar_QueryDataGridView.DataSource = Me.Register_keluar_QueryBindingSource
        Me.Register_keluar_QueryDataGridView.Location = New System.Drawing.Point(12, 223)
        Me.Register_keluar_QueryDataGridView.Name = "Register_keluar_QueryDataGridView"
        Me.Register_keluar_QueryDataGridView.ReadOnly = True
        Me.Register_keluar_QueryDataGridView.Size = New System.Drawing.Size(664, 323)
        Me.Register_keluar_QueryDataGridView.TabIndex = 22
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
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "no_medrec"
        Me.DataGridViewTextBoxColumn3.HeaderText = "No Medrec"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nama_lengkap"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nama Lengkap"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tanggal_keluar"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tanggal Keluar"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cara_pasien_keluar"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cara Pasien Keluar"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "deleted_at"
        Me.DataGridViewTextBoxColumn9.HeaderText = "deleted_at"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'RegisterKeluarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 571)
        Me.Controls.Add(Me.Register_keluar_QueryDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RegisterKeluarForm"
        Me.Text = "Master Data Pasien Keluar Rawat Inap"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Register_keluar_QueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Register_keluar_QueryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TambahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DBDataSet As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSet
    Friend WithEvents Register_keluar_QueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Register_keluar_QueryTableAdapter As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.register_keluar_QueryTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents No_medrecTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_lengkapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal_keluarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cara_pasien_keluarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Register_keluar_QueryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

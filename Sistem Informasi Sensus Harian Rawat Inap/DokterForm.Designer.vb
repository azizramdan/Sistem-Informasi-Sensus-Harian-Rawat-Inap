<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DokterForm
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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DokterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSet()
        Me.SipTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_lengkapTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.No_telponTextBox = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DokterTableAdapter = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.dokterTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager()
        Me.DokterDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DokterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DokterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.SipTextBox)
        Me.GroupBox1.Controls.Add(Me.Nama_lengkapTextBox)
        Me.GroupBox1.Controls.Add(Me.AlamatTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.No_telponTextBox)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 164)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.DokterBindingSource, "status_kepegawaian", True))
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokterBindingSource, "status_kepegawaian", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Aktif", "Tidak aktif", "Cuti"})
        Me.ComboBox2.Location = New System.Drawing.Point(460, 74)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(242, 21)
        Me.ComboBox2.TabIndex = 26
        '
        'DokterBindingSource
        '
        Me.DokterBindingSource.DataMember = "dokter"
        Me.DokterBindingSource.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SipTextBox
        '
        Me.SipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokterBindingSource, "sip", True))
        Me.SipTextBox.Enabled = False
        Me.SipTextBox.Location = New System.Drawing.Point(95, 19)
        Me.SipTextBox.Name = "SipTextBox"
        Me.SipTextBox.Size = New System.Drawing.Size(242, 20)
        Me.SipTextBox.TabIndex = 19
        '
        'Nama_lengkapTextBox
        '
        Me.Nama_lengkapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokterBindingSource, "nama_lengkap", True))
        Me.Nama_lengkapTextBox.Location = New System.Drawing.Point(95, 45)
        Me.Nama_lengkapTextBox.Name = "Nama_lengkapTextBox"
        Me.Nama_lengkapTextBox.Size = New System.Drawing.Size(242, 20)
        Me.Nama_lengkapTextBox.TabIndex = 21
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokterBindingSource, "alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(95, 74)
        Me.AlamatTextBox.Multiline = True
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(242, 38)
        Me.AlamatTextBox.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(371, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Status"
        '
        'No_telponTextBox
        '
        Me.No_telponTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokterBindingSource, "no_telpon", True))
        Me.No_telponTextBox.Location = New System.Drawing.Point(460, 19)
        Me.No_telponTextBox.Name = "No_telponTextBox"
        Me.No_telponTextBox.Size = New System.Drawing.Size(242, 20)
        Me.No_telponTextBox.TabIndex = 25
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(374, 127)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 14
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(262, 127)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.DokterBindingSource, "spesialis", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokterBindingSource, "spesialis", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Gigi", "THT", "Mata", "Kulit"})
        Me.ComboBox1.Location = New System.Drawing.Point(460, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(242, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(371, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Spesialis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "No. Telpon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama Dokter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "No. SIP"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(749, 24)
        Me.MenuStrip1.TabIndex = 6
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(720, 63)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari data"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(481, 26)
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
        Me.Label7.Size = New System.Drawing.Size(162, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cari berdasarkan SIP atau Nama"
        '
        'tbCari
        '
        Me.tbCari.Location = New System.Drawing.Point(188, 26)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(287, 20)
        Me.tbCari.TabIndex = 5
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(528, 26)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 3
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 670)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(749, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'DokterTableAdapter
        '
        Me.DokterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dokterTableAdapter = Me.DokterTableAdapter
        Me.TableAdapterManager.kelasTableAdapter = Nothing
        Me.TableAdapterManager.pasienTableAdapter = Nothing
        Me.TableAdapterManager.register_masuk1TableAdapter = Nothing
        Me.TableAdapterManager.ruanganTableAdapter = Nothing
        Me.TableAdapterManager.sensusTableAdapter = Nothing
        Me.TableAdapterManager.tempat_tidurTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'DokterDataGridView
        '
        Me.DokterDataGridView.AllowUserToAddRows = False
        Me.DokterDataGridView.AllowUserToDeleteRows = False
        Me.DokterDataGridView.AutoGenerateColumns = False
        Me.DokterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DokterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DokterDataGridView.DataSource = Me.DokterBindingSource
        Me.DokterDataGridView.Location = New System.Drawing.Point(12, 266)
        Me.DokterDataGridView.Name = "DokterDataGridView"
        Me.DokterDataGridView.ReadOnly = True
        Me.DokterDataGridView.Size = New System.Drawing.Size(720, 384)
        Me.DokterDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "sip"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SIP"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_lengkap"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Lengkap"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "alamat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Alamat"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "no_telpon"
        Me.DataGridViewTextBoxColumn4.HeaderText = "No. Telp"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "spesialis"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Spesialis"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "status_kepegawaian"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DokterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 692)
        Me.Controls.Add(Me.DokterDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DokterForm"
        Me.Text = "Master Data Dokter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DokterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DokterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TambahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents tbCari As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DBDataSet As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSet
    Friend WithEvents DokterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DokterTableAdapter As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.dokterTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Sensus_Harian_Rawat_Inap.DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DokterDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents SipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_lengkapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_telponTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

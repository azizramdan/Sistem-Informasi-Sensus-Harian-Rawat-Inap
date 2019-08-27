<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DokterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProsesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterPasienMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterPasienKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SensusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasienMasukRawatInapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasienKeluarRawatInapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMasterToolStripMenuItem, Me.ProsesToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(520, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.PasienToolStripMenuItem, Me.DokterToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'PasienToolStripMenuItem
        '
        Me.PasienToolStripMenuItem.Name = "PasienToolStripMenuItem"
        Me.PasienToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.PasienToolStripMenuItem.Text = "Pasien"
        '
        'DokterToolStripMenuItem
        '
        Me.DokterToolStripMenuItem.Name = "DokterToolStripMenuItem"
        Me.DokterToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.DokterToolStripMenuItem.Text = "Dokter"
        '
        'ProsesToolStripMenuItem
        '
        Me.ProsesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterPasienMasukToolStripMenuItem, Me.RegisterPasienKeluarToolStripMenuItem})
        Me.ProsesToolStripMenuItem.Name = "ProsesToolStripMenuItem"
        Me.ProsesToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProsesToolStripMenuItem.Text = "Proses"
        '
        'RegisterPasienMasukToolStripMenuItem
        '
        Me.RegisterPasienMasukToolStripMenuItem.Name = "RegisterPasienMasukToolStripMenuItem"
        Me.RegisterPasienMasukToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.RegisterPasienMasukToolStripMenuItem.Text = "Register Pasien Masuk"
        '
        'RegisterPasienKeluarToolStripMenuItem
        '
        Me.RegisterPasienKeluarToolStripMenuItem.Name = "RegisterPasienKeluarToolStripMenuItem"
        Me.RegisterPasienKeluarToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.RegisterPasienKeluarToolStripMenuItem.Text = "Register Pasien Keluar"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SensusToolStripMenuItem, Me.PasienMasukRawatInapToolStripMenuItem, Me.PasienKeluarRawatInapToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'SensusToolStripMenuItem
        '
        Me.SensusToolStripMenuItem.Name = "SensusToolStripMenuItem"
        Me.SensusToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SensusToolStripMenuItem.Text = "Sensus"
        '
        'PasienMasukRawatInapToolStripMenuItem
        '
        Me.PasienMasukRawatInapToolStripMenuItem.Name = "PasienMasukRawatInapToolStripMenuItem"
        Me.PasienMasukRawatInapToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.PasienMasukRawatInapToolStripMenuItem.Text = "Register Pasien Masuk"
        '
        'PasienKeluarRawatInapToolStripMenuItem
        '
        Me.PasienKeluarRawatInapToolStripMenuItem.Name = "PasienKeluarRawatInapToolStripMenuItem"
        Me.PasienKeluarRawatInapToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.PasienKeluarRawatInapToolStripMenuItem.Text = "Register Pasien Keluar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(520, 283)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 322)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuForm"
        Me.Text = "SISTEM INFORMASI SENSUS RAWAT INAP"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DokterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterPasienMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterPasienKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SensusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PasienMasukRawatInapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasienKeluarRawatInapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

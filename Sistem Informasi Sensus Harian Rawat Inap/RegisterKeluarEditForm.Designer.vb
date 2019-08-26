<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterKeluarEditForm
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
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.cbCaraKeluar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMedrec = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(130, 12)
        Me.tbId.Name = "tbId"
        Me.tbId.ReadOnly = True
        Me.tbId.Size = New System.Drawing.Size(181, 20)
        Me.tbId.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "ID Register Masuk"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(116, 153)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 55
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Cara Pasien Keluar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Tanggal Keluar"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(130, 90)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(181, 20)
        Me.dtpTanggal.TabIndex = 51
        '
        'cbCaraKeluar
        '
        Me.cbCaraKeluar.FormattingEnabled = True
        Me.cbCaraKeluar.Items.AddRange(New Object() {"Diizinkan pulang", "Dirujuk", "Pindah RS lain", "Pulang paksa", "Melarikan diri", "Dipindahkan", "Meninggal <48 jam", "Meninggal >48 jam"})
        Me.cbCaraKeluar.Location = New System.Drawing.Point(130, 116)
        Me.cbCaraKeluar.Name = "cbCaraKeluar"
        Me.cbCaraKeluar.Size = New System.Drawing.Size(181, 21)
        Me.cbCaraKeluar.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "No. Medrec"
        '
        'tbMedrec
        '
        Me.tbMedrec.Location = New System.Drawing.Point(130, 38)
        Me.tbMedrec.Name = "tbMedrec"
        Me.tbMedrec.ReadOnly = True
        Me.tbMedrec.Size = New System.Drawing.Size(181, 20)
        Me.tbMedrec.TabIndex = 47
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(130, 64)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.ReadOnly = True
        Me.tbNama.Size = New System.Drawing.Size(181, 20)
        Me.tbNama.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Nama Pasien"
        '
        'RegisterKeluarEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 196)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.cbCaraKeluar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMedrec)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label2)
        Me.Name = "RegisterKeluarEditForm"
        Me.Text = "Edit Data Pasien Keluar Rawat Inap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbId As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbCaraKeluar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbMedrec As System.Windows.Forms.TextBox
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

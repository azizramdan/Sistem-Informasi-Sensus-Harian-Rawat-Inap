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
        Me.btnTempatTidur = New System.Windows.Forms.Button()
        Me.btnPasien = New System.Windows.Forms.Button()
        Me.btnDokter = New System.Windows.Forms.Button()
        Me.btnPasienMasuk = New System.Windows.Forms.Button()
        Me.btnPasienKeluar = New System.Windows.Forms.Button()
        Me.btnSensus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTempatTidur
        '
        Me.btnTempatTidur.Location = New System.Drawing.Point(39, 40)
        Me.btnTempatTidur.Name = "btnTempatTidur"
        Me.btnTempatTidur.Size = New System.Drawing.Size(127, 23)
        Me.btnTempatTidur.TabIndex = 0
        Me.btnTempatTidur.Text = "Data Tempat Tidur"
        Me.btnTempatTidur.UseVisualStyleBackColor = True
        '
        'btnPasien
        '
        Me.btnPasien.Location = New System.Drawing.Point(39, 88)
        Me.btnPasien.Name = "btnPasien"
        Me.btnPasien.Size = New System.Drawing.Size(75, 23)
        Me.btnPasien.TabIndex = 1
        Me.btnPasien.Text = "Data Pasien"
        Me.btnPasien.UseVisualStyleBackColor = True
        '
        'btnDokter
        '
        Me.btnDokter.Location = New System.Drawing.Point(39, 136)
        Me.btnDokter.Name = "btnDokter"
        Me.btnDokter.Size = New System.Drawing.Size(75, 23)
        Me.btnDokter.TabIndex = 2
        Me.btnDokter.Text = "Data Dokter"
        Me.btnDokter.UseVisualStyleBackColor = True
        '
        'btnPasienMasuk
        '
        Me.btnPasienMasuk.Location = New System.Drawing.Point(226, 40)
        Me.btnPasienMasuk.Name = "btnPasienMasuk"
        Me.btnPasienMasuk.Size = New System.Drawing.Size(118, 23)
        Me.btnPasienMasuk.TabIndex = 3
        Me.btnPasienMasuk.Text = "Data Pasien Masuk"
        Me.btnPasienMasuk.UseVisualStyleBackColor = True
        '
        'btnPasienKeluar
        '
        Me.btnPasienKeluar.Location = New System.Drawing.Point(226, 88)
        Me.btnPasienKeluar.Name = "btnPasienKeluar"
        Me.btnPasienKeluar.Size = New System.Drawing.Size(116, 23)
        Me.btnPasienKeluar.TabIndex = 4
        Me.btnPasienKeluar.Text = "Data Pasien Keluar"
        Me.btnPasienKeluar.UseVisualStyleBackColor = True
        '
        'btnSensus
        '
        Me.btnSensus.Location = New System.Drawing.Point(226, 136)
        Me.btnSensus.Name = "btnSensus"
        Me.btnSensus.Size = New System.Drawing.Size(98, 23)
        Me.btnSensus.TabIndex = 5
        Me.btnSensus.Text = "Data Sensus"
        Me.btnSensus.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 322)
        Me.Controls.Add(Me.btnSensus)
        Me.Controls.Add(Me.btnPasienKeluar)
        Me.Controls.Add(Me.btnPasienMasuk)
        Me.Controls.Add(Me.btnDokter)
        Me.Controls.Add(Me.btnPasien)
        Me.Controls.Add(Me.btnTempatTidur)
        Me.Name = "MenuForm"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTempatTidur As System.Windows.Forms.Button
    Friend WithEvents btnPasien As System.Windows.Forms.Button
    Friend WithEvents btnDokter As System.Windows.Forms.Button
    Friend WithEvents btnPasienMasuk As System.Windows.Forms.Button
    Friend WithEvents btnPasienKeluar As System.Windows.Forms.Button
    Friend WithEvents btnSensus As System.Windows.Forms.Button
End Class

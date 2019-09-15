Public Class LaporanKeluarForm
    Dim periode As String

    Private Sub LaporanKeluarForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        getRuanganKelas(cbRuangan, cbKelas)
        cbCaraKeluar.SelectedIndex = 0
        cbRuangan.SelectedIndex = 0
        cbKelas.SelectedIndex = 0
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            MenuForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub rbHarian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHarian.CheckedChanged
        dtpTanggal.ShowUpDown = False
        dtpTanggal.Format = DateTimePickerFormat.Custom
        dtpTanggal.CustomFormat = "dddd, d MMMM yyyy"
    End Sub

    Private Sub rbBulanan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBulanan.CheckedChanged
        dtpTanggal.ShowUpDown = True
        dtpTanggal.Format = DateTimePickerFormat.Custom
        dtpTanggal.CustomFormat = "MMMM yyyy"
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim filter As String

        If rbHarian.Checked Then
            periode = "Periode: " & dtpTanggal.Value.ToString("d MMMM yyyy")
            Dim tglMasuk As String
            tglMasuk = dtpTanggal.Value.ToString("M/d/yyyy")
            filter = "tanggal_keluar = #" & tglMasuk & "#"
        Else
            periode = "Periode: " & dtpTanggal.Value.ToString("MMMM yyyy")
            Dim awalBulan As Date = dtpTanggal.Value.Month & "/1/" & dtpTanggal.Value.Year
            Dim akhirBulan As Date = awalBulan.AddMonths(1)

            filter = "tanggal_keluar >= #" & awalBulan.ToString("M/d/yyyy") & "#"
            filter &= " AND tanggal_keluar < #" & akhirBulan.ToString("M/d/yyyy") & "#"
        End If

        If Not cbCaraKeluar.SelectedIndex = 0 Then
            filter &= " AND cara_pasien_keluar = '" & cbCaraKeluar.SelectedItem & "'"
        End If

        If cRuangan.Checked Then
            filter &= " AND ruangan = '" & cbRuangan.SelectedItem & "'"
        End If

        If cKelas.Checked Then
            filter &= " AND kelas = '" & cbKelas.SelectedItem & "'"
        End If

        filter &= " AND deleted_at IS NULL"
        Laporan_keluar_QueryBindingSource.Filter = filter
        Laporan_keluar_QueryBindingSource.Sort = "id"
        Me.Laporan_keluar_QueryTableAdapter.Fill(Me.DBDataSet.laporan_keluar_Query)
        Jumlah()
        For r As Integer = 1 To Laporan_keluar_QueryDataGridView.RowCount
            Laporan_keluar_QueryDataGridView.Rows(r - 1).HeaderCell.Value = r.ToString
        Next
    End Sub
    Private Sub Jumlah()
        ToolStripStatusLabel1.Text = "Jumlah data: " & Laporan_keluar_QueryDataGridView.RowCount
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Laporan_keluar_QueryDataGridView.RowCount = 0 Then
            MsgBox("Tidak ada data!")
        Else
            Dim report As New LaporanKeluarReport
            report.SetDataSource(Laporan_keluar_QueryBindingSource.List)
            report.SetParameterValue("jumlah", ToolStripStatusLabel1.Text)
            LaporanKeluarPrint.CrystalReportViewer1.ReportSource = report
            LaporanKeluarPrint.ShowDialog()
        End If
    End Sub

    Private Sub cRuangan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cRuangan.CheckedChanged
        If cRuangan.Checked Then
            cbRuangan.Enabled = True
        Else
            cbRuangan.Enabled = False
        End If
    End Sub

    Private Sub cKelas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cKelas.CheckedChanged
        If cKelas.Checked Then
            cbKelas.Enabled = True
        Else
            cbKelas.Enabled = False
        End If
    End Sub
End Class
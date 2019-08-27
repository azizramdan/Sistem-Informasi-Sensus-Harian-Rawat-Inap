Public Class LaporanMasukForm

    Private Sub LaporanMasukForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
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
        If cbRuangan.SelectedIndex = -1 Or cbKelas.SelectedIndex = -1 Then
            MsgBox("Data harus diisi semua")
        Else
            Dim filter As String
            If rbHarian.Checked Then
                Dim tglMasuk As String
                tglMasuk = dtpTanggal.Value.ToString("M/d/yyyy")
                filter = "tanggal_masuk = #" & tglMasuk & "#"
            Else
                Dim awalBulan As Date = dtpTanggal.Value.Month & "/1/" & dtpTanggal.Value.Year
                Dim akhirBulan As Date = awalBulan.AddMonths(1)

                filter = "tanggal_masuk >= #" & awalBulan.ToString("M/d/yyyy") & "#"
                filter &= " AND tanggal_masuk <= #" & akhirBulan.ToString("M/d/yyyy") & "#"
            End If

            filter &= " AND ruangan = '" & cbRuangan.SelectedItem & "'"
            filter &= " AND kelas = '" & cbKelas.SelectedItem & "'"
            filter &= " AND deleted_at IS NULL"
            Register_masuk_QueryBindingSource.Filter = filter
            Register_masuk_QueryBindingSource.Sort = "id"
            Me.Register_masuk_QueryTableAdapter.Fill(Me.DBDataSet.register_masuk_Query)
            Jumlah()
        End If
    End Sub
    Private Sub Jumlah()
        ToolStripStatusLabel1.Text = "Jumlah data " & Register_masuk_QueryDataGridView.RowCount
    End Sub
End Class
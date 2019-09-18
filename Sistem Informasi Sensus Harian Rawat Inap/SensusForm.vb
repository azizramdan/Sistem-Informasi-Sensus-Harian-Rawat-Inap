Imports System.Data.OleDb
Public Class SensusForm
    Dim btnCari_isClicked As Boolean
    Dim ruangan, kelas, ruanganParam, kelasParam As String
    Dim dt As New DataTable

    Private Sub SensusForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        rbHarian.Checked = True
        getRuanganKelas(cbRuangan, cbKelas)
        cbRuangan.SelectedIndex = 0
        cbKelas.SelectedIndex = 0

        With dt
            .Columns.Add("tanggal", GetType(Integer))
            .Columns.Add("pasien_awal", GetType(Integer))
            .Columns.Add("pasien_masuk", GetType(Integer))
            .Columns.Add("pasien_pindahan", GetType(Integer))
            .Columns.Add("jumlah_dirawat", GetType(Integer))
            .Columns.Add("diizinkan_pulang", GetType(Integer))
            .Columns.Add("dirujuk", GetType(Integer))
            .Columns.Add("pindah_rs", GetType(Integer))
            .Columns.Add("pulang_paksa", GetType(Integer))
            .Columns.Add("melarikan_diri", GetType(Integer))
            .Columns.Add("dipindahkan", GetType(Integer))
            .Columns.Add("jumlah_keluar_hidup", GetType(Integer))
            .Columns.Add("kurang", GetType(Integer))
            .Columns.Add("lebih", GetType(Integer))
            .Columns.Add("jumlah_keluar_mati", GetType(Integer))
            .Columns.Add("lama_dirawat", GetType(Integer))
            .Columns.Add("keluar_masuk", GetType(Integer))
        End With
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
        btnCari_isClicked = True
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        Dim query As String
        Dim cmd As New OleDbCommand
        Dim result As OleDbDataReader

        dt.Clear()

        If cbRuangan.Enabled Then
            ruangan = cbRuangan.SelectedItem
            ruanganParam = ruangan
        Else
            ruangan = "%"
            ruanganParam = "Semua"
        End If
        If cbKelas.Enabled Then
            kelas = cbKelas.SelectedItem
            kelasParam = kelas
        Else
            kelas = "%"
            kelasParam = "Semua"
        End If

        If conn.State = ConnectionState.Closed Then
            conn.Open()
            query = "SELECT SUM(awal) AS [Pasien awal], SUM(masuk) AS [Pasien masuk], SUM(pindahan) AS [Pasien pindahan], SUM(diizinkan) AS [Diizinkan pulang], SUM(rujuk) AS [Dirujuk], SUM(pindah) AS [Pindah RS lain], SUM(paksa) AS [Pulang paksa], SUM(melarikan) AS [Melarikan diri], SUM(dipindah) AS [Dipindahkan], SUM(kurang) AS [Meninggal <48 jam], SUM(lebih) AS [Meninggal >48 jam], SUM(lama) AS [Lama dirawat], SUM(keluarmasuk) AS [Keluar Masuk] FROM ( SELECT COUNT(register_masuk.id) AS awal, 0 AS masuk, 0 AS pindahan, 0 AS diizinkan, 0 AS rujuk, 0 AS pindah, 0 AS paksa, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih, 0 AS lama, 0 AS keluarmasuk FROM (ruangan INNER JOIN (kelas INNER JOIN tempat_tidur ON kelas.[id] = tempat_tidur.[id_kelas]) ON ruangan.[id] = tempat_tidur.[id_ruangan]) INNER JOIN register_masuk ON tempat_tidur.[id] = register_masuk.[id_tempat_tidur] WHERE tanggal_masuk < @tgl AND register_masuk.deleted_at IS NULL AND keluar = FALSE AND ruangan LIKE @ruangan AND kelas LIKE @kelas UNION ALL SELECT 0 AS awal, SUM(IIF([cara_pasien_masuk] <> 'Pindahan', 1, 0)) AS masuk, SUM(IIF([cara_pasien_masuk] = 'Pindahan', 1, 0)) AS pindahan, 0 AS diizinkan, 0 AS rujuk, 0 AS pindah, 0 AS paksa, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih, 0 AS lama, 0 AS keluarmasuk FROM (ruangan INNER JOIN (kelas INNER JOIN tempat_tidur ON kelas.[id] = tempat_tidur.[id_kelas]) ON ruangan.[id] = tempat_tidur.[id_ruangan]) INNER JOIN register_masuk ON tempat_tidur.[id] = register_masuk.[id_tempat_tidur] WHERE tanggal_masuk = @tgl AND register_masuk.deleted_at IS NULL AND ruangan LIKE @ruangan AND kelas LIKE @kelas UNION ALL SELECT 0 AS awal, 0 AS masuk, 0 AS pindahan, SUM(IIF([cara_pasien_keluar] = 'Diizinkan pulang', 1, 0)) AS diizinkan, SUM(IIF([cara_pasien_keluar] = 'Dirujuk', 1, 0)) AS rujuk, SUM(IIF([cara_pasien_keluar] = 'Pindah RS lain', 1, 0)) AS pindah, SUM(IIF([cara_pasien_keluar] = 'Pulang paksa', 1, 0)) AS paksa, SUM(IIF([cara_pasien_keluar] = 'Melarikan diri', 1, 0)) AS melarikan, SUM(IIF([cara_pasien_keluar] = 'Dipindahkan', 1, 0)) AS dipindah, SUM(IIF([cara_pasien_keluar] = 'Meninggal <48 jam', 1, 0)) AS kurang, SUM(IIF([cara_pasien_keluar] = 'Meninggal >48 jam', 1, 0)) AS lebih, 0 AS lama, 0 AS keluarmasuk FROM ((ruangan INNER JOIN (kelas INNER JOIN tempat_tidur ON kelas.[id] = tempat_tidur.[id_kelas]) ON ruangan.[id] = tempat_tidur.[id_ruangan]) INNER JOIN register_masuk ON tempat_tidur.[id] = register_masuk.[id_tempat_tidur]) INNER JOIN register_keluar ON register_masuk.[id] = register_keluar.[id_register_masuk] WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND ruangan LIKE @ruangan AND kelas LIKE @kelas UNION ALL SELECT 0 AS awal, 0 AS masuk, 0 AS pindahan, 0 AS diizinkan, 0 AS rujuk, 0 AS pindah, 0 AS paksa, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih, SUM(DATEDIFF('y', [tanggal_masuk], @tgl)) AS lama, 0 AS keluarmasuk FROM (ruangan INNER JOIN (kelas INNER JOIN tempat_tidur ON kelas.[id] = tempat_tidur.[id_kelas]) ON ruangan.[id] = tempat_tidur.[id_ruangan]) INNER JOIN register_masuk ON tempat_tidur.[id] = register_masuk.[id_tempat_tidur] WHERE register_masuk.deleted_at IS NULL AND keluar = FALSE AND tanggal_masuk < @tgl AND ruangan LIKE @ruangan AND kelas LIKE @kelas UNION ALL SELECT 0 AS awal, 0 AS masuk, 0 AS pindahan, 0 AS diizinkan, 0 AS rujuk, 0 AS pindah, 0 AS paksa, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih, COUNT(register_masuk.id) AS lama, 0 AS keluarmasuk FROM (ruangan INNER JOIN (kelas INNER JOIN tempat_tidur ON kelas.[id] = tempat_tidur.[id_kelas]) ON ruangan.[id] = tempat_tidur.[id_ruangan]) INNER JOIN register_masuk ON tempat_tidur.[id] = register_masuk.[id_tempat_tidur] WHERE register_masuk.deleted_at IS NULL AND tanggal_masuk = @tgl AND ruangan LIKE @ruangan AND kelas LIKE @kelas UNION ALL SELECT 0 AS awal, 0 AS masuk, 0 AS pindahan, 0 AS diizinkan, 0 AS rujuk, 0 AS pindah, 0 AS paksa, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih, SUM(DATEDIFF('y', [tanggal_masuk], @tgl)) AS lama, 0 AS keluarmasuk FROM ((ruangan INNER JOIN (kelas INNER JOIN tempat_tidur ON kelas.[id] = tempat_tidur.[id_kelas]) ON ruangan.[id] = tempat_tidur.[id_ruangan]) INNER JOIN register_masuk ON tempat_tidur.[id] = register_masuk.[id_tempat_tidur]) INNER JOIN register_keluar ON register_masuk.[id] = register_keluar.[id_register_masuk] WHERE register_masuk.deleted_at IS NULL AND keluar = TRUE AND tanggal_keluar >= @tgl AND tanggal_masuk < @tgl AND ruangan LIKE @ruangan AND kelas LIKE @kelas UNION ALL SELECT 0 AS awal, 0 AS masuk, 0 AS pindahan, 0 AS diizinkan, 0 AS rujuk, 0 AS pindah, 0 AS paksa, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih, 0 AS lama, COUNT(register_masuk.id) AS keluarmasuk FROM (ruangan INNER JOIN (kelas INNER JOIN tempat_tidur ON kelas.[id] = tempat_tidur.[id_kelas]) ON ruangan.[id] = tempat_tidur.[id_ruangan]) INNER JOIN register_masuk ON tempat_tidur.[id] = register_masuk.[id_tempat_tidur] WHERE tanggal_masuk = @tgl AND register_masuk.deleted_at IS NULL AND ruangan LIKE @ruangan AND kelas LIKE @kelas UNION ALL SELECT 0 AS awal, 0 AS masuk, 0 AS pindahan, 0 AS diizinkan, 0 AS rujuk, 0 AS pindah, 0 AS paksa, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih, 0 AS lama, COUNT(register_keluar.id) AS keluarmasuk FROM ((ruangan INNER JOIN (kelas INNER JOIN tempat_tidur ON kelas.[id] = tempat_tidur.[id_kelas]) ON ruangan.[id] = tempat_tidur.[id_ruangan]) INNER JOIN register_masuk ON tempat_tidur.[id] = register_masuk.[id_tempat_tidur]) INNER JOIN register_keluar ON register_masuk.[id] = register_keluar.[id_register_masuk] WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND ruangan LIKE @ruangan AND kelas LIKE @kelas )  AS [%$##@_Alias];"

            If rbHarian.Checked Then
                cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@tgl", dtpTanggal.Value.ToString("M/d/yyyy"))
                cmd.Parameters.AddWithValue("@ruangan", ruangan)
                cmd.Parameters.AddWithValue("@kelas", kelas)
                result = cmd.ExecuteReader
                If result.Read Then

                    dt.Rows.Add(dtpTanggal.Value.Day,
                                result.GetValue(0),
                                result.GetValue(1),
                                result.GetValue(2),
                                result.GetValue(0) + result.GetValue(1) + result.GetValue(2),
                                result.GetValue(3),
                                result.GetValue(4),
                                result.GetValue(5),
                                result.GetValue(6),
                                result.GetValue(7),
                                result.GetValue(8),
                                result.GetValue(3) + result.GetValue(4) + result.GetValue(5) + result.GetValue(6) + result.GetValue(7) + result.GetValue(8),
                                result.GetValue(9),
                                result.GetValue(10),
                                result.GetValue(9) + result.GetValue(10),
                                result.GetValue(11),
                                result.GetValue(12)
                                )

                    tbPasienAwal.Text = dt.Rows(0)(1)
                    tbPasienMasuk.Text = dt.Rows(0)(2)
                    tbPasienPindahan.Text = dt.Rows(0)(3)
                    tbJumlahDirawat.Text = dt.Rows(0)(4)

                    tbDiizinkan.Text = dt.Rows(0)(5)
                    tbDirujuk.Text = dt.Rows(0)(6)
                    tbPindahRS.Text = dt.Rows(0)(7)
                    tbPulangPaksa.Text = dt.Rows(0)(8)
                    tbMelarikanDiri.Text = dt.Rows(0)(9)
                    tbDipindahkan.Text = dt.Rows(0)(10)
                    tbJumlahKeluarHidup.Text = dt.Rows(0)(11)

                    tbKurang48.Text = dt.Rows(0)(12)
                    tbLebih48.Text = dt.Rows(0)(13)
                    tbJumlahKeluarMati.Text = dt.Rows(0)(14)

                    tbLamaRawat.Text = dt.Rows(0)(15)
                    tbKeluarMasuk.Text = dt.Rows(0)(16)

                Else
                    MsgBox("Koneksi database gagal!")
                    btnCari_isClicked = False
                End If
            Else
                Dim taskLoading As New System.Threading.Thread(AddressOf showLoading)
                taskLoading.Start()
                Dim awalBulan As Date = dtpTanggal.Value.Month & "/1/" & dtpTanggal.Value.Year
                Dim akhirBulan As Date = awalBulan.AddMonths(1)
                akhirBulan = akhirBulan.AddDays(-1)
                For i As Integer = 1 To akhirBulan.Day
                    cmd = New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@tgl", awalBulan.ToString("M/d/yyyy"))
                    cmd.Parameters.AddWithValue("@ruangan", ruangan)
                    cmd.Parameters.AddWithValue("@kelas", kelas)
                    result = cmd.ExecuteReader
                    If result.Read Then
                        dt.Rows.Add(i,
                                result.GetValue(0),
                                result.GetValue(1),
                                result.GetValue(2),
                                result.GetValue(0) + result.GetValue(1) + result.GetValue(2),
                                result.GetValue(3),
                                result.GetValue(4),
                                result.GetValue(5),
                                result.GetValue(6),
                                result.GetValue(7),
                                result.GetValue(8),
                                result.GetValue(3) + result.GetValue(4) + result.GetValue(5) + result.GetValue(6) + result.GetValue(7) + result.GetValue(8),
                                result.GetValue(9),
                                result.GetValue(10),
                                result.GetValue(9) + result.GetValue(10),
                                result.GetValue(11),
                                result.GetValue(12)
                                )
                    Else
                        MsgBox("Koneksi database gagal!")
                        btnCari_isClicked = False
                        taskLoading.Abort()
                        Exit For
                    End If
                    awalBulan = awalBulan.AddDays(1)
                Next
                tbPasienAwal.Text = Convert.ToInt32(dt.Compute("SUM(pasien_awal)", String.Empty))
                tbPasienMasuk.Text = Convert.ToInt32(dt.Compute("SUM(pasien_masuk)", String.Empty))
                tbPasienPindahan.Text = Convert.ToInt32(dt.Compute("SUM(pasien_pindahan)", String.Empty))
                tbJumlahDirawat.Text = Convert.ToInt32(dt.Compute("SUM(jumlah_dirawat)", String.Empty))

                tbDiizinkan.Text = Convert.ToInt32(dt.Compute("SUM(diizinkan_pulang)", String.Empty))
                tbDirujuk.Text = Convert.ToInt32(dt.Compute("SUM(dirujuk)", String.Empty))
                tbPindahRS.Text = Convert.ToInt32(dt.Compute("SUM(pindah_rs)", String.Empty))
                tbPulangPaksa.Text = Convert.ToInt32(dt.Compute("SUM(pulang_paksa)", String.Empty))
                tbMelarikanDiri.Text = Convert.ToInt32(dt.Compute("SUM(melarikan_diri)", String.Empty))
                tbDipindahkan.Text = Convert.ToInt32(dt.Compute("SUM(dipindahkan)", String.Empty))
                tbJumlahKeluarHidup.Text = Convert.ToInt32(dt.Compute("SUM(jumlah_keluar_hidup)", String.Empty))

                tbKurang48.Text = Convert.ToInt32(dt.Compute("SUM(kurang)", String.Empty))
                tbLebih48.Text = Convert.ToInt32(dt.Compute("SUM(lebih)", String.Empty))
                tbJumlahKeluarMati.Text = Convert.ToInt32(dt.Compute("SUM(jumlah_keluar_mati)", String.Empty))

                tbLamaRawat.Text = Convert.ToInt32(dt.Compute("SUM(lama_dirawat)", String.Empty))
                tbKeluarMasuk.Text = Convert.ToInt32(dt.Compute("SUM(keluar_masuk)", String.Empty))
                taskLoading.Abort()
            End If
        End If
        conn.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If btnCari_isClicked Then
            Dim report As New SensusReport
            report.SetDataSource(dt)
            report.SetParameterValue("bulan", dtpTanggal.Value.ToString("MMMM yyyy"))
            report.SetParameterValue("ruangan", ruanganParam)
            report.SetParameterValue("kelas", kelasParam)
            report.SetParameterValue("pasien_awal", tbPasienAwal.Text)
            report.SetParameterValue("pasien_masuk", tbPasienMasuk.Text)
            report.SetParameterValue("pasien_pindahan", tbPasienPindahan.Text)
            report.SetParameterValue("jumlah_dirawat", tbJumlahDirawat.Text)
            report.SetParameterValue("diizinkan_pulang", tbDiizinkan.Text)
            report.SetParameterValue("dirujuk", tbDirujuk.Text)
            report.SetParameterValue("pindah_rs", tbPindahRS.Text)
            report.SetParameterValue("pulang_paksa", tbPulangPaksa.Text)
            report.SetParameterValue("melarikan_diri", tbMelarikanDiri.Text)
            report.SetParameterValue("dipindahkan", tbDipindahkan.Text)
            report.SetParameterValue("jumlah_keluar_hidup", tbJumlahKeluarHidup.Text)
            report.SetParameterValue("kurang", tbKurang48.Text)
            report.SetParameterValue("lebih", tbLebih48.Text)
            report.SetParameterValue("jumlah_keluar_mati", tbJumlahKeluarMati.Text)
            report.SetParameterValue("lama_dirawat", tbLamaRawat.Text)
            report.SetParameterValue("keluar_masuk", tbKeluarMasuk.Text)
            SensusPrint.CrystalReportViewer1.ReportSource = report
            SensusPrint.ShowDialog()
        Else
            MsgBox("Cari data terlebih dahulu")
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

    Private Sub showLoading()
        LoadingForm.StartPosition = FormStartPosition.Manual
        Dim x As Integer = Me.Location.X + Me.Width / 2 - LoadingForm.Width / 2
        Dim y As Integer = Me.Location.Y + Me.Height / 2 - LoadingForm.Height / 2
        If x < 0 Then
            x = 0
        End If
        If y < 0 Then
            y = 0
        End If
        LoadingForm.Location = New Point(x, y)
        LoadingForm.ShowDialog()
    End Sub
End Class
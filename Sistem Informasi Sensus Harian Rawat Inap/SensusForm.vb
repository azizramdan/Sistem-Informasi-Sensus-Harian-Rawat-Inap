Imports System.Data.OleDb
Public Class SensusForm
    Dim btnCari_isClicked As Boolean
    Dim periode As String

    Private Sub SensusForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        rbHarian.Checked = True
        getRuanganKelas(cbRuangan, cbKelas)
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
        If cbRuangan.SelectedIndex = -1 Or cbKelas.SelectedIndex = -1 Then
            MsgBox("Data harus diisi semua")
        Else
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim query As String
                If rbHarian.Checked Then
                    periode = "Periode: " & dtpTanggal.Value.ToString("d MMMM yyyy")
                    query = SensusHarian()
                Else
                    periode = "Periode: " & dtpTanggal.Value.ToString("MMMM yyyy")
                    query = SensusBulanan()
                End If
                getTempatTidur(cbRuangan.SelectedItem, cbKelas.SelectedItem)
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@tgl", dtpTanggal.Value.ToString("M/d/yyyy"))
                cmd.Parameters.AddWithValue("@idTempatTidur", IdTempatTidur)
                Dim result As OleDbDataReader = cmd.ExecuteReader
                If result.Read Then
                    tbPasienAwal.Text = result.GetValue(0)
                    tbPasienMasuk.Text = result.GetValue(1)
                    tbJumlahDirawat.Text = Val(tbPasienAwal.Text) + Val(tbPasienMasuk.Text)

                    tbDiizinkan.Text = result.GetValue(2)
                    tbDirujuk.Text = result.GetValue(3)
                    tbPindahRS.Text = result.GetValue(4)
                    tbPulangPaksa.Text = result.GetValue(5)
                    tbMelarikanDiri.Text = result.GetValue(6)
                    tbDipindahkan.Text = result.GetValue(7)
                    tbJumlahKeluarHidup.Text = Val(tbDiizinkan.Text) + Val(tbDirujuk.Text) + Val(tbPindahRS.Text) + Val(tbPulangPaksa.Text) + Val(tbMelarikanDiri.Text) + Val(tbDipindahkan.Text)

                    tbKurang48.Text = result.GetValue(8)
                    tbLebih48.Text = result.GetValue(9)
                    tbJumlahKeluarMati.Text = Val(tbKurang48.Text) + Val(tbLebih48.Text)

                    tbKeluarMasuk.Text = Val(tbJumlahDirawat.Text) - (Val(tbJumlahKeluarHidup.Text) + Val(tbJumlahKeluarMati.Text))

                    LamaRawat()
                End If
            Else
                MsgBox("Koneksi database gagal!")
            End If
        End If
    End Sub

    Private Function SensusHarian()
        Dim query As String
        query = "SELECT Sum(awal) AS [Pasien Awal], Sum(masuk) AS [Pasien Masuk], Sum(izin) AS [Diizinkan Pulang], Sum(rujuk) AS Dirujuk, Sum(pindah) AS [Pindah RS], Sum(pulang) AS [Pulang Paksa], Sum(melarikan) AS [Melarikan Diri], Sum(dipindah) AS Dipindahkan, Sum(kurang) AS KurangJam, Sum(lebih) AS LebihJam FROM (  SELECT COUNT(id) AS awal, 0 AS masuk, 0 AS izin, 0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_masuk WHERE tanggal_masuk < @tgl AND deleted_at IS NULL AND id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, COUNT(id) AS masuk, 0 AS izin, 0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_masuk WHERE tanggal_masuk = @tgl AND deleted_at IS NULL AND id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, COUNT(register_keluar.id) AS izin, 0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Diizinkan pulang' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  COUNT(register_keluar.id) AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Dirujuk' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, COUNT(register_keluar.id) AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Pindah RS lain' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, COUNT(register_keluar.id) AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Pulang paksa' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, 0 AS pulang, COUNT(register_keluar.id) AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Melarikan diri' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, COUNT(register_keluar.id) AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Dipindahkan' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, COUNT(register_keluar.id) AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Meninggal <48 jam' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, COUNT(register_keluar.id) AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Meninggal >48 jam' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  )  AS [%$##@_Alias]"
        Return query
    End Function

    Private Function SensusBulanan()
        Dim query As String
        query = "SELECT Sum(awal) AS [Pasien Awal], Sum(masuk) AS [Pasien Masuk], Sum(izin) AS [Diizinkan Pulang], Sum(rujuk) AS Dirujuk, Sum(pindah) AS [Pindah RS], Sum(pulang) AS [Pulang Paksa], Sum(melarikan) AS [Melarikan Diri], Sum(dipindah) AS Dipindahkan, Sum(kurang) AS KurangJam, Sum(lebih) AS LebihJam FROM (SELECT COUNT(id) AS awal, 0 AS masuk, 0 AS izin, 0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_masuk WHERE MONTH(tanggal_masuk) < MONTH(@tgl) AND YEAR(tanggal_masuk) = YEAR(@tgl) AND deleted_at IS NULL AND id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, COUNT(id) AS masuk, 0 AS izin, 0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_masuk WHERE MONTH(tanggal_masuk) = MONTH(@tgl) AND YEAR(tanggal_masuk) = YEAR(@tgl) AND deleted_at IS NULL AND id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, COUNT(register_keluar.id) AS izin, 0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Diizinkan pulang' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  COUNT(register_keluar.id) AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Dirujuk' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, COUNT(register_keluar.id) AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Pindah RS lain' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, COUNT(register_keluar.id) AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Pulang paksa' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, 0 AS pulang, COUNT(register_keluar.id) AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Melarikan diri' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, COUNT(register_keluar.id) AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Dipindahkan' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, COUNT(register_keluar.id) AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Meninggal <48 jam' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, COUNT(register_keluar.id) AS lebih FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Meninggal >48 jam' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  )  AS [%$##@_Alias]"
        Return query
    End Function

    Private Sub LamaRawat()
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            Dim query As String
            If rbHarian.Checked Then
                query = "SELECT sum(lama) AS [Lama dirawat] FROM (  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_masuk WHERE tanggal_masuk < @tgl AND deleted_at IS NULL AND id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_masuk WHERE tanggal_masuk = @tgl AND deleted_at IS NULL AND id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Diizinkan pulang' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Dirujuk' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Pindah RS lain' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Pulang paksa' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Melarikan diri' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Dipindahkan' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Meninggal <48 jam' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Meninggal >48 jam' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  )  AS [%$##@_Alias]"
            Else
                query = "SELECT sum(lama) AS [Lama dirawat] FROM (SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_masuk WHERE MONTH(tanggal_masuk) < MONTH(@tgl) AND YEAR(tanggal_masuk) = YEAR(@tgl) AND deleted_at IS NULL AND id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_masuk WHERE MONTH(tanggal_masuk) = MONTH(@tgl) AND YEAR(tanggal_masuk) = YEAR(@tgl) AND deleted_at IS NULL AND id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Diizinkan pulang' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Dirujuk' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Pindah RS lain' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Pulang paksa' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Melarikan diri' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Dipindahkan' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Meninggal <48 jam' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT DATEDIFF('y', [tanggal_masuk], @tgl) AS lama FROM register_keluar, register_masuk WHERE MONTH(tanggal_keluar) = MONTH(@tgl) AND YEAR(tanggal_keluar) = YEAR(@tgl) AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Meninggal >48 jam' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  )  AS [%$##@_Alias]"
            End If
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@tgl", dtpTanggal.Value.ToString("M/d/yyyy"))
            cmd.Parameters.AddWithValue("@idTempatTidur", IdTempatTidur)
            Dim result As OleDbDataReader = cmd.ExecuteReader
            If result.Read Then
                tbLamaRawat.Text = result.GetValue(0)
            End If
        Else
            MsgBox("Koneksi database gagal!")
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If btnCari_isClicked Then
            Dim ppd As New PrintPreviewDialog
            ppd.Document = PrintDocument1
            ppd.Document.DefaultPageSettings.Landscape = True
            ppd.WindowState = FormWindowState.Maximized
            ppd.ShowDialog()
        Else
            MsgBox("Cari data sensus terlebih dahulu")
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim width As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width)
        Dim height As Integer = 50
        Dim rect As New Rectangle(20, 20, width, height)
        Dim sf As New StringFormat
        Dim startX As Integer = 20
        Dim startY As Integer = rect.Bottom
        Dim fontJudul As New Font("Microsoft Sans Serif", 20, FontStyle.Bold)

        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString("Laporan Sensus", fontJudul, Brushes.Black, rect, sf)
        fontJudul = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        startY += 10
        height = 20
        e.Graphics.DrawString(periode, fontJudul, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Ruangan: " & cbRuangan.SelectedItem, fontJudul, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Kelas: " & cbKelas.SelectedItem, fontJudul, Brushes.Black, New Rectangle(startX, startY, width, height), sf)

        fontJudul = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
        Dim fontIsi As New Font("Microsoft Sans Serif", 10)
        sf.Alignment = StringAlignment.Near
        sf.LineAlignment = StringAlignment.Near

        startY += 60
        e.Graphics.DrawString("Total pasien dirawat", fontJudul, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Pasien awal: " & tbPasienAwal.Text, fontIsi, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Pasien masuk: " & tbPasienMasuk.Text, fontIsi, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Jumlah: " & tbJumlahDirawat.Text, fontJudul, Brushes.Black, New Rectangle(startX, startY, width, height), sf)

        startY += 40
        e.Graphics.DrawString("Total pasien keluar hidup", fontJudul, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Diizinkan pulang: " & tbDiizinkan.Text, fontIsi, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Dirujuk: " & tbDirujuk.Text, fontIsi, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Pindah RS lain: " & tbPindahRS.Text, fontIsi, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Pulang paksa: " & tbPulangPaksa.Text, fontIsi, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Melarikan diri: " & tbMelarikanDiri.Text, fontIsi, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Dipindahkan: " & tbDipindahkan.Text, fontIsi, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Jumlah: " & tbJumlahKeluarHidup.Text, fontJudul, Brushes.Black, New Rectangle(startX, startY, width, height), sf)

        startY += 40
        e.Graphics.DrawString("Total pasien keluar mati", fontJudul, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("<48 jam: " & tbKurang48.Text, fontIsi, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString(">48 jam: " & tbLebih48.Text, fontIsi, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Jumlah: " & tbJumlahKeluarMati.Text, fontJudul, Brushes.Black, New Rectangle(startX, startY, width, height), sf)

        startY += 40
        e.Graphics.DrawString("Lama dirawat: " & tbLamaRawat.Text, fontJudul, Brushes.Black, New Rectangle(startX, startY, width, height), sf)
        startY += 20
        e.Graphics.DrawString("Pasien keluar masuk dihari yang sama: " & tbKeluarMasuk.Text, fontJudul, Brushes.Black, New Rectangle(startX, startY, width, height), sf)

    End Sub
End Class
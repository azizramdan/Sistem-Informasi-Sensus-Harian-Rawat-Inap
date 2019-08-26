Imports System.Data.OleDb
Public Class SensusForm

    Private Sub SensusForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        rbHarian.Checked = True
    End Sub

    Private Sub rbHarian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHarian.CheckedChanged
        dtpTanggal.Format = DateTimePickerFormat.Custom
        dtpTanggal.CustomFormat = "dddd, d MMMM yyyy"
    End Sub

    Private Sub rbBulanan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBulanan.CheckedChanged
        dtpTanggal.Format = DateTimePickerFormat.Custom
        dtpTanggal.CustomFormat = "MMMM yyyy"
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        If cbRuangan.SelectedIndex = -1 Or cbKelas.SelectedIndex = -1 Then
            MsgBox("Data harus diisi semua")
        Else
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim query As String
                If rbHarian.Checked Then
                    query = Harian()
                Else
                    query = "SELECT rm.no_medrec, p.nama_lengkap FROM [register_masuk] AS rm, [pasien] AS p WHERE rm.id=@id AND p.no_medrec = rm.no_medrec"
                End If

                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@tgl", dtpTanggal.Value.ToString("M/d/yyyy"))
                cmd.Parameters.AddWithValue("@idTempatTidur", getIdTempatTidur())
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
                    tbJumlahKeluarHidup.Text = Val(tbDiizinkan.Text) + Val(tbDirujuk.Text) + Val(tbPindahRS.Text) + Val(tbPulangPaksa.Text) + Val(tbMelarikanDiri.Text)

                    tbDipindahkan.Text = result.GetValue(7)
                    tbKurang48.Text = result.GetValue(8)
                    tbLebih48.Text = result.GetValue(9)
                    tbJumlahPasienKeluar.Text = Val(tbDipindahkan.Text) + Val(tbKurang48.Text) + Val(tbLebih48.Text)
                End If
            Else
                MsgBox("Koneksi database gagal!")
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub tbJumlahKeluarHidup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbJumlahKeluarHidup.TextChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
    Private Function getIdTempatTidur()
        Dim idTempatTidur As String = 0
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            Dim query As String = "SELECT tempat_tidur.id FROM tempat_tidur, ruangan, kelas WHERE tempat_tidur.id_ruangan = ruangan.id AND tempat_tidur.id_kelas = kelas.id AND ruangan.ruangan = @ruangan AND kelas.kelas = @kelas"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@ruangan", cbRuangan.SelectedItem)
            cmd.Parameters.AddWithValue("@kelas", cbKelas.SelectedItem)
            Dim result As OleDbDataReader = cmd.ExecuteReader
            If result.Read Then
                idTempatTidur = result.GetValue(0)
            End If
        Else
            MsgBox("Koneksi database gagal!")
        End If
        Return idTempatTidur
    End Function
    Private Function Harian()
        Dim query As String
        query = "SELECT Sum(awal) AS [Pasien Awal], Sum(masuk) AS [Pasien Masuk], Sum(izin) AS [Diizinkan Pulang], Sum(rujuk) AS Dirujuk, Sum(pindah) AS [Pindah RS], Sum(pulang) AS [Pulang Paksa], Sum(melarikan) AS [Melarikan Diri], Sum(dipindah) AS Dipindahkan, Sum(kurang) AS KurangJam, Sum(lebih) AS LebihJam FROM (  SELECT COUNT(id) AS awal, 0 AS masuk, 0 AS izin, 0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_masuk WHERE tanggal_masuk < @tgl AND deleted_at IS NULL AND id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, COUNT(id) AS masuk, 0 AS izin, 0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_masuk WHERE tanggal_masuk = @tgl AND deleted_at IS NULL AND id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, COUNT(register_keluar.id) AS izin, 0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Diizinkan pulang' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  COUNT(register_keluar.id) AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Dirujuk' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, COUNT(register_keluar.id) AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Pindah RS lain' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, COUNT(register_keluar.id) AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Pulang paksa' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, 0 AS pulang, COUNT(register_keluar.id) AS melarikan, 0 AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Melarikan diri' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, COUNT(register_keluar.id) AS dipindah, 0 AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Dipindahkan' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, COUNT(register_keluar.id) AS kurang, 0 AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Meninggal <48 jam' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  UNION ALL  SELECT 0 AS awal, 0 AS masuk, 0 AS izin,  0 AS rujuk, 0 AS pindah, 0 AS pulang, 0 AS melarikan, 0 AS dipindah, 0 AS kurang, COUNT(register_keluar.id) AS lebih FROM register_keluar, register_masuk WHERE tanggal_keluar = @tgl AND register_keluar.deleted_at IS NULL AND cara_pasien_keluar = 'Meninggal >48 jam' AND register_keluar.id_register_masuk = register_masuk.id AND register_masuk.id_tempat_tidur = @idTempatTidur  )  AS [%$##@_Alias]"
        Return query
    End Function
End Class
Imports System.Data.OleDb
Public Class PasienTambahForm

    Private Sub PasienTambahForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            PasienForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim medrec, nama, tempat, tanggal, alamat, telp, agama, status, pekerjaan, ayah, ibu
        medrec = tbMedrec.Text
        nama = tbPasien.Text
        tempat = tbTempatLahir.Text
        tanggal = dtpTanggalLahir.Value.ToString("M/d/yyyy")
        alamat = rtbAlamat.Text
        telp = tbTelp.Text
        agama = cbAgama.SelectedItem
        status = cbStatus.SelectedItem
        pekerjaan = tbPekerjaan.Text
        ayah = tbAyah.Text
        ibu = tbIbu.Text

        If medrec = "" Or nama = "" Or tempat = "" Or alamat = "" Or telp = "" Or agama = "" Or status = "" Or pekerjaan = "" Or ayah = "" Or ibu = "" Then
            MsgBox("Data harus diisi semua")
        Else
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim query As String = "SELECT * FROM [pasien] WHERE no_medrec=@medrec"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@medrec", medrec)
                Dim result As OleDbDataReader = cmd.ExecuteReader
                If result.Read Then
                    MsgBox("Gagal! No. Medrec sudah ada!")
                Else
                    query = "INSERT INTO pasien (no_medrec, nama_lengkap, tempat_lahir, tanggal_lahir, alamat, no_telpon, agama, status, pekerjaan, nama_ayah, nama_ibu) "
                    query &= "VALUES (@medrec, @nama, @tempat, @tanggal, @alamat, @telp, @agama, @status, @pekerjaan, @ayah, @ibu)"
                    cmd = New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@medrec", medrec)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@tempat", tempat)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@telp", telp)
                    cmd.Parameters.AddWithValue("@agama", agama)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@pekerjaan", pekerjaan)
                    cmd.Parameters.AddWithValue("@ayah", ayah)
                    cmd.Parameters.AddWithValue("@ibu", ibu)
                    Dim result2 As Integer = cmd.ExecuteNonQuery
                    If result2 > 0 Then
                        MsgBox("Data pasien berhasil disimpan")
                    Else
                        MsgBox("Data pasien gagal disimpan")
                    End If
                End If
            Else
                MsgBox("Koneksi database gagal!")
            End If
        End If
    End Sub

    Private Sub btnBersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersihkan.Click
        tbMedrec.Text = ""
        tbPasien.Text = ""
        tbTempatLahir.Text = ""
        rtbAlamat.Text = ""
        tbTelp.Text = ""
        cbAgama.SelectedIndex = -1
        cbStatus.SelectedIndex = -1
        tbPekerjaan.Text = ""
        tbAyah.Text = ""
        tbIbu.Text = ""
    End Sub
End Class
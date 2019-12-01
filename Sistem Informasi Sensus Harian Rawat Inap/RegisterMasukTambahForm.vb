Imports System.Data.OleDb
Public Class RegisterMasukTambahForm
    Dim btnCek_Clicked As Boolean
    Dim sip As String

    Private Sub RegisterMasukTambahForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        getRuanganKelas(cbRuangan, cbKelas)
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            RegisterMasukForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub btnCek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCek.Click
        If btnCek_Clicked Then
            btnCek_Clicked = False
            btnCek.Text = "Cek"
            tbMedrec.Enabled = True
            tbMedrec.Text = ""
            tbNama.Text = ""
        Else
            Dim medrec As String = tbMedrec.Text
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim query As String = "SELECT nama_lengkap FROM [pasien] WHERE no_medrec=@medrec AND deleted_at IS NULL"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@medrec", medrec)
                Dim result As OleDbDataReader = cmd.ExecuteReader
                If result.Read Then
                    tbNama.Text = result.GetString(0)
                    btnCek_Clicked = True
                    btnCek.Text = "X"
                    tbMedrec.Enabled = False
                End If
            Else
                MsgBox("Koneksi database gagal!")
            End If
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim medrec, nama, ruangan, kelas, dokter, tanggalMasuk, caraMasuk As String
        medrec = tbMedrec.Text
        nama = tbNama.Text
        ruangan = cbRuangan.SelectedIndex + 1
        kelas = cbKelas.SelectedIndex + 1
        dokter = tbDokter.Text
        tanggalMasuk = dtpTanggalMasuk.Value.ToString("M/d/yyyy")
        caraMasuk = cbCaraMasuk.SelectedItem

        If Not btnCek_Clicked Then
            MsgBox("Cek No. Medrec terlebih dahulu!")
        ElseIf medrec = "" Or ruangan = -1 Or kelas = -1 Or dokter = "" Or tanggalMasuk = "" Or caraMasuk = "" Then
            MsgBox("Data harus diisi semua")
        Else
            getTempatTidur(cbRuangan.SelectedItem, cbKelas.SelectedItem)
            If IsKosong Then
                Dim source As String = My.Settings.DBConnectionString
                Dim conn = New OleDbConnection(source)
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                    Dim query As String = "SELECT id FROM register_masuk WHERE no_medrec = @medrec AND keluar = FALSE AND deleted_at IS NULL"
                    Dim cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@medrec", medrec)
                    Dim result As OleDbDataReader = cmd.ExecuteReader
                    If result.Read Then
                        MsgBox("Pasien sudah ada dan belum keluar")
                    Else
                        query = "INSERT INTO register_masuk (no_medrec, id_tempat_tidur, tanggal_masuk, cara_pasien_masuk, sip_dokter) "
                        query &= "VALUES (@medrec, @idTempatTidur, @tanggalMasuk, @caraMasuk, @sip)"
                        cmd = New OleDbCommand(query, conn)
                        cmd.Parameters.AddWithValue("@medrec", medrec)
                        cmd.Parameters.AddWithValue("@idTempatTidur", IdTempatTidur)
                        cmd.Parameters.AddWithValue("@tanggalMasuk", tanggalMasuk)
                        cmd.Parameters.AddWithValue("@caraMasuk", caraMasuk)
                        cmd.Parameters.AddWithValue("@sip", sip)
                        Dim result2 As Integer = cmd.ExecuteNonQuery
                        If result2 > 0 Then
                            If UpdateTempatTidur(IdTempatTidur, "-") Then
                                MsgBox("Data berhasil disimpan")
                                btnBersihkan_Click(sender, e)
                            Else
                                MsgBox("Data gagal disimpan")
                            End If
                        Else
                            MsgBox("Data gagal disimpan")
                        End If
                    End If
                Else
                    MsgBox("Koneksi database gagal!")
                End If
            Else
                MsgBox("Data gagal disimpan!, tempat tidur penuh!")
            End If
        End If

    End Sub

    Private Sub btnBersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersihkan.Click
        If btnCek_Clicked Then
            btnCek_Clicked = False
            btnCek.Text = "Cek"
            tbMedrec.Enabled = True
        End If
        tbMedrec.Text = ""
        tbNama.Text = ""
        cbRuangan.SelectedIndex = -1
        cbKelas.SelectedIndex = -1
        tbDokter.Text = ""
        cbCaraMasuk.SelectedIndex = -1
    End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        Dim f As New PilihDokterForm
        If (f.ShowDialog() = DialogResult.OK) Then
            tbDokter.Text = f.nama
            sip = f.sip
        End If
    End Sub
End Class
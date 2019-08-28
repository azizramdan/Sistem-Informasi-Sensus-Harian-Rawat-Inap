Imports System.Data.OleDb
Public Class RegisterPindahForm
    Dim btnCek_Clicked As Boolean

    Private Sub RegisterPindahForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            MenuForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub btnCek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCek.Click
        If btnCek_Clicked Then
            btnCek_Clicked = False
            btnCek.Text = "Cek"
            tbId.Enabled = True
            tbId.Text = ""
            tbMedrec.Text = ""
            tbNama.Text = ""
            tbRuanganLama.Text = ""
            tbKelasLama.Text = ""
        End If
        Dim id As String = tbId.Text
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            Dim query As String = "SELECT rm.no_medrec, p.nama_lengkap, r.ruangan, k.kelas FROM [register_masuk] AS rm, [pasien] AS p, [ruangan] AS r, [kelas] AS k, [tempat_tidur] AS tt WHERE rm.id=@id AND rm.keluar = FALSE AND rm.deleted_at IS NULL AND p.no_medrec = rm.no_medrec AND tt.id = rm.id_tempat_tidur AND r.id = tt.id_ruangan AND k.id = tt.id_kelas"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", id)
            Dim result As OleDbDataReader = cmd.ExecuteReader
            If result.Read Then
                tbMedrec.Text = result.GetString(0)
                tbNama.Text = result.GetString(1)
                tbRuanganLama.Text = result.GetString(2)
                tbKelasLama.Text = result.GetString(3)
                btnCek_Clicked = True
                btnCek.Text = "X"
                tbId.Enabled = False
            End If
        Else
            MsgBox("Koneksi database gagal!")
        End If
    End Sub

    Private Sub btnPindah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPindah.Click
        Dim ruanganLama, ruanganBaru, kelasLama, kelasBaru, idRegMasuk, tanggalPindah, medrec As String
        ruanganLama = tbRuanganLama.Text
        ruanganBaru = cbRuangan.SelectedItem
        kelasLama = tbKelasLama.Text
        kelasBaru = cbKelas.SelectedItem
        idRegMasuk = tbId.Text
        tanggalPindah = dtpTanggal.Value.ToString("M/d/yyyy")
        medrec = tbMedrec.Text

        If Not btnCek_Clicked Then
            MsgBox("Cek ID Register Masuk terlebih dahulu!")
        ElseIf ruanganBaru = "" Or kelasBaru = "" Then
            MsgBox("Data harus diisi semua")
        ElseIf ruanganLama = ruanganBaru And kelasLama = kelasBaru Then
            MsgBox("Tidak ada perubahan ruangan dan kelas")
        Else
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim query As String = "INSERT INTO register_keluar (id_register_masuk, tanggal_keluar, cara_pasien_keluar) "
                query &= "VALUES (@idRegMasuk, @tanggalKeluar, @caraKeluar)"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@idRegMasuk", idRegMasuk)
                cmd.Parameters.AddWithValue("@tanggalKeluar", tanggalPindah)
                cmd.Parameters.AddWithValue("@caraKeluar", "Dipindahkan")
                Dim result As Integer = cmd.ExecuteNonQuery
                If result > 0 Then
                    query = "UPDATE register_masuk, tempat_tidur SET keluar=TRUE, kosong=kosong+1 WHERE register_masuk.id=@id AND tempat_tidur.id = register_masuk.id_tempat_tidur"
                    cmd = New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idRegMasuk)
                    result = cmd.ExecuteNonQuery
                    If result > 0 Then
                        getTempatTidur(ruanganBaru, kelasBaru)
                        query = "INSERT INTO register_masuk (no_medrec, id_tempat_tidur, tanggal_masuk, cara_pasien_masuk) "
                        query &= "VALUES (@medrec, @idTempatTidur, @tanggalMasuk, @caraMasuk)"
                        cmd = New OleDbCommand(query, conn)
                        cmd.Parameters.AddWithValue("@medrec", medrec)
                        cmd.Parameters.AddWithValue("@idTempatTidur", IdTempatTidur)
                        cmd.Parameters.AddWithValue("@tanggalMasuk", tanggalPindah)
                        cmd.Parameters.AddWithValue("@caraMasuk", "Pindahan")
                        result = cmd.ExecuteNonQuery
                        If result > 0 Then
                            If UpdateTempatTidur(IdTempatTidur, "-") Then
                                MsgBox("Pasien berhasil dipindahkan")
                                btnBersihkan_Click(Me, e)
                            Else
                                MsgBox("Pasien gagal dipindahkan")
                            End If
                        Else
                            MsgBox("Pasien gagal dipindahkan")
                        End If
                    Else
                        MsgBox("Pasien gagal dipindahkan")
                    End If
                Else
                    MsgBox("Pasien gagal dipindahkan")
                End If
            Else
                MsgBox("Pasien gagal dipindahkan")
            End If
        End If
    End Sub

    Private Sub btnBersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersihkan.Click
        If btnCek_Clicked Then
            btnCek_Clicked = False
            btnCek.Text = "Cek"
            tbId.Enabled = True
        End If
        tbId.Text = ""
        tbMedrec.Text = ""
        tbNama.Text = ""
        tbRuanganLama.Text = ""
        tbKelasLama.Text = ""
        cbRuangan.SelectedIndex = -1
        cbKelas.SelectedIndex = -1
    End Sub
End Class
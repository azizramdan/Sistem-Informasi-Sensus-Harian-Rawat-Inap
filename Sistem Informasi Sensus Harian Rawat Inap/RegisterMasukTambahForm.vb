Imports System.Data.OleDb
Public Class RegisterMasukTambahForm
    Dim btnCek_Clicked As Boolean
    Private Sub RegisterMasukTambahForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
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
        Dim medrec, nama, ruangan, kelas, tanggalMasuk, caraMasuk As String
        medrec = tbMedrec.Text
        nama = tbNama.Text
        ruangan = cbRuangan.SelectedIndex + 1
        kelas = cbKelas.SelectedIndex + 1
        tanggalMasuk = dtpTanggalMasuk.Value.ToString("M/d/yyyy")
        caraMasuk = cbCaraMasuk.SelectedItem

        If Not btnCek_Clicked Then
            MsgBox("Cek No. Medrec terlebih dahulu!")
        ElseIf medrec = "" Or ruangan = -1 Or kelas = -1 Or tanggalMasuk = "" Or caraMasuk = "" Then
            MsgBox("Data harus diisi semua")
        Else
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim query As String = "INSERT INTO register_masuk (no_medrec, id_ruangan, id_kelas, tanggal_masuk, cara_pasien_masuk) "
                query &= "VALUES (@medrec, @ruangan, @kelas, @tanggalMasuk, @caraMasuk)"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@medrec", medrec)
                cmd.Parameters.AddWithValue("@ruangan", ruangan)
                cmd.Parameters.AddWithValue("@kelas", kelas)
                cmd.Parameters.AddWithValue("@tanggalMasuk", tanggalMasuk)
                cmd.Parameters.AddWithValue("@caraMasuk", caraMasuk)
                Dim result As Integer = cmd.ExecuteNonQuery
                If result > 0 Then
                    MsgBox("Data berhasil disimpan")
                Else
                    MsgBox("Data gagal disimpan")
                End If
            Else
                MsgBox("Koneksi database gagal!")
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
        cbCaraMasuk.SelectedIndex = -1
    End Sub
End Class
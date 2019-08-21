Imports System.Data.OleDb
Public Class RegisterKeluarTambahForm
    Dim btnCek_Clicked As Boolean
    Private Sub RegisterKeluarTambahForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            RegisterKeluarForm.Show()
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
        End If
        Dim id As String = tbId.Text
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            Dim query As String = "SELECT rm.no_medrec, p.nama_lengkap FROM [register_masuk] AS rm, [pasien] AS p WHERE rm.id=@id AND p.no_medrec = rm.no_medrec"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", id)
            Dim result As OleDbDataReader = cmd.ExecuteReader
            If result.Read Then
                tbMedrec.Text = result.GetString(0)
                tbNama.Text = result.GetString(1)
                btnCek_Clicked = True
                btnCek.Text = "X"
                tbId.Enabled = False
            End If
        Else
            MsgBox("Koneksi database gagal!")
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim id, tanggalKeluar, caraKeluar As String
        id = tbId.Text
        tanggalKeluar = dtpTanggal.Value.ToString("M/d/yyyy")
        caraKeluar = cbCaraKeluar.SelectedItem

        If Not btnCek_Clicked Then
            MsgBox("Cek ID Register Masuk terlebih dahulu!")
        ElseIf tanggalKeluar = "" Or caraKeluar = "" Then
            MsgBox("Data harus diisi semua")
        Else
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim query As String = "INSERT INTO register_keluar (id_register_masuk, tanggal_keluar, cara_pasien_keluar) "
                query &= "VALUES (@id, @tanggalKeluar, @caraKeluar)"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@tanggalKeluar", tanggalKeluar)
                cmd.Parameters.AddWithValue("@caraKeluar", caraKeluar)
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
            tbId.Enabled = True
        End If
        tbId.Text = ""
        tbMedrec.Text = ""
        tbNama.Text = ""
        cbCaraKeluar.SelectedIndex = -1
    End Sub
End Class
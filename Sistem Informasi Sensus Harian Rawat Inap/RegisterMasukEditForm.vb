Imports System.Data.OleDb
Public Class RegisterMasukEditForm
    Dim idRegMasuk, namaRuangan, namaKelas As String

    Private Sub RegisterMasukEditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        getRuanganKelas(cbRuangan, cbKelas)
        cbRuangan.SelectedItem = namaRuangan
        cbKelas.SelectedItem = namaKelas
    End Sub

    Public Sub New(ByVal id As String, ByVal medrec As String, ByVal nama As String, ByVal tanggal As Date, ByVal ruangan As String, ByVal kelas As String, ByVal dokter As String, ByVal caraMasuk As String)
        InitializeComponent()
        idRegMasuk = id
        tbMedrec.Text = medrec
        tbNama.Text = nama
        dtpTanggal.Value = tanggal
        namaRuangan = ruangan
        namaKelas = kelas
        tbDokter.Text = dokter
        cbCaraMasuk.SelectedItem = caraMasuk
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            RegisterMasukForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        getTempatTidur(cbRuangan.SelectedItem, cbKelas.SelectedItem)
        If cbRuangan.SelectedItem = namaRuangan And cbKelas.SelectedItem = namaKelas Then
            IsKosong = True
        End If

        If IsKosong Then
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim tanggalMasuk, caraMasuk As String
                tanggalMasuk = dtpTanggal.Value.ToString("M/d/yyyy")
                caraMasuk = cbCaraMasuk.SelectedItem
                Dim query As String = "UPDATE [register_masuk] SET [id_tempat_tidur]=@idTempatTidur, [tanggal_masuk]=@tanggalMasuk, [cara_pasien_masuk]=@caraMasuk WHERE id=@id"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@idTempatTidur", IdTempatTidur)
                cmd.Parameters.AddWithValue("@tanggalMasuk", tanggalMasuk)
                cmd.Parameters.AddWithValue("@caraMasuk", caraMasuk)
                cmd.Parameters.AddWithValue("@id", idRegMasuk)
                Dim result As Integer = cmd.ExecuteNonQuery
                If result > 0 Then
                    If cbRuangan.SelectedItem = namaRuangan And cbKelas.SelectedItem = namaKelas Then
                    Else
                        UpdateTempatTidur(IdTempatTidur, "-")
                        getTempatTidur(namaRuangan, namaKelas)
                        UpdateTempatTidur(IdTempatTidur, "+")
                        namaRuangan = cbRuangan.SelectedItem
                        namaKelas = cbKelas.SelectedItem
                    End If
                    MsgBox("Data berhasil diubah")
                Else
                    MsgBox("Data gagal diubah")
                End If
            Else
                MsgBox("Koneksi database gagal!")
            End If
        Else
            MsgBox("Data gagal disimpan!, tempat tidur penuh!")
        End If
    End Sub
End Class
Imports System.Data.OleDb
Public Class RegisterMasukEditForm
    Dim idRegMasuk As String

    Public Sub New(ByVal id As String, ByVal medrec As String, ByVal nama As String, ByVal tanggal As Date, ByVal ruangan As String, ByVal kelas As String, ByVal caraMasuk As String)
        InitializeComponent()
        idRegMasuk = id
        tbMedrec.Text = medrec
        tbNama.Text = nama
        dtpTanggal.Value = tanggal
        cbRuangan.SelectedItem = ruangan
        cbKelas.SelectedItem = kelas
        cbCaraMasuk.SelectedItem = caraMasuk
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            RegisterMasukForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            Dim tanggalMasuk, ruangan, kelas, caraMasuk As String
            tanggalMasuk = dtpTanggal.Value.ToString("M/d/yyyy")
            ruangan = cbRuangan.SelectedIndex + 1
            kelas = cbKelas.SelectedIndex + 1
            caraMasuk = cbCaraMasuk.SelectedItem
            Dim query As String = "UPDATE [register_masuk] SET [id_ruangan]=@ruangan, [id_kelas]=@kelas, [tanggal_masuk]=@tanggalMasuk, [cara_pasien_masuk]=@caraMasuk WHERE id=@id"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@ruangan", ruangan)
            cmd.Parameters.AddWithValue("@kelas", kelas)
            cmd.Parameters.AddWithValue("@tanggalMasuk", tanggalMasuk)
            cmd.Parameters.AddWithValue("@caraMasuk", caraMasuk)
            cmd.Parameters.AddWithValue("@id", idRegMasuk)
            Dim result As Integer = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("Data berhasil diubah")
            Else
                MsgBox("Data gagal diubah")
            End If
        Else
            MsgBox("Koneksi database gagal!")
        End If
    End Sub
End Class
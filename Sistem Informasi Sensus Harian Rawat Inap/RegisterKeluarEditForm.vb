Imports System.Data.OleDb
Public Class RegisterKeluarEditForm
    Dim idRegKeluar As String

    Public Sub New(ByVal id As String, ByVal idRegMasuk As String, ByVal medrec As String, ByVal nama As String, ByVal tanggal As Date, ByVal caraKeluar As String)
        InitializeComponent()
        idRegKeluar = id
        tbId.Text = idRegMasuk
        tbMedrec.Text = medrec
        tbNama.Text = nama
        dtpTanggal.Value = tanggal
        cbCaraKeluar.SelectedItem = caraKeluar
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            RegisterKeluarForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            Dim tanggalKeluar, caraKeluar As String
            tanggalKeluar = dtpTanggal.Value.ToString("M/d/yyyy")
            caraKeluar = cbCaraKeluar.SelectedItem
            Dim query As String = "UPDATE [register_keluar] SET [tanggal_keluar]=@tanggalKeluar, [cara_pasien_keluar]=@caraKeluar WHERE id=@id"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@tanggalKeluar", tanggalKeluar)
            cmd.Parameters.AddWithValue("@caraKeluar", caraKeluar)
            cmd.Parameters.AddWithValue("@id", idRegKeluar)
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
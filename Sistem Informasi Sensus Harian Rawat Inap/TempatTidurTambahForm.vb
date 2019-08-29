Imports System.Data.OleDb
Public Class TempatTidurTambahForm

    Private Sub TempatTidurTambahForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        rbRuangan.Checked = True
        tbKelas.Enabled = False
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            TempatTidurForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub rbRuangan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRuangan.CheckedChanged
        tbRuangan.Enabled = True
        tbKelas.Enabled = False
        tbRuangan.Text = ""
        tbKelas.Text = ""
    End Sub

    Private Sub rbKelas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbKelas.CheckedChanged
        tbRuangan.Enabled = False
        tbKelas.Enabled = True
        tbRuangan.Text = ""
        tbKelas.Text = ""
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        Dim cmd As New OleDbCommand
        Dim query, nama As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
            If rbRuangan.Checked Then
                query = "SELECT id FROM ruangan WHERE ruangan=@nama"
                nama = tbRuangan.Text
            Else
                query = "SELECT id FROM kelas WHERE kelas=@nama"
                nama = tbKelas.Text
            End If

            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", nama)
            Dim result As OleDbDataReader = cmd.ExecuteReader
            If result.Read Then
                MsgBox(nama & " sudah ada")
            Else
                If rbRuangan.Checked Then
                    query = "INSERT INTO ruangan (ruangan) VALUES (@nama)"
                Else
                    query = "INSERT INTO kelas (kelas) VALUES (@nama)"
                End If
                cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@nama", nama)

                Dim result2 As Integer = cmd.ExecuteNonQuery
                If result2 > 0 Then
                    MsgBox("Data berhasil ditambahkan")
                    btnBersihkan_Click(Me, e)
                Else
                    MsgBox("Data gagal ditambahkan")
                End If
            End If
        Else
            MsgBox("Koneksi database gagal!")
        End If
    End Sub

    Private Sub btnBersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersihkan.Click
        tbRuangan.Text = ""
        tbKelas.Text = ""
    End Sub
End Class
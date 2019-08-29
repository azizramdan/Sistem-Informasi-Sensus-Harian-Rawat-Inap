Imports System.Data.OleDb
Public Class TempatTidurEditForm

    Private Sub TempatTidurEditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        rbRuangan.Checked = True
        getnama()
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            TempatTidurForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRuangan.CheckedChanged
        lbLama.Text = "Nama ruangan lama"
        lbBaru.Text = "Nama ruangan baru"
        getnama()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbKelas.CheckedChanged
        lbLama.Text = "Nama kelas lama"
        lbBaru.Text = "Nama kelas baru"
        getnama()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        Dim query As String
        Dim cmd As New OleDbCommand

        If conn.State = ConnectionState.Closed Then
            conn.Open()
            If rbRuangan.Checked Then
                query = "SELECT id FROM ruangan WHERE ruangan=@nama"
            Else
                query = "SELECT id FROM kelas WHERE kelas=@nama"
            End If
            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", TextBox1.Text)
            Dim result As OleDbDataReader = cmd.ExecuteReader
            If result.Read Then
                MsgBox(TextBox1.Text & " sudah ada")
            Else
                If rbRuangan.Checked Then
                    query = "UPDATE ruangan SET ruangan=@namaBaru WHERE ruangan=@namaLama"
                Else
                    query = "UPDATE kelas SET kelas=@namaBaru WHERE kelas=@namaLama"
                End If
                cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@namaBaru", TextBox1.Text)
                cmd.Parameters.AddWithValue("@namaLama", ComboBox1.SelectedItem)
                Dim result2 As Integer = cmd.ExecuteNonQuery
                If result2 > 0 Then
                    MsgBox("Data berhasil diubah")
                    TextBox1.Text = ""
                    getnama()
                Else
                    MsgBox("Data gagal diubah")
                End If
            End If
        Else
            MsgBox("Koneksi database gagal!")
        End If
    End Sub
    Sub getnama()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        Dim query As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
            If rbRuangan.Checked Then
                query = "SELECT ruangan FROM ruangan"
            Else
                query = "SELECT kelas FROM kelas"
            End If

            Dim cmd As New OleDbCommand(query, conn)
            Dim result As OleDbDataReader = cmd.ExecuteReader
            While result.Read
                ComboBox1.Items.Add(result.GetValue(0))
            End While
        Else
            MsgBox("Koneksi database gagal!")
        End If
    End Sub
End Class
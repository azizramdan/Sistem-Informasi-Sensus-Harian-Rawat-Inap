Imports System.Data.OleDb
Public Class TempatTidurForm

    Private Sub TempatTidurForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            Tampil()
        End If
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            MenuForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub Tampil(Optional ByVal filter As String = "deleted_at IS NULL")
        Get_semua_tempat_tidurBindingSource.Filter = filter
        Get_semua_tempat_tidurBindingSource.Sort = "id_ruangan"
        Me.Get_semua_tempat_tidurTableAdapter.Fill(Me.DBDataSet.get_semua_tempat_tidur)
        Jumlah()
        getRuanganKelas(RuanganComboBox, KelasComboBox)
    End Sub

    Private Sub Jumlah()
        ToolStripStatusLabel1.Text = "Jumlah data " & Get_semua_tempat_tidurDataGridView.RowCount
    End Sub

    Private Sub Cari()
        Dim cari As String = tbCari.Text
        Dim filter As String
        If cari = "" Then
            Tampil()
        Else
            filter = "deleted_at IS NULL AND (ruangan LIKE '%" & cari & "%' OR kelas LIKE '%" & cari & "%')"
            Tampil(filter)
        End If
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Cari()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        tbCari.Text = ""
        Cari()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            btnTambah.Text = "X"
            RuanganComboBox.Enabled = True
            KelasComboBox.Enabled = True
            RuanganComboBox.Text = ""
            KelasComboBox.Text = ""
            RuanganComboBox.SelectedIndex = -1
            KelasComboBox.SelectedIndex = -1

            JumlahTextBox.Text = "0"
            KosongTextBox.Text = ""
            Get_semua_tempat_tidurDataGridView.Visible = False
            GroupBox2.Visible = False
        Else
            btnTambah.Text = "Tambah"
            RuanganComboBox.Enabled = False
            KelasComboBox.Enabled = False
            Get_semua_tempat_tidurDataGridView.Visible = True
            GroupBox2.Visible = True
            Tampil()
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        Dim query, idRuangan, idKelas As String
        Dim cmd As New OleDbCommand

        idRuangan = RuanganComboBox.SelectedIndex + 1
        idKelas = KelasComboBox.SelectedIndex + 1

        If btnTambah.Text = "X" Then
            Dim namaRuangan, namaKelas, jmlTempatTidur As String
            namaRuangan = RuanganComboBox.SelectedItem
            namaKelas = KelasComboBox.SelectedItem
            jmlTempatTidur = JumlahTextBox.Text

            If namaRuangan = "" Or namaKelas = "" Or jmlTempatTidur = "" Then
                MsgBox("Data harus diisi semua")
            Else
                If conn.State = ConnectionState.Closed Then
                    conn.Open()

                    query = "SELECT id FROM tempat_tidur WHERE id_ruangan=@idRuangan AND id_kelas=@idKelas"
                    cmd = New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idRuangan", idRuangan)
                    cmd.Parameters.AddWithValue("@idKelas", idKelas)
                    Dim result As OleDbDataReader = cmd.ExecuteReader
                    If result.Read Then
                        MsgBox("Data dengan ruangan " & namaRuangan & " dan kelas " & namaKelas & " sudah ada")
                    Else
                        query = "INSERT INTO tempat_tidur (id_ruangan, id_kelas, jumlah, kosong) "
                        query &= "VALUES (@idRuangan, @idKelas, @jumlah, @kosong)"
                        cmd = New OleDbCommand(query, conn)
                        cmd.Parameters.AddWithValue("@idRuangan", idRuangan)
                        cmd.Parameters.AddWithValue("@idKelas", idKelas)
                        cmd.Parameters.AddWithValue("@jumlah", jmlTempatTidur)
                        cmd.Parameters.AddWithValue("@kosong", jmlTempatTidur)
                        Dim result2 As Integer = cmd.ExecuteNonQuery
                        If result2 > 0 Then
                            MsgBox("Data berhasil disimpan")
                            btnTambah.Text = "Tambah"
                            RuanganComboBox.Enabled = False
                            KelasComboBox.Enabled = False
                            Get_semua_tempat_tidurDataGridView.Visible = True
                            GroupBox2.Visible = True
                            Tampil()
                        Else
                            MsgBox("Data gagal disimpan")
                        End If
                    End If
                End If
            End If
        Else
            Dim tempatTidurTerpakai, kosong As String
            Dim id As String = Get_semua_tempat_tidurDataGridView(0, Get_semua_tempat_tidurDataGridView.CurrentRow.Index).Value
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                query = "SELECT jumlah, jumlah - kosong FROM tempat_tidur WHERE id=@id"
                cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Dim result As OleDbDataReader = cmd.ExecuteReader
                If result.Read Then
                    tempatTidurTerpakai = result.GetValue(1)
                    If JumlahTextBox.Text = result.GetValue(0) Then

                    ElseIf JumlahTextBox.Text < tempatTidurTerpakai Then
                        MsgBox("Jumlah tempat tidur tidak mencukupi")
                        JumlahTextBox.Text = result.GetValue(0)
                    Else
                        If result.GetValue(0) < JumlahTextBox.Text Then
                            kosong = "+" & JumlahTextBox.Text - result.GetValue(0)
                        Else
                            kosong = "-" & result.GetValue(0) - JumlahTextBox.Text
                        End If
                        query = "UPDATE tempat_tidur SET jumlah=@jumlah, kosong=kosong" & kosong & " WHERE id=@id"
                        cmd = New OleDbCommand(query, conn)
                        cmd.Parameters.AddWithValue("@jumlah", JumlahTextBox.Text)
                        cmd.Parameters.AddWithValue("@id", id)
                        Dim result2 As Integer = cmd.ExecuteNonQuery
                        If result2 > 0 Then
                            MsgBox("Data berhasil disimpan")
                            Tampil()
                        Else
                            MsgBox("Data gagal disimpan")
                        End If
                    End If
                End If
            Else
                MsgBox("Koneksi database gagal!")
            End If
        End If
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        ShowCenter(Me, TempatTidurTambahForm)
    End Sub

    Private Sub EditRuanganKelasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditRuanganKelasToolStripMenuItem.Click
        ShowCenter(Me, TempatTidurEditForm)
    End Sub
End Class
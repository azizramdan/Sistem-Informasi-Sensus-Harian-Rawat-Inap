Imports System.Data.OleDb
Public Class RegisterMasukForm
    Private Sub RegisterMasukForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        tbCari.Text = ""
        Cari()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Cari()
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        ShowCenter(Me, RegisterMasukTambahForm)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim id As String = Register_masuk_QueryDataGridView(0, Register_masuk_QueryDataGridView.CurrentRow.Index).Value
        Dim medrec As String = Register_masuk_QueryDataGridView(1, Register_masuk_QueryDataGridView.CurrentRow.Index).Value
        Dim nama As String = Register_masuk_QueryDataGridView(2, Register_masuk_QueryDataGridView.CurrentRow.Index).Value
        Dim tanggal As Date = Register_masuk_QueryDataGridView(3, Register_masuk_QueryDataGridView.CurrentRow.Index).Value
        Dim ruangan As String = Register_masuk_QueryDataGridView(4, Register_masuk_QueryDataGridView.CurrentRow.Index).Value
        Dim kelas As String = Register_masuk_QueryDataGridView(5, Register_masuk_QueryDataGridView.CurrentRow.Index).Value
        Dim dokter As String = Register_masuk_QueryDataGridView(6, Register_masuk_QueryDataGridView.CurrentRow.Index).Value
        Dim caraMasuk As String = Register_masuk_QueryDataGridView(7, Register_masuk_QueryDataGridView.CurrentRow.Index).Value

        Dim form As New RegisterMasukEditForm(id, medrec, nama, tanggal, ruangan, kelas, dokter, caraMasuk)
        ShowCenter(Me, form)
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim response As MsgBoxResult
        response = MsgBox("Apakah Anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            Dim ruangan As String = Register_masuk_QueryDataGridView(4, Register_masuk_QueryDataGridView.CurrentRow.Index).Value
            Dim kelas As String = Register_masuk_QueryDataGridView(5, Register_masuk_QueryDataGridView.CurrentRow.Index).Value
            getTempatTidur(ruangan, kelas)
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim now As Date = Today
                Dim id As String = Register_masuk_QueryDataGridView(0, Register_masuk_QueryDataGridView.CurrentRow.Index).Value
                Dim query As String = "UPDATE [register_masuk], [tempat_tidur] SET register_masuk.deleted_at=@now, tempat_tidur.kosong=tempat_tidur.kosong+1 WHERE register_masuk.id=@id AND tempat_tidur.id=@IdTempatTidur"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@now", now.ToString("M/d/yyyy"))
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@IdTempatTidur", IdTempatTidur)
                Dim result As Integer = cmd.ExecuteNonQuery
                If result > 0 Then
                    MsgBox("Data berhasil dihapus")
                    Tampil()
                Else
                    MsgBox("Data gagal dihapus")
                End If
            Else
                MsgBox("Koneksi database gagal!")
            End If
        End If
    End Sub

    Private Sub Tampil(Optional ByVal filter As String = "deleted_at IS NULL")
        Register_masuk_QueryBindingSource.Filter = filter
        Register_masuk_QueryBindingSource.Sort = "id"
        Me.Register_masuk_QueryTableAdapter.Fill(Me.DBDataSet.register_masuk_Query)
        Jumlah()
    End Sub

    Private Sub Cari()
        Dim cari As String = tbCari.Text
        Dim filter As String
        If cari = "" Then
            Tampil()
        Else
            filter = "deleted_at IS NULL AND (no_medrec = '" & cari & "' OR pasien_nama_lengkap LIKE '%" & cari & "%')"
            Tampil(filter)
        End If
    End Sub

    Private Sub Jumlah()
        ToolStripStatusLabel1.Text = "Jumlah data " & Register_masuk_QueryDataGridView.RowCount
    End Sub
End Class
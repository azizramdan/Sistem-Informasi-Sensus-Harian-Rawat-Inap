﻿Imports System.Data.OleDb
Public Class RegisterKeluarForm
    Private Sub RegisterKeluarForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        ShowCenter(Me, RegisterKeluarTambahForm)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim id As String = Register_keluar_QueryDataGridView(0, Register_keluar_QueryDataGridView.CurrentRow.Index).Value
        Dim idRegMasuk As String = Register_keluar_QueryDataGridView(1, Register_keluar_QueryDataGridView.CurrentRow.Index).Value
        Dim medrec As String = Register_keluar_QueryDataGridView(2, Register_keluar_QueryDataGridView.CurrentRow.Index).Value
        Dim nama As String = Register_keluar_QueryDataGridView(3, Register_keluar_QueryDataGridView.CurrentRow.Index).Value
        Dim tanggal As Date = Register_keluar_QueryDataGridView(4, Register_keluar_QueryDataGridView.CurrentRow.Index).Value
        Dim caraKeluar As String = Register_keluar_QueryDataGridView(6, Register_keluar_QueryDataGridView.CurrentRow.Index).Value

        Dim form As New RegisterKeluarEditForm(id, idRegMasuk, medrec, nama, tanggal, caraKeluar)
        ShowCenter(Me, form)
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim response As MsgBoxResult
        response = MsgBox("Apakah Anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim now As Date = Today
                Dim id As String = Register_keluar_QueryDataGridView(0, Register_keluar_QueryDataGridView.CurrentRow.Index).Value
                Dim idRegMasuk As String = Register_keluar_QueryDataGridView(1, Register_keluar_QueryDataGridView.CurrentRow.Index).Value
                Dim query As String = "UPDATE register_keluar, register_masuk, tempat_tidur SET register_keluar.deleted_at = @now, register_masuk.keluar = False, tempat_tidur.kosong = tempat_tidur.kosong-1 WHERE (((register_keluar.id)=[@id]) AND ((register_masuk.id)=[@idRegMasuk]) AND ((tempat_tidur.id)=[register_masuk].[id_tempat_tidur]))"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@now", now.ToString("M/d/yyyy"))
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@idRegMasuk", idRegMasuk)
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
        Register_keluar_QueryBindingSource.Filter = filter
        Register_keluar_QueryBindingSource.Sort = "id"
        Me.Register_keluar_QueryTableAdapter.Fill(Me.DBDataSet.register_keluar_Query)
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
        ToolStripStatusLabel1.Text = "Jumlah data " & Register_keluar_QueryDataGridView.RowCount
    End Sub
End Class
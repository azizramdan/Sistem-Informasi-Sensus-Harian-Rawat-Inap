﻿Imports System.Data.OleDb
Public Class PasienForm
    Private Sub PasienForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Cari()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        tbCari.Text = ""
        Cari()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Simpan()
        MsgBox("Data berhasil disimpan")
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        ShowCenter(Me, PasienTambahForm)
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
                Dim medrec As String = PasienDataGridView(0, PasienDataGridView.CurrentRow.Index).Value
                Dim query As String = "UPDATE [pasien] SET [deleted_at]=@now WHERE no_medrec=@medrec"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@now", now.ToString("M/d/yyyy"))
                cmd.Parameters.AddWithValue("@medrec", medrec)
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

    Private Sub Simpan()
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDataSet)
        Jumlah()
    End Sub

    Private Sub Tampil(Optional ByVal filter As String = "deleted_at IS NULL")
        PasienBindingSource.Filter = filter
        PasienBindingSource.Sort = "no_medrec"
        Me.PasienTableAdapter.Fill(Me.DBDataSet.pasien)
        Jumlah()
    End Sub

    Private Sub Cari()
        Dim cari As String = tbCari.Text
        Dim filter As String
        If cari = "" Then
            Tampil()
        Else
            filter = "deleted_at IS NULL AND (no_medrec = '" & cari & "' OR nama_lengkap LIKE '%" & cari & "%')"
            Tampil(filter)
        End If
    End Sub

    Private Sub Jumlah()
        ToolStripStatusLabel1.Text = "Jumlah data " & PasienDataGridView.RowCount
    End Sub
End Class
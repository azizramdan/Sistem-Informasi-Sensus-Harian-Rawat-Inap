Public Class PasienForm
    Dim DataChanged As Boolean

    Private Sub PasienForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.pasien' table. You can move, or remove it, as needed.
        connect()
        Me.PasienTableAdapter.Fill(Me.DBDataSet.pasien)
        Jumlah()
        DataChanged = False
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If DataChanged Then
            Dim response As MsgBoxResult
            response = MsgBox("Data belum disimpan, keluar tanpa menyimpan data?", MsgBoxStyle.YesNo)
            If response = MsgBoxResult.Yes Then
                MenuForm.Show()
                e.Cancel = False
            End If
        Else
            If e.CloseReason = CloseReason.UserClosing Then
                MenuForm.Show()
                e.Cancel = False
            End If
        End If
        'If e.CloseReason = CloseReason.UserClosing Then
        '    MenuForm.Show()
        '    e.Cancel = False
        'End If
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
        PasienTambahForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim response As MsgBoxResult
        response = MsgBox("Apakah Anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            Dim index As Integer
            index = PasienDataGridView.CurrentCell.RowIndex
            PasienDataGridView.Rows.RemoveAt(index)
            Simpan()
        End If
    End Sub

    Private Sub Jumlah()
        ToolStripStatusLabel1.Text = "Jumlah data " & PasienDataGridView.RowCount
    End Sub

    Private Sub Cari()
        Dim filter As String = tbCari.Text
        If filter = "" Then
            PasienBindingSource.RemoveFilter()
        Else
            PasienBindingSource.Filter = "no_medrec = '" & filter & "' OR nama_lengkap LIKE '%" & filter & "%'"
        End If
        Me.PasienTableAdapter.Fill(Me.DBDataSet.pasien)
        Jumlah()
    End Sub

    Private Sub Simpan()
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDataSet)
        Jumlah()
    End Sub
End Class
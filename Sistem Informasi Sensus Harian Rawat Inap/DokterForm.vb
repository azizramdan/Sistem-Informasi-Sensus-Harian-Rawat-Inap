Public Class DokterForm
    Dim DataChanged As Boolean

    Private Sub DokterForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet1.dokter' table. You can move, or remove it, as needed.
        connect()
        Me.DokterTableAdapter.Fill(Me.DBDataSet.dokter)
        Jumlah()
    End Sub

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            Me.DokterTableAdapter.Fill(Me.DBDataSet.dokter)
        End If
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            MenuForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        ShowCenter(Me, DokterTambahForm)
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Simpan()
        MsgBox("Data berhasil disimpan")
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim response As MsgBoxResult
        response = MsgBox("Apakah Anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            Dim index As Integer
            index = DokterDataGridView.CurrentCell.RowIndex
            DokterDataGridView.Rows.RemoveAt(index)
            Simpan()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        tbCari.Text = ""
        Cari()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Cari()
    End Sub

    Private Sub Jumlah()
        ToolStripStatusLabel1.Text = "Jumlah data " & DokterDataGridView.RowCount
    End Sub

    Private Sub Cari()
        Dim filter As String = tbCari.Text
        If filter = "" Then
            DokterBindingSource.RemoveFilter()
        Else
            DokterBindingSource.Filter = "sip = '" & filter & "' OR nama_lengkap LIKE '%" & filter & "%'"
        End If
        Me.DokterTableAdapter.Fill(Me.DBDataSet.dokter)
        Jumlah()
    End Sub

    Private Sub Simpan()
        Me.Validate()
        Me.DokterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDataSet)
        Jumlah()
    End Sub
End Class
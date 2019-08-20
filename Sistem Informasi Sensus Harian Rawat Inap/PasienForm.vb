Public Class PasienForm
    Dim DataChanged As Boolean
    Private Sub PasienBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDataSet)
    End Sub

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

    Private Sub PasienDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles PasienDataGridView.CellValueChanged
        DataChanged = True
    End Sub

    Private Sub PasienDataGridView_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles PasienDataGridView.CurrentCellDirtyStateChanged
        DataChanged = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Cari()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox8.Text = ""
        Cari()
    End Sub

    Private Sub Jumlah()
        ToolStripStatusLabel1.Text = "Jumlah data " & PasienDataGridView.RowCount
    End Sub

    Private Sub Cari()
        Dim filter As String = TextBox8.Text
        If filter = "" Then
            PasienBindingSource.RemoveFilter()
        Else
            PasienBindingSource.Filter = "no_medrec = '" & filter & "' OR nama_lengkap LIKE '%" & filter & "%'"
        End If
        Me.PasienTableAdapter.Fill(Me.DBDataSet.pasien)
        Jumlah()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDataSet)
        MsgBox("Data berhasil disimpan")
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        PasienTambahForm.Show()
        Me.Hide()
    End Sub
End Class
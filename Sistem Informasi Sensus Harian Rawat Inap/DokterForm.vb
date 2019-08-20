Public Class DokterForm
    Dim DataChanged As Boolean
    Private Sub DokterForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.dokter' table. You can move, or remove it, as needed.
        connect()
        Me.DokterTableAdapter.Fill(Me.DBDataSet.dokter)
        Jumlah()
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

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        DokterTambahForm.Show()
        Me.Hide()
    End Sub
    Private Sub Jumlah()
        ToolStripStatusLabel1.Text = "Jumlah data " & DokterDataGridView.RowCount
    End Sub

    Private Sub Cari()
        Dim filter As String = TextBox4.Text
        If filter = "" Then
            DokterBindingSource.RemoveFilter()
        Else
            DokterBindingSource.Filter = "sip = '" & filter & "' OR nama_lengkap LIKE '%" & filter & "%'"
        End If
        Me.DokterTableAdapter.Fill(Me.DBDataSet.dokter)
        Jumlah()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.DokterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDataSet)
        MsgBox("Data berhasil disimpan")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox4.Text = ""
        Cari()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Cari()
    End Sub
End Class
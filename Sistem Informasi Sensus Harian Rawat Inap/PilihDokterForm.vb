Public Class PilihDokterForm
    Public Property sip As String
    Public Property nama As String

    Private Sub DokterBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DokterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDataSet)
    End Sub

    Private Sub PilihDokterForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            Tampil()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        tbCari.Text = ""
        Cari()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Cari()
    End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        Me.sip = DokterDataGridView(0, DokterDataGridView.CurrentRow.Index).Value
        Me.nama = DokterDataGridView(1, DokterDataGridView.CurrentRow.Index).Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Cari()
        Dim cari As String = tbCari.Text
        Dim filter As String
        If cari = "" Then
            Tampil()
        Else
            filter = "deleted_at IS NULL AND (sip = '" & cari & "' OR nama_lengkap LIKE '%" & cari & "%')"
            Tampil(filter)
        End If
    End Sub

    Private Sub Tampil(Optional ByVal filter As String = "deleted_at IS NULL")
        DokterBindingSource.Filter = filter
        DokterBindingSource.Sort = "sip"
        Me.DokterTableAdapter.Fill(Me.DBDataSet.dokter)
    End Sub
End Class
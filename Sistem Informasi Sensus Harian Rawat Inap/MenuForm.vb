Public Class MenuForm

    Private Sub MenuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Image()
        PictureBox1.ImageLocation = ImagePath & "hospital.jpg"
    End Sub
    Private Sub MenuForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = False
            End
        End If
    End Sub

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        ShowCenter(Me, UserForm)
    End Sub

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienToolStripMenuItem.Click
        ShowCenter(Me, PasienForm)
    End Sub

    Private Sub DokterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DokterToolStripMenuItem.Click
        ShowCenter(Me, DokterForm)
    End Sub

    Private Sub RegisterPasienMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterPasienMasukToolStripMenuItem.Click
        ShowCenter(Me, RegisterMasukForm)
    End Sub

    Private Sub RegisterPasienKeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterPasienKeluarToolStripMenuItem.Click
        ShowCenter(Me, RegisterKeluarForm)
    End Sub

    Private Sub SensusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SensusToolStripMenuItem.Click
        ShowCenter(Me, SensusForm)
    End Sub

    Private Sub PasienMasukRawatInapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienMasukRawatInapToolStripMenuItem.Click
        ShowCenter(Me, LaporanMasukForm)
    End Sub

    Private Sub PasienKeluarRawatInapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienKeluarRawatInapToolStripMenuItem.Click
        ShowCenter(Me, LaporanKeluarForm)
    End Sub
End Class
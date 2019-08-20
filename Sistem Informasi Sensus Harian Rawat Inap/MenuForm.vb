Public Class MenuForm
    Private Sub MenuForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = False
            End
        End If
    End Sub

    Private Sub btnTempatTidur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTempatTidur.Click
        TempatTidurForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnPasien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasien.Click
        PasienForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDokter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDokter.Click
        DokterForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnPasienMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasienMasuk.Click
        RegisterMasukForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnPasienKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasienKeluar.Click
        RegisterKeluarForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSensus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSensus.Click

    End Sub
End Class
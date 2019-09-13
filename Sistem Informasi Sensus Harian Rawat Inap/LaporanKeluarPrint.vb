Public Class LaporanKeluarPrint
    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            LaporanKeluarForm.Show()
            e.Cancel = False
        End If
    End Sub
End Class
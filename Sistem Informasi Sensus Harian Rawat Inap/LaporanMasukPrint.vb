Public Class LaporanMasukPrint

    Private Sub LaporanMasukPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            LaporanMasukForm.Show()
            e.Cancel = False
        End If
    End Sub
End Class
Imports System.Data.OleDb
Public Class UserForm
    Private Sub UserForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        NikTextBox.Text = Nik
        Nama_lengkapTextBox.Text = Nama
        UsernameTextBox.Text = Username
    End Sub
    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            MenuForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If PasswordTextBox.Text <> "" Or KonfirmasiPasswordTextBox.Text <> "" Then
            If PasswordTextBox.Text <> KonfirmasiPasswordTextBox.Text Then
                MsgBox("Konfirmasi password tidak sama")
            Else
                Dim source As String = My.Settings.DBConnectionString
                Dim conn = New OleDbConnection(source)
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                    Dim pass As String = PasswordTextBox.Text
                    Dim query As String = "UPDATE [user] SET [password]=@password WHERE id=@id"
                    Dim cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@password", pass)
                    cmd.Parameters.AddWithValue("@id", Id)
                    Dim result As Integer = cmd.ExecuteNonQuery
                    If result > 0 Then
                        MsgBox("Password berhasil diganti")
                    Else
                        MsgBox("Password gagal diganti")
                    End If
                Else
                    MsgBox("Koneksi database gagal!")
                End If
            End If
        End If

    End Sub
End Class
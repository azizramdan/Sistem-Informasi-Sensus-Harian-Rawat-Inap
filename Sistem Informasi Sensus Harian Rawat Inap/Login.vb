Imports System.Data.OleDb

Public Class Login
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        Dim akun As String = "admin1"
        tbUsername.Text = akun
        tbPassword.Text = akun
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If tbUsername.Text = "" Or tbPassword.Text = "" Then
            MsgBox("Username dan Password harus diisi!")
        Else
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim username As String = tbUsername.Text
                Dim password As String = tbPassword.Text
                Dim query As String = "SELECT id FROM [user] WHERE username=@username AND password=@password"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Dim result As OleDbDataReader = cmd.ExecuteReader
                If result.Read Then
                    Dim form As New MenuForm
                    form.Show()
                    Me.Close()
                Else
                    MsgBox("Login gagal")
                End If
            Else
                MsgBox("Koneksi database gagal!")
            End If
        End If
    End Sub
End Class

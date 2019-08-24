Imports System.Data.OleDb

Public Class Login
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        Image()
        PictureBox1.ImageLocation = ImagePath & "user-login.png"
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
                Dim query As String = "SELECT * FROM [user] WHERE username=@username AND password=@password"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Dim result As OleDbDataReader = cmd.ExecuteReader
                If result.Read Then
                    Dim id As Integer
                    Dim nik, nama, uname As String
                    id = result.GetInt32(0)
                    nik = result.GetString(1)
                    nama = result.GetString(2)
                    uname = result.GetString(3)
                    UserData(id, nik, nama, uname)
                    Dim form As New MenuForm
                    ShowMenu(form)
                Else
                    MsgBox("Login gagal")
                End If
            Else
                MsgBox("Koneksi database gagal!")
            End If
            conn.Close()
        End If
    End Sub

    Sub ShowMenu(ByVal form As Form)
        form.StartPosition = FormStartPosition.Manual
        Dim x As Integer = Me.Location.X + Me.Width / 2 - form.Width / 2
        Dim y As Integer = Me.Location.Y + Me.Height / 2 - form.Height / 2
        If x < 0 Then
            x = 0
        End If
        If y < 0 Then
            y = 0
        End If
        form.Location = New Point(x, y)
        form.Show()
        Me.Close()
    End Sub
End Class

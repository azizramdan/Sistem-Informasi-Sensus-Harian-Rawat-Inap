Imports System.Data.OleDb
Module Connection
    Public ImagePath As String
    Public Id As Integer
    Public Nik, Nama, Username As String
    Public IsKosong As Boolean
    Public IdTempatTidur As String
    Sub connect()
        Dim path As String = AppDomain.CurrentDomain.BaseDirectory
        path = path.Replace("bin\Debug\", "SISHRI.accdb")
        My.Settings("DBConnectionString") = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & path
    End Sub

    Sub Image()
        ImagePath = AppDomain.CurrentDomain.BaseDirectory
        ImagePath = ImagePath.Replace("bin\Debug\", "assets\")
    End Sub

    Sub UserData(ByVal _id As Integer, ByVal _nik As String, ByVal _nama As String, ByVal _username As String)
        Id = _id
        Nik = _nik
        Nama = _nama
        Username = _username
    End Sub

    Sub ShowCenter(ByVal form1 As Form, ByVal form2 As Form)
        form2.StartPosition = FormStartPosition.Manual
        Dim x As Integer = form1.Location.X + form1.Width / 2 - form2.Width / 2
        Dim y As Integer = form1.Location.Y + form1.Height / 2 - form2.Height / 2
        If x < 0 Then
            x = 0
        End If
        If y < 0 Then
            y = 0
        End If
        form2.Location = New Point(x, y)
        form2.Show()
        form1.Hide()
    End Sub

    Function UpdateTempatTidur(ByVal id As String, ByVal op As String)
        Dim ret As Boolean
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            Dim query As String = "UPDATE tempat_tidur SET kosong = kosong " & op & " 1 WHERE id=@id"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", id)
            Dim result As Integer = cmd.ExecuteNonQuery
            If result > 0 Then
                ret = True
            Else
                ret = False
            End If
        Else
            MsgBox("Koneksi database gagal!")
        End If
        Return ret
    End Function

    Sub getTempatTidur(ByVal ruangan As String, ByVal kelas As String)
        IsKosong = False
        IdTempatTidur = 0
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            Dim query As String = "SELECT tempat_tidur.id, tempat_tidur.kosong FROM tempat_tidur, ruangan, kelas WHERE tempat_tidur.id_ruangan = ruangan.id AND tempat_tidur.id_kelas = kelas.id AND ruangan.ruangan = @ruangan AND kelas.kelas = @kelas"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@ruangan", ruangan)
            cmd.Parameters.AddWithValue("@kelas", kelas)
            Dim result As OleDbDataReader = cmd.ExecuteReader
            If result.Read Then
                If result.GetValue(1) = 0 Then
                    IsKosong = False
                Else
                    IsKosong = True
                    IdTempatTidur = result.GetValue(0)
                End If
            End If
        Else
            MsgBox("Koneksi database gagal!")
        End If
    End Sub
    Sub getRuanganKelas(ByVal ruangan As ComboBox, ByVal kelas As ComboBox)
        Dim source As String = My.Settings.DBConnectionString
        Dim conn = New OleDbConnection(source)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            Dim query As String = "SELECT ruangan FROM ruangan"
            Dim cmd As New OleDbCommand(query, conn)
            Dim result As OleDbDataReader = cmd.ExecuteReader
            While result.Read
                ruangan.Items.Add(result.GetValue(0))
            End While

            query = "SELECT kelas FROM kelas"
            cmd = New OleDbCommand(query, conn)
            result = cmd.ExecuteReader
            While result.Read
                kelas.Items.Add(result.GetValue(0))
            End While
        Else
            MsgBox("Koneksi database gagal!")
        End If
    End Sub
End Module

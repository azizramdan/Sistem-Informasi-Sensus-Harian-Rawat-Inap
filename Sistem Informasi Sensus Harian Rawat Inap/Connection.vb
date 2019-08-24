Module Connection
    Public ImagePath As String
    Public Id As Integer
    Public Nik, Nama, Username As String
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
        form2.Location = New Point(form1.Location.X + form1.Width / 2 - form2.Width / 2, form1.Location.Y + form1.Height / 2 - form2.Height / 2)
        form2.Show()
        form1.Hide()
    End Sub
End Module

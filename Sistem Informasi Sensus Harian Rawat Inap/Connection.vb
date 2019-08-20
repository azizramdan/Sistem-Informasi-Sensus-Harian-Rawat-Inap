Module Connection
    Sub connect()
        Dim path As String = AppDomain.CurrentDomain.BaseDirectory
        path = path.Replace("bin\Debug\", "SISHRI.accdb")
        My.Settings("DBConnectionString") = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & path
    End Sub
End Module

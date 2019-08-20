Imports System.Data.OleDb
Public Class PasienTambahForm
    Private Sub PasienTambahForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            PasienForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim medrec, nama, tempat, tanggal, alamat, telp, agama, status, pekerjaan, ayah, ibu
        medrec = TextBox1.Text
        nama = TextBox2.Text
        tempat = TextBox3.Text
        tanggal = DateTimePicker1.Value.ToString("M/d/yyyy")
        alamat = RichTextBox1.Text
        telp = TextBox4.Text
        agama = ComboBox1.SelectedItem
        status = ComboBox2.SelectedItem
        pekerjaan = TextBox5.Text
        ayah = TextBox6.Text
        ibu = TextBox7.Text
        If medrec = "" Or nama = "" Or tempat = "" Or alamat = "" Or telp = "" Or agama = "" Or status = "" Or pekerjaan = "" Or ayah = "" Or ibu = "" Then
            MsgBox("Data harus diisi semua")
        Else
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim query As String = "SELECT * FROM [pasien] WHERE no_medrec=@medrec"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@medrec", medrec)
                Dim result As OleDbDataReader = cmd.ExecuteReader
                If result.Read Then
                    MsgBox("Gagal! No. Medrec sudah ada!")
                Else
                    query = "INSERT INTO pasien (no_medrec, nama_lengkap, tempat_lahir, tanggal_lahir, alamat, no_telpon, agama, status, pekerjaan, nama_ayah, nama_ibu) "
                    query &= "VALUES (@medrec, @nama, @tempat, @tanggal, @alamat, @telp, @agama, @status, @pekerjaan, @ayah, @ibu)"
                    cmd = New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@medrec", medrec)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@tempat", tempat)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@telp", telp)
                    cmd.Parameters.AddWithValue("@agama", agama)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@pekerjaan", pekerjaan)
                    cmd.Parameters.AddWithValue("@ayah", ayah)
                    cmd.Parameters.AddWithValue("@ibu", ibu)
                    Dim result2 As Integer = cmd.ExecuteNonQuery
                    If result2 > 0 Then
                        MsgBox("Data pasien berhasil disimpan")
                    Else
                        MsgBox("Data pasien gagal disimpan")
                    End If
                End If
            Else
                MsgBox("Koneksi database gagal!")
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        RichTextBox1.Text = ""
        TextBox4.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub
End Class
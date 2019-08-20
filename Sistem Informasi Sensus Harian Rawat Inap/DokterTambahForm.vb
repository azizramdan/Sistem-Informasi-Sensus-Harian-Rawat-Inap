﻿Imports System.Data.OleDb
Public Class DokterTambahForm
    Private Sub DokterTambahForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub
    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            DokterForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sip, nama, alamat, telp, spesialis, status
        sip = TextBox1.Text
        nama = TextBox2.Text
        alamat = RichTextBox1.Text
        telp = TextBox3.Text
        spesialis = ComboBox1.SelectedItem
        status = ComboBox2.SelectedItem

        If sip = "" Or nama = "" Or alamat = "" Or telp = "" Or spesialis = "" Or status = "" Then
            MsgBox("Data harus diisi semua")
        Else
            Dim source As String = My.Settings.DBConnectionString
            Dim conn = New OleDbConnection(source)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim query As String = "SELECT * FROM [dokter] WHERE sip=@sip"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@sip", sip)
                Dim result As OleDbDataReader = cmd.ExecuteReader
                If result.Read Then
                    MsgBox("Gagal! No. SIP sudah ada!")
                Else
                    query = "INSERT INTO dokter (sip, nama_lengkap, alamat, no_telpon, spesialis, status_kepegawaian) "
                    query &= "VALUES (@sip, @nama, @alamat, @telp, @spesialis, @status)"
                    cmd = New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@sip", sip)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@telp", telp)
                    cmd.Parameters.AddWithValue("@spesialis", spesialis)
                    cmd.Parameters.AddWithValue("@status", status)
                    Dim result2 As Integer = cmd.ExecuteNonQuery
                    If result2 > 0 Then
                        MsgBox("Data dokter berhasil disimpan")
                    Else
                        MsgBox("Data dokter gagal disimpan")
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
        RichTextBox1.Text = ""
        TextBox3.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub
End Class
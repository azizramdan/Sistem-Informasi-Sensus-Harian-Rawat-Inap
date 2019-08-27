﻿Public Class LaporanMasukForm
    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure
    Private pages As Dictionary(Of Integer, pageDetails)

    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer
    Dim mRow As Integer = 0
    Dim newpage As Boolean = True

    Dim periode As String
    Private Sub LaporanMasukForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            MenuForm.Show()
            e.Cancel = False
        End If
    End Sub

    Private Sub rbHarian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHarian.CheckedChanged
        dtpTanggal.ShowUpDown = False
        dtpTanggal.Format = DateTimePickerFormat.Custom
        dtpTanggal.CustomFormat = "dddd, d MMMM yyyy"
    End Sub

    Private Sub rbBulanan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBulanan.CheckedChanged
        dtpTanggal.ShowUpDown = True
        dtpTanggal.Format = DateTimePickerFormat.Custom
        dtpTanggal.CustomFormat = "MMMM yyyy"
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        If cbRuangan.SelectedIndex = -1 Or cbKelas.SelectedIndex = -1 Then
            MsgBox("Data harus diisi semua")
        Else
            Dim filter As String
            If rbHarian.Checked Then
                periode = "Periode: " & dtpTanggal.Value.ToString("d MMMM yyyy")
                Dim tglMasuk As String
                tglMasuk = dtpTanggal.Value.ToString("M/d/yyyy")
                filter = "tanggal_masuk = #" & tglMasuk & "#"
            Else
                periode = "Periode: " & dtpTanggal.Value.ToString("MMMM yyyy")
                Dim awalBulan As Date = dtpTanggal.Value.Month & "/1/" & dtpTanggal.Value.Year
                Dim akhirBulan As Date = awalBulan.AddMonths(1)

                filter = "tanggal_masuk >= #" & awalBulan.ToString("M/d/yyyy") & "#"
                filter &= " AND tanggal_masuk <= #" & akhirBulan.ToString("M/d/yyyy") & "#"
            End If

            filter &= " AND ruangan = '" & cbRuangan.SelectedItem & "'"
            filter &= " AND kelas = '" & cbKelas.SelectedItem & "'"
            filter &= " AND deleted_at IS NULL"
            Register_masuk_QueryBindingSource.Filter = filter
            Register_masuk_QueryBindingSource.Sort = "id"
            Me.Register_masuk_QueryTableAdapter.Fill(Me.DBDataSet.register_masuk_Query)
            Jumlah()
            For r As Integer = 1 To Register_masuk_QueryDataGridView.RowCount
                Register_masuk_QueryDataGridView.Rows(r - 1).HeaderCell.Value = r.ToString
            Next
        End If
    End Sub
    Private Sub Jumlah()
        ToolStripStatusLabel1.Text = "Jumlah data " & Register_masuk_QueryDataGridView.RowCount
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Register_masuk_QueryDataGridView.RowCount = 0 Then
            MsgBox("Tidak ada data!")
        Else
            Dim ppd As New PrintPreviewDialog
            ppd.Document = PrintDocument1
            ppd.Document.DefaultPageSettings.Landscape = True
            ppd.WindowState = FormWindowState.Maximized
            ppd.ShowDialog()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim rect As New Rectangle(20, 20, CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width), 50)
        Dim sf As New StringFormat
        Dim rectBottom As Integer
        Dim startX As Integer = 50
        Dim startY As Integer = rect.Bottom

        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString("Laporan Registrasi Pasien Keluar", New Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Black, rect, sf)
        startY += 10
        e.Graphics.DrawString(periode, New Font("Microsoft Sans Serif", 10, FontStyle.Bold), Brushes.Black, New Rectangle(20, startY, CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width), Label1.Height), sf)
        startY += 20
        e.Graphics.DrawString("Ruangan: " & cbRuangan.SelectedItem, New Font("Microsoft Sans Serif", 10, FontStyle.Bold), Brushes.Black, New Rectangle(20, startY, CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width), Label1.Height), sf)
        startY += 20
        e.Graphics.DrawString("Kelas: " & cbKelas.SelectedItem, New Font("Microsoft Sans Serif", 10, FontStyle.Bold), Brushes.Black, New Rectangle(20, startY, CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width), Label1.Height), sf)

        sf.Alignment = StringAlignment.Near
        rectBottom = startY + 35
        startY = rectBottom
        Static startPage As Integer = 0

        For p As Integer = startPage To pages.Count - 1
            Dim cell As New Rectangle(startX, startY, Register_masuk_QueryDataGridView.RowHeadersWidth, Register_masuk_QueryDataGridView.ColumnHeadersHeight)
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
            e.Graphics.DrawRectangle(Pens.Black, cell)

            startY += Register_masuk_QueryDataGridView.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows
                cell = New Rectangle(startX, startY, Register_masuk_QueryDataGridView.RowHeadersWidth, Register_masuk_QueryDataGridView.Rows(r).Height)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(Register_masuk_QueryDataGridView.Rows(r).HeaderCell.Value.ToString, Register_masuk_QueryDataGridView.Font, Brushes.Black, cell, sf)
                startY += Register_masuk_QueryDataGridView.Rows(r).Height
            Next

            startX += cell.Width
            startY = rectBottom

            For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                If Register_masuk_QueryDataGridView.Columns(c).Visible Then
                    cell = New Rectangle(startX, startY, Register_masuk_QueryDataGridView.Columns(c).Width, Register_masuk_QueryDataGridView.ColumnHeadersHeight)
                    e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                    e.Graphics.DrawRectangle(Pens.Black, cell)
                    e.Graphics.DrawString(Register_masuk_QueryDataGridView.Columns(c).HeaderCell.Value.ToString, Register_masuk_QueryDataGridView.Font, Brushes.Black, cell, sf)
                    startX += Register_masuk_QueryDataGridView.Columns(c).Width
                End If
            Next

            startY = rectBottom + Register_masuk_QueryDataGridView.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows
                startX = 50 + Register_masuk_QueryDataGridView.RowHeadersWidth
                For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                    If Register_masuk_QueryDataGridView.Columns(c).Visible Then
                        cell = New Rectangle(startX, startY, Register_masuk_QueryDataGridView.Columns(c).Width, Register_masuk_QueryDataGridView.Rows(r).Height)
                        e.Graphics.DrawRectangle(Pens.Black, cell)
                        If Register_masuk_QueryDataGridView.Columns(c).DataPropertyName = "tanggal_masuk" Then
                            Dim tgl As DateTime = Convert.ToDateTime(Register_masuk_QueryDataGridView(c, r).Value.ToString)
                            e.Graphics.DrawString(tgl.ToString("d MMMM yyyy"), Register_masuk_QueryDataGridView.Font, Brushes.Black, cell, sf)
                        Else
                            e.Graphics.DrawString(Register_masuk_QueryDataGridView(c, r).Value.ToString, Register_masuk_QueryDataGridView.Font, Brushes.Black, cell, sf)
                        End If
                        startX += Register_masuk_QueryDataGridView.Columns(c).Width
                    End If
                Next
                startY += Register_masuk_QueryDataGridView.Rows(r).Height
            Next

            If p <> pages.Count - 1 Then
                startPage = p + 1
                e.HasMorePages = True
                Return
            Else
                startPage = 0
            End If

        Next

    End Sub
    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        ''this removes the printed page margins
        PrintDocument1.OriginAtMargins = True
        PrintDocument1.DefaultPageSettings.Margins = New Drawing.Printing.Margins(0, 0, 0, 0)

        pages = New Dictionary(Of Integer, pageDetails)

        Dim maxWidth As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width)
        Dim maxHeight As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Height) - 40 + Label1.Height

        Dim pageCounter As Integer = 0
        pages.Add(pageCounter, New pageDetails)

        Dim columnCounter As Integer = 0

        Dim columnSum As Integer = Register_masuk_QueryDataGridView.RowHeadersWidth

        For c As Integer = 0 To Register_masuk_QueryDataGridView.Columns.Count - 1
            If columnSum + Register_masuk_QueryDataGridView.Columns(c).Width < maxWidth Then
                columnSum += Register_masuk_QueryDataGridView.Columns(c).Width
                columnCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                columnSum = Register_masuk_QueryDataGridView.RowHeadersWidth + Register_masuk_QueryDataGridView.Columns(c).Width
                columnCounter = 1
                pageCounter += 1
                pages.Add(pageCounter, New pageDetails With {.startCol = c})
            End If
            If c = Register_masuk_QueryDataGridView.Columns.Count - 1 Then
                If pages(pageCounter).columns = 0 Then
                    pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                End If
            End If
        Next

        maxPagesWide = pages.Keys.Max + 1

        pageCounter = 0

        Dim rowCounter As Integer = 0

        Dim rowSum As Integer = Register_masuk_QueryDataGridView.ColumnHeadersHeight

        For r As Integer = 0 To Register_masuk_QueryDataGridView.Rows.Count - 2
            If rowSum + Register_masuk_QueryDataGridView.Rows(r).Height < maxHeight Then
                rowSum += Register_masuk_QueryDataGridView.Rows(r).Height
                rowCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = pages(pageCounter).columns, .rows = rowCounter, .startCol = pages(pageCounter).startCol, .startRow = pages(pageCounter).startRow}
                For x As Integer = 1 To maxPagesWide - 1
                    pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter).startRow}
                Next

                pageCounter += maxPagesWide
                For x As Integer = 0 To maxPagesWide - 1
                    pages.Add(pageCounter + x, New pageDetails With {.columns = pages(x).columns, .rows = 0, .startCol = pages(x).startCol, .startRow = r})
                Next

                rowSum = Register_masuk_QueryDataGridView.ColumnHeadersHeight + Register_masuk_QueryDataGridView.Rows(r).Height
                rowCounter = 1
            End If
            If r = Register_masuk_QueryDataGridView.Rows.Count - 2 Then
                For x As Integer = 0 To maxPagesWide - 1
                    If pages(pageCounter + x).rows = 0 Then
                        pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter + x).startRow}
                    End If
                Next
            End If
        Next

        maxPagesTall = pages.Count \ maxPagesWide

    End Sub
End Class
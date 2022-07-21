Imports System.Data.Odbc

Public Class transaksi2
    Const DSN = "DSN=pegawai"
    Const DSA = "DSN=koperasi"
    Const DSB = "DSN=transaksi"
    Const DSC = "DSN=detail_transaksi"
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim da As OdbcDataAdapter
    Dim df As OdbcDataAdapter
    Dim dr As OdbcDataReader
    Dim ds As DataSet
    Dim table As DataTable

    Sub koneksi()
        conn = New OdbcConnection(DSN)
        conn = New OdbcConnection(DSA)
        conn = New OdbcConnection(DSB)
        conn = New OdbcConnection(DSC)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub tampilkan_data()
        koneksi()
        da = New OdbcDataAdapter("select * from koperasi", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        table = ds.Tables(0)
        conn.Close()
    End Sub
    Sub Auto_Barang()
        koneksi()
        cmd = New OdbcCommand("SELECT nama_barang FROM koperasi", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            With txtbarang
                .AutoCompleteCustomSource.Add(dr(0).ToString)
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        End While
        conn.Close()
    End Sub
    Sub bersihkan()
        txtkode.Text = Format(Now, "ddMMyyyy")
        txtpegawai.Clear()
        txtbarang.Clear()
        txtpusat.Clear()
        txtgolongan.Clear()
        txtjumlah.Text = "0"
        txttotal.Text = "0"
        txtjual.Text = "0"
        DGV.Rows.Clear()
        txtkembalian.Text = "0"
        DTP.Text = Today
    End Sub
    Sub buatkolom()
        With DGV
            .Columns.Add("kode_transaksi", "Kode Transaksi")
            .Columns.Add("tanggal_transaksi", "tanggal Transaksi")
            .Columns.Add("nama", "Nama Pegawai")
            .Columns.Add("nama_barang", "Nama Barang")
            .Columns.Add("jumlah", "jumlah")
            .Columns.Add("sub_harga", "Total Harga")
            .Columns.Add("sub_setelah", "Stok Setelah")
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

    Sub Auto_Supplier()
        koneksi()
        cmd = New OdbcCommand("SELECT nama FROM pegawai", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            With txtpegawai
                .AutoCompleteCustomSource.Add(dr(0).ToString)
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        End While
        conn.Close()
    End Sub

    Sub otomatis()
        koneksi()
        Dim oto As String = Format(Now, "ddMMyyyy")
        txtkode.Text = oto

    End Sub
    Sub bersih_barang()
        txtkode.Text = Format(Now, "ddMMyyyy")
        txtjumlah.Text = "0"
        txttotal.Text = "0"
        txtcash.Text = "0"
        txtkembalian.Text = "0"

        Auto_Barang()
    End Sub
    Sub call_all()
        txtpegawai.Focus()
        bersihkan()
        Auto_Supplier()
        Auto_Barang()
        otomatis()
    End Sub
    Sub total()
        Dim barang, harga, jumlah, total As Integer
        For i As Integer = 0 To DGV.RowCount - 1
            barang += DGV.Item(5, i).Value
            harga += DGV.Rows(i).Cells(4).Value
            total += DGV.Rows(i).Cells(5).Value
            jumlah += DGV.Rows(i).Cells(4).Value
        Next

        txttotal.Text = barang.ToString
        txttotalbarang.Text = harga.ToString
    End Sub

    Private Sub Transaksi2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        call_all()
        buatkolom()
    End Sub

    Private Sub txtjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlah.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(13) And e.KeyChar <> vbBack Then e.Handled = True
    End Sub

    Private Sub txtpegawai_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpegawai.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT no, nama, golongan, pusat FROM pegawai WHERE nama ='" + txtpegawai.Text + "'", conn)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    txtno.Text = dr(0).ToString
                    txtpegawai.Text = dr(1).ToString
                    txtgolongan.Text = dr(2).ToString
                    txtpusat.Text = dr(3).ToString
                End If
                conn.Close()
                txtbarang.Focus()
            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Dim index As Integer
        Dim sub_jumlah As Integer
        Dim sub_harga As Integer = Val(txtjual.Text) * Val(txtjbeli.Text)
        Dim sub_total As Integer = Val(sub_harga.ToString) * Val(sub_jumlah.ToString)
        Dim kembalian As Integer = Val(txtcash.Text) - Val(txttotal.Text)
        txtstok.Text = Val(txtjumlah.Text) - Val(txtjbeli.Text)
        txttotal.Text = Val(txtjual.Text) * Val(txtjbeli.Text)
        txtkode.Text = txtno.Text & "" & txtkode.Text
        If txtpegawai.Text = "" Then
            MsgBox("Mohon isi Nama Pegawai terlebih dahulu!")
            txtpegawai.Focus()
        ElseIf txtbarang.Text = "" Then
            MsgBox("Nama Barang harus diisi terlebih dahulu!")
            txtbarang.Focus()
        ElseIf txtjbeli.Text = "0" Or txtjbeli.Text = "" Then
            MsgBox("Total barang harus diisi!")
            txtjumlah.Focus()
        Else
            koneksi()
            cmd = New OdbcCommand("SELECT nama_barang FROM koperasi WHERE nama_barang = '" + txtbarang.Text + "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("Nama Barang Tidak terdafrtar, Harap Periksa Kembali!")
                txtbarang.Focus()
            ElseIf txtbarang.Text = DGV.Item(0, index).Value Then
                If MsgBox("Data yang diinput sudah ada, Apakah ingin di edit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    With DGV
                        .Item(0, index).Value = txtkode.Text
                        .Item(1, index).Value = DTP.Text
                        .Item(2, index).Value = txtpegawai.Text
                        .Item(3, index).Value = txtbarang.Text
                        .Item(4, index).Value = txtjbeli.Text
                        .Item(5, index).Value = sub_harga.ToString
                        .Item(6, index).Value = txtstok.Text

                    End With
                    bersih_barang()
                    total()
                    txtbarang.Focus()
                Else
                    bersih_barang()
                    txtbarang.Focus()
                    total()
                End If
                conn.Close()

            Else
                DGV.Rows.Insert(DGV.NewRowIndex, txtkode.Text, DTP.Text, txtpegawai.Text, txtbarang.Text, txtjbeli.Text, sub_harga.ToString, txtstok.Text)
                bersih_barang()
                total()
                txtbarang.Focus()
            End If


        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtbarang.Text = "" Then
            MsgBox("Pilih data dari Grid terlebih dahulu!")
        Else
            If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If DGV.CurrentRow.Index <> DGV.NewRowIndex Then
                    DGV.Rows.RemoveAt(DGV.CurrentRow.Index)
                    bersih_barang()
                    total()
                    txtbarang.Focus()
                Else
                    bersih_barang()
                    total()
                    txtbarang.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Dim i = DGV.CurrentRow.Index
        With DGV
            txtkode.Text = .Item(0, i).Value.ToString
            DTP.Text = .Item(1, i).Value.ToString
            txtpegawai.Text = .Item(2, i).Value.ToString
            txtbarang.Text = .Item(3, i).Value.ToString
            txttotalbarang.Text = .Item(4, i).Value.ToString
            txtstok.Text = .Item(6, i).Value.ToString
        End With
    End Sub

    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        Dim index As Integer
        If txtpegawai.Text = "" Then
            MsgBox("Nama Pegawai tidak boleh kosong!")
            txtpegawai.Focus()
        ElseIf DGV.Item(0, index).Value = "" Then
            MsgBox("Transaksi pembelian masih kosong")
            txtbarang.Focus()
        Else
            'simpan tabel pembelian
            For i As Integer = 0 To DGV.RowCount - 2
                koneksi()
                cmd = New OdbcCommand("INSERT INTO transaksi VALUES (?, ?, ?, ?, ?, ?, ?, ?)", conn)
                With cmd
                    .Parameters.AddWithValue("?", txttotal1.Text)
                    .Parameters.AddWithValue("?", DGV.Item(0, i).Value)
                    .Parameters.AddWithValue("?", DTP.Text)
                    .Parameters.AddWithValue("?", DGV.Item(2, i).Value)
                    .Parameters.AddWithValue("?", DGV.Item(3, i).Value)
                    .Parameters.AddWithValue("?", DGV.Item(5, i).Value)
                    .Parameters.AddWithValue("?", txtcash.Text)
                    .Parameters.AddWithValue("?", txtkembalian.Text)
                    .ExecuteNonQuery()
                End With
                conn.Close()
                'Next

                'For i As Integer = 0 To DGV.RowCount - 2

                'simpan tabel pembelian detail
                koneksi()
                cmd = New OdbcCommand("INSERT INTO detail_transaksi VALUES (?, ?, ?, ?, ?)", conn)
                With cmd
                    .Parameters.AddWithValue("?", txttotal1.Text)
                    .Parameters.AddWithValue("?", DGV.Item(0, i).Value)
                    .Parameters.AddWithValue("?", DGV.Item(3, i).Value)
                    .Parameters.AddWithValue("?", DGV.Item(4, i).Value)
                    .Parameters.AddWithValue("?", DGV.Item(5, i).Value)
                    .ExecuteNonQuery()
                End With
                conn.Close()

                koneksi()
                cmd = New OdbcCommand("SELECT jumlah FROM koperasi WHERE nama_barang ='" + DGV.Item(3, i).Value + "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    'Dim jumlah As String
                    'jumlah = dr(0) + DGV.Item(6, i).Value

                    koneksi()
                    cmd = New OdbcCommand("UPDATE koperasi SET jumlah ='" + DGV.Item(6, i).Value + "' WHERE nama_barang='" + DGV.Item(3, i).Value + "'", conn)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End If
                conn.Close()
            Next
            MsgBox("Data berhasil disimpan")
            call_all()
        End If
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        call_all()
    End Sub
    Private Sub DGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        DGV.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub txtbarang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT nama_barang, jumlah, harga_jual FROM koperasi WHERE nama_barang ='" + txtbarang.Text + "'", conn)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    txtbarang.Text = dr(0).ToString
                    txtjumlah.Text = dr(1).ToString
                    txtjual.Text = dr(2).ToString
                End If
                conn.Close()
                txtjumlah.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtbarang.Clear()
        txtjumlah.Clear()
        txtjual.Clear()
        txtcash.Clear()
        txtkembalian.Clear()
        txtpegawai.Clear()
        txtgolongan.Clear()
        txtpusat.Clear()
        txtstok.Clear()
        txttotal.Clear()
        txttotalbarang.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtkembalian.Text = Val(txtcash.Text) - Val(txttotal.Text)
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            koneksi()
            cmd = New OdbcCommand("update koperasi set jumlah = ? where nama_barang = ?", conn)
            With cmd
                .Parameters.AddWithValue("?", txtstok.Text)
                .Parameters.AddWithValue("?", txtbarang.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtbarang.Text = ""
            txtstok.Text = ""
            txtbarang.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
                koneksi()
                cmd = New OdbcCommand("update pegawai set nama = ?, golongan = ?, pusat = ? where no = ?", conn)
                With cmd
                    .Parameters.AddWithValue("?", txtpegawai.Text)
                    .Parameters.AddWithValue("?", txtgolongan.Text)
                    .Parameters.AddWithValue("?", txtpusat.Text)
                    .Parameters.AddWithValue("?", txtno.Text)
                    .ExecuteNonQuery()
                End With
                conn.Close()

                tampilkan_data()

                txtno.Text = ""
                txtpegawai.Text = ""
                txtgolongan.Text = ""
                txtpusat.Text = ""
                txtno.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txttotal1_TextChanged(sender As Object, e As EventArgs) Handles txttotal1.TextChanged

    End Sub
End Class
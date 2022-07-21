Imports System.Data.Odbc
Public Class stockis
    Const DSN = "DSN=koperasi"
    Const DSA = "DSN=stok_barang"
    Const DSB = "DSN=stockis"
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim da As OdbcDataAdapter
    Dim dr As OdbcDataReader
    Dim ds As DataSet
    Dim table As DataTable
    Sub koneksi()
        conn = New OdbcConnection(DSN)
        conn = New OdbcConnection(DSA)
        conn = New OdbcConnection(DSB)
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
        DGV.DataSource = table
        conn.Close()
    End Sub
    Sub Auto_Barang()
        koneksi()
        cmd = New OdbcCommand("SELECT nama_barang FROM koperasi", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            With txtnamabarang
                .AutoCompleteCustomSource.Add(dr(0).ToString)
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        End While
        conn.Close()
    End Sub
    Sub otomatis()
        Dim oto As String = "SP" + Format(Now, "yyMMdd-hhmmss")
        txtno.Text = oto

    End Sub
    Sub call_all()
        txtnamabarang.Focus()
        Auto_Barang()
        otomatis()
    End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Try
            koneksi()
            cmd = New OdbcCommand("SELECT nama_barang FROM koperasi WHERE nama_barang = '" + txtnamabarang.Text + "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("Jika anda ingin menginput barang,silahkan ke form barang!")
                txtnamabarang.Focus()

            ElseIf txtnamabarang.Text = "" Then
                MsgBox("Isi Nama Barang terlebih dahulu.")
            ElseIf MsgBox("Apakah anda yakin akan menginput data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End If
            koneksi()
            cmd = New OdbcCommand("insert into stockis values (?, ?, ?, ?, ?, ?, ?, ?)", conn)
            With cmd
                .Parameters.AddWithValue("?", txtno.Text)
                .Parameters.AddWithValue("?", txtnobarang.Text)
                .Parameters.AddWithValue("?", DTP.Text)
                .Parameters.AddWithValue("?", txtjumlah.Text)
                .Parameters.AddWithValue("?", txtharga.Text)
                .Parameters.AddWithValue("?", txtsupplier.Text)
                .Parameters.AddWithValue("?", txtjasa.Text)
                .Parameters.AddWithValue("?", txtupah.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            koneksi()
            cmd = New OdbcCommand("INSERT INTO stok_barang VALUES (?,?)", conn)
            With cmd
                .Parameters.AddWithValue("?", txtnobarang.Text)
                .Parameters.AddWithValue("?", txtstokarang.Text)
                .ExecuteNonQuery()

            End With
            conn.Close()

            koneksi()
            cmd = New OdbcCommand("update koperasi set jumlah = ?, nama_barang = ? WHERE no = ?", conn)
            With cmd
                .Parameters.AddWithValue("?", txtstokarang.Text)
                .Parameters.AddWithValue("?", txtnamabarang.Text)
                .Parameters.AddWithValue("?", txtnobarang.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()
            tampilkan_data()

            txtjasa.Text = ""
            txtupah.Text = ""
            txtnobarang.Text = ""
            txtstokarang.Text = ""
            txtnamabarang.Text = ""
            txtnobarang.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtnamabarang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnamabarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT no, nama_barang, jumlah FROM koperasi WHERE nama_barang ='" + txtnamabarang.Text + "'", conn)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    txtnobarang.Text = dr(0).ToString
                    txtnamabarang.Text = dr(1).ToString
                    txtstok.Text = dr(2).ToString

                End If
                conn.Close()
                txtnamabarang.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub stockis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        call_all()
        tampilkan_data()
    End Sub

    Private Sub btnstok_Click(sender As Object, e As EventArgs)
        Try
            koneksi()
            cmd = New OdbcCommand("insert into stok_barang values (?, ?)", conn)
            With cmd
                .Parameters.AddWithValue("?", txtnobarang.Text)
                .Parameters.AddWithValue("?", txtstok.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnjumlah_Click(sender As Object, e As EventArgs) Handles btnjumlah.Click
        txtstokarang.Text = Val(txtjumlah.Text) + Val(txtstok.Text)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtno.Clear()
        txtnobarang.Clear()
        txtnamabarang.Clear()
        txtjumlah.Clear()
        txtsupplier.Clear()
        txtharga.Clear()
        txtstok.Clear()
        txtstokarang.Clear()
        txtjasa.Clear()
        txtupah.Clear()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            koneksi()
            cmd = New OdbcCommand("update koperasi set nama_barang = ?, jumlah = ? where no = ?", conn)
            With cmd
                .Parameters.AddWithValue("?", txtnamabarang.Text)
                .Parameters.AddWithValue("?", txtstokarang.Text)
                .Parameters.AddWithValue("?", txtnobarang.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            txtnamabarang.Text = ""
            txtstokarang.Text = ""
            txtnobarang.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class
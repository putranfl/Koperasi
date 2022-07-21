Imports System.Data.Odbc

Public Class Form1
    Const DSN = "DSN=koperasi"
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim da As OdbcDataAdapter
    Dim dr As OdbcDataReader
    Dim ds As DataSet
    Dim table As DataTable

    Sub koneksi()
        conn = New OdbcConnection(DSN)
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkan_data()
        call_all()
    End Sub
    Sub Auto_Barang()
        koneksi()
        cmd = New OdbcCommand("SELECT nama_barang FROM koperasi", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            With TextNama
                .AutoCompleteCustomSource.Add(dr(0).ToString)
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        End While
        conn.Close()
    End Sub
    Sub call_all()
        TextNama.Focus()
        Auto_Barang()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs)
        Try
            koneksi()
            cmd = New OdbcCommand("insert into koperasi values (?, ?, ?, ?, ?, ?)", conn)
            With cmd
                .Parameters.AddWithValue("?", txtno.Text)
                .Parameters.AddWithValue("?", TextNama.Text)
                .Parameters.AddWithValue("?", TextJenis_Kelamin.Text)
                .Parameters.AddWithValue("?", TextAlamat.Text)
                .Parameters.AddWithValue("?", txtsatuan.Text)
                .Parameters.AddWithValue("?", txtharga.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            TextNama.Text = ""
            TextJenis_Kelamin.Text = ""
            TextAlamat.Text = ""
            txtsatuan.Text = ""
            txtharga.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs)

        Try
            koneksi()
            cmd = New OdbcCommand("update koperasi set nama_barang = ?, jenis = ?, jumlah = ?, satuan = ?, harga_jual = ? where no = ?", conn)
            With cmd
                .Parameters.AddWithValue("?", TextNama.Text)
                .Parameters.AddWithValue("?", TextJenis_Kelamin.Text)
                .Parameters.AddWithValue("?", TextAlamat.Text)
                .Parameters.AddWithValue("?", txtsatuan.Text)
                .Parameters.AddWithValue("?", txtharga.Text)
                .Parameters.AddWithValue("?", txtno.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            TextNama.Text = ""
            TextJenis_Kelamin.Text = ""
            TextAlamat.Text = ""
            txtsatuan.Text = ""
            txtharga.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)

        If txtno.Text = "" Then
            MsgBox("Isi Nomor terlebih dahulu.")
        ElseIf MsgBox("Apakah anda yakin akan menghapus data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM koperasi WHERE no= '" + txtno.Text + "'", conn)
            With cmd
                .ExecuteNonQuery()
                .Dispose()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            TextNama.Text = ""
            TextJenis_Kelamin.Text = ""
            TextAlamat.Text = ""
            txtsatuan.Text = ""
            txtharga.Text = ""
            txtno.Focus()
        End If

    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs)
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        Try
            koneksi()
            cmd = New OdbcCommand("insert into koperasi values (?, ?, ?, ?, ?, ?)", conn)
            With cmd
                .Parameters.AddWithValue("?", txtno.Text)
                .Parameters.AddWithValue("?", TextNama.Text)
                .Parameters.AddWithValue("?", TextJenis_Kelamin.Text)
                .Parameters.AddWithValue("?", TextAlamat.Text)
                .Parameters.AddWithValue("?", txtsatuan.Text)
                .Parameters.AddWithValue("?", txtharga.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            TextNama.Text = ""
            TextJenis_Kelamin.Text = ""
            TextAlamat.Text = ""
            txtsatuan.Text = ""
            txtharga.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Try
            koneksi()
            cmd = New OdbcCommand("insert into koperasi values (?, ?, ?, ?, ?, ?)", conn)
            With cmd
                .Parameters.AddWithValue("?", txtno.Text)
                .Parameters.AddWithValue("?", TextNama.Text)
                .Parameters.AddWithValue("?", TextJenis_Kelamin.Text)
                .Parameters.AddWithValue("?", TextAlamat.Text)
                .Parameters.AddWithValue("?", txtsatuan.Text)
                .Parameters.AddWithValue("?", txtharga.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            TextNama.Text = ""
            TextJenis_Kelamin.Text = ""
            TextAlamat.Text = ""
            txtsatuan.Text = ""
            txtharga.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click
        If txtno.Text = "" Then
            MsgBox("Isi Nomor terlebih dahulu.")
        ElseIf MsgBox("Apakah anda yakin akan menghapus data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM koperasi WHERE no= '" + txtno.Text + "'", conn)
            With cmd
                .ExecuteNonQuery()
                .Dispose()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            TextNama.Text = ""
            TextJenis_Kelamin.Text = ""
            TextAlamat.Text = ""
            txtsatuan.Text = ""
            txtharga.Text = ""
            txtno.Focus()
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        If txtno.Text = "" Then
            MsgBox("Isi Nomor terlebih dahulu.")
        ElseIf MsgBox("Apakah anda yakin akan menghapus data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM koperasi WHERE no= '" + txtno.Text + "'", conn)
            With cmd
                .ExecuteNonQuery()
                .Dispose()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            TextNama.Text = ""
            TextJenis_Kelamin.Text = ""
            TextAlamat.Text = ""
            txtsatuan.Text = ""
            txtharga.Text = ""
            txtno.Focus()
        End If
    End Sub

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click, RectangleShape4.Click

        Try
            koneksi()
            cmd = New OdbcCommand("update koperasi set nama_barang = ?, jenis = ?, jumlah = ?, satuan = ?, harga_jual = ? where no = ?", conn)
            With cmd
                .Parameters.AddWithValue("?", TextNama.Text)
                .Parameters.AddWithValue("?", TextJenis_Kelamin.Text)
                .Parameters.AddWithValue("?", TextAlamat.Text)
                .Parameters.AddWithValue("?", txtsatuan.Text)
                .Parameters.AddWithValue("?", txtharga.Text)
                .Parameters.AddWithValue("?", txtno.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            TextNama.Text = ""
            TextJenis_Kelamin.Text = ""
            TextAlamat.Text = ""
            txtsatuan.Text = ""
            txtharga.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

        Try
            koneksi()
            cmd = New OdbcCommand("update koperasi set nama_barang = ?, jenis = ?, jumlah = ?, satuan = ?, harga_jual = ? where no = ?", conn)
            With cmd
                .Parameters.AddWithValue("?", TextNama.Text)
                .Parameters.AddWithValue("?", TextJenis_Kelamin.Text)
                .Parameters.AddWithValue("?", TextAlamat.Text)
                .Parameters.AddWithValue("?", txtsatuan.Text)
                .Parameters.AddWithValue("?", txtharga.Text)
                .Parameters.AddWithValue("?", txtno.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            TextNama.Text = ""
            TextJenis_Kelamin.Text = ""
            TextAlamat.Text = ""
            txtsatuan.Text = ""
            txtharga.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextNama_TextChanged(sender As Object, e As EventArgs) Handles TextNama.TextChanged

    End Sub

    Private Sub txtno_TextChanged(sender As Object, e As EventArgs) Handles txtno.TextChanged

    End Sub

    Private Sub TextNama_KeyDown(sender As Object, e As KeyEventArgs) Handles TextNama.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT no, nama_barang, jenis, jumlah, satuan, harga_jual FROM koperasi WHERE nama_barang ='" + TextNama.Text + "'", conn)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    txtno.Text = dr(0).ToString
                    TextNama.Text = dr(1).ToString
                    TextJenis_Kelamin.Text = dr(2).ToString
                    TextAlamat.Text = dr(3).ToString
                    txtsatuan.Text = dr(4).ToString
                    txtharga.Text = dr(5).ToString
                End If
                conn.Close()
                TextNama.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            koneksi()
            cmd = New OdbcCommand("update koperasi set nama_barang = ?, jenis = ?, jumlah = ?, satuan = ?, harga_jual = ? where no = ?", conn)
            With cmd
                .Parameters.AddWithValue("?", TextNama.Text)
                .Parameters.AddWithValue("?", TextJenis_Kelamin.Text)
                .Parameters.AddWithValue("?", TextAlamat.Text)
                .Parameters.AddWithValue("?", txtsatuan.Text)
                .Parameters.AddWithValue("?", txtharga.Text)
                .Parameters.AddWithValue("?", txtno.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            TextNama.Text = ""
            TextJenis_Kelamin.Text = ""
            TextAlamat.Text = ""
            txtsatuan.Text = ""
            txtharga.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        txtno.Clear()
        TextNama.Clear()
        TextJenis_Kelamin.Clear()
        TextAlamat.Clear()
        txtsatuan.Clear()
        txtharga.Clear()
    End Sub
End Class

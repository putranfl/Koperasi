Imports System.Data.Odbc

Public Class Form2
    Const DSN = "DSN=pegawai"
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
        da = New OdbcDataAdapter("select * from pegawai", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        table = ds.Tables(0)
        DGV.DataSource = table
        conn.Close()
    End Sub
    Sub Auto_Supplier()
        koneksi()
        cmd = New OdbcCommand("SELECT nama FROM pegawai", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            With txtnama
                .AutoCompleteCustomSource.Add(dr(0).ToString)
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        End While
        conn.Close()
    End Sub
    Sub call_all()
        txtnama.Focus()
        Auto_Supplier()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkan_data()
        call_all()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs)
        Try
            koneksi()
            cmd = New OdbcCommand("insert into pegawai values (?, ?, ?, ?)", conn)
            With cmd
                .Parameters.AddWithValue("?", txtno.Text)
                .Parameters.AddWithValue("?", txtnama.Text)
                .Parameters.AddWithValue("?", txtgolongan.Text)
                .Parameters.AddWithValue("?", txtpusat.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            txtnama.Text = ""
            txtgolongan.Text = ""
            txtpusat.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs)

        Try
            koneksi()
            cmd = New OdbcCommand("update pegawai set nama = ?, golongan = ?, pusat = ? where no = ?", conn)
            With cmd
                .Parameters.AddWithValue("?", txtnama.Text)
                .Parameters.AddWithValue("?", txtgolongan.Text)
                .Parameters.AddWithValue("?", txtpusat.Text)
                .Parameters.AddWithValue("?", txtno.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            txtnama.Text = ""
            txtgolongan.Text = ""
            txtpusat.Text = ""
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
            cmd = New OdbcCommand("DELETE FROM pegawai WHERE no= '" + txtno.Text + "'", conn)
            With cmd
                .ExecuteNonQuery()
                .Dispose()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            txtnama.Text = ""
            txtgolongan.Text = ""
            txtpusat.Text = ""
            txtno.Focus()
        End If

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs)
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        Try
            koneksi()
            cmd = New OdbcCommand("insert into pegawai values (?, ?, ?, ?)", conn)
            With cmd
                .Parameters.AddWithValue("?", txtno.Text)
                .Parameters.AddWithValue("?", txtnama.Text)
                .Parameters.AddWithValue("?", txtgolongan.Text)
                .Parameters.AddWithValue("?", txtpusat.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            txtnama.Text = ""
            txtgolongan.Text = ""
            txtpusat.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Try
            koneksi()
            cmd = New OdbcCommand("insert into pegawai values (?, ?, ?, ?)", conn)
            With cmd
                .Parameters.AddWithValue("?", txtno.Text)
                .Parameters.AddWithValue("?", txtnama.Text)
                .Parameters.AddWithValue("?", txtgolongan.Text)
                .Parameters.AddWithValue("?", txtpusat.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            txtnama.Text = ""
            txtgolongan.Text = ""
            txtpusat.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Try
            koneksi()
            cmd = New OdbcCommand("update pegawai set nama = ?, golongan = ?, pusat = ? where no = ?", conn)
            With cmd
                .Parameters.AddWithValue("?", txtnama.Text)
                .Parameters.AddWithValue("?", txtgolongan.Text)
                .Parameters.AddWithValue("?", txtpusat.Text)
                .Parameters.AddWithValue("?", txtno.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            txtnama.Text = ""
            txtgolongan.Text = ""
            txtpusat.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RectangleShagf_Click(sender As Object, e As EventArgs) Handles RectangleShagf.Click
        Try
            koneksi()
            cmd = New OdbcCommand("update pegawai set nama = ?, golongan = ?, pusat = ? where no = ?", conn)
            With cmd
                .Parameters.AddWithValue("?", txtnama.Text)
                .Parameters.AddWithValue("?", txtgolongan.Text)
                .Parameters.AddWithValue("?", txtpusat.Text)
                .Parameters.AddWithValue("?", txtno.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            txtnama.Text = ""
            txtgolongan.Text = ""
            txtpusat.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click, RectangleShape2.Click
        If txtno.Text = "" Then
            MsgBox("Isi Nomor terlebih dahulu.")
        ElseIf MsgBox("Apakah anda yakin akan menghapus data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM pegawai WHERE no= '" + txtno.Text + "'", conn)
            With cmd
                .ExecuteNonQuery()
                .Dispose()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            txtnama.Text = ""
            txtgolongan.Text = ""
            txtpusat.Text = ""
            txtno.Focus()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If txtno.Text = "" Then
            MsgBox("Isi Nomor terlebih dahulu.")
        ElseIf MsgBox("Apakah anda yakin akan menghapus data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM pegawai WHERE no= '" + txtno.Text + "'", conn)
            With cmd
                .ExecuteNonQuery()
                .Dispose()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            txtnama.Text = ""
            txtgolongan.Text = ""
            txtpusat.Text = ""
            txtno.Focus()
        End If
    End Sub
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub txtnama_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnama.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT no, nama, golongan, pusat FROM pegawai WHERE nama ='" + txtnama.Text + "'", conn)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    txtno.Text = dr(0).ToString
                    txtnama.Text = dr(1).ToString
                    txtgolongan.Text = dr(2).ToString
                    txtpusat.Text = dr(3).ToString
                End If
                conn.Close()
                txtnama.Focus()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs) Handles Label8.Click
        txtno.Clear()
        txtnama.Clear()
        txtgolongan.Clear()
        txtpusat.Clear()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            koneksi()
            cmd = New OdbcCommand("update pegawai set nama = ?, golongan = ?, pusat = ? where no = ?", conn)
            With cmd
                .Parameters.AddWithValue("?", txtnama.Text)
                .Parameters.AddWithValue("?", txtgolongan.Text)
                .Parameters.AddWithValue("?", txtpusat.Text)
                .Parameters.AddWithValue("?", txtno.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            txtnama.Text = ""
            txtgolongan.Text = ""
            txtpusat.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

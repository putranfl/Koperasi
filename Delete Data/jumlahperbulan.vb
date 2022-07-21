Imports System.Data.Odbc
Public Class jumlahperbulan
    Const DSN = "DSN=transaksi"
    Const DSA = "DSN=totalperbulan"
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim da As OdbcDataAdapter
    Dim dr As OdbcDataReader
    Dim ds As DataSet
    Dim table As DataTable
    Sub koneksi()
        conn = New OdbcConnection(DSN)
        conn = New OdbcConnection(DSA)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub tampilkan_data()
        koneksi()
        da = New OdbcDataAdapter("select * from transaksi", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        table = ds.Tables(0)
        DGV.DataSource = table
        conn.Close()
    End Sub
    Sub Hitung_DATAGRIDVIEW()
        Dim totalharga As Double
        totalharga = 0
        For t As Integer = 0 To DGV.Rows.Count - 1
            totalharga = totalharga + Val(DGV.Rows(t).Cells(5).Value)
        Next
        txttotal.Text = totalharga
    End Sub
    Private Sub txttotal_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Call Hitung_DATAGRIDVIEW()
            DTP.Focus()
        End If
    End Sub

    Private Sub jumlahperbulan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkan_data()
        Hitung_DATAGRIDVIEW()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            koneksi()
            cmd = New OdbcCommand("insert into totalperbulan values (?, ?, ?)", conn)
            With cmd
                .Parameters.AddWithValue("?", txtno.Text)
                .Parameters.AddWithValue("?", DTP.Text)
                .Parameters.AddWithValue("?", txttotal.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            DTP.Text = ""
            txttotal.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            koneksi()
            cmd = New OdbcCommand("update transaksi set tanggal_transaksi = ? where no = ?", conn)
            With cmd
                .Parameters.AddWithValue("?", DTP.Text)
                .Parameters.AddWithValue("?", txtno.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()

            tampilkan_data()

            txtno.Text = ""
            DTP.Text = ""
            txtno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class

Imports System.Data.Odbc
Public Class buatakun

    Const DSN = "DSN=db_login"
    Dim connection As OdbcConnection
    Dim DR As OdbcDataReader
    Dim CMD As OdbcCommand

    Sub Koneksi()
        connection = New OdbcConnection(DSN)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        Else
            MsgBox("Gagal Melakukan Koneksi Database")
        End If
    End Sub

    Private Sub buatakun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Select()
    End Sub

    Private Sub btnbuat_Click(sender As Object, e As EventArgs)
        Try
            Koneksi()
            CMD = New OdbcCommand("insert into tbl_login values (?, ?)", connection)
            With CMD
                .Parameters.AddWithValue("?", txtuser.Text)
                .Parameters.AddWithValue("?", txtpass.Text)
                .ExecuteNonQuery()
            End With
            connection.Close()

            txtuser.Text = ""
            txtpass.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btngakjadi_Click(sender As Object, e As EventArgs)
        txtuser.Clear()
        txtpass.Clear()
    End Sub
    Private Sub txtuser_Click(sender As Object, e As EventArgs) Handles txtuser.Click
        txtuser.Text = ""
    End Sub
    Private Sub txtpass_Click(sender As Object, e As EventArgs) Handles txtpass.Click
        txtpass.UseSystemPasswordChar = True
        txtpass.Text = ""
    End Sub

    Private Sub RectangleShape8_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click
        Try
            Koneksi()
            CMD = New OdbcCommand("insert into tbl_login values (?, ?, ?)", connection)
            With CMD
                .Parameters.AddWithValue("?", txtuser.Text)
                .Parameters.AddWithValue("?", txtpass.Text)
                .Parameters.AddWithValue("?", cb1.Text)
                .ExecuteNonQuery()
            End With
            connection.Close()

            txtuser.Text = ""
            txtpass.Text = ""
            cb1.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Data Berhasil Dibuat")
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            Koneksi()
            CMD = New OdbcCommand("insert into tbl_login values (?, ?, ?)", connection)
            With CMD
                .Parameters.AddWithValue("?", txtuser.Text)
                .Parameters.AddWithValue("?", txtpass.Text)
                .Parameters.AddWithValue("?", cb1.Text)
                .ExecuteNonQuery()
            End With
            connection.Close()

            txtuser.Text = ""
            txtpass.Text = ""
            cb1.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Data Berhasil Dibuat")
        login.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtuser.Clear()
        txtpass.Clear()
    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        login.Show()
        Me.Hide()
    End Sub
End Class
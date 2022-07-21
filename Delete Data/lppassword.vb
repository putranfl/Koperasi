Imports System.Data.Odbc
Public Class lppassword
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

    Private Sub btnoke_Click(sender As Object, e As EventArgs)
        Try
            Koneksi()
            CMD = New OdbcCommand("update tbl_login set  password = ? where username = ?", connection)
            With CMD
                .Parameters.AddWithValue("?", txtpass.Text)
                .Parameters.AddWithValue("?", txtuser.Text)
                .ExecuteNonQuery()
            End With
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        txtuser.Clear()
        txtpass.Clear()
    End Sub

    Private Sub RectangleShape8_Click(sender As Object, e As EventArgs) Handles RectangleShape8.Click
        Try
            Koneksi()
            CMD = New OdbcCommand("update tbl_login set username = ?, password = ? where hak_akses  = ?", connection)
            With CMD
                .Parameters.AddWithValue("?", txtuser.Text)
                .Parameters.AddWithValue("?", txtpass.Text)
                .Parameters.AddWithValue("?", cb1.Text)
                .ExecuteNonQuery()
            End With
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Password Berhasil Diubah")
        login.Show()
        Me.Hide()
    End Sub

    Private Sub txtuser_Click(sender As Object, e As EventArgs) Handles txtuser.Click
        txtuser.Text = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtuser.Clear()
        txtpass.Clear()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            Koneksi()
            CMD = New OdbcCommand("update tbl_login set username = ?, password = ? where hak_akses  = ?", connection)
            With CMD
                .Parameters.AddWithValue("?", txtuser.Text)
                .Parameters.AddWithValue("?", txtpass.Text)
                .Parameters.AddWithValue("?", cb1.Text)
                .ExecuteNonQuery()
            End With
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Password Berhasil Diubah")
        login.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        login.Show()
        Me.Hide()
    End Sub
End Class
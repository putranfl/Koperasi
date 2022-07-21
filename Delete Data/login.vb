Imports System.Data.Odbc

Public Class login

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

    Private Sub btnlogin_Click(sender As Object, e As EventArgs)
        Try
            If txtuser.Text = "" Or txtpass.Text = "" Then
                MsgBox("Username atau Password Belum lengkap")
            Else
                Koneksi()
                CMD = New OdbcCommand("SELECT * FROM tbl_login WHERE username = '" + txtuser.Text + "' AND password = '" + txtpass.Text + "'", connection)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Me.Hide()
                    Form3.Show()
                Else
                    MsgBox("Username atau Password yang anda masukan salah, Mohon periksa kembali")
                End If
                connection.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs)
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

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textbox3.Select()
    End Sub

    Private Sub RectangleShape8_Click(sender As Object, e As EventArgs) Handles RectangleShape8.Click
        Try
            If txtuser.Text = "" Or txtpass.Text = "" Then
                MsgBox("Username atau Password Belum lengkap")
            Else
                Koneksi()
                CMD = New OdbcCommand("SELECT * FROM tbl_login WHERE username = '" + txtuser.Text + "' AND password = '" + txtpass.Text + "'", connection)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Form3.Show()
                    Me.Hide()
                Else
                    MsgBox("Username atau Password yang anda masukan salah, Mohon periksa kembali")
                End If
                connection.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            If txtuser.Text = "" Or txtpass.Text = "" Then
                MsgBox("Username atau Password Belum lengkap")
            Else
                Koneksi()
                CMD = New OdbcCommand("SELECT * FROM tbl_login WHERE username = '" + txtuser.Text + "' AND password = '" + txtpass.Text + "'", connection)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Form3.Show()
                    Me.Hide()
                    MsgBox("Username atau Password yang anda masukan salah, Mohon periksa kembali")
                End If
                connection.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub daftar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles daftar.LinkClicked
        buatakun.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        lppassword.Show()
        Me.Hide()
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class

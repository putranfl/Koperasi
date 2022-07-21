Public Class Form3
    Private Sub btnbarang_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnpegawai_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        transaksi2.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        transaksi2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        stockis.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        jumlahperbulan.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        jumlahperbulan.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        '  Formreporttransaksi.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        ' Formreporttransaksi.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click
        reporttransaksi2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        reporttransaksi2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        reporttransaksi.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        reporttransaksi.Show()
        Me.Hide()
    End Sub
End Class
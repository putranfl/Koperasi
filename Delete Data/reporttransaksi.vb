Public Class reporttransaksi
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        CrystalReportViewer1.ReportSource = crystalReportstokist1
        crystalReportstokist1.Load()
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        reporttransaksi2.Show()
        Me.Hide()
    End Sub

    Private Sub reporttransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
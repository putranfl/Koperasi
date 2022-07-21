Public Class reporttransaksi2
    Private Sub reporttransaksi2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = crystalReporttransaksi1
        crystalReporttransaksi1.Load()
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        reporttransaksi.Show()
        Me.Hide()
    End Sub
End Class
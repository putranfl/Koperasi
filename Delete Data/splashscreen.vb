Public Class splashscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        PGB.Value += 10
        If PGB.Value = 200 Then
            Timer1.Dispose()
            Me.Visible = False
            Form3.Show()
        End If
    End Sub
End Class
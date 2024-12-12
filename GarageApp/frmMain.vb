Public Class frmMain
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        frmFuelPump.Show()
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        AdminLogin.Show()
        Me.Hide()
        Me.Dispose()
    End Sub
End Class
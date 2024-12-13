Public Class frmPaymentConfirmation
    Private Sub frmPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "Amount: " + labelTotalPrice
        Timer1.Start()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        frmFuelPump.Show()
        Me.Hide()
        Me.Dispose()
    End Sub
End Class
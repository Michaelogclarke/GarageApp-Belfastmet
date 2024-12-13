Imports System.Security.Cryptography.X509Certificates

Public Class Checkout
    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = labelTotalPrice
        Label2.Text = labelTotalFuel
        btnPayment.Text = "Pay " + labelTotalPrice

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        System.IO.File.WriteAllText("fuelAmount.txt", Label2.Text)
        frmPaymentConfirmation.Show()
        Me.Dispose()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class

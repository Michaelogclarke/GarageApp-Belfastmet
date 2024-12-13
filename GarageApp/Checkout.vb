Imports System.Security.Cryptography.X509Certificates

Public Class Checkout
    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = labelTotalPrice
        Label2.Text = labelTotalFuel
        btnPayment.Text = "Pay " + labelTotalPrice
        modGlobals.InitializeFuelData()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click

        Dim fuel As Double = Val(labelTotalFuel)
        Dim price As Double = Val(labelTotalPrice)

        modGlobals.AddFuel(fuel, price)

        frmPaymentConfirmation.Show()
        Me.Dispose()
    End Sub


End Class

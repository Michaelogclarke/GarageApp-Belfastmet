Imports System.Reflection.Emit

Public Class AdminPage
    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("fuelAmount.txt") Then
            lblFueltxt.Text = System.IO.File.ReadAllText("fuelAmount.txt")
            lblPricetxt.Text = System.IO.File.ReadAllText("fuelPrice.txt")
            lblDieselPrice.Text = PriceDiesel
            lblPetrolPrice.Text = PricePetrol

        End If


    End Sub
    Private Sub AdminPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    End Sub

    Private Sub btnReturntofuel_Click(sender As Object, e As EventArgs) Handles btnReturntofuel.Click
        frmFuelPump.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnChangePrice_Click(sender As Object, e As EventArgs) Handles btnChangePrice.Click
        If txtboxDieselAM.Text = "" Then
            PriceDiesel = 0.7
        Else
            PriceDiesel = txtboxDieselAM.Text
        End If
        If txtboxPetrolAM.Text = "" Then
            PricePetrol = 0.7
        Else
            PricePetrol = txtboxPetrolAM.Text
        End If
        lblDieselPrice.Text = PriceDiesel
        lblPetrolPrice.Text = PricePetrol
    End Sub

    Private Sub txtboxPetrolAM_TextChanged(sender As Object, e As EventArgs) Handles txtboxPetrolAM.TextChanged

    End Sub
End Class
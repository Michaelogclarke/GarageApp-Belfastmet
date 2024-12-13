Imports System.Reflection.Emit

Public Class AdminPage
    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("fuelAmount.txt") Then
            lblFueltxt.Text = System.IO.File.ReadAllText("fuelAmount.txt")
            lblPricetxt.Text = System.IO.File.ReadAllText("fuelPrice.txt")
        End If


    End Sub
    Private Sub AdminPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    End Sub
End Class
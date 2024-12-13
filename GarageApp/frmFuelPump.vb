﻿Imports System.Reflection

Public Class frmFuelPump
    Private Sub frmFuelPump_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataSet As New DataSet("MyDataSet")
        Dim mydataTable As New DataTable("MyTable")

        mydataTable.Columns.Add("Total Price", GetType(Double))
        dataSet.Tables.Add(mydataTable)

    End Sub

    Private Sub btnCloseProgram_Click(sender As Object, e As EventArgs) Handles btnCloseProgram.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub btnPumpFuelMouseDown(sender As Object, e As EventArgs) Handles btnPumpFuel.MouseDown
        If rbDiesel.Checked() Then
            Timer1.Enabled = True
            DieselPricetmr.Enabled = True

        ElseIf rbpetrol.Checked() Then
            Timer1.Enabled = True
            petrolPriceTmr.Enabled = True

        Else
            MessageBox.Show("Choose a fuel type")
        End If
    End Sub



    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Checkout.Show()
        Me.Hide()
        Me.Dispose()
        'TODO find a way to write total price and total pumed to a dataset here
        Try
            ' Getting the total price
            Dim labelValue As Double = Convert.ToDouble(lblPriceAmount.Text)

            Dim newRow As DataRow = mydataTable.NewRow()
            newRow("Total Price") = labelValue
            mydataTable.Rows.Add(newRow)

            MessageBox.Show("Total Price: " & labelValue)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub rbDiesel_CheckedChanged(sender As Object, e As EventArgs) Handles rbDiesel.CheckedChanged

    End Sub

    Private Sub rbpetrol_CheckedChanged(sender As Object, e As EventArgs) Handles rbpetrol.CheckedChanged

    End Sub

    Private Sub lblLitres_Click(sender As Object, e As EventArgs) Handles lbLitres.Click

    End Sub

    Private Sub lblPrice_Click(sender As Object, e As EventArgs) Handles lblPrice.Click


    End Sub

    Private Sub lblLitresAmount_Click(sender As Object, e As EventArgs) Handles lblLitresAmount.Click

    End Sub

    Private Sub lblPriceAmount_Click(sender As Object, e As EventArgs) Handles lblPriceAmount.Click

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If rbDiesel.Checked Then
            Dim currentLitresDiesel As Double = Val(lblLitresAmount.Text.Replace(" L", ""))
            currentLitresDiesel += LitresDiesel
            lblLitresAmount.Text = currentLitresDiesel.ToString("0.0") & " L"

            Dim currentPriceDiesel As Double = Val(lblPriceAmount.Text.Replace("£", ""))
            currentPriceDiesel += PriceDiesel

            lblPriceAmount.Text = currentPriceDiesel.ToString("£0.0")
        ElseIf rbpetrol.Checked Then
            Dim currentLitresPetrol As Double = Val(lblLitresAmount.Text.Replace(" L", ""))
            currentLitresPetrol += LitresPetrol

            lblLitresAmount.Text = currentLitresPetrol.ToString("0.0") & " L"

            Dim currentPricePetrol As Double = Val(lblPriceAmount.Text.Replace("£", ""))
            currentPricePetrol += PricePetrol

            lblPriceAmount.Text = currentPricePetrol.ToString("£0.0")

        End If



    End Sub

    Private Sub btnPumpFuelMouseUp(sender As Object, e As EventArgs) Handles btnPumpFuel.MouseUp
        Timer1.Enabled = False
        petrolPriceTmr.Enabled = False
        DieselPricetmr.Enabled = False
    End Sub

    Private Sub petrolPriceTmr_Tick(sender As Object, e As EventArgs) Handles petrolPriceTmr.Tick


    End Sub

    Private Sub DieselPricetmr_Tick(sender As Object, e As EventArgs) Handles DieselPricetmr.Tick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnPumpFuel_Click(sender As Object, e As EventArgs) Handles btnPumpFuel.Click

    End Sub
End Class
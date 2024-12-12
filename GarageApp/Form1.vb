Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        frmFuelPump.Show()
        Me.Visible = False
        Timer1.Stop()
        Timer1.Dispose()
        


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStartTransaction_Click(sender As Object, e As EventArgs) Handles btnStartTransaction.Click
        frmMain.Show()
        Me.Hide()

    End Sub
End Class

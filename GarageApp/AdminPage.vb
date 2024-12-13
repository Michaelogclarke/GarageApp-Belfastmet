Public Class AdminPage
    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmFuelPump.lblLitresAmount = lblTotalFuel
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
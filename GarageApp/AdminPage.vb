Public Class AdminPage
    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmFuelPump.lblLitresAmount = lblTotalFuel
        modGlobals.InitializeFuelData()

        DataGridView1.DataSource = modGlobals.FuelData

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
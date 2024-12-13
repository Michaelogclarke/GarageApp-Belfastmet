Public Class AdminPage
    Private Const XmlFilePath As String = "/FuelData.xml"
    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmFuelPump.lblLitresAmount = lblTotalFuel
        modGlobals.LoadFuelDataFromXML(XmlFilePath)


        DataGridView1.DataSource = modGlobals.FuelData

    End Sub
    Private Sub AdminPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        modGlobals.saveFuelDataToXml(XmlFilePath)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
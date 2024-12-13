Module modGlobals

    Public PriceDiesel As Double = 0.7
    Public PricePetrol As Double = 0.6
    Public LitresDiesel As Double = 0.4
    Public LitresPetrol As Double = 0.3
    Public labelTotalPrice As String
    Public labelTotalFuel As String

    ' Public Function GetAdminData() As DataTable
    'Dim table As New DataTable()
    '   table.Columns.Add("Fuelpumped", GetType(Double))
    '  table.Columns.Add("Price", GetType(Double))

    'End Function

    Public FuelData As New DataTable()

    Public Sub InitializeFuelData()
        If FuelData.Columns.Count = 0 Then
            FuelData.Columns.Add("Fuel", GetType(Double))
            FuelData.Columns.Add("Price", GetType(Double))
            FuelData.Columns.Add("TImestamp", GetType(DateTime))
        End If
    End Sub

    Public Sub AddFuel(fuel As Double, price As Double)
        FuelData.Rows.Add(fuel, price)
    End Sub
End Module

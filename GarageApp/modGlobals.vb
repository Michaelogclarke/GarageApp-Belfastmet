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
        FuelData.Rows.Add(fuel, price, DateTime.Now)
        saveFuelDataToXml("FuelData.xml")

    End Sub
    Public Sub saveFuelDataToXml(filePath As String)
        Try
            FuelData.WriteXml(filePath, XmlWriteMode.WriteSchema)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub LoadFuelDataFromXML(filePath As String)
        Try
            ' Ensure the table structure is initialized
            InitializeFuelData()

            ' Check if the file exists
            If IO.File.Exists(filePath) Then
                FuelData.ReadXml(filePath)
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module

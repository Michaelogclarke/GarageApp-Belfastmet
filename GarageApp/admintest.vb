Public Class admintest
    Private Sub admintest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("fuelAmount.txt") Then
            Label1.Text = System.IO.File.ReadAllText("fuelAmount.txt")
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
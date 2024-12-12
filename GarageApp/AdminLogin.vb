Public Class AdminLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbUsername.Text = "Admin1" And tbPassword.Text = "Password1" Then
            AdminPage.Show()
            Me.Hide()
            Me.Dispose()
        Else
            MessageBox.Show("Wrong password try again")
        End If
    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged

    End Sub

    Private Sub tbUsername_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged

    End Sub
End Class
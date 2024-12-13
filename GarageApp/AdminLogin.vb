Public Class AdminLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbUsername.Text = "Admin" And tbPassword.Text = "Password" Then
            AdminPage.Show()
            Me.Dispose()
        Else
            MessageBox.Show("Username is Admin, Password is Password")

        End If
    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged

    End Sub

    Private Sub tbUsername_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged

    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
Public Class frmLogIn
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        'Set the username and password which must be required to proceed to the Price Quote Form
        'Username = User1, Password = password123
        If txtUsername.Text = "User1" And txtPassword.Text = "password123" Then
            frmMain.Show()
            Me.Close()
        Else
            MessageBox.Show("Incorrect username or password.")
            txtPassword.Clear()
        End If

    End Sub
End Class


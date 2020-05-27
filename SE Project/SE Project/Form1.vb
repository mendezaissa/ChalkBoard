Public Class loginPage

    'login button actions
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If usernameTextBox.Text = "administrator" And passwordTextBox.Text = "password" Then
            Me.Hide()
            adminForm.Show()
            usernameTextBox.Clear()
            passwordTextBox.Clear()
            usernameTextBox.Select()
        End If

        If usernameTextBox.Text = "mendeza59" And passwordTextBox.Text = "password" Then
            Me.Hide()
            student1Form.Show()
            usernameTextBox.Clear()
            passwordTextBox.Clear()
            usernameTextBox.Select()
        End If

        If usernameTextBox.Text = "bocanegraj2" And passwordTextBox.Text = "password" Then
            Me.Hide()
            student2Form.Show()
            usernameTextBox.Clear()
            passwordTextBox.Clear()
            usernameTextBox.Select()
        End If
    End Sub

End Class
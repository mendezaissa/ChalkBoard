Public Class student1Form

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles seLinkLabel.LinkClicked
        Me.Hide()
        seForm.Show()
    End Sub

    Private Sub logoutButton1_Click(sender As Object, e As EventArgs) Handles logoutButton1.Click
        Me.Hide()
        loginPage.Show()
    End Sub

    Private Sub mlLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles mlLinkLabel.LinkClicked
        Me.Hide()
        machineForm.Show()
    End Sub

End Class
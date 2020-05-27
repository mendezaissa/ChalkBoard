Public Class student2Form

    Private Sub logoutButton1_Click(sender As Object, e As EventArgs) Handles logoutButton1.Click
        Me.Hide()
        loginPage.Show()
    End Sub

    Private Sub seLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles seLinkLabel.LinkClicked
        Me.Hide()
        softEngForm.Show()
    End Sub

    Private Sub mlLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles mlLinkLabel.LinkClicked
        Me.Hide()
        mlForm.Show()
    End Sub
End Class
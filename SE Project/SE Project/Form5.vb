Public Class machineForm

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        student1Form.Show()
    End Sub

    Private Sub mLgrades_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles mLgrades.LinkClicked
        Me.Hide()
        Form6.Show()
    End Sub

End Class
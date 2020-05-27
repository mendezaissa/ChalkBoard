Public Class softEngForm
    Private Sub seBackButton_Click(sender As Object, e As EventArgs) Handles seBackButton.Click
        Me.Hide()
        student2Form.Show()
    End Sub

    Private Sub seGrades_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles seGrades.LinkClicked
        Me.Hide()
        Form11.Show()
    End Sub
End Class
Public Class seForm

    Private Sub seBackButton_Click(sender As Object, e As EventArgs) Handles seBackButton.Click
        Me.Hide()
        student1Form.Show()
    End Sub

    Private Sub seGrades_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles seGrades.LinkClicked
        Me.Hide()
        myGradesForm.Show()
    End Sub

End Class
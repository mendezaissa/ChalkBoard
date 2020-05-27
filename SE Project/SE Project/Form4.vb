Public Class myGradesForm

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        seForm.Show()
    End Sub

    Private Sub myGradesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentsDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.StudentsDataSet.Students)

    End Sub
End Class
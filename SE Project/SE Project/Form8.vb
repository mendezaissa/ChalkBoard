Public Class adminForm

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        StudentsBindingSource.AddNew()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        StudentsBindingSource.RemoveCurrent()
    End Sub

    Private Sub adminLogoutButton_Click(sender As Object, e As EventArgs) Handles adminLogoutButton.Click
        Me.Hide()
        loginPage.Show()
    End Sub

    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentsDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.StudentsDataSet.Students)

    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Try
            StudentsBindingSource.EndEdit()
            StudentsTableAdapter.Update(StudentsDataSet.Students)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error while Saving")
        End Try
    End Sub

End Class
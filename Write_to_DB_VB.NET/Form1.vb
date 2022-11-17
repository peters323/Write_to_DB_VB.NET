Imports System.Data.Entity

Public Class Form1
    Private db As NorthwindEntities

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = New NorthwindEntities()
        db.Customers.Load()
        CustomerBindingSource.DataSource = db.Customers.Local



    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        CustomerBindingSource.AddNew()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            CustomerBindingSource.RemoveCurrent()

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        db.SaveChanges()
        MessageBox.Show("Your data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim changed = db.ChangeTracker.Entries().Where(Function(x) x.State <> EntityState.Unchanged).ToList()
        For Each obj In changed
            Select Case obj.State
                Case EntityState.Modified
                    obj.CurrentValues.SetValues(obj.OriginalValues)
                    obj.State = EntityState.Unchanged
                Case EntityState.Added
                    obj.State = EntityState.Detached
                Case EntityState.Deleted
                    obj.State = EntityState.Unchanged
            End Select
        Next
        CustomerBindingSource.ResetBindings(False)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        db.Dispose()

    End Sub
End Class

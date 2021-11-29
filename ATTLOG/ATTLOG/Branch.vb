Public Class Branch
    Private Sub BranchBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BranchBindingNavigatorSaveItem.Click, BranchBindingNavigatorSaveItem.Click, BranchBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BranchBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AttLogDataSet)

    End Sub

    Private Sub Branch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AttLogDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.AttLogDataSet.Branch)

    End Sub

End Class
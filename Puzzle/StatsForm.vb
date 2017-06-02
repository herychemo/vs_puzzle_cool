Public Class StatsForm
    Private Sub StatsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = GlobalObj.users_list

    End Sub

End Class
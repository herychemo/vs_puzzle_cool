Public Class StatsForm
    Private Sub StatsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = GlobalObj.users_list

    End Sub


    Private Sub quit_here()

        Dim menu As Menu = New Menu
        menu.Show()
        Me.Close()
    End Sub

    Private Sub quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        quit_here()
    End Sub
End Class
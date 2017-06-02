Public Class StatsForm
    Private Sub StatsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenamos el grd a partir de los datos de los usuarios 
        DataGridView1.DataSource = GlobalObj.users_list

    End Sub


    Private Sub quit_here()
        'volvemos a menu
        Dim menu As Menu = New Menu
        menu.Show()
        Me.Close()
    End Sub

    Private Sub quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        quit_here()     ' llamamos al metodo que nos devuelve al menu 
    End Sub
End Class
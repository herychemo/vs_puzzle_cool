Public Class Menu

    Private Sub btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click

        Dim user_name = InputBox("Introduce tu nombre", "Input", "")    '' OBtenemos un nombre de usuario

        If user_name.Length = 0 Then    ' si el nombre esta vacio, mostramos error
            MsgBox("Debes intrducir un nombre")
            Return
        ElseIf user_name.Length > 10 Then       ' Si el nombre es muy largo, mostramos error
            MsgBox("Nombre demasiado largo")
            Return
        End If

        GlobalObj.user_name = user_name     ' si es correcto, guardamos nombre en variable global

        Dim pf = New PlayForm()
        pf.Show()   '' iniciamos Formulario de juego
        Me.Close()
    End Sub

    Private Sub btn_stats_Click(sender As Object, e As EventArgs) Handles btn_stats.Click
        Dim sf = New StatsForm()
        sf.Show()           ' se inicia formulario de estadisticas
        Me.Close()
    End Sub
End Class

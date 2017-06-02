Public Class Menu

    Private Sub btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click

        Dim user_name = InputBox("Introduce tu nombre", "Input", "")

        If user_name.Length = 0 Then
            MsgBox("Debes intrducir un nombre")
            Return
        ElseIf user_name.Length > 10 Then
            MsgBox("Nombre demasiado largo")
            Return
        End If

        GlobalObj.user_name = user_name

        Dim pf = New PlayForm()
        pf.Show()
        Me.Close()
    End Sub

    Private Sub btn_stats_Click(sender As Object, e As EventArgs) Handles btn_stats.Click
        Dim sf = New StatsForm()
        sf.Show()
        Me.Close()
    End Sub
End Class

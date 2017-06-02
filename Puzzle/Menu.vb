Public Class Menu

    Private Sub btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click
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

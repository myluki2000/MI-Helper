Public Class SoundTimeline

    Private Sub SelectSButton_Click(sender As Object, e As EventArgs) Handles SelectSButton.Click
        If OSDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SoundPlayer.URL = OSDialog.FileName
            Label1.Text = OSDialog.SafeFileName
            SoundPlayer.Ctlcontrols.stop()
        End If
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If PlayButton.Tag = "Paused" Then
            SoundPlayer.Ctlcontrols.play()
            PlayButton.Tag = "Playing"
            PlayButton.Text = "II"
        ElseIf PlayButton.Tag = "Playing" Then
            SoundPlayer.Ctlcontrols.pause()
            PlayButton.Tag = "Paused"
            PlayButton.Text = "►▌"
        End If
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        SoundPlayer.Ctlcontrols.stop()
    End Sub
End Class
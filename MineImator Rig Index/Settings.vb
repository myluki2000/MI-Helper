Public Class Settings

    Private Sub InstallLocButton_Click(sender As Object, e As EventArgs) Handles InstallLocButton.Click
        InstallLocDialog.ShowDialog()

        My.Settings.MILoc = InstallLocDialog.SelectedPath


        MILocTB.Text = My.Settings.MILoc
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        My.Settings.Save()
        Me.Close()
    End Sub
End Class
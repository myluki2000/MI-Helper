Public Class Generate

    Private Sub GenButton_Click(sender As Object, e As EventArgs) Handles GenButton.Click
        TreeGen.GenerateTree(StemLengthUD.Value)
    End Sub
End Class
Public Class Generate

    Private Sub GenButton_Click(sender As Object, e As EventArgs) Handles GenButton.Click
        TreeGen.GenerateTree(StemLengthUD.Value)
    End Sub

    Private Sub TreeMid1_Click(sender As Object, e As EventArgs) Handles TreeMid1.Click
        Select Case TreeMid1.Tag
            Case "Wood"
                TreeMid1.Tag = "Leaves"
                TreeMid1.Image = My.Resources.leaves_oak
            Case "Leaves"
                TreeMid1.Tag = "Air"
                TreeMid1.Image = Nothing
            Case "Air"
                TreeMid1.Tag = "Wood"
                TreeMid1.Image = My.Resources.oak_wood
        End Select
    End Sub

    Private Sub LeavesUD1_ValueChanged(sender As Object, e As EventArgs) Handles LeavesUD1.ValueChanged
        SimpleTreePage.Invalidate()
    End Sub

    Private Sub LeavesUD2_ValueChanged(sender As Object, e As EventArgs) Handles LeavesUD2.ValueChanged
        SimpleTreePage.Invalidate()
    End Sub

    Private Sub LeavesUD3_ValueChanged(sender As Object, e As EventArgs) Handles LeavesUD3.ValueChanged
        SimpleTreePage.Invalidate()
    End Sub

    Private Sub LeavesUD4_ValueChanged(sender As Object, e As EventArgs) Handles LeavesUD4.ValueChanged
        SimpleTreePage.Invalidate()
    End Sub

    Private Sub LeavesUD5_ValueChanged(sender As Object, e As EventArgs) Handles LeavesUD5.ValueChanged
        SimpleTreePage.Invalidate()
    End Sub

    Private Sub LeavesUD6_ValueChanged(sender As Object, e As EventArgs) Handles LeavesUD6.ValueChanged
        SimpleTreePage.Invalidate()
    End Sub

    Private Sub LeavesUD7_ValueChanged(sender As Object, e As EventArgs) Handles LeavesUD7.ValueChanged
        SimpleTreePage.Invalidate()
    End Sub

    Private Sub SimpleTreePage_Paint(sender As Object, e As PaintEventArgs) Handles SimpleTreePage.Paint
        For i As Integer = 1 To LeavesUD1.Value
            e.Graphics.DrawImage(My.Resources.leaves_oak, New Point(TreeMid1.Location.X + 55 * i, TreeMid1.Location.Y))
        Next
    End Sub
End Class
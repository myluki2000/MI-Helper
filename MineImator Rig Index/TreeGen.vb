Public Class Generate

    Private Sub GenButton_Click(sender As Object, e As EventArgs) Handles GenButton.Click
        TreeGen.GenerateSimpleTree()
    End Sub

    Private Sub TreeMidClick(TreeMid As PictureBox)
        Select Case TreeMid.Tag
            Case "Wood"
                TreeMid.Tag = "Leaves"
                TreeMid.Image = My.Resources.leaves_oak
            Case "Leaves"
                TreeMid.Tag = "Air"
                TreeMid.Image = Nothing
            Case "Air"
                TreeMid.Tag = "Wood"
                TreeMid.Image = My.Resources.oak_wood
        End Select
    End Sub

    Private Sub TreeMid1_Click(sender As Object, e As EventArgs) Handles TreeMid1.Click
        TreeMidClick(TreeMid1)
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

        For i As Integer = 1 To LeavesUD2.Value
            e.Graphics.DrawImage(My.Resources.leaves_oak, New Point(TreeMid2.Location.X + 55 * i, TreeMid2.Location.Y))
        Next

        For i As Integer = 1 To LeavesUD3.Value
            e.Graphics.DrawImage(My.Resources.leaves_oak, New Point(TreeMid3.Location.X + 55 * i, TreeMid3.Location.Y))
        Next

        For i As Integer = 1 To LeavesUD4.Value
            e.Graphics.DrawImage(My.Resources.leaves_oak, New Point(TreeMid4.Location.X + 55 * i, TreeMid4.Location.Y))
        Next

        For i As Integer = 1 To LeavesUD5.Value
            e.Graphics.DrawImage(My.Resources.leaves_oak, New Point(TreeMid5.Location.X + 55 * i, TreeMid5.Location.Y))
        Next

        For i As Integer = 1 To LeavesUD6.Value
            e.Graphics.DrawImage(My.Resources.leaves_oak, New Point(TreeMid6.Location.X + 55 * i, TreeMid6.Location.Y))
        Next

        For i As Integer = 1 To LeavesUD7.Value
            e.Graphics.DrawImage(My.Resources.leaves_oak, New Point(TreeMid7.Location.X + 55 * i, TreeMid7.Location.Y))
        Next
    End Sub

    Private Sub TreeMid2_Click(sender As Object, e As EventArgs) Handles TreeMid2.Click
        TreeMidClick(TreeMid2)
    End Sub

    Private Sub TreeMid3_Click(sender As Object, e As EventArgs) Handles TreeMid3.Click
        TreeMidClick(TreeMid3)
    End Sub

    Private Sub TreeMid4_Click(sender As Object, e As EventArgs) Handles TreeMid4.Click
        TreeMidClick(TreeMid4)
    End Sub

    Private Sub TreeMid5_Click(sender As Object, e As EventArgs) Handles TreeMid5.Click
        TreeMidClick(TreeMid5)
    End Sub

    Private Sub TreeMid6_Click(sender As Object, e As EventArgs) Handles TreeMid6.Click
        TreeMidClick(TreeMid6)
    End Sub

    Private Sub TreeMid7_Click(sender As Object, e As EventArgs) Handles TreeMid7.Click
        TreeMidClick(TreeMid7)
    End Sub
End Class
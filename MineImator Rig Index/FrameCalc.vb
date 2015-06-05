Public Class FrameCalc

    Private Sub FrameTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FrameTB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub TempoTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TempoTB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub TimeTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TimeTB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 44
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        If TempoTB.Text = "" Then
            TempoTB.Text = FrameTB.Text / TimeTB.Text
        ElseIf FrameTB.Text = "" Then
            FrameTB.Text = TempoTB.Text * TimeTB.Text

        ElseIf TimeTB.Text = "" Then
            TimeTB.Text = FrameTB.Text / TempoTB.Text
        End If
    End Sub
End Class
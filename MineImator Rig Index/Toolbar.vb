Public Class Toolbar

    Dim MoveOut As Boolean = True
    Dim YLoc As Integer
    Dim onFC As Boolean
    Dim onForm As Boolean
    Dim onRB As Boolean

    Private Sub FrameCalcBox_Click(sender As Object, e As EventArgs) Handles FrameCalcBox.Click
        FrameCalc.Show()
    End Sub

    Private Sub RigDLBox_Click(sender As Object, e As EventArgs) Handles RigDLBox.Click
        RigIndex.Show()
    End Sub

    Private Sub Toolbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2 - Me.Width, -60)

        Me.TopMost = True
    End Sub


    Private Sub MoveTimer_Tick(sender As Object, e As EventArgs) Handles MoveTimer.Tick
        If MoveOut Then
            YLoc += 8

            If YLoc < 0 Then
                Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2 - Me.Width, YLoc)
            Else
                MoveTimer.Stop()
                YLoc = 0
            End If
        Else
            YLoc -= 8

            If YLoc > -65 Then
                Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2 - Me.Width, YLoc)
            Else
                MoveTimer.Stop()
                YLoc = 0
            End If
        End If
    End Sub

    Private Sub Toolbar_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        MoveOut = True
        YLoc = Me.Location.Y
        MoveTimer.Start()

        If Screen.PrimaryScreen.Bounds.Width / 2 - Me.Width / 2 + 10 < Cursor.Position.X < Screen.PrimaryScreen.Bounds.Width / 2 + Me.Width / 2 - 5 AndAlso Cursor.Position.Y < 65 Then

        Else
            MoveOut = False
            YLoc = Me.Location.Y
            MoveTimer.Start()
        End If
    End Sub

    Private Sub Toolbar_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        If Screen.PrimaryScreen.Bounds.Width / 2 - Me.Width / 2 + 10 < Cursor.Position.X < Screen.PrimaryScreen.Bounds.Width / 2 + Me.Width / 2 - 5 AndAlso Cursor.Position.Y < 65 Then

        Else
            MoveOut = False
            YLoc = Me.Location.Y
            MoveTimer.Start()
        End If
    End Sub

    Private Sub FrameCalcBox_MouseDown(sender As Object, e As MouseEventArgs) Handles FrameCalcBox.MouseDown
        FrameCalcBox.BackColor = Color.DarkBlue
    End Sub

    Private Sub FrameCalcBox_MouseHover(sender As Object, e As EventArgs) Handles FrameCalcBox.MouseHover
        MoveOut = True
        YLoc = Me.Location.Y
        MoveTimer.Start()

        FrameCalcBox.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub RigDLBox_MouseDown(sender As Object, e As MouseEventArgs) Handles RigDLBox.MouseDown
        RigDLBox.BackColor = Color.DarkBlue
    End Sub

    Private Sub RigDLBox_MouseHover(sender As Object, e As EventArgs) Handles RigDLBox.MouseHover
        MoveOut = True
        YLoc = Me.Location.Y
        MoveTimer.Start()

        RigDLBox.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub FrameCalcBox_MouseLeave(sender As Object, e As EventArgs) Handles FrameCalcBox.MouseLeave
        FrameCalcBox.BackColor = Color.Transparent
    End Sub

    Private Sub RigDLBox_MouseLeave(sender As Object, e As EventArgs) Handles RigDLBox.MouseLeave
        RigDLBox.BackColor = Color.Transparent
    End Sub
End Class
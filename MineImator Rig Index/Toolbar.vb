﻿Imports System.IO

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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Generate.Show()
    End Sub

    Private Sub Toolbar_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If My.Settings.MILoc = "" Then
            If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Mine-Imator") Then
                My.Settings.MILoc = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Mine-Imator"
            Else
                Settings.Show()
                MsgBox("This is the first time you have started or your settings have been lost. Mine-Imator-Helper could not auto-detect the installation path of your Mine-Imator Installation. Please select it manually.")
            End If
        End If
    End Sub

    Private Sub TreeGenBox_Click(sender As Object, e As EventArgs) Handles TreeGenBox.Click
        Generate.Show()
    End Sub

    Private Sub TreeGenBox_MouseDown(sender As Object, e As MouseEventArgs) Handles TreeGenBox.MouseDown
        TreeGenBox.BackColor = Color.DarkBlue
    End Sub

    Private Sub TreeGenBox_MouseHover(sender As Object, e As EventArgs) Handles TreeGenBox.MouseHover
        MoveOut = True
        YLoc = Me.Location.Y
        MoveTimer.Start()

        TreeGenBox.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub TreeGenBox_MouseLeave(sender As Object, e As EventArgs) Handles TreeGenBox.MouseLeave
        TreeGenBox.BackColor = Color.Transparent
    End Sub

    Private Sub CloseBox_Click(sender As Object, e As EventArgs) Handles CloseBox.Click
        End
    End Sub

    Private Sub CloseBox_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseBox.MouseDown
        CloseBox.BackColor = Color.DarkBlue
    End Sub

    Private Sub CloseBox_MouseHover(sender As Object, e As EventArgs) Handles CloseBox.MouseHover
        MoveOut = True
        YLoc = Me.Location.Y
        MoveTimer.Start()

        CloseBox.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub CloseBox_MouseLeave(sender As Object, e As EventArgs) Handles CloseBox.MouseLeave
        CloseBox.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SoundTimeline.Show()
    End Sub
End Class
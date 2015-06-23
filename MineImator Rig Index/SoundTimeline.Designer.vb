<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoundTimeline
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SoundTimeline))
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.SelectSButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OSDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SoundPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.SetKFButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        CType(Me.SoundPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayButton
        '
        Me.PlayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.Location = New System.Drawing.Point(6, 8)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(52, 42)
        Me.PlayButton.TabIndex = 0
        Me.PlayButton.Tag = "Paused"
        Me.PlayButton.Text = "►"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'SelectSButton
        '
        Me.SelectSButton.Location = New System.Drawing.Point(238, 8)
        Me.SelectSButton.Name = "SelectSButton"
        Me.SelectSButton.Size = New System.Drawing.Size(81, 42)
        Me.SelectSButton.TabIndex = 1
        Me.SelectSButton.Text = "Select Music/Sound"
        Me.SelectSButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nothing Selected"
        '
        'SoundPlayer
        '
        Me.SoundPlayer.Enabled = True
        Me.SoundPlayer.Location = New System.Drawing.Point(89, 39)
        Me.SoundPlayer.Name = "SoundPlayer"
        Me.SoundPlayer.OcxState = CType(resources.GetObject("SoundPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SoundPlayer.Size = New System.Drawing.Size(75, 23)
        Me.SoundPlayer.TabIndex = 3
        Me.SoundPlayer.Visible = False
        '
        'SetKFButton
        '
        Me.SetKFButton.Location = New System.Drawing.Point(64, 8)
        Me.SetKFButton.Name = "SetKFButton"
        Me.SetKFButton.Size = New System.Drawing.Size(61, 42)
        Me.SetKFButton.TabIndex = 4
        Me.SetKFButton.Text = "Set Keyframe"
        Me.SetKFButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.Location = New System.Drawing.Point(6, 56)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(52, 42)
        Me.StopButton.TabIndex = 5
        Me.StopButton.Tag = ""
        Me.StopButton.Text = "■"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'SoundTimeline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 105)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.SetKFButton)
        Me.Controls.Add(Me.SoundPlayer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelectSButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Name = "SoundTimeline"
        Me.Text = "SoundTimeline"
        CType(Me.SoundPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents SelectSButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OSDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SoundPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents SetKFButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toolbar
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
        Me.components = New System.ComponentModel.Container()
        Me.RigDLBox = New System.Windows.Forms.PictureBox()
        Me.FrameCalcBox = New System.Windows.Forms.PictureBox()
        Me.MoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TreeGenBox = New System.Windows.Forms.PictureBox()
        CType(Me.RigDLBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrameCalcBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeGenBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RigDLBox
        '
        Me.RigDLBox.Image = Global.MineImator_Helper.My.Resources.Resources.RigDownload
        Me.RigDLBox.Location = New System.Drawing.Point(66, 12)
        Me.RigDLBox.Name = "RigDLBox"
        Me.RigDLBox.Size = New System.Drawing.Size(48, 48)
        Me.RigDLBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RigDLBox.TabIndex = 1
        Me.RigDLBox.TabStop = False
        '
        'FrameCalcBox
        '
        Me.FrameCalcBox.Image = Global.MineImator_Helper.My.Resources.Resources.frameCalc
        Me.FrameCalcBox.Location = New System.Drawing.Point(12, 12)
        Me.FrameCalcBox.Name = "FrameCalcBox"
        Me.FrameCalcBox.Size = New System.Drawing.Size(48, 48)
        Me.FrameCalcBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FrameCalcBox.TabIndex = 0
        Me.FrameCalcBox.TabStop = False
        '
        'MoveTimer
        '
        Me.MoveTimer.Interval = 15
        '
        'TreeGenBox
        '
        Me.TreeGenBox.Image = Global.MineImator_Helper.My.Resources.Resources.TreeGen
        Me.TreeGenBox.Location = New System.Drawing.Point(120, 12)
        Me.TreeGenBox.Name = "TreeGenBox"
        Me.TreeGenBox.Size = New System.Drawing.Size(48, 48)
        Me.TreeGenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TreeGenBox.TabIndex = 2
        Me.TreeGenBox.TabStop = False
        '
        'Toolbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(181, 70)
        Me.Controls.Add(Me.TreeGenBox)
        Me.Controls.Add(Me.FrameCalcBox)
        Me.Controls.Add(Me.RigDLBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Toolbar"
        Me.Text = "Toolbar"
        CType(Me.RigDLBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrameCalcBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeGenBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FrameCalcBox As System.Windows.Forms.PictureBox
    Friend WithEvents RigDLBox As System.Windows.Forms.PictureBox
    Friend WithEvents MoveTimer As System.Windows.Forms.Timer
    Friend WithEvents TreeGenBox As System.Windows.Forms.PictureBox
End Class

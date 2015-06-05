<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrameCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrameCalc))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.TempoTB = New System.Windows.Forms.TextBox()
        Me.TimeTB = New System.Windows.Forms.TextBox()
        Me.FrameTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tempo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Time in seconds:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Frame Count:"
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(15, 173)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(353, 40)
        Me.CalcButton.TabIndex = 9
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'TempoTB
        '
        Me.TempoTB.Location = New System.Drawing.Point(105, 89)
        Me.TempoTB.Name = "TempoTB"
        Me.TempoTB.Size = New System.Drawing.Size(263, 20)
        Me.TempoTB.TabIndex = 10
        '
        'TimeTB
        '
        Me.TimeTB.Location = New System.Drawing.Point(105, 115)
        Me.TimeTB.Name = "TimeTB"
        Me.TimeTB.Size = New System.Drawing.Size(263, 20)
        Me.TimeTB.TabIndex = 11
        '
        'FrameTB
        '
        Me.FrameTB.Location = New System.Drawing.Point(105, 141)
        Me.FrameTB.Name = "FrameTB"
        Me.FrameTB.Size = New System.Drawing.Size(263, 20)
        Me.FrameTB.TabIndex = 12
        '
        'FrameCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 225)
        Me.Controls.Add(Me.FrameTB)
        Me.Controls.Add(Me.TimeTB)
        Me.Controls.Add(Me.TempoTB)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.Name = "FrameCalc"
        Me.Text = "Frame Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents TempoTB As System.Windows.Forms.TextBox
    Friend WithEvents TimeTB As System.Windows.Forms.TextBox
    Friend WithEvents FrameTB As System.Windows.Forms.TextBox
End Class

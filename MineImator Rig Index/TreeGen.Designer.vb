<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreeGen
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
        Me.GenButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StemLengthUD = New System.Windows.Forms.NumericUpDown()
        CType(Me.StemLengthUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenButton
        '
        Me.GenButton.Location = New System.Drawing.Point(12, 221)
        Me.GenButton.Name = "GenButton"
        Me.GenButton.Size = New System.Drawing.Size(260, 29)
        Me.GenButton.TabIndex = 0
        Me.GenButton.Text = "Generate Tree"
        Me.GenButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Stem Length:"
        '
        'StemLengthUD
        '
        Me.StemLengthUD.Location = New System.Drawing.Point(85, 7)
        Me.StemLengthUD.Name = "StemLengthUD"
        Me.StemLengthUD.Size = New System.Drawing.Size(187, 20)
        Me.StemLengthUD.TabIndex = 3
        '
        'TreeGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.StemLengthUD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GenButton)
        Me.Name = "TreeGen"
        Me.Text = "TreeGen"
        CType(Me.StemLengthUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GenButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StemLengthUD As System.Windows.Forms.NumericUpDown
End Class

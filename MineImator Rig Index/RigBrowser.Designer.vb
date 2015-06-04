<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RigBrowser
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WB = New System.Windows.Forms.WebBrowser()
        Me.SStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'WB
        '
        Me.WB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WB.Location = New System.Drawing.Point(0, 0)
        Me.WB.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB.Name = "WB"
        Me.WB.ScriptErrorsSuppressed = True
        Me.WB.Size = New System.Drawing.Size(993, 457)
        Me.WB.TabIndex = 0
        '
        'SStrip
        '
        Me.SStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.SStrip.Location = New System.Drawing.Point(0, 435)
        Me.SStrip.Name = "SStrip"
        Me.SStrip.Size = New System.Drawing.Size(993, 22)
        Me.SStrip.TabIndex = 1
        Me.SStrip.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(132, 17)
        Me.StatusLabel.Text = "Selecting Rig Download"
        '
        'RigBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 457)
        Me.Controls.Add(Me.SStrip)
        Me.Controls.Add(Me.WB)
        Me.Name = "RigBrowser"
        Me.Text = "RigBrowser"
        Me.SStrip.ResumeLayout(False)
        Me.SStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WB As System.Windows.Forms.WebBrowser
    Friend WithEvents SStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.MILocTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InstallLocButton = New System.Windows.Forms.Button()
        Me.InstallLocDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MILocTB
        '
        Me.MILocTB.Location = New System.Drawing.Point(149, 26)
        Me.MILocTB.Name = "MILocTB"
        Me.MILocTB.Size = New System.Drawing.Size(237, 20)
        Me.MILocTB.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mine-imator Install location"
        '
        'InstallLocButton
        '
        Me.InstallLocButton.Location = New System.Drawing.Point(392, 24)
        Me.InstallLocButton.Name = "InstallLocButton"
        Me.InstallLocButton.Size = New System.Drawing.Size(75, 23)
        Me.InstallLocButton.TabIndex = 2
        Me.InstallLocButton.Text = "Select"
        Me.InstallLocButton.UseVisualStyleBackColor = True
        '
        'InstallLocDialog
        '
        Me.InstallLocDialog.RootFolder = System.Environment.SpecialFolder.UserProfile
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(15, 61)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(453, 32)
        Me.OkButton.TabIndex = 3
        Me.OkButton.Text = "Save"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 105)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.InstallLocButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MILocTB)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MILocTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InstallLocButton As System.Windows.Forms.Button
    Friend WithEvents InstallLocDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OkButton As System.Windows.Forms.Button
End Class

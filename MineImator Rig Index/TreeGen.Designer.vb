<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generate
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.SimpleTreePage = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LeavesUD1 = New System.Windows.Forms.NumericUpDown()
        Me.LeavesUD2 = New System.Windows.Forms.NumericUpDown()
        Me.LeavesUD3 = New System.Windows.Forms.NumericUpDown()
        Me.LeavesUD4 = New System.Windows.Forms.NumericUpDown()
        Me.LeavesUD5 = New System.Windows.Forms.NumericUpDown()
        Me.LeavesUD6 = New System.Windows.Forms.NumericUpDown()
        Me.LeavesUD7 = New System.Windows.Forms.NumericUpDown()
        Me.TreeMid7 = New System.Windows.Forms.PictureBox()
        Me.TreeMid6 = New System.Windows.Forms.PictureBox()
        Me.TreeMid5 = New System.Windows.Forms.PictureBox()
        Me.TreeMid4 = New System.Windows.Forms.PictureBox()
        Me.TreeMid3 = New System.Windows.Forms.PictureBox()
        Me.TreeMid2 = New System.Windows.Forms.PictureBox()
        Me.TreeMid1 = New System.Windows.Forms.PictureBox()
        Me.SFDialog = New System.Windows.Forms.SaveFileDialog()
        CType(Me.StemLengthUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SimpleTreePage.SuspendLayout()
        CType(Me.LeavesUD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeavesUD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeavesUD3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeavesUD4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeavesUD5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeavesUD6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeavesUD7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeMid7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeMid6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeMid5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeMid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeMid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeMid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeMid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenButton
        '
        Me.GenButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenButton.Location = New System.Drawing.Point(12, 464)
        Me.GenButton.Name = "GenButton"
        Me.GenButton.Size = New System.Drawing.Size(506, 29)
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
        Me.Label1.Visible = False
        '
        'StemLengthUD
        '
        Me.StemLengthUD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StemLengthUD.Location = New System.Drawing.Point(85, 7)
        Me.StemLengthUD.Name = "StemLengthUD"
        Me.StemLengthUD.Size = New System.Drawing.Size(433, 20)
        Me.StemLengthUD.TabIndex = 3
        Me.StemLengthUD.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.SimpleTreePage)
        Me.TabControl1.Location = New System.Drawing.Point(7, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(511, 451)
        Me.TabControl1.TabIndex = 4
        '
        'SimpleTreePage
        '
        Me.SimpleTreePage.Controls.Add(Me.Label2)
        Me.SimpleTreePage.Controls.Add(Me.LeavesUD1)
        Me.SimpleTreePage.Controls.Add(Me.LeavesUD2)
        Me.SimpleTreePage.Controls.Add(Me.LeavesUD3)
        Me.SimpleTreePage.Controls.Add(Me.LeavesUD4)
        Me.SimpleTreePage.Controls.Add(Me.LeavesUD5)
        Me.SimpleTreePage.Controls.Add(Me.LeavesUD6)
        Me.SimpleTreePage.Controls.Add(Me.LeavesUD7)
        Me.SimpleTreePage.Controls.Add(Me.TreeMid7)
        Me.SimpleTreePage.Controls.Add(Me.TreeMid6)
        Me.SimpleTreePage.Controls.Add(Me.TreeMid5)
        Me.SimpleTreePage.Controls.Add(Me.TreeMid4)
        Me.SimpleTreePage.Controls.Add(Me.TreeMid3)
        Me.SimpleTreePage.Controls.Add(Me.TreeMid2)
        Me.SimpleTreePage.Controls.Add(Me.TreeMid1)
        Me.SimpleTreePage.Location = New System.Drawing.Point(4, 22)
        Me.SimpleTreePage.Name = "SimpleTreePage"
        Me.SimpleTreePage.Padding = New System.Windows.Forms.Padding(3)
        Me.SimpleTreePage.Size = New System.Drawing.Size(503, 425)
        Me.SimpleTreePage.TabIndex = 0
        Me.SimpleTreePage.Text = "Simple Tree"
        Me.SimpleTreePage.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 26)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Leave Blocks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LeavesUD1
        '
        Me.LeavesUD1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LeavesUD1.Location = New System.Drawing.Point(466, 357)
        Me.LeavesUD1.Name = "LeavesUD1"
        Me.LeavesUD1.Size = New System.Drawing.Size(31, 20)
        Me.LeavesUD1.TabIndex = 13
        '
        'LeavesUD2
        '
        Me.LeavesUD2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LeavesUD2.Location = New System.Drawing.Point(466, 303)
        Me.LeavesUD2.Name = "LeavesUD2"
        Me.LeavesUD2.Size = New System.Drawing.Size(31, 20)
        Me.LeavesUD2.TabIndex = 12
        '
        'LeavesUD3
        '
        Me.LeavesUD3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LeavesUD3.Location = New System.Drawing.Point(466, 249)
        Me.LeavesUD3.Name = "LeavesUD3"
        Me.LeavesUD3.Size = New System.Drawing.Size(31, 20)
        Me.LeavesUD3.TabIndex = 11
        '
        'LeavesUD4
        '
        Me.LeavesUD4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LeavesUD4.Location = New System.Drawing.Point(466, 195)
        Me.LeavesUD4.Name = "LeavesUD4"
        Me.LeavesUD4.Size = New System.Drawing.Size(31, 20)
        Me.LeavesUD4.TabIndex = 10
        '
        'LeavesUD5
        '
        Me.LeavesUD5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LeavesUD5.Location = New System.Drawing.Point(466, 141)
        Me.LeavesUD5.Name = "LeavesUD5"
        Me.LeavesUD5.Size = New System.Drawing.Size(31, 20)
        Me.LeavesUD5.TabIndex = 9
        '
        'LeavesUD6
        '
        Me.LeavesUD6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LeavesUD6.Location = New System.Drawing.Point(466, 87)
        Me.LeavesUD6.Name = "LeavesUD6"
        Me.LeavesUD6.Size = New System.Drawing.Size(31, 20)
        Me.LeavesUD6.TabIndex = 8
        '
        'LeavesUD7
        '
        Me.LeavesUD7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LeavesUD7.Location = New System.Drawing.Point(466, 33)
        Me.LeavesUD7.Name = "LeavesUD7"
        Me.LeavesUD7.Size = New System.Drawing.Size(31, 20)
        Me.LeavesUD7.TabIndex = 7
        '
        'TreeMid7
        '
        Me.TreeMid7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeMid7.Image = Global.MineImator_Helper.My.Resources.Resources.oak_wood
        Me.TreeMid7.Location = New System.Drawing.Point(6, 20)
        Me.TreeMid7.Name = "TreeMid7"
        Me.TreeMid7.Size = New System.Drawing.Size(48, 48)
        Me.TreeMid7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TreeMid7.TabIndex = 6
        Me.TreeMid7.TabStop = False
        Me.TreeMid7.Tag = "Wood"
        '
        'TreeMid6
        '
        Me.TreeMid6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeMid6.Image = Global.MineImator_Helper.My.Resources.Resources.oak_wood
        Me.TreeMid6.Location = New System.Drawing.Point(6, 74)
        Me.TreeMid6.Name = "TreeMid6"
        Me.TreeMid6.Size = New System.Drawing.Size(48, 48)
        Me.TreeMid6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TreeMid6.TabIndex = 5
        Me.TreeMid6.TabStop = False
        Me.TreeMid6.Tag = "Wood"
        '
        'TreeMid5
        '
        Me.TreeMid5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeMid5.Image = Global.MineImator_Helper.My.Resources.Resources.oak_wood
        Me.TreeMid5.Location = New System.Drawing.Point(6, 128)
        Me.TreeMid5.Name = "TreeMid5"
        Me.TreeMid5.Size = New System.Drawing.Size(48, 48)
        Me.TreeMid5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TreeMid5.TabIndex = 4
        Me.TreeMid5.TabStop = False
        Me.TreeMid5.Tag = "Wood"
        '
        'TreeMid4
        '
        Me.TreeMid4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeMid4.Image = Global.MineImator_Helper.My.Resources.Resources.oak_wood
        Me.TreeMid4.Location = New System.Drawing.Point(6, 182)
        Me.TreeMid4.Name = "TreeMid4"
        Me.TreeMid4.Size = New System.Drawing.Size(48, 48)
        Me.TreeMid4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TreeMid4.TabIndex = 3
        Me.TreeMid4.TabStop = False
        Me.TreeMid4.Tag = "Wood"
        '
        'TreeMid3
        '
        Me.TreeMid3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeMid3.Image = Global.MineImator_Helper.My.Resources.Resources.oak_wood
        Me.TreeMid3.Location = New System.Drawing.Point(6, 236)
        Me.TreeMid3.Name = "TreeMid3"
        Me.TreeMid3.Size = New System.Drawing.Size(48, 48)
        Me.TreeMid3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TreeMid3.TabIndex = 2
        Me.TreeMid3.TabStop = False
        Me.TreeMid3.Tag = "Wood"
        '
        'TreeMid2
        '
        Me.TreeMid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeMid2.Image = Global.MineImator_Helper.My.Resources.Resources.oak_wood
        Me.TreeMid2.Location = New System.Drawing.Point(6, 290)
        Me.TreeMid2.Name = "TreeMid2"
        Me.TreeMid2.Size = New System.Drawing.Size(48, 48)
        Me.TreeMid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TreeMid2.TabIndex = 1
        Me.TreeMid2.TabStop = False
        Me.TreeMid2.Tag = "Wood"
        '
        'TreeMid1
        '
        Me.TreeMid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeMid1.Image = Global.MineImator_Helper.My.Resources.Resources.oak_wood
        Me.TreeMid1.Location = New System.Drawing.Point(6, 344)
        Me.TreeMid1.Name = "TreeMid1"
        Me.TreeMid1.Size = New System.Drawing.Size(48, 48)
        Me.TreeMid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TreeMid1.TabIndex = 0
        Me.TreeMid1.TabStop = False
        Me.TreeMid1.Tag = "Wood"
        '
        'SFDialog
        '
        Me.SFDialog.Filter = "Schematic Files|*.schematic"
        '
        'Generate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 505)
        Me.Controls.Add(Me.StemLengthUD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GenButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Generate"
        Me.Text = "TreeGen"
        CType(Me.StemLengthUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.SimpleTreePage.ResumeLayout(False)
        Me.SimpleTreePage.PerformLayout()
        CType(Me.LeavesUD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeavesUD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeavesUD3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeavesUD4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeavesUD5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeavesUD6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeavesUD7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeMid7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeMid6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeMid5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeMid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeMid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeMid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeMid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GenButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StemLengthUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents SimpleTreePage As System.Windows.Forms.TabPage
    Friend WithEvents TreeMid1 As System.Windows.Forms.PictureBox
    Friend WithEvents TreeMid7 As System.Windows.Forms.PictureBox
    Friend WithEvents TreeMid6 As System.Windows.Forms.PictureBox
    Friend WithEvents TreeMid5 As System.Windows.Forms.PictureBox
    Friend WithEvents TreeMid4 As System.Windows.Forms.PictureBox
    Friend WithEvents TreeMid3 As System.Windows.Forms.PictureBox
    Friend WithEvents TreeMid2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LeavesUD1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LeavesUD2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LeavesUD3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LeavesUD4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LeavesUD5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LeavesUD6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LeavesUD7 As System.Windows.Forms.NumericUpDown
    Friend WithEvents SFDialog As System.Windows.Forms.SaveFileDialog
End Class

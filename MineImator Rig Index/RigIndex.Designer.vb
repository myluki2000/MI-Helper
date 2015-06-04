<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RigIndex
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
        Me.GetRigsButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchTB = New System.Windows.Forms.TextBox()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.RigName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RigLink = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WB
        '
        Me.WB.Location = New System.Drawing.Point(861, 29)
        Me.WB.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB.Name = "WB"
        Me.WB.Size = New System.Drawing.Size(40, 20)
        Me.WB.TabIndex = 0
        Me.WB.Url = New System.Uri("", System.UriKind.Relative)
        Me.WB.Visible = False
        '
        'GetRigsButton
        '
        Me.GetRigsButton.Location = New System.Drawing.Point(12, 8)
        Me.GetRigsButton.Name = "GetRigsButton"
        Me.GetRigsButton.Size = New System.Drawing.Size(120, 31)
        Me.GetRigsButton.TabIndex = 1
        Me.GetRigsButton.Text = "Get Rigs"
        Me.GetRigsButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(814, 8)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 32)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SearchTB
        '
        Me.SearchTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTB.Location = New System.Drawing.Point(264, 12)
        Me.SearchTB.Name = "SearchTB"
        Me.SearchTB.Size = New System.Drawing.Size(544, 23)
        Me.SearchTB.TabIndex = 3
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(138, 8)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(120, 31)
        Me.StopButton.TabIndex = 4
        Me.StopButton.Text = "Stop Fetching Rigs"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.StopButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SearchTB)
        Me.SplitContainer1.Panel2.Controls.Add(Me.WB)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SearchButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GetRigsButton)
        Me.SplitContainer1.Size = New System.Drawing.Size(901, 492)
        Me.SplitContainer1.SplitterDistance = 439
        Me.SplitContainer1.TabIndex = 5
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.Author, Me.ColumnHeader2})
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Location = New System.Drawing.Point(0, 0)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(901, 439)
        Me.ListView2.TabIndex = 9
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        Me.ListView2.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Rig"
        Me.ColumnHeader1.Width = 350
        '
        'Author
        '
        Me.Author.Text = "Author"
        Me.Author.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Link"
        Me.ColumnHeader2.Width = 200
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RigName, Me.RigLink})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(901, 439)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'RigName
        '
        Me.RigName.Text = "Rig"
        Me.RigName.Width = 350
        '
        'RigLink
        '
        Me.RigLink.Text = "Link"
        Me.RigLink.Width = 200
        '
        'RigIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 492)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "RigIndex"
        Me.Text = "Rig Index"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WB As System.Windows.Forms.WebBrowser
    Friend WithEvents GetRigsButton As System.Windows.Forms.Button
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents SearchTB As System.Windows.Forms.TextBox
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents RigName As System.Windows.Forms.ColumnHeader
    Friend WithEvents RigLink As System.Windows.Forms.ColumnHeader
    Friend WithEvents Author As System.Windows.Forms.ColumnHeader

End Class

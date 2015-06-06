Imports System.Text.RegularExpressions

Public Class RigIndex

    Dim page As Integer = 0

    Dim keepLoading As Boolean = True

    Dim illegalTitles As String() = { _
        "Return to Mine-imator",
        "Return to Mine-imator resources",
        "Return to Rigs",
        "Read this before posting!",
        "How to install rigs!"}

    Private Sub GetRigsButton_Click(sender As System.Object, e As System.EventArgs) Handles GetRigsButton.Click
        getPostTitles()
        keepLoading = True
    End Sub

    Private Sub getPostTitles()
        WB.Navigate("http://www.mineimatorforums.com/index.php?/forum/23-rigs/page-" & page)
    End Sub

    Private Sub SearchButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchButton.Click
        FindItems()
    End Sub

    Private Sub StopButton_Click(sender As System.Object, e As System.EventArgs) Handles StopButton.Click
        keepLoading = False
    End Sub

    Private Sub WB_DocumentCompleted(sender As Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WB.DocumentCompleted
        Dim titleClean As Boolean = True

        If WB.Document.Title = "Error - Mine-imator forums" Then
            keepLoading = False
            MsgBox("Rig index has been pulled from the Forums")
            Exit Sub
        End If

        For Each a In WB.Document.GetElementsByTagName("a")
            titleClean = True
            If a.getAttribute("itemprop") = "url" Then
                titleClean = True
                For Each title In illegalTitles
                    If a.getAttribute("title").contains(title) OrElse a.getAttribute("href") = "http://www.mineimatorforums.com/" Then
                        titleClean = False
                    End If
                Next
                If titleClean Then
                    ListView1.Items.Add(a.getAttribute("title")).SubItems.add(a.getAttribute("href"))

                End If


            End If
            titleClean = True
        Next

        'Dim LVItem As New ListViewItem("")

        'For Each a In WB.Document.GetElementsByTagName("a")
        '    titleClean = True

        '    If a.getAttribute("itemprop") = "url" Then

        '        LVItem.SubItems.Add(a.getAttribute("href"))
        '        ListView1.Items.AddRange(New ListViewItem() {New ListViewItem(a.getAttribute("title"))})
        '    End If

        'Next



        If keepLoading Then
            page += 1
            getPostTitles()
        End If
    End Sub

    Private Sub SearchTB_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles SearchTB.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindItems()
        End If
    End Sub

    Private Sub SearchTB_TextChanged(sender As System.Object, e As System.EventArgs) Handles SearchTB.TextChanged
        If SearchTB.Text = "" Then
            ListView2.Visible = False
        End If
    End Sub

    Private Sub FindItems()
        ListView2.Items.Clear()


        For Each item In ListView1.Items
            If item.text.toLower.contains(SearchTB.Text.ToLower) Then
                ListView2.Items.Add(item.text).SubItems.Add(item.SubItems(1).text)
                ListView2.Visible = True
            End If
        Next
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As System.EventArgs) Handles ListView1.DoubleClick
        RigBrowser.loadUrl(ListView1.SelectedItems(0).SubItems(1).Text)
        RigBrowser.Show()
    End Sub

    Private Sub ListView2_DoubleClick(sender As Object, e As System.EventArgs) Handles ListView2.DoubleClick
        RigBrowser.loadUrl(ListView2.SelectedItems(0).SubItems(1).Text)
        RigBrowser.Show()
    End Sub

    Private Sub RigIndex_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        SplitContainer1.SplitterDistance = Me.Height - 80
    End Sub
End Class

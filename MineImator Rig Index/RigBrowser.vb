Imports SevenZip
Imports System.IO
Imports System.Runtime.InteropServices
Imports mshtml

Public Class RigBrowser

    Dim url As String

    Public Sub loadUrl(Url As String)
        WB.Navigate("")
        WB.Navigate(Url)
    End Sub

    Private Sub WB_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WB.DocumentCompleted
        Dim link As HtmlElement
        Dim links As Windows.Forms.HtmlElementCollection = WB.Document.Links
        For Each link In links
            link.AttachEventHandler("onclick", AddressOf LinkClicked)
        Next
    End Sub

    Private Sub WB_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WB.Navigated

        Dim doc As IHTMLDocument2 = TryCast(WB.Document.DomDocument, IHTMLDocument2)
        ' The first parameter is the url, the second is the index of the added style sheet.
        Dim ss As IHTMLStyleSheet = doc.createStyleSheet("", 0)

        ' Now that you have the style sheet you have a few options:
        ' 1. You can just set the content as text.
        ss.addRule("#content", "margin-right:0px;margin-left:0px;width:auto !important;min-width:10px;margin-top:-200px !important;")
        ss.addRule("#header_bar", "height: 0px;visibility:hidden;")
        ss.addRule("body", "margin-top:-70px !important;")
        ss.addRule("#branding", "height:0px;visibility:hidden;margin-top:-130px;")
        ss.addRule("#primary_nav", "visibility:hidden !important;z-index:0 !important;")

    End Sub

    Private Sub WB_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WB.Navigating
        If WB.StatusText.EndsWith(".zip") OrElse WB.StatusText.EndsWith(".object") Then
            e.Cancel = True
        End If
    End Sub

    Private Sub WB_NewWindow(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WB.NewWindow
        e.Cancel = True


        WB.Navigate(WB.StatusText)


    End Sub

    Private Sub LinkClicked(ByVal sender As Object, ByVal e As EventArgs)

        Dim link As HtmlElement = WB.Document.ActiveElement
        Dim url As String = link.GetAttribute("href")
        If url.EndsWith(".zip") Then 'zip downloading and extracting
            Try
                StatusLabel.Text = "Downloading Rig..."
                My.Computer.Network.DownloadFile(url, My.Settings.MILoc & "\Downloaded Rigs\" & Path.GetFileName(url))
                SevenZip.SevenZipCompressor.SetLibraryPath("F:\Users\Lukas\Documents\Visual Studio 2013\Projects\MineImator Helper\MineImator Rig Index\bin\Debug\7z.dll")

                System.IO.Directory.CreateDirectory(My.Settings.MILoc & "\Downloaded Rigs\" & Path.GetFileNameWithoutExtension(url))


                Dim dlFile = New SevenZipExtractor(My.Settings.MILoc & "\Downloaded Rigs\" & Path.GetFileName(url))
                StatusLabel.Text = "Extracting Rig..."
                Try
                    dlFile.ExtractArchive(My.Settings.MILoc & "\Downloaded Rigs\" & Path.GetFileNameWithoutExtension(url))
                Catch archiveEx As SevenZip.SevenZipArchiveException
                    MsgBox("Error! The downloaded archive might be corrupted.")
                End Try

                File.Delete(My.Settings.MILoc & "\Downloaded Rigs\" & Path.GetFileName(url))

            Catch ex As IO.IOException

            End Try


        ElseIf url.EndsWith(".7z") Then '7z downloading and extracting


            Try
                StatusLabel.Text = "Downloading Rig..."
                My.Computer.Network.DownloadFile(url, My.Settings.MILoc & "\Downloaded Rigs\" & Path.GetFileName(url))
                SevenZip.SevenZipCompressor.SetLibraryPath("F:\Users\Lukas\Documents\Visual Studio 2013\Projects\MineImator Helper\MineImator Rig Index\bin\Debug\7z.dll")

                System.IO.Directory.CreateDirectory(My.Settings.MILoc & "\Downloaded Rigs\" & Path.GetFileNameWithoutExtension(url))


                Dim dlFile = New SevenZipExtractor(My.Settings.MILoc & "\Downloaded Rigs\" & Path.GetFileName(url))
                StatusLabel.Text = "Extracting Rig..."
                Try
                    dlFile.ExtractArchive(My.Settings.MILoc & "\Downloaded Rigs\" & Path.GetFileNameWithoutExtension(url))

                    '
                    ' 7z EXTRACTOR
                    '

                Catch archiveEx As SevenZip.SevenZipArchiveException
                    MsgBox("Error! The downloaded archive might be corrupted.")
                End Try

                File.Delete(My.Settings.MILoc & "\Downloaded Rigs\" & Path.GetFileName(url))

            Catch ex As IO.IOException

            End Try

        ElseIf url.EndsWith(".object") Then 'Object downloading and saving

            Try
                StatusLabel.Text = "Downloading Rig..."
                My.Computer.Network.DownloadFile(url, My.Settings.MILoc & "\Downloaded Rigs\" & Path.GetFileName(url))
                SevenZip.SevenZipCompressor.SetLibraryPath("F:\Users\Lukas\Documents\Visual Studio 2013\Projects\MineImator Helper\MineImator Rig Index\bin\Debug\7z.dll")
            Catch ex As IO.IOException

            End Try
        Else
            WB.Navigate(url)
        End If
        StatusLabel.Text = "Done"
    End Sub

    Private Sub RigBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusLabel.Text = "Selecting Rig Download"
    End Sub
End Class
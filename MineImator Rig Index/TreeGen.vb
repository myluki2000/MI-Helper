Imports Substrate

Public Class TreeGen

    Private Sub GenButton_Click(sender As Object, e As EventArgs) Handles GenButton.Click
        Dim schem As Substrate.ImportExport.Schematic = New ImportExport.Schematic(10, 10, 10)

        For i As Integer = 1 To StemLengthUD.Value
            schem.Blocks.SetBlock(0, i, 0, New AlphaBlock(17))
        Next

        schem.Export("C:\Test\test.schematic")
    End Sub
End Class
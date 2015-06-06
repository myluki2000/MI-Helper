Imports Substrate

Public Class TreeGen
    Shared BlockLog As New AlphaBlock(17)
    Shared r = New Random
    Shared schem As Substrate.ImportExport.Schematic

    Public Shared Sub GenerateTree(stemHeight As Integer)

        schem = New ImportExport.Schematic(20, 20, 20)


        Dim BlockLog As New AlphaBlock(17)
        BlockLog.Data = 8

        For i As Integer = 1 To stemHeight
            schem.Blocks.SetBlock(10, i, 10, New AlphaBlock(17))

            If i = 4 AndAlso stemHeight > 7 Then
                GenerateBranch(10, i, 10, "nesw")
            End If
        Next

        schem.Export("C:\Test\test.schematic")
    End Sub

    Private Shared Sub GenerateBranch(AroundX As Integer, AroundY As Integer, AroundZ As Integer, Directions As String)
        Select Case r.Next(0, 4)
            Case 0
                If Directions.Contains("n") Then
                    BlockLog.Data = 4
                    schem.Blocks.SetBlock(AroundX, AroundY, AroundZ, BlockLog)
                End If
            Case 1
                If Directions.Contains("e") Then
                    BlockLog.Data = 4
                    schem.Blocks.SetBlock(AroundX, AroundY, AroundZ, BlockLog)
                End If
            Case 2
                If Directions.Contains("s") Then
                    BlockLog.Data = 8
                    schem.Blocks.SetBlock(AroundX, AroundY, AroundZ, BlockLog)
                End If
            Case 3
                If Directions.Contains("w") Then
                    BlockLog.Data = 8
                    schem.Blocks.SetBlock(AroundX, AroundY, AroundZ, BlockLog)
                End If
        End Select
    End Sub
End Class

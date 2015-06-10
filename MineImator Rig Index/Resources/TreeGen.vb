Imports Substrate
Imports System.Windows

Public Class TreeGen
    Shared BlockLog As New AlphaBlock(17)
    Shared r = New Random
    Shared schem As Substrate.ImportExport.Schematic

    Public Shared Sub GenerateTree(stemHeight As Integer)
        Dim branchPos As Vector3
        Dim blockPos As New Vector3

        schem = New ImportExport.Schematic(20, 20, 20)

        Dim BlockLog As New AlphaBlock(17)
        BlockLog.Data = 8

        blockPos.X = 10
        blockPos.Z = 10


        schem.Export("C:\Test\test.schematic")
    End Sub

    Public Shared Sub GenerateSimpleTree()
        schem = New ImportExport.Schematic(21, 20, 21)

        For Each pic As Object In Generate.SimpleTreePage.Controls
            If TypeOf pic Is PictureBox Then
                Dim block As New AlphaBlock(BlockType.AIR)
                Select Case pic.tag
                    Case "Wood"
                        block.ID = BlockType.WOOD
                    Case "Leaves"
                        block.ID = BlockType.LEAVES
                    Case "Air"
                        block.ID = BlockType.AIR
                End Select
                schem.Blocks.SetBlock(10, CInt(Right(pic.name, 1)) - 1, 10, block)
            End If
        Next

        For Each UpDown As Object In Generate.SimpleTreePage.Controls
            If TypeOf UpDown Is NumericUpDown Then
                Dim Pos As New Vector3
                Pos.X = 10
                Pos.Y = CInt(Right(UpDown.name, 1)) - 1
                Pos.Z = 10

                GenLeavesAround(UpDown.value, Pos)
            End If
        Next

        Generate.SFDialog.InitialDirectory = My.Settings.MILoc
        If Generate.SFDialog.ShowDialog = DialogResult.OK Then
            schem.Export(Generate.SFDialog.FileName)
        End If
    End Sub

    Private Shared Function GenerateBranch(AroundX As Integer, AroundY As Integer, AroundZ As Integer, Directions As String)
        Dim branchPos As New Vector3
        Select Case r.Next(0, 4)
            Case 0
                If Directions.Contains("n") Then
                    BlockLog.Data = 4
                    schem.Blocks.SetBlock(AroundX + 1, AroundY, AroundZ, BlockLog)

                    branchPos.X = AroundX + 1
                    branchPos.Y = AroundY
                    branchPos.Z = AroundZ
                    Return branchPos
                End If
            Case 1
                If Directions.Contains("e") Then
                    BlockLog.Data = 4
                    schem.Blocks.SetBlock(AroundX, AroundY, AroundZ + 1, BlockLog)

                    branchPos.X = AroundX
                    branchPos.Y = AroundY
                    branchPos.Z = AroundZ + 1
                    Return branchPos
                End If
            Case 2
                If Directions.Contains("s") Then
                    BlockLog.Data = 8
                    schem.Blocks.SetBlock(AroundX - 1, AroundY, AroundZ, BlockLog)

                    branchPos.X = AroundX - 1
                    branchPos.Y = AroundY
                    branchPos.Z = AroundZ
                    Return branchPos
                End If
            Case 3
                If Directions.Contains("w") Then
                    BlockLog.Data = 8
                    schem.Blocks.SetBlock(AroundX, AroundY, AroundZ - 1, BlockLog)

                    branchPos.X = AroundX
                    branchPos.Y = AroundY
                    branchPos.Z = AroundZ - 1
                    Return branchPos
                End If
        End Select

        branchPos.X = -1
        branchPos.Y = -1
        branchPos.Z = -1
        Return branchPos
    End Function

    Private Shared Sub GenLeavesAround(Radius As Integer, Point As Vector3)
        Dim counter As Integer = 0

        For i As Integer = 1 To Radius
            schem.Blocks.SetBlock(CInt(Point.X) + i, CInt(Point.Y), CInt(Point.Z), New AlphaBlock(BlockType.LEAVES))
            schem.Blocks.SetBlock(CInt(Point.X) - i, CInt(Point.Y), CInt(Point.Z), New AlphaBlock(BlockType.LEAVES))
            schem.Blocks.SetBlock(CInt(Point.X), CInt(Point.Y), CInt(Point.Z) + i, New AlphaBlock(BlockType.LEAVES))
            schem.Blocks.SetBlock(CInt(Point.X), CInt(Point.Y), CInt(Point.Z) - i, New AlphaBlock(BlockType.LEAVES))


            If i = Radius Then
                While counter < i
                    For cI As Integer = 1 To counter
                        If r.Next(0, 6) < 5 OrElse cI <> counter Then
                            schem.Blocks.SetBlock(CInt(Point.X) + cI, CInt(Point.Y), CInt(Point.Z) - i + counter, New AlphaBlock(BlockType.LEAVES))
                        End If

                        If r.Next(0, 6) < 5 OrElse cI <> counter Then
                            schem.Blocks.SetBlock(CInt(Point.X) - cI, CInt(Point.Y), CInt(Point.Z) - i + counter, New AlphaBlock(BlockType.LEAVES))
                        End If

                        If r.Next(0, 6) < 5 OrElse cI <> counter Then
                            schem.Blocks.SetBlock(CInt(Point.X) + cI, CInt(Point.Y), CInt(Point.Z) + i - counter, New AlphaBlock(BlockType.LEAVES))
                        End If

                        If r.Next(0, 6) < 5 OrElse cI <> counter Then
                            schem.Blocks.SetBlock(CInt(Point.X) - cI, CInt(Point.Y), CInt(Point.Z) + i - counter, New AlphaBlock(BlockType.LEAVES))
                        End If
                    Next
                        counter += 1
                End While
            End If
        Next
    End Sub
End Class
Imports System
Imports Spectre.Console

Module Program
    Sub Main(args As String())
        Dim curPlayer = New Player With {.stillPlaying = True, .usersName = ""}

        While curPlayer.stillPlaying
            If curPlayer.usersName = "" Then
                curPlayer.GiveName()
            Else
                Console.WriteLine($"What would you like to do {curPlayer.usersName}?")
                Dim input = Console.ReadLine()
                CallByName(curPlayer, input, Microsoft.VisualBasic.CallType.Method)
            End If
        End While

    End Sub

    Private Class manu

    End Class




End Module

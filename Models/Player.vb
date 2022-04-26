Imports Spectre.Console
Public Class Player
    Property usersName As String
    Property stillPlaying As Boolean
    Sub ExitGame()
        AnsiConsole.Markup($"Thansk for playing {usersName}")
        stillPlaying = False

    End Sub
    Sub GiveName()
        Console.Write("Name Please:")
        Dim enteredName = Console.ReadLine()
        usersName = enteredName
    End Sub
    Sub Help()
        Dim Actions = New List(Of String) From {"GiveName", "ExitGame", "Help"}
        For Each action In Actions
            Console.WriteLine(action)
        Next
    End Sub



End Class

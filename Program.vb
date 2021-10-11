Imports System
Module Program
    Sub Main()
        Dim amico(5) As String
        For i = 0 To 4
            Console.WriteLine("Inserisci 5 nome dei tuoi amici: ")
            amico(i) = Console.ReadLine()
            Console.Clear()
        Next
        For i = 0 To 4
            Console.WriteLine(amico(i))
        Next
        Console.ReadLine()
    End Sub
End Module

Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        If Console.ReadLine() = 1 Then
            Contador()

        End If

        If Console.ReadLine() = -1 Then
            Escala��o()

        End If

    End Sub

    Dim pessoas
    Function Jogadores()
        Console.Write("JOGADORES:")
        pessoas = Console.ReadLine()




    End Function

    Function Escala��o()
        Console.Write("ESCALA��O:")
        Console.WriteLine(pessoas)

    End Function

    Sub Contador()
        Dim Contar As Integer
        Contar = 1


        Do While Contar <= 10
            If Contar <= 10 Then
                Contar = Contar + 1
            End If
        Loop
    End Sub


End Module

Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine(vbCrLf + "Temperatura da GPU (°C): ")
        Dim temp = Console.ReadLine()

        If temp <= 0 Then
            Console.WriteLine("GPU Inativa")

        ElseIf temp <= 30 Then
            Console.WriteLine("Temperatura Normal")

        ElseIf temp <= 50 Then
            Console.WriteLine("Temperatura Alta")

        Else
            Console.WriteLine("CUIDADO! Temperatura Acima Do Limite")
        End If

    End Sub
End Module

Option Explicit On
Option Strict On

Module SelectCaseExample
    Sub Main()

        Dim temp As String = "2"

        If temp = "2" Then
            Console.WriteLine("If 2")
            'do stuff for the "2" input
        ElseIf temp = "3" Then
            Console.WriteLine("If 3")
            'do stuff for the "3" input
        Else
            Console.WriteLine("Everything else")
            'do stuff for everything else
        End If

        Select Case temp
            Case = "1"
                Console.WriteLine("Case 1")
                'do stuff for the "1" input
            Case = "2"
                Console.WriteLine("Case 2")
                'do stuff for the "2" input
            Case = "3"
                Console.WriteLine("Case 3")
                'do stuff for the "3" input
            Case Else
        End Select

        Console.Read()
    End Sub
End Module

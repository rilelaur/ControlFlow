Option Explicit On
Option Strict On
Option Compare Binary

Module ControlFlow

    Sub Main()
        'Select code ctrl + k + c comments everything selected
        'ctrl + k + u uncomments everything selected

        'Dim firstNumber As Integer
        'Dim secondNumber As Integer

        'firstNumber = 5
        'secondNumber = 3

        'If firstNumber > secondNumber Then
        '    Console.WriteLine("First number is larger then Second number.")
        'ElseIf firstNumber < secondNumber Then
        '    Console.WriteLine("Second number is larger then First number")
        'Else
        '    Console.WriteLine("First and Second number are equal")
        'End If

        'Dim userInput As String

        'Console.WriteLine("Please Type your name and press 'Enter'")

        'userInput = Console.ReadLine()

        'Console.WriteLine("You typed " & userInput)
        'Console.WriteLine($"You typed {userInput}")


        '1/21/2021
        'simple calculator example
        Dim firstInput As Integer
        Dim secondInput As Integer
        Dim userInput As String = ""
        Dim problem As Boolean = False

        Console.WriteLine("Enter a number")

        Try
            userInput = Console.ReadLine()
            firstInput = CInt(userInput)
        Catch ex As Exception
            Console.WriteLine($"I need a number. You entered an invaid character {userInput}" & vbCrLf)
            problem = True
        End Try

        Console.WriteLine("Enter a number")

        Try
            userInput = Console.ReadLine()
            secondInput = CInt(userInput)
        Catch ex As Exception
            Console.WriteLine($"I need a number. You entered an invaid character {userInput}" & vbCrLf)
            problem = True
        End Try

        If problem = True Then
            Console.Clear()
            Console.WriteLine("Sorry try again later...")
            Console.WriteLine("Have a nice day...")
        Else
            'Do the math if no problem
            Console.WriteLine(firstInput + secondInput)
        End If

        'Console.WriteLine(CInt(firstInput) + CInt(secondInput))

        '1/22/2021

        Console.Read()
    End Sub

End Module

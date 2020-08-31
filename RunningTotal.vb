Option Strict On
Option Explicit On

Module RunningTotal

    Sub Main()
        Dim userInput As String
        Dim runningTotal As Integer
        Const TAXRATE As Decimal = 0.06D

        While userInput <> "q"
            Console.WriteLine("Please select an option.")
            Console.WriteLine("1. Add Item")
            Console.WriteLine("2. Calculate Tax")

            'User Choice???
            userInput = Console.ReadLine() ' TODO what if item is a $1.50

            If userInput = "1" Then
                Console.WriteLine("Enter the item cost")
                userInput = Console.ReadLine()

                Try
                    'runningTotal = runningTotal + CInt(userInput)
                    runningTotal += CInt(userInput)
                Catch ex As Exception
                    'prompt user to give good data  TODO
                End Try
                Console.WriteLine("Total: " & runningTotal) 'TODO format as currency

            ElseIf userInput = "2" Then
                Console.WriteLine("Tax: " & runningTotal * TAXRATE) ' 
            Else
                'prompt user for good data TODO 
            End If

        End While
        Console.ReadLine()
    End Sub

End Module

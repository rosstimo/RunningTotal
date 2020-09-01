Option Strict On
Option Explicit On
Option Compare Text

Module RunningTotal

    Sub Main()
        Dim userInput As String = ""
        Dim runningTotal As Decimal
        Const TAXRATE As Decimal = 0.06D
        Dim taxAmount As Decimal
        Dim badData As Boolean = True

        While userInput <> "q"
            Console.Clear()
            Console.WriteLine("Please select an option.")
            Console.WriteLine("1. Add Item")
            Console.WriteLine("2. Calculate Tax")
            Console.WriteLine("3. Show Sub Total")
            Console.WriteLine("4. Show Grand Total")

            'User Choice
            userInput = Console.ReadLine()

            If userInput = "1" Then

                Do
                    Console.WriteLine("Enter the item cost")
                    userInput = Console.ReadLine()
                    Try
                        'runningTotal = runningTotal + CDec(userInput)
                        runningTotal += CDec(userInput)
                        badData = False
                    Catch ex As Exception
                        'prompt user to give good data
                        Console.WriteLine("Item cost must be a number")
                        badData = True
                    End Try
                Loop While badData

            ElseIf userInput = "2" Then
                taxAmount = runningTotal * TAXRATE
                Console.WriteLine("Tax: " & taxAmount.ToString("C"))
            ElseIf userInput = "3" Then
                Console.WriteLine("Sub Total: " & runningTotal.ToString("C"))
            ElseIf userInput = "4" Then
                Console.WriteLine("Grand Total: " & (runningTotal + taxAmount).ToString("C"))
            Else
                'catch all. bad choice
            End If
            Console.ReadLine()
        End While

    End Sub

End Module

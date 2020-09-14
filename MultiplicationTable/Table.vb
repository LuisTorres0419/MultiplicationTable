'Luis Torres
'RCET0265
'Fall 2020
'Multiplication Table
'

Option Strict On
Option Explicit On
Option Compare Text


Module Table

    Sub Main()
        Dim goodData As Boolean
        Dim data(12, 12) As Integer
        Dim quit As String
        Dim userInput As String
        Dim numberInput, column, row As Integer
        Console.WriteLine("Press the Q to Quit.")
        Do
            Do
                Console.WriteLine("Enter a number between 1 and 12")

                Try
                    userInput = Console.ReadLine()

                    numberInput = CInt(userInput)

                    If numberInput > 0 Or numberInput < 13 Then

                        goodData = True

                    Else

                        goodData = False

                        Console.WriteLine("Hey! only between 1 and 12 silly.")

                    End If

                Catch ex As Exception

                    If userInput = ("q") Then

                        Exit Sub

                    End If

                    Console.WriteLine("don't you do it 1 through 12 man")

                    goodData = False

                End Try

            Loop Until goodData = True

            For column = 1 To numberInput

                For row = 1 To numberInput

                    data(row, column) = row * column

                    Console.WriteLine(data(row, column) & vbTab)

                Next

                Console.WriteLine()

            Next

            Console.WriteLine("press enter to exit or Q to quit.")

            quit = Console.ReadLine()

            If quit = "q" Then

                Exit Sub

            End If
        Loop

    End Sub

End Module

'Zachary Christensen
'RCET 2265
'Fall 2023
'Convert and Validate
'https://github.com/Minidude140/Convert-and-Validate.git


Option Explicit On
Option Strict On

Module ConvertAndValidate

    Sub Main()
        'for testing the function add this to your Sub Main()

        Dim aValidNumber As Integer
        Dim userResponse As String

        Do

            Console.WriteLine($"Enter a number:" & vbLf & "(enter 'Q' to quit)")

            userResponse = Console.ReadLine()


            Select Case userResponse
                Case = "Q", "q"
                    Exit Do
                Case Else
                    If ConversionValid(userResponse, aValidNumber) = True Then

                        aValidNumber = CInt(userResponse)
                        Console.WriteLine($"{userResponse} converted successfully to {aValidNumber}!")

                    Else

                        Console.WriteLine($"Oops, {userResponse} does not seem to be a number")

                    End If
            End Select

        Loop
    End Sub

    'make this work
    Function ConversionValid(userInput As String, convertedInteger As Integer) As Boolean

        Dim status As Boolean

        Try
            convertedInteger = CInt(userInput)
            status = True
            'aValidNumber = convertedInteger
        Catch ex As Exception
            status = False
        End Try

        Return status
    End Function


End Module

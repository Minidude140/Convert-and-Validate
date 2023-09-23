'Zachary Christensen
'RCET 2265
'Fall 2023
'Convert and Validate
'https://github.com/Minidude140/Convert-and-Validate.git


Option Explicit On
Option Strict On

Module ConvertAndValidate

    Sub Main()

        Dim aValidNumber As Integer
        Dim userResponse As String

        Do
            'Prompt user for input
            Console.WriteLine($"Enter a number:" & vbLf & "(enter 'Q' to quit)")

            userResponse = Console.ReadLine()
            Console.WriteLine()

            'Check if user wants to quit or convert
            Select Case userResponse
                'Quit if user types q
                Case = "Q", "q"
                    Exit Do
                Case Else
                    'If user types anything but q try to convert
                    'if conversion successful report to user
                    If ConversionValid(userResponse, aValidNumber) = True Then
                        aValidNumber = CInt(userResponse)
                        Console.WriteLine($"{userResponse} converted successfully to {aValidNumber}!" & vbLf)
                        'if conversion fails report to user
                    Else
                        Console.WriteLine($"Oops, {userResponse} does not seem to be a number" & vbLf)
                    End If
            End Select

        Loop
    End Sub

    Function ConversionValid(userInput As String, convertedInteger As Integer) As Boolean

        'Dim the return as boolean; True for successful conversion, false for failure to convert
        Dim status As Boolean
        Try
            convertedInteger = CInt(userInput)
            status = True
        Catch ex As Exception
            status = False
        End Try
        Return status
    End Function


End Module

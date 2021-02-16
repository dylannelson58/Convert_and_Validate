Option Strict On
Option Explicit On

'Dylan Nelson
'RCET0265
'Spring 2021
'Accumulate Messages Function
'https://github.com/dylannelson58/Accumulate_Messages_Function


Module Convert_and_Validate

    Sub Main()

        Dim userInput As String
        Dim conversion As Integer

        Console.WriteLine("Enter in a number.")
        userInput = Console.ReadLine()

        Console.WriteLine($"Integer value before converted, {conversion}")

        Console.WriteLine(ValidateAndConvert(userInput, conversion))

        Console.WriteLine(vbNewLine & "ValidateAndConvert function:")
        Console.WriteLine($"Converted validated integer, {conversion}")
        Console.ReadLine()
    End Sub
    Function ValidateAndConvert(ByVal validate As String, ByRef conversion As Integer) As String
        Try
            conversion = CInt(validate)
            Return ""
        Catch ex As Exception
            Select Case validate
                Case ""
                    Return "is empty"
                Case Else
                    Return "must contain a number"
            End Select
        End Try
    End Function


End Module

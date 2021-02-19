'Sean Gingerich
'RCET0265
'Spring 2021
'Roll the Dice
'https://github.com/gingsean5/RolltheDice

Module RolltheDice

    Sub Main()
        Dim banana As Integer
        banana = CInt((77 - 14) / 2)
        'Header that reads Random Numbers in the middle
        Console.WriteLine(StrDup(banana, " ") & "Random Numbers" & StrDup(banana, " "))
        'line of - 
        Console.WriteLine(StrDup(77, "-"))
        'Just spaces out numbers 2 to 12
        For i = 2 To 12
            Console.Write(Str(i).PadLeft(6) & "|")

        Next

        Console.WriteLine()
        'line of -
        Console.WriteLine(StrDup(77, "-"))
        'This is the actual Random numbers part 
        Dim totalRoll As Integer
        Dim randomNumbers(12)
        For i = 0 To 1000
            totalRoll = (MakeRandoNumber(5) + 1) + (MakeRandoNumber(5) + 1)
            randomNumbers(totalRoll) += 1
        Next
        For i = 2 To UBound(randomNumbers)
            Console.Write(CStr(randomNumbers(i)).PadLeft(6) & "|")
        Next
        Console.Read()
    End Sub
    Function MakeRandoNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function

End Module

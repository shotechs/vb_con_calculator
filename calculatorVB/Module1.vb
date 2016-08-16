Module Module1

    Sub Main()

        shotechs.output()

        Console.WriteLine("Type 1st number")
        Dim x As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Type 2nd number")
        Dim y As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("///////////////////////")
        Console.WriteLine("// Choose a option //")
        Console.WriteLine("///////////////////////")
        Console.WriteLine("1 - addition")
        Console.WriteLine("2 - subtration ")
        Console.WriteLine("3 - multification")
        Console.WriteLine("4 - division")
        Dim z As Integer = Convert.ToInt32(Console.ReadLine())

        'userOption
        Select Case z

            Case 1
                Console.WriteLine("///////////////////////")
                Console.WriteLine("// Result //")
                Console.WriteLine("///////////////////////")
                Console.WriteLine(x + y)

            Case 2
                Console.WriteLine("///////////////////////")
                Console.WriteLine("// Result //")
                Console.WriteLine("///////////////////////")
                Console.WriteLine(x - y)

            Case 3
                Console.WriteLine("///////////////////////")
                Console.WriteLine("// Result //")
                Console.WriteLine("///////////////////////")
                Console.WriteLine(x * y)

            Case 4
                Console.WriteLine("///////////////////////")
                Console.WriteLine("// Result //")
                Console.WriteLine("///////////////////////")
                Console.WriteLine(x / y)

        End Select 'Ends Select Statements.

        Console.ReadKey(True) 'Allows program to read in console window and used to exit on MenuExit.

    End Sub

End Module


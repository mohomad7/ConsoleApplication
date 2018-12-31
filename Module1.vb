Module Module1

    Sub Main()
        Console.WriteLine("Hellow world...")
        Console.WriteLine("updating...")
        Console.WriteLine("updating...")
        Console.WriteLine("Enter A :")
        Dim a As Integer = Console.ReadLine()
        Console.WriteLine("Enter B:")
        Dim b As Integer = Console.ReadLine()
        Dim c As Integer = a + b
        Console.WriteLine("Addition is :" + c.ToString())
        a = Console.ReadLine()
        Console.WriteLine("Enter B:")
        b = Console.ReadLine()
        c = a - b
        Console.WriteLine("substraction is :" + c.ToString());
        Console.Read()
    End Sub

End Module

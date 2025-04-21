using System;

class Program
{
    static void Main()
    {
        var list = Console.ReadLine().Split(' ');
        int a = int.Parse(list[0]);
        int b = int.Parse(list[1]);
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);
    }
}
using System;

class Program
{
    static void Main()
    {
        var list = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(list.Length);
    }
}
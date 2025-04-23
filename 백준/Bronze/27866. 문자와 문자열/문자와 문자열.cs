using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(text[num - 1]);
    }
}
using System;

class Program
{
    static void Main()
    {
        var list = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var (a, b) = (list[0], list[1]);
        Console.WriteLine(Math.Abs(a - b));
    }
}
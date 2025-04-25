using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int min = numbers.Min();
        int max = numbers.Max();
        Console.WriteLine($"{min} {max}");
    }
}
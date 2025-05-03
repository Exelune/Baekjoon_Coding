using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] scores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int max = scores.Max();

        var result = scores.Select(s => s / (double)max * 100);

        Console.WriteLine(result.Average());
    }
}
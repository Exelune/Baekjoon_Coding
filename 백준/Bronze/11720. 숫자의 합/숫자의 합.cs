using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int total = Console.ReadLine().Select(arr => arr - '0').Sum();
        Console.WriteLine(total);
    }
}
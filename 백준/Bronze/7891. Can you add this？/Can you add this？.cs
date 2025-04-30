using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result = 0;
        
        for (int i = 0; i < n; i++)
        {
            var list = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var (a, b) = (list[0], list[1]);

            Console.WriteLine(a + b);
        }
    }
}
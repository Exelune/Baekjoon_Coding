using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        for(int i = 0; i < num; i++)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var (a, b) = (list[0], list[1]);
            Console.WriteLine(a + b);
        }
    }
}
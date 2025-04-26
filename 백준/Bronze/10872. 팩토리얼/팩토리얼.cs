using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        long total = 1;
        
        for (int i = 1; i <= N; i++)
        {
            total *= i;
        }
        Console.WriteLine(total);
    }
}
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int c = 0;
        for(int i = 1; i <= a; i++)
        {
            c = c + i;
        }
        Console.WriteLine(c);
    }
}
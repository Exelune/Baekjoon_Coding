using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> results = new HashSet<int>();

        for (int i = 0; i < 10; i++)
        {
            int remainder = int.Parse(Console.ReadLine()) % 42;
            results.Add(remainder);
        }

        Console.WriteLine(results.Count);
    }
}
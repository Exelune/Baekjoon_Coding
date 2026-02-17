using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        var nums = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int total = 0;

        foreach (var x in nums)
        {
            total += x;
        }
        total *= 5;
        sw.WriteLine(total);

    }
}

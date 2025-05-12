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

        int result = 0;
        int sum = 0;
        int num = int.Parse(sr.ReadLine());
        var numbers = sr.ReadLine().Split(' ').Select(int.Parse).ToList();

        numbers.Sort();

        foreach (var number in numbers)
        {
            sum += number;
            result += sum;
        }

        sw.WriteLine(result);
    }
}
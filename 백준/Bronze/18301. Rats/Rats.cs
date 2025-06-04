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

        var input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

        sw.WriteLine((input[0] + 1) * (input[1] + 1) / (input[2] + 1) - 1);
    }
}
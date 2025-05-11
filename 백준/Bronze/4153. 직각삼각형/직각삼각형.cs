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

        while (true)
        {
            var inputs = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(inputs);

            int ab = (inputs[0] * inputs[0]) + (inputs[1] * inputs[1]);
            int c = inputs[2] * inputs[2];

            if (inputs[0] == 0 && inputs[1] == 0 && inputs[2] == 0) break;
            else if (ab == c) sw.WriteLine("right");
            else sw.WriteLine("wrong");
        }
    }
}
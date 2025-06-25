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

        int input = int.Parse(sr.ReadLine());
        for(int i = 1; i <= input; i++)
        {
            int[] Case = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            sw.WriteLine("Case " + i + ": " + (Case[0] + Case[1]));
        }
    }
}

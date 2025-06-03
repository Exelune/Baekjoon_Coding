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

        int N = int.Parse(sr.ReadLine());

        for(int i = 0; i < N; i++)
        {
            var input = sr.ReadLine().Split(' ').ToArray();

            input[0] = "god";

            for(int j = 0; j < input.Length; j++)
            {
                sw.Write(input[j]);
            }

            sw.WriteLine();
        }
    }
}
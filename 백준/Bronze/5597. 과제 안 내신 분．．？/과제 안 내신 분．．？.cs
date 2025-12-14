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

        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        int[] inputs = new int[31];

        for(int i = 1; i <= 28; i++)
        {
            inputs[i] = int.Parse(sr.ReadLine());
        }

        foreach(int i in array)
        {
            if (inputs.Contains(i))
            {
                continue;
            }
            else
            {
                sw.WriteLine(i);
            }
        }
    }
}

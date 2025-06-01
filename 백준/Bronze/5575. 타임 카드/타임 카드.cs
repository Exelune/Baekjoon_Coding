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

        for (int i = 0; i < 3; i++)
        {
            var list = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = new int[3];

            if (list[2] > list[5])
            {
                list[4]--;
                result[2] = list[5] + 60 - list[2];
            }
            else
            {
                result[2] = list[5] - list[2];
            }

            if (list[1] > list[4])
            {
                list[3]--;
                result[1] = list[4] + 60 - list[1];
            }
            else
            {
                result[1] = list[4] - list[1];
            }

            result[0] = list[3] - list[0];


            sw.WriteLine(result[0] + " " + result[1] + " " + result[2]);
        }
    }
}
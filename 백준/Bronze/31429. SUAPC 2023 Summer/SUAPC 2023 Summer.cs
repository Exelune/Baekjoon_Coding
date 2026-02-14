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

        int[][] info = new int[][]
        {
            null,
            new int[] {12,1600},
            new int[] {11,894},
            new int[] {11,1327},
            new int[] {10,1311},
            new int[] {9,1004},
            new int[] {9,1178},
            new int[] {9,1357},
            new int[] {8,837},
            new int[] {7,1055},
            new int[] {6,556},
            new int[] {6,773},
        };
        int n = int.Parse(sr.ReadLine());
        sw.WriteLine(info[n][0] + " " + info[n][1]);
    }
}

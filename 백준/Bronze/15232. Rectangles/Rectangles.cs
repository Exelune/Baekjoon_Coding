using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int r = int.Parse(sr.ReadLine());
        int c = int.Parse(sr.ReadLine());

        for(int i = 1; i <= r; i++)
        {
            for(int j = 1; j <= c; j++)
            {
                sw.Write("*"); ;
            }
            sw.WriteLine();
        }
    }
}

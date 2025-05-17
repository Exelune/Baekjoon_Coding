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

        int num = int.Parse(sr.ReadLine());

        bool contains = num.ToString().Contains("7");
        bool division = num % 7 == 0;

        if (!contains && !division)
            sw.WriteLine(0);
        else if (!contains && division)
            sw.WriteLine(1);
        else if (contains && !division)
            sw.WriteLine(2);
        else
            sw.WriteLine(3);
    }
}
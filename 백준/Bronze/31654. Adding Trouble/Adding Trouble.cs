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

        var ABC = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        if (ABC[0] + ABC[1] == ABC[2])
        {
            sw.WriteLine("correct!");
        }
        else
        {
            sw.WriteLine("wrong!");
        }
        
    }
}

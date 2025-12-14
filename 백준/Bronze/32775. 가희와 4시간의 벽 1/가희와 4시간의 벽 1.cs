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

        int S = int.Parse(sr.ReadLine());
        int F = int.Parse(sr.ReadLine());
        if (S > F) sw.WriteLine("flight");
        else sw.WriteLine("high speed rail");
    }
}

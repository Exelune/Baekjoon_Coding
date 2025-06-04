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

        string a = sr.ReadLine();
        string h = sr.ReadLine();

        if (a.Length >= h.Length)
        {
            sw.WriteLine("go");
        }
        else
        {
            sw.WriteLine("no");
        }
    }
}
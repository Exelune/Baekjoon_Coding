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

        int three = int.Parse(sr.ReadLine());
        int four = int.Parse(sr.ReadLine());
        int five = int.Parse(sr.ReadLine());

        sw.WriteLine((three * 3) + (four * 4) + (five * 5));
    }
}
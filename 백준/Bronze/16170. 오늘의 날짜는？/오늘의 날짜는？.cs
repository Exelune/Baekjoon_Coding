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

        DateTime now = DateTime.UtcNow;
        sw.WriteLine(now.Year);
        sw.WriteLine(now.Month);
        sw.WriteLine(now.Day);
    }
}

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

        sw.WriteLine("  ___  ___  ___");
        sw.WriteLine("  | |__| |__| |");
        sw.WriteLine("  |           |");
        sw.WriteLine("   \\_________/");
        sw.WriteLine("    \\_______/");
        sw.WriteLine("     |     |");
        sw.WriteLine("     |     |");
        sw.WriteLine("     |     |");
        sw.WriteLine("     |     |");
        sw.WriteLine("     |_____|");
        sw.WriteLine("  __/       \\__");
        sw.WriteLine(" /             \\");
        sw.WriteLine("/_______________\\");

    }
}

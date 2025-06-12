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

        sw.WriteLine("    8888888888  888    88888");
        sw.WriteLine("   88     88   88 88   88  88");
        sw.WriteLine("    8888  88  88   88  88888");
        sw.WriteLine("       88 88 888888888 88   88");
        sw.WriteLine("88888888  88 88     88 88    888888");
        sw.WriteLine("");
        sw.WriteLine("88  88  88   888    88888    888888");
        sw.WriteLine("88  88  88  88 88   88  88  88");
        sw.WriteLine("88 8888 88 88   88  88888    8888");
        sw.WriteLine(" 888  888 888888888 88  88      88");
        sw.WriteLine("  88  88  88     88 88   88888888");

    }
}

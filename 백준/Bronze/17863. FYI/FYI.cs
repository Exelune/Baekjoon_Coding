using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string n = sr.ReadLine();

        if (n[0] == '5' && n[1] == '5' && n[2] == '5') sw.WriteLine("YES");
        else sw.WriteLine("NO");
    }
}
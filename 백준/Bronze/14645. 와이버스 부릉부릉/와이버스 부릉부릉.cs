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

        var NK = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for(int i = 0; i < NK[0]; i++)
        {
            sr.ReadLine();
        }
        sw.WriteLine("비와이");

    }
}

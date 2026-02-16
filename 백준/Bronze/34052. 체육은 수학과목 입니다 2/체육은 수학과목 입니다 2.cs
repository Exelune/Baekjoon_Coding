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

        int total = 0;
        for(int i = 0; i <= 3; i++)
        {
            total += int.Parse(sr.ReadLine());
        }

        total += 300;

        if (total > 1800) sw.WriteLine("No");
        else sw.WriteLine("Yes");
    }
}

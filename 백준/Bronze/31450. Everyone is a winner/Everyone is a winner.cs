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

        var num = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (num[0] % num[1] == 0) sw.WriteLine("Yes");
        else sw.WriteLine("No");

    }
}
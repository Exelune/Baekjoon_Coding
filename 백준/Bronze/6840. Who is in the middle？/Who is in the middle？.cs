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

        List<int> list = new List<int>();

        list.Add(int.Parse(sr.ReadLine()));
        list.Add(int.Parse(sr.ReadLine()));
        list.Add(int.Parse(sr.ReadLine()));

        var input = list.ToArray();

        Array.Sort(input);

        sw.WriteLine(input[1]);
    }
}
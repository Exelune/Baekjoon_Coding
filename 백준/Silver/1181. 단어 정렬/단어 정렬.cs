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

        int num = int.Parse(sr.ReadLine());
        HashSet<string> list = new HashSet<string>();
        for(int i = 0; i < num; i++)
        {
            list.Add(sr.ReadLine());
        }
        var sort = list.OrderBy(x => x.Length).ThenBy(x => x);

        foreach (var n in sort)
        {
            sw.WriteLine(n);
        }
    }
}

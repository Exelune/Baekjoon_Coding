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
        List<(int x, int y)> list = new List<(int x, int y)>();

        for (int i = 0; i < num; i++)
        {
            var inputs = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            list.Add((inputs[0], inputs[1]));
        }

        var sort = list
            .OrderBy(p => p.y)
            .ThenBy(p => p.x);

        foreach (var item in sort)
        {
            sw.WriteLine(item.x + " " + item.y);
        }
    }
}
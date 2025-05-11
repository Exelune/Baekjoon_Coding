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

        List<(int num, string text)> list = new List<(int, string)> { };
        int num = int.Parse(sr.ReadLine());

        for (int i = 0; i < num; i++)
        {
            var inputs = sr.ReadLine().Split(' ').ToArray();
            list.Add((int.Parse(inputs[0]), inputs[1]));
        }

        var sort = list
            .OrderBy(x => x.num);

        foreach (var x in sort)
        {
            sw.WriteLine(x.num + " " + x.text);
        }
    }
}
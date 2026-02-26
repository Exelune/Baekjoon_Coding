using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        var inputs = sr.ReadLine().Split().Select(int.Parse).ToArray();
        if (inputs[1] > inputs[2]) sw.WriteLine("Subway");
        else if (inputs[1] < inputs[2]) sw.WriteLine("Bus");
        else sw.WriteLine("Anything");
    }
}

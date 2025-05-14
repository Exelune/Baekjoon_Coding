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

        var intputs = sr.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

        sw.WriteLine(intputs[0] / intputs[1]);
        sw.WriteLine(intputs[0] % intputs[1]);
    }
}
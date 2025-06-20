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

        var AB = sr.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

        BigInteger A = AB[0];
        BigInteger B = AB[1];

        sw.WriteLine(A + B);
    }
}

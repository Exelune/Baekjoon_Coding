using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] inputs = sr.ReadLine().Split();
        BigInteger a = BigInteger.Parse(inputs[0]);
        BigInteger b = BigInteger.Parse(inputs[1]);

        sw.WriteLine(a * b);
    }
}
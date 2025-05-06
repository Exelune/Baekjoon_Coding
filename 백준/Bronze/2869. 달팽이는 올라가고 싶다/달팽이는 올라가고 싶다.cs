using System;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        var inputs = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var (A, B, V) = (inputs[0], inputs[1], inputs[2]);
        double result;

        result = (double)(V - A) / (A - B);

        sw.WriteLine(Math.Ceiling(result) + 1);
    }
}
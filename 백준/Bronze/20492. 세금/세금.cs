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

        int n = int.Parse(sr.ReadLine());
        int num = (int)(n * 0.8);
        int tax = (int)(n * 0.2);

        sw.WriteLine((int)(n * 0.78) + " " + (int)((tax * 0.78) + num));
    }
}
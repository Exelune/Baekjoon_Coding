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

        for (int i = 0; i < n; i++)
        {
            sw.Write("LoveisKoreaUniversity" + " ");
        }
    }
}
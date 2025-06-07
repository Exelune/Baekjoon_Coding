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

        int A = int.Parse(sr.ReadLine());
        int B = int.Parse(sr.ReadLine());
        int C = int.Parse(sr.ReadLine());
        int D = int.Parse(sr.ReadLine());

        if (A > B && B > C && C > D)
        {
            sw.WriteLine("Fish Diving");
        }
        else if (A < B && B < C && C < D)
        {
            sw.WriteLine("Fish Rising");
        }
        else if (A == B && B == C && C == D)
        {
            sw.WriteLine("Fish At Constant Depth");
        }
        else
        {
            sw.WriteLine("No Fish");
        }
    }
}

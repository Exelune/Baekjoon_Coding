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

        int total = int.Parse(sr.ReadLine());
        int[] tshirt = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] TP = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int T = 0, P = 0, p = 0;

        for(int i = 0; i < tshirt.Length; i++)
        {
            T += (int)Math.Ceiling((double)tshirt[i] / TP[0]);
        }

        P = total / TP[1];
        p = total % TP[1];

        sw.WriteLine(T);
        sw.WriteLine(P + " " + p);
    }
}

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

        int N = int.Parse(sr.ReadLine());

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < N / 4; i++)
        {
            sb.Append("long ");
        }

        sb.Append("int");

        sw.WriteLine(sb.ToString());
    }
}
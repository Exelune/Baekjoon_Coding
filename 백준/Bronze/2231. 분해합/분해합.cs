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

        int N = int.Parse(sr.ReadLine());
        bool token = false;

        for (int i = 1; i <= N; i++)
        {
            int M = i;

            foreach (char c in i.ToString())
            {
                M += c - '0';
            }

            if (M == N)
            {
                sw.WriteLine(i);
                token = true;
                break;
            }
        }

        if (!token)
        {
            sw.WriteLine(0);
        }
    }
}
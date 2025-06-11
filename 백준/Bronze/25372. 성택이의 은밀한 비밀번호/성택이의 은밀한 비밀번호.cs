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

        for(int i = 0; i < N; i++)
        {
             string input = sr.ReadLine();
            if(input.Length >= 6 && input.Length < 10)
            {
                sw.WriteLine("yes");
            }
            else
            {
                sw.WriteLine("no");
            }
        }
    }
}

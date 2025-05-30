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

        int T = int.Parse(sr.ReadLine());

        for(int i  = 0; i < T; i++)
        {
            int N = int.Parse(sr.ReadLine());
            var nums = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            sw.WriteLine(nums.Min() + " " + nums.Max());
        }
    }
}
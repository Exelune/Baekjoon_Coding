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

        for(int i = 1; i <= T; i++)
        {
            var nums = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            sw.WriteLine("Case #" + i + ": " + nums[0] + " + " + nums[1] + " = " + (nums[0] + nums[1]));

        }
    }
}
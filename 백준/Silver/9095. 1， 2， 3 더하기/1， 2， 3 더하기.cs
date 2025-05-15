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

        int num = int.Parse(sr.ReadLine());
        List<int> list = new List<int>();

        for (int i = 0; i < num; i++)
        {
            list.Add(int.Parse(sr.ReadLine()));
        }

        num = list.Max();
        int[] dp = new int[num + 1];
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 4;

        for (int i = 4; i<= num; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
        }

        foreach(int i in list)
        {
            sw.WriteLine(dp[i]);
        }
    }
}
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
        //int[] dp = new int[num + 1];
        //dp[0] = 0;
        //dp[1] = 1;
        int[] dp0 = new int[Math.Max(2, num + 1)];
        dp0[0] = 1;
        dp0[1] = 0;
        int[] dp1 = new int[Math.Max(2, num + 1)];
        dp1[0] = 0;
        dp1[1] = 1;

        for (int i = 2; i<= num; i++)
        {
            //dp[i] = dp[i - 1] + dp[i - 2];
            dp0[i] = dp0[i - 1] + dp0[i - 2];
            dp1[i] = dp1[i - 1] + dp1[i - 2];
        }

        foreach(int i in list)
        {
            sw.WriteLine(dp0[i] + " " + dp1[i]);
        }
    }
}
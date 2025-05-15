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

        const long MOD = 1_000_000_009;
        long num = long.Parse(sr.ReadLine());
        List<long> list = new List<long>();

        for (long i = 0; i < num; i++)
        {
            list.Add(long.Parse(sr.ReadLine()));
        }

        num = list.Max();
        long[] dp = new long[num + 1];
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 4;

        for (long i = 4; i<= num; i++)
        {
            dp[i] = ((dp[i - 1] % MOD) + (dp[i - 2] % MOD) + (dp[i - 3] % MOD)) % MOD;
        }

        foreach(long i in list)
        {
            sw.WriteLine(dp[i]);
        }
    }
}
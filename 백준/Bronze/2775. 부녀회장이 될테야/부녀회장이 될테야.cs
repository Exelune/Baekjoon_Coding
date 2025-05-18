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

        int k = 0;
        int n = 0;
        List<int> listk = new List<int>();
        List<int> listn = new List<int>();
        int T = int.Parse(sr.ReadLine());

        for(int i = 0; i < T; i++)
        {
            k = int.Parse(sr.ReadLine());
            n = int.Parse(sr.ReadLine());
            listk.Add(k);
            listn.Add(n);
        }

        k = listk.Max();
        n = listn.Max();

        int[][] dp = new int[k + 1][];
        
        for(int i = 0;i <= k; i++)
        {
            dp[i] = new int[n + 1];
        }

        for(int i = 1;i<=n; i++)
        {
            dp[0][i] = i;
        }

        for(int i = 1; i <= k; i++)
        {
            for(int j = 1; j <= n; j++)
            {
                dp[i][j] = dp[i][j - 1] + dp[i - 1][j];
            }
        }

        for(int i = 0; i < T; i++)
        {
            k = listk[i];
            n = listn[i];
            sw.WriteLine(dp[k][n]);
        }
    }
}
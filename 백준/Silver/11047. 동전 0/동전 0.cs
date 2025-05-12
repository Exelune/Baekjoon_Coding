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

        var inputs = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<int> coin = new List<int>();
        int k = inputs[1];
        int result = 0;

        for (int i = 0; i < inputs[0]; i++)
        {
            coin.Add(int.Parse(sr.ReadLine()));
        }

        List<int> newCoin = coin.OrderByDescending(i => i).ToList();

        while (k > 0)
        {
            if (newCoin[0] > k)
            {
                newCoin.Remove(newCoin[0]);
            }
            else if (newCoin[0] <= k)
            {
                k -= newCoin[0];
                result++;
            }
        }

        sw.WriteLine(result);
    }
}
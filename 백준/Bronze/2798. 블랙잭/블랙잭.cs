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

        int[] N = sr.ReadLine().Split().Select(int.Parse).ToArray();
        int max = N[1];
        int[] M = sr.ReadLine().Split().Select(int.Parse).ToArray();
        int sum = 0;
        int result = 0;

        for (int i = 0; i <= N[0] - 3; i++)
        {
            for (int j = i + 1; j <= N[0] - 2; j++)
            {
                for (int k = j + 1; k <= N[0] - 1; k++)
                {
                    sum = M[i] + M[j] + M[k];

                    if (sum <= N[1] && sum >= result)
                    {
                        result = sum;
                    }
                }
            }
            sum = 0;
        }

        sw.WriteLine(result);
    }
}

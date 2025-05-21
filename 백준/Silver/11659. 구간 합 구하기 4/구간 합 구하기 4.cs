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

        var NM = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] nums = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] sum = new int[nums.Length + 1];

        for(int i = 1; i <= nums.Length; i++)
        {
            sum[i] = sum[i - 1] + nums[i - 1];
        }

        for(int i = 0; i <  NM[1]; i++)
        {
            var input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = sum[input[1]] - sum[input[0] - 1];

            sw.WriteLine(result);
        }
    }
}
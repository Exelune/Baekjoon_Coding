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

        int input = int.Parse(sr.ReadLine());
        int[] nums = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int flag = 0;
        bool isSqrt = true;

        for(int i =  0; i < nums.Length; i++)
        {
            int sqrt = (int)Math.Sqrt(nums[i]);
            isSqrt = false;
            if (nums[i] < 2) continue;
            for (int j = 2; j <= sqrt; j++)
            {
                if (nums[i] % j == 0)
                {
                    isSqrt = true;
                    break;
                }
                isSqrt = false;
            }

            if (!isSqrt) flag++;
        }

        sw.WriteLine(flag);
    }
}

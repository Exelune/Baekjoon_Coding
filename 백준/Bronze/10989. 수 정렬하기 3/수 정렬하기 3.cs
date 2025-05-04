using System;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int num = int.Parse(sr.ReadLine());
        int[] nums = new int[10001];

        for (int i = 0; i < num; i++)
        {
            nums[int.Parse(sr.ReadLine())]++;
        }

        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < nums[i]; j++)
            {
                sw.WriteLine(i);
            }
        }
    }
}
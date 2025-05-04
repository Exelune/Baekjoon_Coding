using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int num = int.Parse(Console.ReadLine());
        int[] nums = new int[num];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(nums);

        for (int i = 0;i < nums.Length;i++)
        {
            sb.AppendLine(nums[i].ToString());
        }

        Console.WriteLine(sb);
    }
}
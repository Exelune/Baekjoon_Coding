using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        bool isAsc = true;
        bool isDesc = true;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] < nums[i + 1]) isDesc = false;
            else if (nums[i] > nums[i + 1]) isAsc = false;
        }
        if (isAsc)
        {
            Console.WriteLine("ascending");
        }
        else if (isDesc)
        {
            Console.WriteLine("descending");
        }
        else
        {
            Console.WriteLine("mixed");
        }
    }
}
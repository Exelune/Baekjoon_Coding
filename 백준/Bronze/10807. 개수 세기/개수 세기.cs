using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int v = int.Parse(Console.ReadLine());
        int result = 0;

        foreach (int num in nums)
        {
            if(num == v) { result++; }
        }

        Console.WriteLine(result);
    }
}
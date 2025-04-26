using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var(A, B) = (nums[0], nums[1]);
        Console.WriteLine(Atmark(A, B));
    }
    static long Atmark(long a, long b)
    {
        return (a + b)*(a - b);
    }
}
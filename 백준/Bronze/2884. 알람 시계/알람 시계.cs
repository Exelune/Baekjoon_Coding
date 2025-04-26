using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var (H, M) = (nums[0], nums[1]);

        if(M - 45 < 0)
        {
            H -= 1;
            M = 60 + (M - 45);
            if(H == -1)
            {
                H = 23;
            }
        }
        else
        {
            M = M - 45;
        }
        Console.WriteLine($"{H} {M}");
    }
}
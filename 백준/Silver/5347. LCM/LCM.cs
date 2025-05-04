using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var (a, b) = (input[0], input[1]);

            Console.WriteLine(LCM(a, b));
        }
    }

    static long GCD(long a, long b)
    {
        long r = 0;

        while(b != 0)
        {
            r = a % b;
            a = b;
            b = r;
        }

        return a;
    }

    static long LCM(long a, long b)
    {
        return a * b / GCD(a, b);
    }
}
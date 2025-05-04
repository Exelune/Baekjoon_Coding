using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
        var (a, b) = (input[0], input[1]);
        BigInteger num = GCD(a, b);
        int range = 100000000;
        int size = 0;

        while(num > 0)
        {
            if (num >= range)
            {
                size = range;
            }
            else
            {
                size = (int)num;
            }
            Console.Write(new string('1', size));
            num -= size;
        }
    }

    static BigInteger GCD(BigInteger a, BigInteger b)
    {
        BigInteger r = 0;

        while(b != 0)
        {
            r = a % b;
            a = b;
            b = r;
        }

        return a;
    }
}
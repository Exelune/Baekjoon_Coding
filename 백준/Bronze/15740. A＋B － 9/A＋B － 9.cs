using System;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        var inputs = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
        var (a, b) = (inputs[0], inputs[1]);

        Console.WriteLine(a + b);
    }
}
using System;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(a % 20000303);
    }
}
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var list = Console.ReadLine().Split(' ');
        BigInteger a = BigInteger.Parse(list[0]);
        BigInteger b = BigInteger.Parse(list[1]);
        BigInteger c = BigInteger.Parse(list[2]);
        Console.WriteLine(a + b +c);
    }
}
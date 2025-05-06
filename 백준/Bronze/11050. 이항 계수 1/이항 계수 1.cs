using System;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        var inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var (N, K) = (inputs[0], inputs[1]);
        int NK = N - K;

        N = Factorial(N);
        K = Factorial(K);
        NK = Factorial(NK);
        K = K * NK;

        Console.WriteLine(N / K);
    }

    static int Factorial(int n)
    {
        int total = 1;

        for (int i = 1; i <= n; i++)
        {
            total *= i;
        }

        return total;
    }
}
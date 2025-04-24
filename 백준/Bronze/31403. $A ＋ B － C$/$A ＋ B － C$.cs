using System;

class Program
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        var AB = A + B.ToString();

        Console.WriteLine(A + B - C);
        Console.WriteLine(int.Parse(AB) - C);
    }
}

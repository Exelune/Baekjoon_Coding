using System;

class Program
{
    static void Main()
    {
        var list = Console.ReadLine().Split(' ');
        int a = int.Parse(list[0]);
        int b = int.Parse(list[1]);
        int c = int.Parse(list[2]);
        Console.WriteLine((a + b) % c);
        Console.WriteLine(((a % c) + (b % c)) % c);
        Console.WriteLine((a*b) % c);
        Console.WriteLine(((a % c) * (b % c)) % c);
    }
}

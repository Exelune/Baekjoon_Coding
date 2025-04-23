using System;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var (a, b, c, d, e) = (nums[0], nums[1], nums[2], nums[3], nums[4]);
        a = a * a;
        b = b * b;
        c = c * c;
        d = d * d;
        e = e * e;
        int num = (a + b + c + d + e) % 10;
        Console.WriteLine(num);
    }
}
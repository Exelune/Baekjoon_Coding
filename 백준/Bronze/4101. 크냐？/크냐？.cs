using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = inputs[0];
            int b = inputs[1];

            if (a == 0 && b == 0)
                break;

            if (a > b)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
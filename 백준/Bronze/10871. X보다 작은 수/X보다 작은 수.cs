using System;

class Program
{
    static void Main()
    {
        var nx = Console.ReadLine().Split();
        int n = int.Parse(nx[0]);
        int x = int.Parse(nx[1]);

        var numbers = Console.ReadLine().Split();

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(numbers[i]);
            if (num < x)
            {
                Console.Write(num + " ");
            }
        }
    }
}
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            var hwn = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var (H, W, N) = (hwn[0], hwn[1], hwn[2]);
            int y, x = 0;

            y = (N % H);
            x =(N / H + 1);

            if (y == 0)
            {
                y = H;
                x -= 1;
            }

            Console.WriteLine($"{y}{x:D2}");
        }
    }
}
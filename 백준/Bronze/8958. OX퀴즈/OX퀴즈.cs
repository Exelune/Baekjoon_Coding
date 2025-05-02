using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string ox = Console.ReadLine();
            int stack = 0;
            int result = 0;

            foreach (char c in ox)
            {
                if (c == 'O') stack = stack + 1;
                else stack = 0;
                result += stack;
            }
            Console.WriteLine(result);
        }
    }
}
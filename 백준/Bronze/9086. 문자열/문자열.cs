using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            String text = Console.ReadLine();
            String result = "";

            result += text[0];
            result += text[text.Length-1];
            Console.WriteLine(result);
        }
    }
}
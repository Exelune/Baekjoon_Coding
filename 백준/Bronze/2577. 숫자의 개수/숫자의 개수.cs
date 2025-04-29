using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int ABC = A * B * C;
        string text = ABC.ToString();
        int[] result = new int[10];

        foreach (char c in text)
        {
            int num = c - '0';
            for(int i = 0; i < 10; i++)
            {
                if(num == i)
                {
                    result[i]++;
                }
            }
        }

        foreach (int i in result)
        {
            Console.WriteLine(i);
        }
    }
}
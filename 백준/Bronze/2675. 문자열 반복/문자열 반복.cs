using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < N; i++)
        {
            var input = Console.ReadLine().Split().ToArray();
            int R = int.Parse(input[0]);
            String S = input[1];
            for (int j = 0; j < S.Length; j++)
            {
                for(int k = 0; k < R; k++)
                {
                    Console.Write(S[j]);
                }
            }
            Console.WriteLine();
        }
    }
}
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int[] result = Enumerable.Repeat(-1, 26).ToArray();

        for(int i = 0; i < s.Length; i++)
        {
            int idx = s[i] - 'a';

            if (result[idx] == -1)
                result[idx] = i;
        }

        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
    }
}
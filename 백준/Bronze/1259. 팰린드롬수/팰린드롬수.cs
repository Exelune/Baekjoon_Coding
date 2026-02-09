using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string input = "";
        

        while ((input = sr.ReadLine()) != "0")
        {
            int index = input.Length;
            int lastIndex = index - 1;
            bool isPalindrome = false;

            for (int i = 0; i <= index / 2; i++)
            {
                if (input[i] != input[lastIndex])
                {
                    sw.WriteLine("no");
                    isPalindrome = false;
                    break;
                }
                isPalindrome = true;
                lastIndex--;
            }

            if (isPalindrome) sw.WriteLine("yes");
        }

    }
}

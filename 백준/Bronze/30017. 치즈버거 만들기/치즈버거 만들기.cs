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

        var AB = sr.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int result = 0;

        while (true)
        {
            AB[0]--;
            if(AB[0] < 0)
            {
                break;
            }
            result++;

            AB[1]--;
            if (AB[0] <= 0 || AB[1] < 0)
            {
                break;
            }
            result++;
        }

        sw.WriteLine(result);
    }
}
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

        var HM = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int result = 0;

        if (HM[0] - 9 == 1)
        {
            result += 60;
            result += HM[1];
        }
        else if(HM[0] - 9 == 2)
        {
            result += 120;
            result += HM[1];
        }
        else
        {
            result += HM[1];
        }

        sw.WriteLine(result);
    }
}
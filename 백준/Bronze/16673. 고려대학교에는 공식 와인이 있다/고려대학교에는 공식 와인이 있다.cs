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

        var CKP = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int result = 0;

        for(int i = 1; i <= CKP[0]; i++)
        {
            result += (CKP[1] * i) +(CKP[2] * (i * i));
        }
        sw.WriteLine(result);
    }
}

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

        string input = sr.ReadLine();

        if(input == "0")
        {
            sw.WriteLine("YONSEI");
        }
        else
        {
            sw.WriteLine("Leading the Way to the Future");
        }
    }
}

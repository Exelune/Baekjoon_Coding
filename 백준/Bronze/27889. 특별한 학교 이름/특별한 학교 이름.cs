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

        if(input == "NLCS")
        {
            sw.WriteLine("North London Collegiate School");
        }
        else if (input == "BHA")
        {
            sw.WriteLine("Branksome Hall Asia");
        }
        else if (input == "KIS")
        {
            sw.WriteLine("Korea International School");
        }
        else
        {
            sw.WriteLine("St. Johnsbury Academy");
        }
    }
}

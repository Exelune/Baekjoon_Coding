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

        if(input == "M")
        {
            sw.WriteLine("MatKor");
        }
        else if (input == "W")
        {
            sw.WriteLine("WiCys");
        }
        else if (input == "C")
        {
            sw.WriteLine("CyKor");
        }
        else if (input == "A")
        {
            sw.WriteLine("AlKor");
        }
        else
        {
            sw.WriteLine("$clear");
        }
    }
}

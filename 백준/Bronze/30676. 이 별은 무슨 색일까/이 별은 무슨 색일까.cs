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

        int input = int.Parse(sr.ReadLine());
        if (input >= 380 && input < 425)
        {
            sw.Write("Violet");
        }
        else if (input >= 425 && input < 450)
        {
            sw.Write("Indigo");
        }
        else if (input >= 450 && input < 495)
        {
            sw.Write("Blue");
        }
        else if (input >= 495 && input < 570)
        {
            sw.Write("Green");
        }
        else if (input >= 570 && input < 590)
        {
            sw.Write("Yellow");
        }
        else if (input >= 590 && input < 620)
        {
            sw.Write("Orange");
        }
        else
        {
            sw.Write("Red");
        }
    }
}

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

        sw.WriteLine("NFC West       W   L  T\n-----------------------\nSeattle        13  3  0\nSan Francisco  12  4  0\nArizona        10  6  0\nSt. Louis      7   9  0\n\nNFC North      W   L  T\n-----------------------\nGreen Bay      8   7  1\nChicago        8   8  0\nDetroit        7   9  0\nMinnesota      5  10  1");
    }
}

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

        int n = int.Parse(sr.ReadLine()) - 1;
        string SMUPC = "WelcomeToSMUPC";

        int N = n % SMUPC.Length;
        sw.WriteLine(SMUPC[N]);
    }
}

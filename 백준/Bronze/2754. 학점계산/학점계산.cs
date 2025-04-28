using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> C = new Dictionary<string, double>();
        C.Add("A+", 4.3);
        C.Add("A0", 4.0);
        C.Add("A-", 3.7);
        C.Add("B+", 3.3);
        C.Add("B0", 3.0);
        C.Add("B-", 2.7);
        C.Add("C+", 2.3);
        C.Add("C0", 2.0);
        C.Add("C-", 1.7);
        C.Add("D+", 1.3);
        C.Add("D0", 1.0);
        C.Add("D-", 0.7);
        C.Add("F", 0.0);

        string score = Console.ReadLine();
        Console.WriteLine(C[score].ToString("F1"));
    }
}
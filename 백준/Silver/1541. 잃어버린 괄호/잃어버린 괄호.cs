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
        string[] parts = input.Split('-');
        int result = parts[0].Split('+').Select(int.Parse).Sum();

        for (int i = 1; i < parts.Length; i++)
        {
            int value = parts[i].Split('+').Select(int.Parse).Sum();
            result -= value;
        }

        sw.WriteLine(result);
    }
}
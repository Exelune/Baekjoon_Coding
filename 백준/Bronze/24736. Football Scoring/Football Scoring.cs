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

        var home = sr.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var visiting = sr.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int[] score = { 6, 3, 2, 1, 2 };

        int homeScore = 0;
        int visitingScore = 0;

        for(int i = 0; i < 5; i++)
        {
            homeScore += home[i] * score[i];
            visitingScore += visiting[i] * score[i];
        }

        sw.WriteLine(homeScore + " " + visitingScore);
    }
}
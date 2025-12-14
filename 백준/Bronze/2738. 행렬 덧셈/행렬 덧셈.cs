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

        var NM = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[,] A = new int[NM[0], NM[1]];
        int[,] B = new int[NM[0], NM[1]];

        for (int i = 0; i < NM[0]; i++)
        {
            int[] inputs = sr.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < NM[1]; j++)
            {
                A[i, j] = inputs[j];
            }
        }

        for (int i = 0; i < NM[0]; i++)
        {
            int[] inputs = sr.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < NM[1]; j++)
            {
                B[i, j] = inputs[j];
            }
        }

        for (int i = 0; i < NM[0]; i++)
        {
            for (int j = 0; j < NM[1]; j++)
            {
                sw.Write(A[i, j] + B[i, j]);
                sw.Write(" ");
            }
            sw.WriteLine();
        }
    }
}

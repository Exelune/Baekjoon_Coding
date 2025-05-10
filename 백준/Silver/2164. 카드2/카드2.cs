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

        Queue<int> ints = new Queue<int>();

        int num = int.Parse(sr.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            ints.Enqueue(i);
        }

        while (ints.Count > 1)
        {
            ints.Dequeue();
            ints.Enqueue(ints.Dequeue());
        }

        sw.WriteLine(ints.Peek());
    }
}
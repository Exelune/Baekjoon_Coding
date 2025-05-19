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

        var queue = new PriorityQueue<int, int>();
        int N = int.Parse(sr.ReadLine());

        for(int i = 0; i < N; i++)
        {
            int num = int.Parse(sr.ReadLine());
            if(num == 0 && queue.Count == 0)
            {
                sw.WriteLine(0);
            }
            else if(num == 0)
            {
                sw.WriteLine(queue.Dequeue());
            }
            else
            {
                queue.Enqueue(num, num);
            }
        }
    }
}
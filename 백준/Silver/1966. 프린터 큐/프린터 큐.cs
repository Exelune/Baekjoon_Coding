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

        int TC = int.Parse(sr.ReadLine());
        int count = 0;

        for(int i = 0; i < TC; i++)
        {
            int[] NM = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] prioritys = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<(int index, int priority)> q = new Queue<(int, int)>();
            for(int j = 0; j < NM[0]; j++)
            {
                q.Enqueue((j, prioritys[j]));
            }

            while (q.Count > 0)
            {
                var temp = q.Peek();
                if (temp.priority < q.Max(x => x.priority))
                {
                    var tmp = q.Dequeue();
                    q.Enqueue(tmp);
                }
                else
                {
                    var tmp = q.Dequeue();
                    count++;
                    if (NM[1] == tmp.index)
                    {
                        sw.WriteLine(count);
                        count = 0;
                        break;
                    }
                }
            }
        }
    }
}

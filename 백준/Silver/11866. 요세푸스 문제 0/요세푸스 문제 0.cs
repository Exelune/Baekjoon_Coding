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

        var NK = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Queue<int> q = new Queue<int>();
        int count = 1;
        int listCount = 0;

        for (int i = 1; i <= NK[0]; i++)
        {
            q.Enqueue(i);
        }

        int[] list = new int[NK[0]];

        while(q.Count > 0)
        {
            if(count == NK[1])
            {
                list[listCount] = q.Dequeue();
                listCount++;
                count = 1;
            }
            else
            {
                q.Enqueue(q.Dequeue());
                count++;
            }
        }

        string result = $"<{string.Join(", ", list)}>";
        sw.WriteLine(result);
    }
}
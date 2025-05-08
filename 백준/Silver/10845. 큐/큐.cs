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

        Queue<int> queue = new Queue<int>();

        int num = int.Parse(sr.ReadLine());

        for (int i = 0; i < num; i++)
        {
            var input = sr.ReadLine().Split(' ');
            string command = input[0];
            int x = 0;
            int item = 0;

            if (input.Length > 1) x = int.Parse(input[1]);

            switch (command)
            {
                case "push":
                    queue.Enqueue(x);
                    break;

                case "pop":
                    if (queue.Count > 0)
                    {
                        item = queue.Dequeue();
                        sw.WriteLine(item);
                    }
                    else sw.WriteLine(-1);
                    break;

                case "size":
                    sw.WriteLine(queue.Count());
                    break;

                case "empty":
                    if(queue.Count > 0) sw.WriteLine(0);
                    else sw.WriteLine(1);
                    break;

                case "front":
                    if (queue.Count > 0) sw.WriteLine(queue.Peek());
                    else sw.WriteLine(-1);
                    break;

                case "back":
                    if (queue.Count > 0) sw.WriteLine(queue.Last());
                    else sw.WriteLine(-1);
                    break;

            }

        }
    }
}
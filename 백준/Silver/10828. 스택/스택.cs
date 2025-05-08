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

        Stack<int> stack = new Stack<int>();

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
                    stack.Push(x);
                    break;

                case "pop":
                    if (stack.Count() > 0)
                    {
                        item = stack.Pop();
                        sw.WriteLine(item);
                    }
                    else sw.WriteLine(-1);
                    break;

                case "size":
                    sw.WriteLine(stack.Count());
                    break;

                case "empty":
                    if(stack.Count() > 0) sw.WriteLine(0);
                    else sw.WriteLine(1);
                    break;

                case "top":
                    if (stack.Count() > 0) sw.WriteLine(item = stack.Peek());
                    else sw.WriteLine(-1);
                    break;

            }

        }
    }
}
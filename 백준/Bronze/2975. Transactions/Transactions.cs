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

        while (true)
        {
            var inputs = sr.ReadLine().Split(' ');
            int[] nums = { int.Parse(inputs[0]), int.Parse(inputs[2]) };
            string cmd = inputs[1];
            int result = 0;

            if (nums[0] == 0 && nums[1] == 0 && cmd == "W")
            {
                break;
            }
            else if (cmd == "W")
            {
                result = nums[0] - nums[1];
                wf(result, sw);
            }
            else if (cmd == "D")
            {
                result = nums[0] + nums[1];
                wf(result, sw);
            }
        }
    }
    static void wf(int i, StreamWriter sw)
    {
        if(i < -200)
        {
            Console.WriteLine("Not allowed");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}
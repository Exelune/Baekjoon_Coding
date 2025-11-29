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

/*        var inputs = sr.ReadLine().Split().Select(int.Parse).ToArray();*/
        int n = int.Parse(sr.ReadLine());
        int count = 0; // 몆번째 666인가 / N 판별
        int result = 0; // 끝날때의 현재수(i)
        string six = "666"; // 검사용
        

        for(int i = 0; i <= int.MaxValue; i++)
        {
            string text = i.ToString();
            if (text.Contains(six))
            {
                count++;
            }

            if(count == n)
            {
                result = i;
                sw.WriteLine(result);
                break;
            }
        }
    }
}

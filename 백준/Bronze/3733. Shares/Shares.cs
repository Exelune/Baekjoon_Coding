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

        string text;

        while((text = sr.ReadLine()) != null)
        {
            var parts = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int N = int.Parse(parts[0]);
            int S = int.Parse(parts[1]);

            sw.WriteLine(S / (N + 1));
        }
    }
}
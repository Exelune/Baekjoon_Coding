using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var Map = new Dictionary<string, string>
        {
            { "Algorithm", "204" },
            { "DataAnalysis", "207" },
            { "ArtificialIntelligence" , "302" },
            { "CyberSecurity" , "B101" },
            { "Network" , "303" },
            { "Startup" , "501" },
            { "TestStrategy" , "105" }
        };

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Map[input]);
        }
    }
}
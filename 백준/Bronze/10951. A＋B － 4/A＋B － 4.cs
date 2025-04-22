using System;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            var list = line.Split();
            int a = int.Parse(list[0]);
            int b = int.Parse(list[1]);
            Console.WriteLine(a + b);
        }
    }
}
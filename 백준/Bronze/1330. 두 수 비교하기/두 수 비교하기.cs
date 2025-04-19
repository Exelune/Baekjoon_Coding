using System;

class Program
{
    static void Main()
    {
        var list = Console.ReadLine().Split(' ');
        int a = int.Parse(list[0]);
        int b = int.Parse(list[1]);
        if(a > b)
        {
            Console.WriteLine(">");
        }
        else if(a < b)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine("==");
        }

    }
}
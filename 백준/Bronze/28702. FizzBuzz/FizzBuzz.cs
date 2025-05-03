using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();
        string[] abc = { a, b, c };
        int i = 0;
        int num = 0;

        for (i = 0; i < abc.Length; i++)
        {
            if (!abc[i].Contains("Fizz") && !abc[i].Contains("Buzz"))
            {
                num = i;
            }
        }

        i = num;

        if (i == 0) { i = 3; }
        else if (i == 1) { i = 2; }
        else {  i = 1; }

        num = int.Parse(abc[num]) + i;

        if (num % 3 == 0 && num % 5 == 0) { Console.WriteLine("FizzBuzz"); }
        else if (num % 3 == 0) { Console.WriteLine("Fizz"); }
        else if (num % 5 == 0) { Console.WriteLine("Buzz"); }
        else { Console.WriteLine(num); }
    }
}
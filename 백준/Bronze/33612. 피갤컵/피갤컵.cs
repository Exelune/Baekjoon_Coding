using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int year = 2024;
        int month = 8;

        month += (n - 1) * 7;

        if (month > 12) {
            year += (month - 1) / 12;
            month = (month - 1) % 12 + 1;
        }

        Console.WriteLine(year + " " + month);

    }
}
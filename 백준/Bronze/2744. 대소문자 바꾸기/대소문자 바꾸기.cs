using System;
using System.Linq;

class Program
{
    static void Main()
    {
        String text = Console.ReadLine();
        String result = "";

        foreach (char c in text)
        {
            if (char.IsUpper(c))
            {
                result += char.ToLower(c);
            }
            else if (char.IsLower(c))
            {
                result += char.ToUpper(c);
            }
        }
        Console.WriteLine(result);
    }
}
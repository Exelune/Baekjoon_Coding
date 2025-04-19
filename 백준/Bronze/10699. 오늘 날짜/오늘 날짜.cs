using System;

class Program
{
    static void Main()
    {
        string today = DateTime.Now.ToString("yyyy-MM-dd");
        Console.WriteLine(DateTime.UtcNow.AddHours(9).ToString("yyyy-MM-dd"));
    }
}
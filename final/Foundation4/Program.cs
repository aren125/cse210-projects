using System;

class Program
{
    static void Main(string[] args)
    {
        Running r = new Running(new DateTime(2026, 10, 23), 30, 4.5);

        Console.WriteLine(r.GetSummary());

        Cycling c = new Cycling(new DateTime(2026, 10, 24), 45, 20.0);

        Console.WriteLine(c.GetSummary());

    }
}
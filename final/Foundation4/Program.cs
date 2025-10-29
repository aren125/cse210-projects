using System;
using System.Diagnostics;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Running r = new Running(new DateTime(2026, 10, 23), 30, 4.5);
        Cycling c = new Cycling(new DateTime(2026, 10, 24), 45, 20.0);
        Swimming s = new Swimming(new DateTime(2026, 10, 25), 12, 10);

        List<Activity> _activities = new List<Activity> { r, c, s };

        foreach (Activity a in _activities)
        {
            Console.WriteLine(a.GetSummary());
        }

    }
}
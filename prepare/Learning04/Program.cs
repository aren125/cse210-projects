using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine();
        Console.WriteLine(a1.GetSummary());
    }
}
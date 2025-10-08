using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine();
        Console.WriteLine(a1.GetSummary());

        MathAssignment m1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine();
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
    }
}
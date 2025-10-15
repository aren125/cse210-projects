using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("Blue", 5);

        Console.WriteLine($"{s1.GetColor()}, {s1.GetArea()}");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("blue", 5);
        Console.WriteLine($"{s1.GetColor()}, {s1.GetArea()}");

        Rectangle r1 = new Rectangle("red", 4, 5);
        Console.WriteLine($"\n{r1.GetColor()}, {r1.GetArea()}");

        Circle c1 = new Circle("yellow", 6);
        Console.WriteLine($"\n{c1.GetColor()}, {c1.GetArea().ToString("F2")}");
    }
}
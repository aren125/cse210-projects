using System;

class Program
{
    static void Main(string[] args)
    {
        Address l1a = new Address("123 Test Street", "Garner", "NC", "USA");
        Lecture l1 = new Lecture("title", "test", "April 1, 2030", "3:00", l1a, "speaker name", 45);

        Console.WriteLine(l1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(l1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(l1.GetShortDescription());
        Console.WriteLine();
    }
}
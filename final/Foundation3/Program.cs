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

        Address r1a = new Address("456 Test Street", "Raleigh", "NC", "USA");
        Reception r1 = new Reception("title2", "test2", "April 2, 2030", "4:00", r1a, "email@exmple.com");

        Console.WriteLine(r1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(r1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(r1.GetShortDescription());
        Console.WriteLine();
    }
}
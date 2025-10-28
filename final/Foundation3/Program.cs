using System;

class Program
{
    static void Main(string[] args)
    {
        Address la = new Address("123 Psych Street", "Raleigh", "NC", "USA");
        Lecture l = new Lecture("Is Pluto a Planet?", "A lecture on what makes a planet a planet. Have you heard about Pluto? That's messed up, right?", "January 4th, 2026", "6:00 pm", la, "Bruton Gaster", 45);

        Console.WriteLine(l.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(l.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(l.GetShortDescription());
        Console.WriteLine();

        Address ra = new Address("214 Oak Tree Lane", "Stars Hollow", "CT", "USA");
        Reception r = new Reception("Emily and Richard's 45th Anniversary", "Celebrating the love of Emily and Richard Gilmore on their 45th wedding anniversary.", "April 25th, 2030", "4:00", ra, "emilygilmore@rsvp.com");

        Console.WriteLine(r.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(r.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(r.GetShortDescription());
        Console.WriteLine();

        Address oa = new Address("456 Steve Dr.", "Swallow Falls", "ID", "USA");
        OutdoorGathering o = new OutdoorGathering("Flint's Birthday Party", "Celebrating Flint's 25th Birthday", "February 3rd, 2026", "1:00 pm", oa, "Cloudy with a Chance of Meat Balls");

        Console.WriteLine(o.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(o.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(o.GetShortDescription());
        Console.WriteLine();
    }
}
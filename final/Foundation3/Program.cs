using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address la = new Address("123 Psych Street", "Raleigh", "NC", "USA");
        Lecture l = new Lecture("Is Pluto a Planet?", "A lecture on what makes a planet a planet. Have you heard about Pluto? That's messed up, right?", "January 4th, 2026", "6:00 pm", la, "Bruton Gaster", 45);

        Address ra = new Address("214 Oak Tree Lane", "Stars Hollow", "CT", "USA");
        Reception r = new Reception("Emily and Richard's 45th Anniversary", "Celebrating the love of Emily and Richard Gilmore on their 45th wedding anniversary.", "April 25th, 2030", "4:00", ra, "emilygilmore@rsvp.com");

        Address oa = new Address("456 Steve Dr.", "Swallow Falls", "ID", "USA");
        OutdoorGathering o = new OutdoorGathering("Flint's Birthday Party", "Celebrating Flint's 25th Birthday", "February 3rd, 2026", "1:00 pm", oa, "Cloudy with a Chance of Meat Balls");

        List<Event> events = new List<Event> { l, r, o };

        foreach (Event e in events)
        {
            Console.WriteLine($"-- Standard Details --\n{e.GetStandardDetails()}");
            Console.WriteLine();
            Console.WriteLine($"-- Full Details --\n{e.GetFullDetails()}");
            Console.WriteLine();
            Console.WriteLine($"-- Short Description --\n{e.GetShortDescription()}");
            Console.WriteLine();
        }

        
    }
}
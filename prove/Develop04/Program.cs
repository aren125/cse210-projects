using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string choice = " ";

        while (choice != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.RunBreathing();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.RunReflecting();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.RunListing();
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
            }
            else {
                Console.WriteLine("invalid choice. Please enter 1, 2, 3, or 4.");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
     
    
    }

}
using System;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Mastery");
        Console.WriteLine("1. Old Testament");
        Console.WriteLine("2. New Testament"); //other options can be added later- just want to test out the old testament first
        Console.Write("What would you like to study? ");

        string choice = Console.ReadLine();
        string fileName = "";

        if (choice == "1")
        {
            fileName = "oldtestament.txt";
            string[] lines = File.ReadAllLines(fileName);


            // use abstraction- so I need to put as much of this code as possible in other files.
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                {
                    if ((parts.Length) == 4) //book, chapter, verse, scripture
                    {
                        string book = parts[0];
                        int chapter = int.Parse(parts[1]);
                        int verse = int.Parse(parts[2]);
                        string scripture = parts[3];

                        Reference reference = new Reference(book, chapter, verse);
                        // I also need to add the scripture string to the Scripture file. 
                    }
                    else if (parts.Length == 5) //book, chapter, startVerse, endVerse, scripture
                    {
                        string book = parts[0];
                        int chapter = int.Parse(parts[1]);
                        int startVerse = int.Parse(parts[2]);
                        int endVerse = int.Parse(parts[3]);
                        string scripture = parts[4];

                        Reference reference = new Reference(book, chapter, startVerse, endVerse); //Do I need a new variable name like "r1" or?
                        // I also need to add the scripture string to the Scripture file. 
                    }


                }
            }
        }



        Reference r1 = new Reference("John", 3, 16);
        Reference r2 = new Reference("Proverbs", 3, 5, 6);

        r1.DisplayReference(); //Test for reference
        r2.DisplayReference(); // Test for reference
    }
}
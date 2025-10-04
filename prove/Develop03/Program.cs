using System;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Mastery");
        Console.WriteLine("1. Old Testament");
        Console.WriteLine("2. New Testament");
        Console.WriteLine("3. Book of Mormon"); 
        Console.WriteLine("4. Doctrine & Covenants");  
        Console.Write("What would you like to study? ");

        string choice = Console.ReadLine();
        string fileName = "";

        if (choice == "1")
        {
            fileName = "oldtestament.txt";
        }
        else if (choice == "2")
        {
            fileName = "newtestament.txt";
        }
        else if (choice == "3")
        {
            fileName = "bookofmormon.txt";
        }
        else if (choice == "4")
        {
            fileName = "doctrineandcovenants.txt";
        }
        else
        {
            Console.WriteLine("\nInvalid Entry.");
            return;
        }


        string[] lines = File.ReadAllLines(fileName);
        List<Scripture> scriptures = new List<Scripture>();

        // use abstraction- so I need to put as much of this code as possible in other files.
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if ((parts.Length) == 4) //book, chapter, verse, scripture
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int verse = int.Parse(parts[2]);
                string text = parts[3];

                Reference reference = new Reference(book, chapter, verse);
                Scripture scripture = new Scripture(reference, text);
                scriptures.Add(scripture);
            }

            else if (parts.Length == 5) //book, chapter, startVerse, endVerse, scripture
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int startVerse = int.Parse(parts[2]);
                int endVerse = int.Parse(parts[3]);
                string text = parts[4];

                Reference reference = new Reference(book, chapter, startVerse, endVerse);
                Scripture scripture = new Scripture(reference, text);
                scriptures.Add(scripture);

            }

        }

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture randomScripture = scriptures[index]; //selecting scripture from file/from scripture list

        Console.Clear(); //clean console
        randomScripture.Display();

        string input = "";
        while (input != "quit" && randomScripture.AllWordsHidden() != true)
        {
            Console.WriteLine();
            Console.WriteLine("\nPress enter to hide words, or type 'quit' to exit.");
            input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            randomScripture.HideRandomWords(5); //Hide 5 words at a time.

            Console.Clear();
            randomScripture.Display();
        }

        if (randomScripture.AllWordsHidden())
        {
            Console.WriteLine("\nAll words are hidden. Great Job!");
        }
        else
        {
            Console.WriteLine("\nGoodbye!");
        }






    }



}

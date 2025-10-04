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

        ScriptureLoader load = new ScriptureLoader(fileName);
        Scripture randomScripture = load.GetRandomScripture();

        string input = "";

        while (input != "quit" && randomScripture.AllWordsHidden() != true)
        {
            Console.Clear();
            randomScripture.Display();

            Console.WriteLine();
            Console.WriteLine("\nPress enter to hide words, or type 'quit' to exit.");
            input = Console.ReadLine();

            if (input != "quit")
            {
                randomScripture.HideRandomWords(5); //Hide 5 words each enter
            }

        }

        Console.Clear();
        randomScripture.Display();

        if (randomScripture.AllWordsHidden())
        {
            Console.WriteLine("\nAll words are hidden. Great Job!");
        }
        else {
            Console.WriteLine("\nGoodbye!");
        }
            
    }

}

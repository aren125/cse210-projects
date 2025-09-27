using System;
using System.IO;

class Program
{
    static void Main() // Main function inside of program class?? - consult team
    {
        Journal myJournal = new Journal();
        Prompt promptGenerator = new Prompt(); //create a prompt generator

        string choice = ""; //create the choice variable for menu

        while (choice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string date = DateTime.Now.ToShortDateString();
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"\n{prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("Rate your day (1-10): ");
                int rating = int.Parse(Console.ReadLine());

                myJournal.AddEntry(date, prompt, response, rating);
                Console.WriteLine("Entry added.");
                Console.WriteLine(); //spacing
            }

            else if (choice == "2")
            {
                myJournal.DisplayEntries();
            }

            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine(); // needs review

                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("|"); // split the lines by the | separator
                    {
                        string date = parts[0];
                        string prompt = parts[1];
                        string response = parts[2];
                        int rating = int.Parse(parts[3]);

                        myJournal.AddEntry(date, prompt, response, rating);
                    }
                }
                Console.WriteLine("Journal loaded. \n");
            }

            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry entry in myJournal.GetEntries())
                    {
                        outputFile.WriteLine(entry.GetSaveFormat());
                    }
                }
                Console.WriteLine("Journal saved.");
                Console.WriteLine();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye.");
            }

            else
            {
                Console.WriteLine("Invalid choice, please try again.\n");
            }

        }
    }
}
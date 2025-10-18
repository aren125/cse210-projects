using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();
        string choice = " ";

        while (choice != "7")
        {
            Console.WriteLine(); 
            gm.DisplayScore();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Delete Goal"); //for exceeding requirements
            Console.WriteLine("7. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                string goalTypeChoice = " ";


                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("What type of Goal would you like to create? ");
                goalTypeChoice = Console.ReadLine();

                Console.Write("\nWhat is the name of your Goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("How many points are associated with this Goal? ");
                int points = int.Parse(Console.ReadLine());



                if (goalTypeChoice == "1")
                {
                    SimpleGoal sg = new SimpleGoal(name, description, points);
                    gm.CreateGoal(sg);
                }
                else if (goalTypeChoice == "2")
                {
                    EternalGoal eg = new EternalGoal(name, description, points);
                    gm.CreateGoal(eg);
                }
                else if (goalTypeChoice == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int targetCount = int.Parse(Console.ReadLine());

                    Console.Write("How many bonus points for this Goal? ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    ChecklistGoal cg = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                    gm.CreateGoal(cg);
                }
                else
                {
                    Console.WriteLine("Invalid goal type.");
                }

            }
            else if (choice == "2")
            {
                Console.WriteLine();
                gm.ListGoals();

            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                gm.SaveGoals(fileName);

            }
            else if (choice == "4")
            {
                Console.Write("\nWhat is the filename? ");
                string fileName = Console.ReadLine();
                gm.LoadGoals(fileName);

            }
            else if (choice == "5")
            {
                gm.ListGoals();
                Console.Write("\nWhich goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine()) - 1; //minus one to line up with the index - index starts at 0, list starts at 1
                if (index >= 0 && index < gm.GetGoalCount())
                {
                    gm.RecordEvent(index);
                }
                else
                {
                    Console.WriteLine("\n Ivallid goal number.");
                }

            }
            else if (choice == "6") //for exceeding requirements
            {
                gm.ListGoals();
                Console.Write("\nWhich goal would you like to delete? ");
                int index = int.Parse(Console.ReadLine()) - 1;

                if (index >= 0 && index < gm.GetGoalCount())
                {
                    gm.DeleteGoal(index);
                    Console.WriteLine("Goal deleted.");
                }
                else
                {
                    Console.WriteLine("Invalid goal number.");
                }

            }
            else if (choice == "7")
            {
                Console.WriteLine("Goodbye!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter a number 1-6.");
            }
        }
    
    }
}
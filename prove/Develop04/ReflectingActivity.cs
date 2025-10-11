using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "prompt",
        "prompt",
        "prompt"
    };

    private List<string> _questions = new List<string>
    {
        "question",
        "quwation",
        "question"
    };

    private Random _random = new Random();

    public ReflectingActivity()
    : base("Reflecting Activity", "This activity will help you reflect on times in your life when you \nhave shown resilience. This will help you recognize the power you have and how you can use it in other aspects \nof your life.")
    { }

    private string GetRandomPrompt()
    {
        int i = _random.Next(_prompts.Count);
        return _prompts[i];

    }

    private string GetRandomQuestion()
    {
        int i = _random.Next(_questions.Count);
        return _questions[i];
    }
        
    
    public void RunReflecting()
    {
        DisplayStartMessage(); //start message
    
        GetDurationFromUser(); //ask user for duration
        Console.WriteLine();

        int duration = GetDuration(); //getter for duration

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        Console.WriteLine("\n Consider the following prompt: ");
        Console.WriteLine();

        Console.WriteLine($"--{GetRandomPrompt()}--"); //put in random prompt from getrandomrpompt
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration); //end time is the current time + the duration

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"> {GetRandomQuestion()}"); //test and make sure there will be a different random question each loop through
            ShowSpinner(15);
            Console.WriteLine();
        }

        DisplayEndMessage(); //end message
    }
        
    
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
   {
       "Who are people that you appreciate?",
       "What are personal strengths of yours?",
       "Who are people that you have helped this week?",
       "When have you felt the Holy Ghost this month?",
       "Who are some of your personal heroes?"
   };

    private List<string> _responses = new List<string>();

    Random _random = new Random();

    public ListingActivity()
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list \nas many things as you can in a certain area.")
    { }

    private string GetRandomPrompt()
    {
        int i = _random.Next(_prompts.Count);
        return _prompts[i];
    }

    public void RunListing()
    {
        DisplayStartMessage();

        int duration = GetDuration(); //getter for duration

        Console.WriteLine("\n List as many responses as you can to the following prompt: ");
        Console.WriteLine();

        Console.WriteLine($"--{GetRandomPrompt()}--"); //put in random prompt from getrandomrpompt
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration); //end time is the current time + the duration

        int responseCount = 0;


        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            responseCount++; // counting how many responses

        }

        Console.WriteLine($"You listed {responseCount} items!");

        DisplayEndMessage();

    }


}

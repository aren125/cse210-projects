using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _shuffledQuestions; //No repeat questions until they have all been used for exceeding requirements.
    private int _currentQuestionIndex; //exceeding requirements.
    private Random _random = new Random();

    public ReflectingActivity()
    : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        ShuffleQuestions(); //exceeding requirements.
    }

    private void ShuffleQuestions() //exceeding requirements.
    {
        _shuffledQuestions = new List<string>(_questions);
        for (int i = _shuffledQuestions.Count - 1; i > 0; i--)
        {
            int j = _random.Next(i + 1);
            var temp = _shuffledQuestions[i];
            _shuffledQuestions[i] = _shuffledQuestions[j];
            _shuffledQuestions[j] = temp;
        }
        _currentQuestionIndex = 0;
    }

    private string GetNextQuestion() //exceeding requirements.
    {
        if (_currentQuestionIndex >= _shuffledQuestions.Count) //reshuffle if it goes through all questions
        {
            ShuffleQuestions();
        }

        string question = _shuffledQuestions[_currentQuestionIndex];
        _currentQuestionIndex++;
        return question;
    }


    private string GetRandomPrompt()
    {
        int i = _random.Next(_prompts.Count);
        return _prompts[i];

    }
   
    public void RunReflecting()
    {
        DisplayStartMessage(); //start message
    
        int duration = GetDuration(); //getter for duration

        Console.WriteLine("\n Consider the following prompt: ");
        Console.WriteLine();

        Console.WriteLine($"--{GetRandomPrompt()}--"); //put in random prompt from getrandomrpompt
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration); //end time is the current time + the duration

        while (DateTime.Now < endTime)
        {
            Console.Write($"\n> {GetNextQuestion()}"); //test and make sure there will be a different random question each loop through
            ShowSpinner(15);
            Console.WriteLine();
        }

        DisplayEndMessage(); //end message
    }
        
    
}
using System;
using System.Collections.Generic;
public class Prompt
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are three things I am grateful for today, and why?",
        "What do I wish I had done differently today?",
        "What or who made me laugh today?",
        "What challeges did I face today and how did I overcome them?",
        "Did I notice anything beautiful around me today?"
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random(); 
        int index = randomGenerator.Next(_prompts.Count);
        return _prompts[index];
    }
}
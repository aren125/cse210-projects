using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus.")
    { }

    public void RunBreathing()
    {
        DisplayStartMessage(); //start message
    
        GetDurationFromUser(); //ask user for duration
        Console.WriteLine();

        int duration = GetDuration(); //getter for duration

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration); //end time is the current time + the duration

        while (DateTime.Now < endTime) //while the current time is less than the end time, loop through the breathing exercises.
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.Write("Breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndMessage(); //end message.
        
    }


}
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus.")
    { }

    public void RunBreathing()
    {
        DisplayStartMessage(); //start message
        
        int duration = GetDuration(); //getter for duration

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration); //end time is the current time + the duration

        while (DateTime.Now < endTime) //while the current time is less than the end time, loop through the breathing exercises.
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.Write("\nNow breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndMessage(); //end message.
        
    }


}
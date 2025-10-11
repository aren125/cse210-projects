using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity("spinner Activity", "test", 30);
        activity.ShowSpinner(10);
        activity.ShowCountDown(5);
    }

}
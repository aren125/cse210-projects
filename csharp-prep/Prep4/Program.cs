using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = 0;
        foreach (float number in numbers)
        {
            average = ((float)sum) / numbers.Count;
        }
        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest is: {largest}");

        int smallest = numbers[0];
        foreach (int number in numbers)
        {
            if (number < smallest)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"The smallest number is: {smallest}");

        Console.WriteLine("Numbers sorted:");
        numbers.Sort();

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

}
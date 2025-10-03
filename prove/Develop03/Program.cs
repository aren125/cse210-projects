using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("John", 3, 16);
        Reference r2 = new Reference("Proverbs", 3, 5, 6);

        r1.DisplayReference(); //Test for reference
        r2.DisplayReference(); // Test for reference
    }
}
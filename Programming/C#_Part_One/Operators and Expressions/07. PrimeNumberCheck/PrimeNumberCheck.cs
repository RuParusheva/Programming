//Task 07. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter a number you would like to check: ");
        int valueToCheck = int.Parse(Console.ReadLine());

        if (valueToCheck >= 100)
        {
            Console.WriteLine("Incorrect value. Please choose a number that is less than 100.");
            return;
        }
        else if (valueToCheck == 2 || valueToCheck == 3 || valueToCheck == 5 || valueToCheck == 7)
        {
            Console.WriteLine("The number you have entered is prime");        
        }
        else if (valueToCheck % 2 == 0 || valueToCheck % 3 == 0 || valueToCheck % 5 == 0 || valueToCheck % 7 == 0)
        {
            Console.WriteLine("The number you have entered is composite");
        }
        else
        {
            Console.WriteLine("The number you have entered is prime");
        }
    }
}


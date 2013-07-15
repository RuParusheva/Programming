//Task 07. Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("How many numbers would you like to sum? ");
        int counter = int.Parse(Console.ReadLine());

        int sumOfNumbers = 0;
        int currentNumber = 0;
        for (int i = 0; i < counter; i++)
        {
            Console.Write("Number to work with:");
            while (!int.TryParse(Console.ReadLine(), out currentNumber))
            {
                Console.WriteLine("The value you have entered exceeds the allowed range. Try a different entry!");
            }
            sumOfNumbers += currentNumber;
        }
        Console.WriteLine("Sum of given input numbers is: {0}", sumOfNumbers);
    }
}


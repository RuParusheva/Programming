/*Task 01. Write an if statement that examines two integer variables and exchanges their values 
if the first one is greater than the second one.*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstValue = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondValue = int.Parse(Console.ReadLine());

        int biggerValue = Math.Max(firstValue, secondValue);

        if (firstValue > secondValue)
        {
            firstValue = secondValue;
            secondValue = biggerValue;
            Console.WriteLine("Exchanged values {0}, {1}", firstValue, secondValue);
        }
        else
        {
            Console.WriteLine("The second number is greater than the first, thus no exchange has been performed!");
        }
    }
}


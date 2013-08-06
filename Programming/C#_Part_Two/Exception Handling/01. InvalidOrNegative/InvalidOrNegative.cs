/*Task 01. Write a program that reads an integer number and calculates and prints its square root. 
 If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
 Use try-catch-finally.*/
 
using System;
using System.Collections.Generic;

class InvalidOrNegative
{
    public static double SquareRoot(int userInput)
    {
        if (userInput < 0)
        {
            throw new System.ArgumentOutOfRangeException();
        }

        return Math.Sqrt(userInput);
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());
            SquareRoot(userInput);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }
    }
}

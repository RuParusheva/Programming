//Task 03. Write a program that finds the biggest of three integers using nested if statements.

using System;

class MaxValue
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstValue = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondValue = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int thirdValue = int.Parse(Console.ReadLine());

        if (firstValue >= secondValue)
        {
            if (firstValue >= thirdValue)
            {
                Console.WriteLine("The biggest number is {0}", firstValue);
            } 
        }
        else if (secondValue >= firstValue)
        {
            if (secondValue >= thirdValue)
            {
                Console.WriteLine("The biggest number is {0}", secondValue);
            }     
        }
        else
        {
            Console.WriteLine("The biggest number is {0}", thirdValue);
        }
    }
}


//Task 01. Write a program that reads 3 integer numbers from the console and prints their sum.

using System;



class PrintSum
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstValue = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondValue = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int thirdValue = int.Parse(Console.ReadLine());

        int sum = (firstValue + secondValue + thirdValue);
        Console.WriteLine("Their sum equals = {0}", sum); 
    }
}


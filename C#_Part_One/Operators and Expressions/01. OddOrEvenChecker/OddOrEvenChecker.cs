//Task 01. Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenChecker
{
    static void Main()
    {
        Console.WriteLine("Please enter a number you would like to check: ");
        int numberToCheck = int.Parse(Console.ReadLine());
        if ((numberToCheck & 1) == 0) //Using bitwise operation to check whether the number is odd or even. 
//The expression checks whether the least significant bit (bit0) in the binary representation of given value is 1 or 0.                                   
        {
            Console.WriteLine("The number you have entered is even.");
        }
        else
        {
            Console.WriteLine("The number you have entered is odd.");
        }
    }
}


//Task 02. Write a program that reads two arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter values for first array: ");
        string[] firstArray = Console.ReadLine().Split();
        Console.WriteLine("Enter values for second array: ");
        string[] secondArray = Console.ReadLine().Split();

        bool isSameLength = firstArray.Length == secondArray.Length;
        bool areEqual = true;

        if (isSameLength)
        {

            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    Console.WriteLine("The arrays do not have equal values. ");
                    areEqual = false;
                    break;
                }
            }
            if (areEqual)
            {
                Console.WriteLine("The arrays have equal values. "); 
            }                       
        }
        else
        {
            Console.WriteLine("The arrays have different size.");
        }

    }
}


/*Task 05. Write a method that checks if the element at given position in given array of integers 
 is bigger than its two neighbours (when such exist).*/

using System;

internal class BiggerThanNeighbours
{
    public static bool HasTwoNeighbours(int[] array, int indexToCheck)
    {
        if (indexToCheck > 0 && indexToCheck < array.Length - 1)
        {
            return true;
        }

        return false;
    }

    public static bool IsBigger(int[] array, int indexToCheck)
    {
        int currentValue = array[indexToCheck];

        if (currentValue > array[indexToCheck - 1] && currentValue > array[indexToCheck + 1])
        {
            return true;
        }

        return false;
    }

    private static void Main()
    {
        int[] myArray = { 3, 5, 17, 77, 88, 14, 0, 28, 17, 66, 19, 1 };

        Console.WriteLine("Enter the index of the element you would like to check: ");

        int indexToCheck = int.Parse(Console.ReadLine());

        if (indexToCheck >= myArray.Length || indexToCheck < 0)
        {
            Console.WriteLine("The chosen index exceeds the array boundries! Try a different value. ");
        }
        else
        {
            if (HasTwoNeighbours(myArray, indexToCheck))
            {
                if (IsBigger(myArray, indexToCheck))
                {
                    Console.WriteLine("The element at position {0} is bigger than its two neighbours.", indexToCheck);
                }
                else
                {
                    Console.WriteLine("The element at position {0} is not bigger than its two neighbours.", indexToCheck);
                }
            }
            else
            {
                Console.WriteLine("The element at position {0} does not have two neighbours. ", indexToCheck);
            }
        }
    }
}


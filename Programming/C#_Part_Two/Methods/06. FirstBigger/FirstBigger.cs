/*Task 06. Write a method that returns the index of the first element in array that is bigger than its neighbours, 
 or -1, if there’s no such element. Use the method from the previous exercise. */

using System;

class FirstBigger
{
    public static bool IsBigger(int[] array, int indexToCheck)
    {
        int currentValue = array[indexToCheck];

        if (currentValue > array[indexToCheck - 1] && currentValue > array[indexToCheck + 1])
        {
            return true;
        }

        return false;
    }

    static void Main()
    {
        int[] myArray = { 1, 15, 17, 18, 999, 233, 89, 1, 18, 44, 18, 67, 99, 19 };

        int firstBigger = -1;

        for (int index = 1; index < myArray.Length - 1; index++)
        {
            if (IsBigger(myArray, index))
            {
                firstBigger = index;
                break;
            }
        }
        Console.WriteLine(firstBigger);
    }
}

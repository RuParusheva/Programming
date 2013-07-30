/*Task 04. Write a method that counts how many times given number appears in given array. 
Write a test program to check if the method is working correctly.*/

using System;

public static class TimesRepeatedClass
{
    public static int DistinctCount(int[] array, int element)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (element == array[i])
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main()
    {
        int[] myArray = { 1, 15, 17, 18, 999, 1, 233, 1, 18, 89, 1, 18, 999, 44, 18, 67, 44, 233, 1, 18 };

        Console.WriteLine(string.Join(", ", myArray));

        Console.WriteLine("Choose a number, which you want to count occurences for in the given array: ");
        int element = int.Parse(Console.ReadLine());

        int timesRepeated = DistinctCount(myArray, element);

        Console.WriteLine("Number {0} is repeated {1} time/times. ", element, timesRepeated);
    }
}

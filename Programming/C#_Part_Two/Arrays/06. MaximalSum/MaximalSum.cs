/*Task 06. Write a program that reads two integer numbers N and K and an array of N elements from the console. 
Find in the array those K elements that have maximal sum.*/

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter the number of array elements: ");
        int range = int.Parse(Console.ReadLine());
        Console.Write("Enter the value for K: ");
        int items = int.Parse(Console.ReadLine());

        int[] sequence = new int[range];
        int sum = 0;

        if (range >= items)
        {
            for (int index = 0; index < sequence.Length; index++)
            {
                Console.Write("number {0} = ", (index + 1));
                sequence[index] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sequence);
            //Array.Reverse(sequence); -> this can also be used, but if we have many values it will be slower;

            int lastElement = sequence.Length - 1;

            for (int index = 0; index < items; index++)
            {
                sum += sequence[lastElement--];
            }
            Console.WriteLine("The maximal sum is: {0}", sum);      
        }
        else
        {
            Console.WriteLine("The number of items to sum should not exceed the array range. Enter a smaller value! ");
        }

    }
}


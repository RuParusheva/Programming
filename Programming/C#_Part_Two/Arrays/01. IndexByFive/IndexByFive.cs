/*Task 01. Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
 Print the obtained array on the console.*/

using System;

class IndexByFive
{
    static void Main()
    {
        int[] collection = new int[20];


        for (int index = 0; index < collection.Length; index++)
        {
            collection[index] = index * 5;
            Console.WriteLine(collection[index]);
        }
    }
}

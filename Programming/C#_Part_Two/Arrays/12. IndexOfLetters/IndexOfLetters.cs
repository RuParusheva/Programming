/*Task 12. Write a program that creates an array containing all letters from the alphabet (A-Z). 
Read a word from the console and print the index of each of its letters in the array.*/

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];

        for (int index = 0; index < alphabet.Length; index++)
        {
            alphabet[index] = (char)(index + 'A');
        }

        Console.WriteLine("Enter a word of your choice: ");
        string word = Console.ReadLine().ToUpper();

        foreach (char letter in word)
        {
            Console.WriteLine(letter - 'A');
        }

        int[] myArray = new int[26];
        foreach (char letter in word)
        {
            myArray[letter - 'A']++;
        }

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] != 0)
            {
                Console.WriteLine("{0} is repeated {1} time/s", (char)(i + 'A'), myArray[i]);
            }
        }
    }
}


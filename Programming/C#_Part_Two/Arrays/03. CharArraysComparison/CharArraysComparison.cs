//Task 03. Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CharArraysComparison
{
    static void Main()
    {
        char[] first = Console.ReadLine().ToCharArray();
        char[] second = Console.ReadLine().ToCharArray();

        int result = 0;
        bool areEqual = first.Length == second.Length;
        if (areEqual)
        {
            for (int index = 0; index < first.Length; index++)
            {
                result = first[index].CompareTo(second[index]);

                if (result == -1)
                {
                    Console.WriteLine("{0} preceeds {1}", first[index], second[index]);
                }
                else if (result == 0)
                {
                    Console.WriteLine("{0} equals {1}", first[index], second[index]);
                }
                else
                {
                    Console.WriteLine("{0} follows {1}", first[index], second[index]);
                }

            }
        }
        else
        {
            Console.WriteLine("Arrays have different length. ");
        }
    }
}


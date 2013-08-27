//Task 24. Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class AlphabeticalOrder
{
    static void Main()
    {
        Console.WriteLine("Enter string: ");
        string text = Console.ReadLine();

        var splitted = text.Split(' ');

        Array.Sort(splitted);

        foreach (var word in splitted)
        {
            Console.WriteLine(word);
        }
    }
}

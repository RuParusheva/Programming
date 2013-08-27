/*Task 02. Write a program that reads a string, reverses it and prints the result at the console.
Example: "sample" -> "elpmas".*/

using System;

class ReverseString
{
    public static string Reverse(string source)
    {
        char[] inputstream = source.ToCharArray();
        Array.Reverse(inputstream);
        return new string(inputstream);
    }
    static void Main()
    {
        Console.WriteLine("Enter a string you would like to reverse: ");
        string userInput = Console.ReadLine();

        Console.WriteLine(Reverse(userInput));
    }
}

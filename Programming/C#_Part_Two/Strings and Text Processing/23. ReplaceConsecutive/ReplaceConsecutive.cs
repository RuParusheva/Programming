/*Task 23. Write a program that reads a string from the console and replaces all series of consecutive identical 
 letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".*/
using System;
using System.Text.RegularExpressions;

class ReplaceConsecutive
{
    static void Main()
    {
        
        //string input = "aaaaabbbbbcdddeeeedssaa";
        Console.WriteLine("Enter string: ");
        string input = Console.ReadLine();

        var regex = new Regex("(.)\\1+");
        Console.WriteLine(regex.Replace(input, "$1"));
    }
}

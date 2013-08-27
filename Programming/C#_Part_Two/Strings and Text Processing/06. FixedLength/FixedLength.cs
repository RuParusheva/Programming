/*Task 06. Write a program that reads from the console a string of maximum 20 characters. 
 If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
 Print the result string into the console.*/

using System;
using System.Text;

class FixedLength
{
    static void Main()
    {
        Console.WriteLine("Enter string: ");
        string userInput = Console.ReadLine();
        StringBuilder modified = new StringBuilder();

        if  (userInput.Length < 20)
        {
            modified = modified.Insert(0, userInput);

            for (int i = 0; i < (20 - userInput.Length); i++)
            {
                modified.Append('*');
            }
            Console.WriteLine(modified);
        }
        else
        {
            Console.WriteLine(userInput);
        }
        
    }

}

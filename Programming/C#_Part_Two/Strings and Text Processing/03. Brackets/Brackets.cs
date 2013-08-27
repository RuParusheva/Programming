/*Task 03. Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).*/

using System;

class Brackets
{
    static void Main()
    {
        Console.WriteLine("Enter expression to evaluate: ");
        string input = Console.ReadLine();

        if (input != null)
        {
            char[] chars = input.ToCharArray();

            int counter = 0;

            foreach (char c in chars)
            {
                if (c == '(')
                {
                    counter++;

                }
                if (c == ')')
                {
                    counter--;
                }
                if (counter < 0)
                {
                    break;
                }
            }

            Console.WriteLine(counter == 0 ? "Brackets are placed correctly." : "Brackets are placed incorrectly.");
        }
    }
}

/*Task 13. Write a program that calculates for given N how many trailing zeros present at the end of the number N!. 
 Examples:
 N = 10 -> N! = 3628800 -> 2
 N = 20 -> N! = 2432902008176640000 -> 4
 Does your program work for N = 50 000?
 Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!*/

using System;

class TrailingZeros
{

    static void Main()
    {
        Console.Write("Enter number you would like to work with: ");
        uint userInput = 0;
        bool isParsed = uint.TryParse(Console.ReadLine(), out userInput);
        uint value = Convert.ToUInt32(userInput);

        int counter = 0;
        int timesFive = 0;

        if (isParsed && value > 0)
        {
            for (int i = 1; i <= value; i++)
            {              
                while (value % 5 == 0)
                {
                    timesFive++;
                    value /= 5;
                }
                counter += timesFive;
            }
            Console.WriteLine("The trailing zeros in {0}! are {1}", userInput, counter);
        }
        else
        {
            Console.WriteLine("Error! Try a different entry!");
        }
    }
}


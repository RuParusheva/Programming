/*Task 10. Write a program that applies bonus scores to given scores in the range [1..9]. 
The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; 
if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. 
If it is zero or if the value is not a digit, the program must report an error.
Use a switch statement and at the end print the calculated new value in the console.*/

using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter a digit (1-9): ");
        int digit;
        bool isParsed = int.TryParse(Console.ReadLine(), out digit);

        if (isParsed && digit > 0)
        {
            switch (digit)
            {
                case 1:
                case 2:
                case 3:
                    int valueOne = digit * 10;
                    Console.WriteLine("New value is: {0}", valueOne);
                    break;
                case 4:
                case 5:
                case 6:
                    int valueTwo = digit * 100;
                    Console.WriteLine("New value is: {0}", valueTwo);
                    break;
                case 7:
                case 8:
                case 9:
                    int valueThree = digit * 1000;
                    Console.WriteLine("New value is: {0}", valueThree);
                    break;
                default:
                    Console.WriteLine("Value is out of scope for this program. Enter a digit between 1-9.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid number! Please try again! ");
        }
    }
}


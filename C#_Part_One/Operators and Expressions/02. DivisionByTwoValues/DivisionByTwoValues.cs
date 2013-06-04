//Task 02. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;
using System.Globalization; /*I need this namespace in order to use InvariantCulture method, 
                            which ensures separator type will not cause unhandled exception*/

class DivisionByTwoValues
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer that you would like to check: ");
        int valueToCheck = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (valueToCheck % 5 == 0 && valueToCheck % 7 == 0)
        {
            Console.WriteLine("The number is divisible by both 5 and 7");
        }
        else
        {
            Console.WriteLine("The value you have entered cannot be divided by 5 & 7 simultaneously");
        }
    }
}


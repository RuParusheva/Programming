/* Task 12. We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n
   to hold the value v at the position p from the binary representation of n. Example: 
   n = 5 (00000101), p=3, v=1 -> 13 (00001101)
   n = 5 (00000101), p=2, v=0 -> 1 (00000001)*/

using System;


class BitValueModifier
{
    static void Main()
    {
        Console.WriteLine("Enter the number you would like to check: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Which bit position are you interested in? ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value you would like to work with: ");
        int value = int.Parse(Console.ReadLine());

        if (value == 1) //Checking 1 first as mask assigns 1.
        {   
            int mask = 1 << position;
            int result = number | mask; //Operator | is used because it returns true when input value is 1
            string binaryResult = Convert.ToString(result, 2).PadLeft(32, '0');
            string binaryValue = Convert.ToString(number, 2).PadLeft(32, '0');
            Console.WriteLine("The number you have entered has a binary representation of: \n{0}", binaryValue);
            Console.WriteLine("The modified result has a binary representation of: \n{0}", binaryResult);
            Console.WriteLine("The modified number is {0}", result);
        }
        else if (value == 0)
        {
            int mask = ~(1 << position);
            int result = number & mask; //Operator & is used because it returns true everytime input value is 0
            string binaryResult = Convert.ToString(result, 2).PadLeft(32, '0');
            string binaryValue = Convert.ToString(number, 2).PadLeft(32, '0');
            Console.WriteLine("The number you have entered has a binary representation of: \n{0}", binaryValue);
            Console.WriteLine("The modified result has a binary representation of: \n{0}", binaryResult);
            Console.WriteLine("The modified number is {0}", result);
        }
        else
        {
            Console.WriteLine("Incorrect input value!");
        }
    }
}


/*Task 02. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
Use a sequence of if statements.*/

using System;

class ShowValueSign
{
    static void Main()
    {
        int counter = 0;
        double value = 0;
        bool isZero = false;

        for (int index = 0; index < 3; index++)
        {
            Console.Write("Enter real number: ");
            value = double.Parse(Console.ReadLine());

            if (value == 0)
            {
                isZero = true;
            }
            else if (value < 0)
            {
                counter++;
            }
        }

        if (isZero)
        {
            Console.WriteLine("This is 0");
        }
        else if (counter % 2 == 0)
        {
            Console.WriteLine("Sign is positive");
        }
        else
        {
            Console.WriteLine("Sign is negative");
        }
    }
}


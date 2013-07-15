//Task 10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class CalculateSum
{
    static void Main()
    {
        double modifier = 2;
        double oldValue = 0;
        double delta = 0;
        double result = 1.0;
        int sign = 1;
        do
        {
            result = result + (1 / modifier)*sign;
            delta = Math.Abs(result - oldValue);
            oldValue = result;
            modifier++;
            sign = sign * -1;
        } while (delta >= 0.001);
        Console.WriteLine("Sum of values with the required accuracy is: {0:0.000}", result);
    }
}


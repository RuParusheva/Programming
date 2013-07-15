/*Task 06.Write a program that enters the coefficients a, b and c of a quadratic equation
a*x2 + b*x + c = 0 and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.*/

using System;
using System.Globalization;
using System.Threading;

class QuadraticEquationCoefficients

{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter coefficient a: ");
        double firstValue = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double secondValue = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double thirdValue = double.Parse(Console.ReadLine());

        double root1;
        double root2;

        double d = (secondValue * secondValue - 4 * firstValue * thirdValue);

        //I am taking into account two special cases - if a=0 & b=0 

        if (firstValue == 0)
        {
            root1 = -thirdValue / secondValue;
            root2 = root1;
            Console.WriteLine("One solution existst and it is {0} ", root1);
        }
        else if (secondValue == 0)
        {
            root1 = -(thirdValue + firstValue);
            root2 = root1;
            Console.WriteLine("One solution existst and it is {0} ", root1);
        }
        else if (d < 0)
        {
            //There is no solution
            root1 = double.NaN;
            root2 = double.NaN;
            Console.WriteLine("Real number root is not possible!");
        }
        else if (d == 0)
        {
            root1 = -secondValue / (2 * firstValue);
            root2 = root1;
            Console.WriteLine("One solution existst and it is {0} ", root1);
        }
        else
        {
            double sqrt = Math.Sqrt(d);
            root1 = (-secondValue + sqrt) / (2 * firstValue);
            root2 = (-secondValue - sqrt) / (2 * firstValue);
            Console.WriteLine("Solutions of quadratic equation are {0}, {1} ", root1, root2);
        }
    }
}

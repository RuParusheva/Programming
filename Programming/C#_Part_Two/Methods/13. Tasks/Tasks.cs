/*Task 13. Write a program that can solve these tasks:
a) Reverses the digits of a number
b) Calculates the average of a sequence of integers
c) Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
*/
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static string Reverse(string source)
    {
        char[] inputstream = source.ToCharArray();
        Array.Reverse(inputstream);
        return new string(inputstream);
    }

    public static double Average(int[] array)
    {
        double count = array.Length;

        double result = Sum(array) / count;

        return result;
    }

    public static int Sum(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    public static double Solve(double a, double b)
    {
        double result = -b / a;
        return result;
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Press 1 for Reverse.");
            Console.WriteLine("Press 2 for Average.");
            Console.WriteLine("Press 3 for Solve Linear Equation.");
            Console.WriteLine("Press 4 for Exit.");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("Enter number: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number < 0)
                        {
                            Console.WriteLine("Value is negative.");
                            break;
                        }   
                        var result = Reverse(number.ToString());
                        Console.WriteLine("Reversed: " + result);

                        break;
                    }

                case "2":
                    {
                        Console.WriteLine("Enter values for array separated by space:");

                        var splitted = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

                        if (splitted.Length == 0)
                        {
                            Console.WriteLine("Array has no elements.");
                            break;
                        }

                        var numbers = Array.ConvertAll(splitted, int.Parse);

                        var result = Average(numbers);
                        Console.WriteLine("Average: " + result);

                        break;
                    }

                case "3":
                    {
                        Console.WriteLine("Enter value for a: ");
                        double a = double.Parse(Console.ReadLine());

                        if (a == 0)
                        {
                            Console.WriteLine("A equals zero. Enter a different value.");
                            break;
                        }
                        Console.WriteLine("Enter value for b: ");
                        double b = double.Parse(Console.ReadLine());

                        var result = Solve(a, b);
                        Console.WriteLine("x = " + result);

                        break;
                    }

                default:
                    Environment.Exit(0);

                    break;
            }
        }
    }
}

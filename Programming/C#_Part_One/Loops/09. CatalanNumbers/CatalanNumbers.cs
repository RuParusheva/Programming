/*Task 09. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
C(n) = ((2n)!)/((n+1)!n!)
Write a program to calculate the Nth Catalan number by given N.*/

using System;
using System.Numerics;

class CatalanNumbers
{
    static BigInteger CalculateFactorial(uint number)
    {
        BigInteger  factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
    static void Main()
    {
        Console.Write("Enter Catalan number you are interested in: ");
        uint userInput = 0;
        bool isParsed = uint.TryParse(Console.ReadLine(), out userInput);
        uint value = Convert.ToUInt32(userInput);

        BigInteger calculation = 0;

        if (isParsed && value > 0)
        {
            //C(n) = ((2n)!)/((n+1)!n!)
            calculation = (CalculateFactorial(2 * value)) / ((CalculateFactorial(value + 1)) * CalculateFactorial(value));
            Console.WriteLine("Requested value = {0}", calculation);
        }
        else
        {
            Console.WriteLine("Error! Try a different entry.");
        }
    }
}


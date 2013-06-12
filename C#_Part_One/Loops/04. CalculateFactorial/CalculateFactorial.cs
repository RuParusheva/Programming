//Task 04. Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class CalculateFactorial
{
    static void Main()
    {
        Console.Write("Enter first number N (for N>K>1): ");
        uint userInputN = 0;
        bool isParsedN = uint.TryParse(Console.ReadLine(), out userInputN);
        uint valueN = Convert.ToUInt32(userInputN);

        Console.Write("Enter second number K (for 1<K<N): ");
        uint userInputK = 0;
        bool isParsedK = uint.TryParse(Console.ReadLine(), out userInputK);
        uint valueK = Convert.ToUInt32(userInputK);

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        if (isParsedN && isParsedK && valueN > valueK)
        {
            do
            {
                factorialN *= valueN;
                valueN--;

            } while (valueN > 0);

            do
            {
                factorialK *= valueK;
                valueK--;
            } while (valueK > 0 );
            Console.WriteLine("The factorial for N and K, where 1<{0}<{1}", userInputK, userInputN);
            Console.WriteLine("N! = {0}", factorialN);
            Console.WriteLine("K! = {0}", factorialK);
        }
        else
        {
            Console.WriteLine("Error! Either K > N, N & K exceed the allowed value range or either/both of the values is 0.");
        }
    }
}


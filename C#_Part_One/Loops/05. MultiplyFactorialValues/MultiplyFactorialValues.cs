//Task 05. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class MultiplyFactorialValues
{
    static void Main()
    {
        Console.Write("Enter first number N (for K>N>1): ");
        uint userInputN = 0;
        bool isParsedN = uint.TryParse(Console.ReadLine(), out userInputN);
        uint valueN = Convert.ToUInt32(userInputN);

        Console.Write("Enter second number K (for 1<N<K): ");
        uint userInputK = 0;
        bool isParsedK = uint.TryParse(Console.ReadLine(), out userInputK);
        uint valueK = Convert.ToUInt32(userInputK);

        uint valueKMinusN = valueK - valueN;

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialKMinusN = 1;

        if (isParsedN && isParsedK && valueK > valueN && valueK != 0 && valueN != 0)
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

            do
            {
                factorialKMinusN *= valueKMinusN;
                valueKMinusN--;
            } while (valueKMinusN > 0);

            BigInteger formula = (factorialK * factorialN) / factorialKMinusN;

            Console.WriteLine("The factorial for N and K, where 1<{0}<{1}", userInputN, userInputK);
            Console.WriteLine("N! = {0}", factorialN);
            Console.WriteLine("K! = {0}", factorialK);
            Console.WriteLine("(K-N)! = {0}", factorialKMinusN);
            Console.WriteLine("N!*K! / (K-N)!, where {0} * {1} / {2} = {3}", factorialN, factorialK, factorialKMinusN, formula);
        }
        else
        {
            Console.WriteLine("Error! Either N > K, N & K exceed the allowed value range or either/both of the values is 0.");
        }
    }
}


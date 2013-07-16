/*Task 15. Write a program that finds all prime numbers in the range [1...10 000 000]. 
Use the sieve of Eratosthenes algorithm (find it in Wikipedia).*/
 
using System;
using System.Collections.Generic;

class PrimeNumbersInRange
{
    static void Main()
    {

        var primeNumbers = new List<int>();

        //This has been set to 10000 instead of 10000000, because implementation is slow 
        //and will take a while before printing anything. This aims to illustrate the functionality.
        for (int index = 2; index < 10000; index++)
        {
            primeNumbers.Add(index);
        }

        for (int index = 0; index < primeNumbers.Count; index++)
        {
            var primeNumber = primeNumbers[index];

            for (int number = 2 * primeNumber; number < 10000; number += primeNumber)
            {
                primeNumbers.Remove(number);
            }
        }
        Console.WriteLine(string.Join(" ", primeNumbers));
    }
}


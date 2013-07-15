/*Task 07. Write a program that reads a number N and calculates the sum of the first N members 
 of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.*/

using System;
using System.Numerics;

class FibonacciMembersSum
{
    static void Main()
    {
        Console.Write("Enter Fibonacci sequence member you are interested in: ");
        int userInput = 0;
        bool isParsed = int.TryParse(Console.ReadLine(), out userInput);
        int value = Convert.ToInt32(userInput);

        BigInteger firstMember = 0;
        BigInteger nextMember = 1;
        BigInteger sumofMembers = 0;

        Console.Write("{0} ", firstMember);
        Console.Write(" {0} ", nextMember);

        if (isParsed)
        {
            for (int index = 1; index <= value - 2; index++)
            {
                sumofMembers = firstMember + nextMember;
                firstMember = nextMember;
                nextMember = sumofMembers;    
          
                Console.Write(" {0} ", nextMember);
            }
        }
        else
        {
            Console.WriteLine("Error! Try a different entry.");
        }
    }
}


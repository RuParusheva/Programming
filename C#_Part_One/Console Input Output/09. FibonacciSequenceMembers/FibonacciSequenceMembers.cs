/* Task 09. Write a program to print the first 100 members of the sequence of Fibonacci:
 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …*/

using System;
using System.Numerics; /*If BigInteger type, which resides in this namespace is not used the results
                         will not display correctly as int type is exceeded by the 46-th Fibonacci sequence member*/


class FibonacciSequenceMembers
{
    static void Main()
    {
        /*The initializer is set to -1 to ensure 0 and 1 are also displayed on the console;
        if 0 is chosen, the first value displayed will be 1*/
        BigInteger firstMember = -1; 
        BigInteger nextMember = 1;
        BigInteger sumofMembers = 0; 
        
        for (int i = 1; i <= 100; i++)
        {
            sumofMembers = firstMember + nextMember;
            firstMember = nextMember;
            nextMember = sumofMembers;
            Console.WriteLine("{0} member -> {1}", i, nextMember);
        }
    }
}


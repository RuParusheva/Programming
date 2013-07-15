//Task 09. Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;
using System.Collections.Generic; //necessary for IEnumerable query
using System.Linq; //Enumerable range method uses this namespace

class PrintSequence
{
    static void Main()
    {
        int sign = -1;
        //Enumerable range method generates a sequence of integral numbers within a specified range
        IEnumerable<int> query = Enumerable.Range(2, 12).Select(x => 
        {
            x *= sign; //we use a Lambda expression to change the sign of the sequence members
            sign *= -1;
            return x;
        });

        foreach (var item in query)
        {
            Console.WriteLine(item);
        }
    }
}


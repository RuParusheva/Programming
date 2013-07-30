//Task 12. Extend the program to support also subtraction and multiplication of polynomials

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Polynom p1 = new Polynom(5, 1, 1);
        Polynom p2 = new Polynom(1, 1);

        Console.WriteLine("P1: {0}", p1);
        Console.WriteLine("P2: {0}", p2);

        Console.WriteLine("P3: {0}", p1 - p2);
        Console.WriteLine("P3: {0}", p1 * p2);
    }
}

/*Task 11. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5 -> 501*/

using System;
using System.Collections.Generic;

class AddPolynomials
{
    static void Main()
    {
        Polynom p1 = new Polynom(5, 1, 1);
        Polynom p2 = new Polynom(1, 1);

        Console.WriteLine("P1: {0}", p1);
        Console.WriteLine("P2: {0}", p2);

        Console.WriteLine("P3: {0}", p1 + p2);

    }
}

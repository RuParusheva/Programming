//Task 11. Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class ExchangeValues
{
    static void Main()
    {
        int firstValue = 5;
        int secondValue = 10;
        object firstSwap = secondValue;
        object secondSwap = firstValue;
        Console.WriteLine("{0}, {1}", firstSwap, secondSwap);
    }
}

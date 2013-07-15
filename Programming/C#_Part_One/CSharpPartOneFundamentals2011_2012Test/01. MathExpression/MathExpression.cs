using System;
using System.Globalization;
using System.Threading;


class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double numberN = double.Parse(Console.ReadLine());
        double numberM = double.Parse(Console.ReadLine());
        double numberP = double.Parse(Console.ReadLine());

        const double longNumber = 128.523123123;
        double formula = (((numberN * numberN) + (1 / (numberM * numberP)) + 1337) / (numberN - (numberP * longNumber))) + Math.Sin((int)numberM % 180);
       
        Console.WriteLine("{0:F6}", formula);
    }
}
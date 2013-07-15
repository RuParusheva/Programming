/*Task 08. Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways: with and without using quoted strings.*/

using System;

class StringsAndQuotations
{
    static void Main()
    {
        string firstVersion = @"The ""use"" of quotations causes difficulties.";
        string secondVersion = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("{0}\n{1}", firstVersion, secondVersion);
    }
}


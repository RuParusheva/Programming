/*Task 07. Write a method that reverses the digits of given decimal number. Example: 256 -> 652*/

using System;

class ReverseDigits
{
    public static string ReverseWithRecursion(string source)
    {
        if (source.Length == 0)
        {
            return string.Empty;
        }

        return ReverseWithRecursion(source.Substring(1)) + source[0];
    }

    //One more method using char array as reversal technique, just uncomment to test
    //public static string ReverseWithArrayReversal(string source)
    //{
    //    char[] inputstream = source.ToCharArray();
    //    Array.Reverse(inputstream);
    //    return new string(inputstream);
    //}
    static void Main()
    {
        Console.WriteLine("Enter the number you would like to reverse: ");

        decimal source = decimal.Parse(Console.ReadLine());
        string sourceString = source.ToString();
        string reversed = ReverseWithRecursion(sourceString);
        //string reversed = ReverseWithArrayReversal(sourceString);

        Console.WriteLine(reversed);
    }
}

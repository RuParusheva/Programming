/*Task 01: Implement an extension method Substring(int index, int length) for the class StringBuilder that returns 
 new StringBuilder and has the same functionality as Substring in the class String.*/

using System;
using System.Text;

class StringBuilderSubstring
{
    static void Main()
    {
        var input = new StringBuilder("0123456789");
        Console.WriteLine(input.GenerateSubstring(9, 1));
    }
}

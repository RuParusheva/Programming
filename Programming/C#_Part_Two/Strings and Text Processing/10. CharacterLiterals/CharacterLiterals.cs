/*Task 10. Write a program that converts a string to a sequence of C# Unicode character literals. 
 Use format strings. Sample input:
Hi!
Expected output:
\u0048\u0069\u0021*/

using System;
using System.Text;

class CharacterLiterals
{
    static void Main()
    {
        string input = "Hi!";
        var modified = new StringBuilder();

        foreach (var ch in input)
        {
            modified.AppendFormat("\\u{0:X4}", (int) ch);
        }
        Console.WriteLine(modified);
    }
}

/*Task 07. Write a program that encodes and decodes a string using given encryption key (cipher). 
The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) 
 operation over the first letter of the string with the first of the key, the second – with the second, etc. 
 When the last key character is reached, the next is the first.*/

using System;
using System.Text;

class DecodeString
{
    public static string Encode(string input, string cipher)
    {
        var result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            result.Append((char)(input[i] ^ (uint)cipher[i % cipher.Length]));
        }

        return result.ToString();
    }

    public static string Decode(string input, string cipher)
    {
        return Encode(input, cipher);
    }
    static void Main()
    {
        Console.WriteLine("Enter string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Enter cipher: ");
        string cipher = Console.ReadLine();

        Console.WriteLine(Encode(input, cipher));
        Console.WriteLine(Decode(Encode(input, cipher), cipher));
    }
}

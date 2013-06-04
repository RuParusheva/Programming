/*Task 12. Find online more information about ASCII (American Standard Code for Information Interchange) 
and write a program that prints the entire ASCII table of characters on the console.*/

using System;
using System.Text; //we need this namespace for the encoding

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;  
        Console.WriteLine("Extended ASCII Table");
        for (byte counter = 0;; counter++) //we have not set a count here, because it will display only 254 symbols if we do
        {
            //this line uses 437 encoding for some of the characters
            char sevenBitEncoding = Encoding.GetEncoding(437).GetChars(new byte[] { counter })[0];
            Console.WriteLine("{0} {1}", counter, sevenBitEncoding);
            if (counter == byte.MaxValue) //this condition ensures we print 255 symbols and breaks the cycle
            {
                break;
            }
            if (counter == 7)
            {
                Console.WriteLine("you hear a sound"); //you receive notification that the 7-th symbol is a sound
            }
            if ((counter == 0) || (counter == 8) || (counter == 9) || (counter == 10) || (counter == 13))
            {
                Console.WriteLine("not printable"); //you receive notification that symbols 0, 8, 9, 10, 11 are not printable
            }
        }
    }
}


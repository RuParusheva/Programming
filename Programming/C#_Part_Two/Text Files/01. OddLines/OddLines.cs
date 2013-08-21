//Task 01. Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Text;

class OddLines
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        using (var reader = new StreamReader("../../File_1.txt"))
        {
            int counter = 1;
            string line = reader.ReadLine();

            while (line != null)
            {
                if (counter % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                counter++;
                line = reader.ReadLine();
            }
        }
    }
}

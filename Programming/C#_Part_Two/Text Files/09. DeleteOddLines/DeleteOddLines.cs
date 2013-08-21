//Task 09. Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<string> row = new List<string>(); 

        using (var reader = new StreamReader("../../File_1.txt"))
        {
            int counter = 1;
            string line = reader.ReadLine();

            while (line != null)
            {
                if (counter % 2 == 1)
                {
                    row.Add(line);
                }
                counter++;
                line = reader.ReadLine();
            }
        }
        File.WriteAllLines("../../File_1.txt", row);
        
    }
}

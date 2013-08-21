/*Task 11. Write a program that deletes from a text file all words that start with the prefix "test". 
Words contain only the symbols 0...9, a...z, A…Z, _.*/

using System;
using System.Collections.Generic;
using System.IO;

class DeletePrefix
{
    static void Main()
    {
        using (var reader = new StreamReader("../../File_1.txt"))
        using (var writer = new StreamWriter("../../File_2.txt"))
        {
            string line = reader.ReadLine();

            while (line != null)
            {

                while (line.Contains("test"))
                {
                    int start = line.IndexOf("test");

                    if (start == 0 || line[start - 1] == ' ')
                    {
                        int end = line.IndexOf(' ', start);

                        if (end == -1)
                        {
                            end = line.Length -1;
                        }
                        int length = (end - start) + 1;
                        line = line.Remove(start, length);

                    }
                    else
                    {
                        break;
                    }
                }

                writer.WriteLine(line);
                line = reader.ReadLine();
            }
        }
    }
}

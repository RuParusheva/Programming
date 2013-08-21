//Task 02. Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class TwoFilesToOne
{
    static void Writer(string path, StreamWriter writer)
    {
        using (var reader = new StreamReader(path))
        {
            string currentLine = reader.ReadLine();

            while (currentLine != null)
            {
                writer.WriteLine(currentLine);
                currentLine = reader.ReadLine();
            }
        }
    }

    static void Main()
    {
        using (var writer = new StreamWriter("../../TextFile_3.txt"))
        {
            Writer("../../TextFile_1.txt", writer);
            Writer("../../TextFile_2.txt", writer);
        }
    }
}

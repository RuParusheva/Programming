/*Task 03. Write a program that reads a text file and inserts line numbers in front of each of its lines. 
The result should be written to another text file.*/

using System;
using System.IO;
using System.Text;

class InsertLineNumber
{

    static void Main()
    {
        using (var writer = new StreamWriter("../../File_2.txt"))
        using (var reader = new StreamReader("../../File_1.txt"))
        {
            int lineNumber = 0;
            string line = reader.ReadLine();

            while (line !=null)
            {
                writer.WriteLine(lineNumber + " " + line, Encoding.Unicode);
                line = reader.ReadLine();
                lineNumber++;
            }
        }
    }
}

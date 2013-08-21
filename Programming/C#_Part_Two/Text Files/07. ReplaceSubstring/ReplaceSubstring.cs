/*Task 07. Write a program that replaces all occurrences of the substring "start" with the substring
 "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).*/

using System;
using System.IO;
using System.Text;


class ReplaceSubstring
{
    static void Main()
    {
        using (var reader = new StreamReader("../../File_1.txt"))
        using (var writer = new StreamWriter("../../File_2.txt"))     
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                writer.WriteLine(line.Replace("start", "finish"), Encoding.Unicode);
                line = reader.ReadLine();
            }
        }
    }
}

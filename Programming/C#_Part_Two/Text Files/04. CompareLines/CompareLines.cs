/*Task 04. Write a program that compares two text files line by line and prints the number of lines that
 are the same and the number of lines that are different. Assume the files have equal number of lines.*/

using System;
using System.IO;

class CompareLines
{
    static void Main()
    {
        using (var reader1 = new StreamReader("../../File_1.txt"))
        using (var reader2 = new StreamReader("../../File_2.txt"))
        {
            int equal = 0;
            int different = 0;
            string line1 = reader1.ReadLine();
            string line2 = reader2.ReadLine();

            while (line1 != null && line2 != null)
            {
                if (line1 == line2)
                {
                    equal++;
                }
                else
                {
                    different++;
                }

                line1 = reader1.ReadLine();
                line2 = reader2.ReadLine();
            }

            Console.WriteLine("Number of equal lines is {0} and number of different is {1}.", equal, different);
        }
    }
}

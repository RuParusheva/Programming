/*Task 10. Write a program that extracts from given XML file all the text without the tags. Example:
<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest> 
 Games</interest><interest>C#</instrest><interest> Java</instrest></interests></student>
*/
using System;
using System.Collections.Generic;
using System.IO;

class WithoutTags
{
    static void Main()
    {
        using (var reader = new StreamReader("../../XMLFile1.xml"))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                while (line.Contains("<"))
                {
                    int start = line.IndexOf('<');
                    int end = line.IndexOf('>');
                    int length = (end - start) + 1;
                    line = line.Remove(start, length);
                }

                Console.WriteLine(line);

                line = reader.ReadLine();
            }
        }
    }
}

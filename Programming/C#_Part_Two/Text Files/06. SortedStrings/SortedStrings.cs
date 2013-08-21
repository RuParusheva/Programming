/*Task 06. Write a program that reads a text file containing a list of strings, 
 sorts them and saves them to another text file. Example:
	Ivan			George
	Peter	-->		Ivan
	Maria			Maria
	George			Peter
*/

using System;
using System.IO;
using System.Linq;

class SortedStrings
{
    static string Iterator(string line)
    {
        return line.Trim();
    }

    static void Main()
    {
        var result = File.ReadAllLines("../../StringsFile.txt").OrderBy(Iterator);
        File.WriteAllLines("../../SortedStrings.txt", result);
    }
}

/*Task 03. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
 reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.*/

using System;
using System.IO;
using System.Security;

class ReadAndPrintTxt
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter path of choice: ");
            string path = @"" + Console.ReadLine();
            Console.WriteLine(new string('*', 70));
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Path is null.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path is incorrect; contains whitespace or invalid characters.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path exceeds Operating System predefined length.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Path is either invalid or leading to an unmapped drive.");
        }

        catch (UnauthorizedAccessException unae)
        {
            Console.WriteLine("Several occurrences are possible, current is related to: {0}",
                unae.Message);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Path does not exist or was not found");
        }
        catch (IOException ioe)
        {
            Console.WriteLine("I/O Exception type {0}", ioe.GetType().Name);
        }
        catch (NotSupportedException notsup)
        {
            Console.WriteLine("Path is in unsupported format. {0}", notsup.Message);
        }
        catch (SecurityException)
        {
            Console.WriteLine("You don't have the necessary permission level to work with this path. ");
        }

    }
}

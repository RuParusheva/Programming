/*Task 12. Write a program that removes from a text file all words listed in given another text file. 
Handle all possible exceptions in your methods.*/

using System;
using System.IO;
using System.Security;

class RemoveChosen
{
    private static void Main()
    {
        try
        {
            var textReader = new StreamReader("../../File_1.txt");
            var writer = new StreamWriter("../../File_3.txt");

            string[] words = File.ReadAllLines("../../File_2.txt");

            string line = textReader.ReadLine();

            while (line != null)
            {
                foreach (var word in words)
                {
                    while (line.Contains(word))
                    {
                        int start = line.IndexOf(word, StringComparison.Ordinal);

                        line = line.Remove(start, word.Length);
                    }
                }

                writer.WriteLine(line);
                line = textReader.ReadLine();
            }


        }
        catch (ArgumentNullException argumentNull)
        {

            Console.WriteLine(argumentNull.Message);
        }
        catch (ArgumentException aeException)
        {

            Console.WriteLine(aeException.Message);

        }
        catch (PathTooLongException pathTooLong)
        {

            Console.WriteLine(pathTooLong.Message);

        }
        catch (FileNotFoundException fileNotFound)
        {

            Console.WriteLine(fileNotFound.Message);
        }
        catch (DirectoryNotFoundException directoryNotFound)
        {

            Console.WriteLine(directoryNotFound.Message);
        }
        catch (IOException ioException)
        {

            Console.WriteLine(ioException.Message);

        }
        catch (UnauthorizedAccessException unauthorized)
        {

            Console.WriteLine(unauthorized.Message);
        }

        catch (SecurityException securityException)
        {

            Console.WriteLine(securityException.Message);
        }
    }

}

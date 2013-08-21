/*Task 13. Write a program that reads a list of words from a file words.txt and finds how many times each of the words 
 is contained in another file test.txt. The result should be written in the file result.txt and the words should be
 sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods.*/

using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

class NumberOfOccurrences
{
    static void Main()
    {
        try
        {
            var textReader = new StreamReader("../../test.txt");
            var writer = new StreamWriter("../../result.txt");

            string[] words = File.ReadAllLines("../../words.txt");
            var occurences = new int[words.Length];

            string line = textReader.ReadLine();

            while (line != null)
            {
                line = line.ToLower();

                for (int i = 0; i < words.Length; i++)
                {
                    int count = Regex.Matches(line, @"\b" + words[i].ToLower() + @"\b").Count;
                    occurences[i] += count;

                }
                line = textReader.ReadLine();
            }

            Array.Sort(occurences, words);
            Array.Sort(occurences);
            Array.Reverse(words);
            Array.Reverse(occurences);

            for (var i = 0; i < words.Length; i++)
            {
                writer.Write(words[i]);
                writer.Write(" - ");
                writer.Write(occurences[i]);
                writer.WriteLine();
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


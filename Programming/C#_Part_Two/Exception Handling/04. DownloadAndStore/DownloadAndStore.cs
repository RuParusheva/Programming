/*Task 04. Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
 and stores it the current directory. Find in Google how to download files in C#. 
Be sure to catch all exceptions and to free any used resources in the finally block.*/

using System;
using System.Net;

class DownloadAndStore
{
    static void Main()
    {
        try
        {
            string url = @"http://www.devbg.org/img/Logo-BASD.jpg";

            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, @"Logo-BASD.jpg");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Address parameter doesn't have a value");
        }
        catch (WebException we)
        {
            Console.WriteLine("Several possibilities, current related to: {0}, {1}",
                we.GetType().Name, we.Message);
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Method has been called simultaneously on multiple threads");
        }
        finally
        {
            Console.WriteLine("Code has been executed regardless of failure or success for cleanup purposes.");
        }
    }
}

/*Task 12. Write a program that parses an URL address given in the format:
[protocol]://[server]/[resource]
and extracts from it the [protocol], [server] and [resource] elements. 
 For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"*/

using System;

class FormatURL
{
    static void Main()
    {
        string address = @"http://www.devbg.org/forum/index.php";

        int protocolEnd = address.IndexOf(':');
        string protocol = address.Substring(0, protocolEnd);

        int serverStart = address.IndexOf(@"//", System.StringComparison.Ordinal);
        int serverEnd = address.IndexOf('/', serverStart + 2);
        string server = address.Substring(serverStart + 2, (serverEnd - serverStart) - 2);

        string resource = address.Substring(serverEnd, address.Length - serverEnd);

        Console.WriteLine(@"[protocol] = ""{0}""", protocol);
        Console.WriteLine(@"[server] = ""{0}""", server);
        Console.WriteLine(@"[resource] = ""{0}""", resource);

    }
}

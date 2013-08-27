/*Task 18. Write a program for extracting all email addresses from given text. All substrings that match 
 the format <identifier>@<host>…<domain> should be recognized as emails.*/

using System;
using System.Text;
using System.Text.RegularExpressions;

class EMailAddresses
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        string text = @"Можеш да се свържеш с нас по всяко време през чат-системата ни.
Ако предпочиташ друг начин за връзка, използвай контактите по-долу:
    Телефон: 0884/900004
    sales@ozone.bg - за въпроси, свързани с поръчки на продукти:
    support@ozone.bg –  за въпроси или проблеми, свързани със сайта или допълнителна информация за продукти
    contacts@ozone.bg – за всичко останало";

        var mailsList = new StringBuilder();

        string pattern = @"[\w\+\-\.]+@[\w\+\-\.]+\.[\w\+\-\.]+";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        MatchCollection emailMatches = regex.Matches(text);

        foreach (var emailMatch in emailMatches)
        {
            mailsList.Append(emailMatch);
            mailsList.Append("; ");
        }

        Console.WriteLine(mailsList);
    }
}

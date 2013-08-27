/*Task 15. Write a program that replaces in a HTML document given as string all the tags
 <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:
<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
 Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. 
 Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>*/

using System;
using System.Text;

class ChangeTags
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course.
Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        var words = text.Split(new []{"<a", "a>"}, StringSplitOptions.RemoveEmptyEntries);
        var modified = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(" href="))
            {
                var temp = string.Empty;

                temp = words[i];
                temp = temp.Replace(@" href=""", "[URL=");
                temp = temp.Replace(@""">", "]");
                temp = temp.Replace("</", "[/URL]");
                words[i] = temp;
            }
            modified.Append(words[i]);

        }

        Console.WriteLine(modified);

    }
}

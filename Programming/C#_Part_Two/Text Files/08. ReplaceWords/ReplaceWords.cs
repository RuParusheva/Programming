using System;
using System.IO;
using System.Text;

class ReplaceWords
{
    static void Main()
    {
        using (var reader = new StreamReader("../../File_1.txt"))
        using (var writer = new StreamWriter("../../File_2.txt"))
        {
            string line = reader.ReadLine();


            while (line != null)
            {
                var words = line.Split(new char[] {' ', '\t', ',' });

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == "start")
                    {
                        words[i] = "finish";
                    }
                    if (words[i] == "starts")
                    {
                        words[i] = "finishes";
                    }
                }

                writer.WriteLine(string.Join(" ", words));
                line = reader.ReadLine();
            }
        }
    }
}

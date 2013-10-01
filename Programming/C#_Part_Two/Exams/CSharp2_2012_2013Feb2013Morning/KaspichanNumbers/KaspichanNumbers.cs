using System;
using System.Text;

class KaspichanNumbers
{
    public static string ConvertToKaspichan(ulong number)
    {
        if (number == 0)
        {
            return "A";
        }
        string result = "";

        while (number != 0)
        {
            result = BaseCase(number % 256) + result;
            number /= 256;
        }

        return result;
    }

    static StringBuilder BaseCase(ulong input)
    {
        var output = new StringBuilder();
        char kaspichanNum;

        if (input <= 25)
        {
            kaspichanNum = (char)(input + 'A');
            output.Append(kaspichanNum);
            return output;
        }
        else 
        {
            kaspichanNum = (char)(((input / 26) - 1) + 'a');
            output.Append(kaspichanNum);
            kaspichanNum = (char)(input - (26) * (input / 26) + 'A');
            output.Append(kaspichanNum);
            return output;
        }
    }

    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        Console.WriteLine(ConvertToKaspichan(input));
    }
}

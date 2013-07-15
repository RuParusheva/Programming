using System;

class WeAllLoveBits
{
    public static string ReverseWithBitwiseXOR(string source)
    {
        char[] inputstream = source.ToCharArray();
        int length = source.Length - 1;
        for (int i = 0; i < length; i++, length--)
        {
            inputstream[i] ^= inputstream[length];
            inputstream[length] ^= inputstream[i];
            inputstream[i] ^= inputstream[length];
        }
        return new string(inputstream);
    }
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        int value = 0;

        string stringValue = "";
        int reversedValue = 0;

        for (int index = 0; index < count; index++)
        {
            value = int.Parse(Console.ReadLine());

            reversedValue = 0;

            stringValue = Convert.ToString(value, 2);

            for (int i = 0; i < count; i++)
            {               
                reversedValue = Convert.ToInt32(ReverseWithBitwiseXOR(stringValue), 2);
            }
            Console.WriteLine((value ^ (~value)) & reversedValue); 
        }        
       
    }
}


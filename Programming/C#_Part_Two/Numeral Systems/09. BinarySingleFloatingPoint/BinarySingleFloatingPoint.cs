/*Task 09. Write a program that shows the internal binary representation of given 32-bit signed 
 floating-point number in IEEE 754 format (the C# type float).
 Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.
*/

using System;
using System.Globalization;
using System.Threading;

class BinarySingleFloatingPoint
{
    static byte GetSign(float number)
    {
        byte sign = 0;

        if (number > 0)
        {

            return sign;
        }
        else
        {
            sign += 1;
            return sign;
        }
    }

    static string GetExponent(string binary)
    {
        string[] temp = binary.Split('.');

        int timesCount = ((temp[0].Length) - 1) + 127;
        string exponent = Convert.ToString(timesCount, 2).PadLeft(8, '0');

        return exponent;
    }

    static string GetMantissa(string mantissa)
    {
        mantissa = mantissa.Remove(0, 1);
        int dotIndex = mantissa.IndexOf('.');
        if (dotIndex != -1)
        {
            mantissa = mantissa.Remove(dotIndex, 1);
        }
        for (int i = mantissa.Length; i < 23; i++)
        {
            mantissa += 0;
        }
    
        return mantissa;
    }

    static string WholeToBinary(int whole)
    {
        string result = string.Empty;

        while (whole != 0)
        {
            result = (whole % 2) + result;
            whole /= 2;
        }
        return result;
    }

    static string PartialToBinary(float partial)
    {
        string result = string.Empty;

        while (partial != 0)
        {
            partial *= 2;

            if (partial >= 1)
            {
                result += 1;
            }
            else
            {
                result += 0;
            }
            partial -= (int)(partial);
        }

        return result;
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        float number = -27.25f;
        //float number = 970.75f;
        string sValue = number.ToString();
        var split = sValue.Split('.');
        int len = split[1].Length;
        int whole = Math.Abs(Convert.ToInt32(split[0]));
        float partial = Convert.ToInt32(split[1]) / (float)(Math.Pow(-10, len));           
        string binary = WholeToBinary(whole) + "." + PartialToBinary(partial);

        Console.WriteLine("sign = {0}, exponent = {1}, mantissa = {2}", GetSign(number), GetExponent(binary), GetMantissa(binary));
    }
}

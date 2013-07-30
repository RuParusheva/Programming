/*Task 08. Write a method that adds two positive integer numbers represented as arrays of digits 
 (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the 
 numbers that will be added could have up to 10 000 digits.*/

using System;

class SumDigits
{
    public static string SumArrays(byte[] first, byte[] second)
    {
        int calculation = 0;
        string result = "";
        int carry = 0;

        int shorter = Math.Min(first.Length, second.Length);
        int rotations = (Math.Max(first.Length, second.Length)) - shorter;

        for (int index = 0; index < shorter; index++)
        {
            calculation = first[index] + second[index] + carry;
            carry = calculation / 10;
            result = (calculation % 10) + result;
        }

        byte[] longer = new byte[Math.Max(first.Length, second.Length)];

        if (first.Length > second.Length)
        {
            longer = first;
        }
        else
        {
            longer = second;
        }

        while (rotations > 0)
        {
            calculation = longer[shorter] + carry;
            carry = calculation / 10;
            result = (calculation % 10) + result;
            shorter++;
            rotations--;
        }

        if (carry == 1)
        {
            result = carry + result;
        }

        return result;
    }
    static void Main()
    {
        Console.WriteLine("Enter first positive number: ");
        string first = Console.ReadLine();
        Console.WriteLine("Enter second positive number: ");
        string second = Console.ReadLine();

        byte[] firstArray = Array.ConvertAll(first.ToCharArray(), c => (byte)(c - '0'));
        byte[] secondArray = Array.ConvertAll(second.ToCharArray(), c => (byte)(c - '0'));

        Array.Reverse(firstArray);
        Array.Reverse(secondArray);

        string result = SumArrays(firstArray, secondArray);
        Console.WriteLine("Sum of the two arrays is: {0}", result);
    }
}

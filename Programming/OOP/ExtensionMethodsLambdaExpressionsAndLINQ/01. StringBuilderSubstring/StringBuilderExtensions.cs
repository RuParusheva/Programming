using System;
using System.Text;

static class StringBuilderExtensions
{
    public static StringBuilder GenerateSubstring(this StringBuilder input, int index, int length)
    {
        if (index < 0)
        {
            throw new ArgumentException("Index cannot be less than 0");
        }

        if (length < 0)
        {
            throw  new ArgumentOutOfRangeException("length", "Value for substring length cannot be negative");
        }

        if (index + length > input.Length)
        {
            throw new ArgumentOutOfRangeException("length", "Substring length cannot exceed input length");
        }

        StringBuilder result = new StringBuilder();

        var lastIndex = index + length;

        for (int i = index; i < lastIndex; i++)
        {
            result.Append(input[i]);
        }

        return result;
    }
}
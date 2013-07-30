using System;
using System.Collections.Generic;

public class Polynom
{
    private const char X = 'x';

    private int[] coefficients = null;

    public Polynom(params int[] coefficients)
    {
        this.coefficients = coefficients;
    }

    public static Polynom operator +(Polynom first, Polynom second)
    {
        if (first.coefficients.Length > second.coefficients.Length)
        {
            return second + first;
        }

        int[] third = new int[second.coefficients.Length];

        for (int i = 0; i < first.coefficients.Length; i++)
        {
            third[i] = first.coefficients[i] + second.coefficients[i];
        }

        for (int i = first.coefficients.Length; i < third.Length; i++)
        {
            third[i] = second.coefficients[i];
        }

        return new Polynom(third);
    }

    public static Polynom operator -(Polynom first, Polynom second)
    {
        if (first.coefficients.Length > second.coefficients.Length)
        {
            int[] third = new int[first.coefficients.Length];

            for (int i = 0; i < second.coefficients.Length; i++)
            {
                third[i] = first.coefficients[i] - second.coefficients[i];
            }

            for (int i = second.coefficients.Length; i < first.coefficients.Length; i++)
            {
                third[i] = first.coefficients[i];
            }

            return new Polynom(third);
        }
        else
        {
            int[] third = new int[second.coefficients.Length];

            for (int i = 0; i < first.coefficients.Length; i++)
            {
                third[i] = first.coefficients[i] - second.coefficients[i];
            }

            for (int i = first.coefficients.Length; i < second.coefficients.Length; i++)
            {
                third[i] = -second.coefficients[i];
            }

            return new Polynom(third);
        }
    }

    public static Polynom operator *(Polynom first, Polynom second)
    {
        int[] third = new int[(first.coefficients.Length - 1) + (second.coefficients.Length - 1) + 1];

        for (int i = 0; i < first.coefficients.Length; i++)
        {
            for (int j = 0; j < second.coefficients.Length; j++)
            {
                third[i + j] += first.coefficients[i] * second.coefficients[j];
            }
        }

        return new Polynom(third);
    }

    public override string ToString()
    {
        var result = new List<string>();

        for (int i = coefficients.Length - 1; i >= 1; i--)
        {
            if (coefficients[i] == 0) continue;

            if (coefficients[i] == 1)
            {
                result.Add(string.Format("x^{0}", i));
            }
            else
            {
                result.Add(string.Format("({0} * {1}^{2})", coefficients[i], X, i));
            }
        }

        result.Add(coefficients[0].ToString());

        return string.Join(" + ", result);
    }
}
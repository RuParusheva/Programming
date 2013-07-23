/*Task 05. You are given an array of strings. Write a method that sorts the array by the length of its elements 
(the number of characters composing them).*/

using System;
using System.Linq;
using System.Collections.Generic;

class SortStringsByLength
{
    static void Main()
    {
        string[] arr = { "if", "else", "without", "before", "a" };

        Console.WriteLine(string.Join(" ", arr.OrderBy(x => x.Length)));
    }
}

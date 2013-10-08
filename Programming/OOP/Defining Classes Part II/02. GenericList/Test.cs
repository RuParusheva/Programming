/*Tasks 05-07:
05. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
 Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
 Implement methods for adding element, accessing element by index, removing element by index, 
 inserting element at given position, clearing the list, finding element by its value and ToString(). 
 Check all input parameters to avoid accessing elements at invalid positions.
06. Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
07. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>.
You may need to add a generic constraints for the type T.
*/

using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        var test = new GenericList<int>(2);

        for (int i = 0; i < 25; i++)
        {
            test.Add(i * 4);
        }

        Console.WriteLine(test);

        test.Remove(5);

        Console.WriteLine(test);

        test.Insert(9, 77);
        Console.WriteLine(test);

        Console.WriteLine("ByValue: {0} ", test.FindIndexByValue(77));
        Console.WriteLine("ByIndex: {0}", test[17]);
        Console.WriteLine("Max: {0} ", test.GetMax());
        Console.WriteLine("Min: {0}" , test.GetMin());

        test.Clear();
    }
}

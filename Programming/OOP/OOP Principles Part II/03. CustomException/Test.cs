/*Task 03. Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
 It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
 by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
 */
using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        {
            try
            {
                int start = 1;
                int end = 100;

                int value = 547;

                if (!(start < value && value < end))
                {
                    throw new InvalidRangeException<int>(start, end);
                }
                    
            }

            catch (InvalidRangeException<int> exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Start: {0}; \nEnd: {1};", exception.Start, exception.End);
            }
        }

        Console.WriteLine();

        {
            try
            {
                DateTime start = new DateTime(1980, 1, 1);
                DateTime end = new DateTime(2013, 12, 31);

                DateTime value = new DateTime(2014, 11, 17);

                if (!(start < value && value < end))
                {
                    throw new InvalidRangeException<DateTime>(start, end);
                }
                    
            }

            catch (InvalidRangeException<DateTime> exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Start: {0}; \nEnd: {1};", exception.Start, exception.End);
            }
        }

    }
}


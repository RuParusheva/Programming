/*Task 05. Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), 
 GetHashCode(), [], == and !=.
*/
using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        var bitArray = new BitArray();

        bitArray[5] = 1;
        Console.WriteLine(bitArray[5]);
        Console.WriteLine(bitArray);

        Console.WriteLine(bitArray == new BitArray());
        Console.WriteLine(bitArray != new BitArray());

        bitArray[5] = 0;
        Console.WriteLine(bitArray[5]);
        Console.WriteLine(bitArray);

        Console.WriteLine(bitArray == new BitArray());
        Console.WriteLine(bitArray != new BitArray());
    }
}

using System;
using System.Linq;


class OddNumber
{
    static void Main()
    {
        int range = int.Parse(Console.ReadLine());

        long[] values = new long[range];

        for (int index = 0; index < range; index++)
        {
            values[index] = long.Parse(Console.ReadLine());

        }

        var query = from d in values
                    group d by d into da
                    select da;

        foreach (var i in query.Select((ab, bc) => ab).Where((ab, bc) => ab.Count() % 2 != 0))
            Console.WriteLine(i.Key);

    }
}

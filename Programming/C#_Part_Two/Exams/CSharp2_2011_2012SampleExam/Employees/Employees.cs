using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Employees
{
    static void Main()
    {
#if DEBUG
        Console.SetIn(new StreamReader("../../input.txt"));
#endif

        int positionsNum = int.Parse(Console.ReadLine());

        var positions = new Dictionary<string, int>(); 

        for (int i = 0; i < positionsNum; i++)
        {
            string input = Console.ReadLine();
            var position = input.Split(new[] {" - "}, StringSplitOptions.RemoveEmptyEntries);
            var type = position[0];
            var points = int.Parse(position[1]);
            positions.Add(type, points);
        }

        int employees = int.Parse(Console.ReadLine());

        List<string[]> employeeNames = new List<string[]>();

        for (int i = 0; i < employees; i++)
        {
            string input = Console.ReadLine();
            var employee = input.Split(new[] {" - ", " "}, 3, StringSplitOptions.RemoveEmptyEntries);
            employeeNames.Add(employee);
        }

        var sorted = employeeNames
            .OrderByDescending(x => positions[x[2]])
            .ThenBy(x => x[1])
            .ThenBy(x => x[0]);


        foreach (var person in sorted)
        {
            Console.WriteLine("{0} {1}", person[0], person[1]);
        }
    }
}
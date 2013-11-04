/*Tasks 03-05:
03. Write a method that from a given array of students finds all students whose first name 
is before its last name alphabetically. Use LINQ query operators.
04. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
05. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name
and last name in descending order. Rewrite the same with LINQ.*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class StudentsLINQ
{
    static void Main()
    {
        var students = new[]
        {
            new { FirstName = "Liolio", LastName = "Papazov", Age = 17  },
            new { FirstName = "Kircho", LastName = "Chaushev", Age = 22},
            new { FirstName = "Limon", LastName = "Limonov", Age = 20  },
            new { FirstName = "Pisanka", LastName = "Triaskova", Age = 25 },
            new { FirstName = "Kapka", LastName = "Tupchileshtova", Age = 19 },
            new { FirstName = "Unufri", LastName = "Simeonov", Age = 24 },
            new { FirstName = "Pesho", LastName = "Peshev", Age = 45 },
        };

        Print(students.Where(x => String.Compare(x.FirstName, x.LastName, StringComparison.Ordinal) < 0));
        Print(students.Where(x => 18 <= x.Age && x.Age <= 24));
        Print(students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName));

        Print(
            from x in students
            where String.Compare(x.FirstName, x.LastName, StringComparison.Ordinal) < 0
            select x
        );
        Print(
            from x in students
            where 18 <= x.Age && x.Age <= 24
            select x
        );
        Print(
            from x in students
            orderby x.FirstName descending, x.LastName descending
            select x
        );
    }

    static void Print<T>(IEnumerable<T> elements)
    {
        Console.WriteLine(string.Join(Environment.NewLine, elements));
        Console.WriteLine();
    }
}

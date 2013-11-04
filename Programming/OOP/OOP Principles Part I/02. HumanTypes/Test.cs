/*Task 02. Define abstract class Human with first name and last name. Define new class Student which is derived from Human
 and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method
 MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy. 
 Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
 Initialize a list of 10 workers and sort them by money per hour in descending order. 
Merge the lists and sort them by first name and last name.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        List<Student> studentsList = new List<Student>
        {
            new Student("Oligo", "MyFriend", 5.24m),
            new Student("Liolio", "Peshev", 3.34m),
            new Student("Kapka", "Prostakova", 4.25m),
            new Student("Gosho", "Goshov", 3.95m),
            new Student("Alla", "Pugacheva", 2.26m),
            new Student("Pisi", "Ligliova", 5.59m),
            new Student("Kiko", "Vylchev", 5.02m),
            new Student("Dzhidzhi", "Filipov", 4.80m),
            new Student("Klati", "Pipirudata", 2.00m),
            new Student("Kristalchu", "Zubrikov", 6.00m),
        };

        Console.WriteLine(string.Join(Environment.NewLine, studentsList.OrderBy(x => x.Grade)));

        Console.WriteLine();

        List<Worker> workersList= new List<Worker>
        {
            new Worker("Oligo", "MyFriend", 160m, 8),
            new Worker("Liolio", "Peshev", 50.5m, 6),
            new Worker("Kapka", "Prostakova", 360m, 4),
            new Worker("Gosho", "Goshov", 100m, 9),
            new Worker("Alla", "Pugacheva", 2850m, 5),
            new Worker("Pisi", "Ligliova", 200m, 12),
            new Worker("Kiko", "Vylchev", 80m, 4),
            new Worker("Dzhidzhi", "Filipov", 120m, 12),
            new Worker("Klati", "Pipirudata", 1000m, 3),
            new Worker("Kristalchu", "Zubrikov", 2400m, 2),
        };

        Console.WriteLine(string.Join(Environment.NewLine, workersList.OrderByDescending(x => x.MoneyPerHour())));

        Console.WriteLine();

        var people = new List<Human>();
        people.AddRange(studentsList);
        people.AddRange(workersList);

        Console.WriteLine(string.Join(Environment.NewLine, people.OrderBy(x => x.FirstName).ThenBy(x => x.LastName)));
    }
}

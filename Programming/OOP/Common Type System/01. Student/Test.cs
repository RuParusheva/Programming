/*
 Task 01. Define a class Student, which contains data about a student – first, middle and last name, SSN, 
 permanent address, mobile phone e-mail, course, specialty, university, faculty.
 Use an enumeration for the specialties, universities and faculties. Override the standard methods,
 inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 Task 02. Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields 
 into a new object of type Student.
 Task 03. Implement the  IComparable<Student> interface to compare students by names 
 (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
*/

using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        Student first = new Student
            ("Liolio", "Glupev", "Cheshitov", "1245123154840", "4-th Saborna street, Sofia", "+1545458787878",
            "liolio@liolio.com", "2-nd", Specialty.Fashion, Faculty.FineArts, University.NationalAcademyForTheatreAndFilmArts);

        Student second = new Student
            ("Liolio", "Glupev", "Cheshitov", "1245123154840", "4-th Saborna street, Sofia", "+1545458787878",
            "liolio@liolio.com", "2-nd", Specialty.Fashion, Faculty.FineArts, University.NationalAcademyForTheatreAndFilmArts);

        Student third = new Student
            ("Kichka", "Ristova", "Boshniakova", "1545478778682", "1-st Liuliak street, Sofia", "+4545787545454215",
            "kichka@kichka.net", "1-st", Specialty.NetworkingTechnologies, Faculty.Informatics, University.TechnicalUniversityOfSofia);

        Console.WriteLine(first);

        Console.WriteLine(first == second);
        Console.WriteLine(first.Equals(second));

        Console.WriteLine(first != second);
        Console.WriteLine(first.Equals(third));

        Student clone = (Student) first.Clone();
        Console.WriteLine(clone);

        Console.WriteLine(first.CompareTo(third));

        List<Student> students = new List<Student>
        {
            first,
            third,
            new Student("Mishka", "Kotkova", "Leopardova", "1135145465446", "2-nd Evlogi street, Sofia", "+1546464681477",
            "mishka@mishka.org", "3-rd", Specialty.Finances, Faculty.Economics, University.UniversityOfNationalAndWorldEconomy)
        };

        students.Sort();

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}

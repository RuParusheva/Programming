/*Task 01. We are given a school. In the school there are classes of students. Each class has a set of teachers. 
 Each teacher teaches a set of disciplines. Students have name and unique class number. 
 Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. 
 Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
 Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, 
 define the class hierarchy and create a class diagram with Visual Studio.
*/

using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        School firstLanguageSchool = new School("First Language School");

        Discipline math = new Discipline("Basic Mathematics", 15, 11, "Kofti predmet");
        Discipline math2 = new Discipline("Mathematics 2-nd part", 14, 2);
        Console.WriteLine(math);

        Teacher first = new Teacher("Kolio", "Ivanov", "Idiot");
        first.AddDiscipline(math);
        first.AddDiscipline(math2);
        Console.WriteLine(first);

        Student firstStudent = new Student("Liolio", "Peshev", "Very poor performance", "11b");
        Console.WriteLine(firstStudent);

        SchoolClass eleven = new SchoolClass("Eleventh grade");
        eleven.AddTeacher(first);

    }
}

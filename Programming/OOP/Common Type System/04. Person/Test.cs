/*Task 04. Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value).
 Override ToString() to display the information of a person and if age is not specified – to say so. 
 Write a program to test this functionality*/

using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        Person randomPerson = new Person("Ivo Ivov", 15);
        Person secondPerson = new Person("Liolio Liliputov");

        Console.WriteLine(randomPerson);
        Console.WriteLine(secondPerson);
    }
}

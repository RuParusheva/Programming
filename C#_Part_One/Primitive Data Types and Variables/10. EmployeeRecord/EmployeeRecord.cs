/*Task 10. A marketing firm wants to keep record of its employees. Each record would have the following characteristics:
first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.*/

using System;

class EmployeeRecord
{
    static void Main()
    {
        string firstName = "Firstname";
        string familyName = "Familyname";
        byte age = 32;
        char gender = 'f';
        long idNumber = 8104152733;
        int employeeID = 27545326;
        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Family name: {0}", familyName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender (f/m): {0}", gender);
        Console.WriteLine("ID number: {0}", idNumber);
        Console.WriteLine("Unique Employee ID: {0}", employeeID);
    }
}

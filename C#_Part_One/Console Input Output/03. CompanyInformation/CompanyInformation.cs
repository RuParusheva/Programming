/*Task 03. A company has name, address, phone number, fax number, web site and manager. 
The manager has first name, last name, age and a phone number. Write a program that reads the 
information about a company and its manager and prints them on the console.*/

using System;

class CompanyInformation
{
    static void Main()
    {
        //I have used object type to ensure that input from the console allows spacing, symbols, text and numbers.
        Console.Write("Enter company name: ");
        object orgName = Console.ReadLine();

        Console.Write("Enter company address: ");
        object orgAddress = Console.ReadLine();

        Console.Write("Phone number is: ");
        object orgPhone = Console.ReadLine();

        Console.Write("Fax number of the company is: ");
        object faxNumber = Console.ReadLine();

        Console.Write("The internet address is: ");
        object web = Console.ReadLine();

        Console.Write("What is the company manager's first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is the company manager's last name? ");
        string lastName = Console.ReadLine();

        Console.Write("What is the company manager's age? ");
        string age = Console.ReadLine();

        Console.Write("What is the company manager's phone? ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("--COMPANY INFORMATION-- \nCompany name: {0} \nCompany Address: {1}", orgName, orgAddress);
        Console.WriteLine("--CONTACT INFORMATION-- \nPhone number: {0} \nFax number: {1} \nInternet address: {2}", orgPhone, faxNumber, web);
        Console.WriteLine("--CONTACT PERSON-- \nCompany Manager name: {0} {1} \nAage: {2}\nManager's phone: {3}", firstName, lastName, age, managerPhone);
    }
}


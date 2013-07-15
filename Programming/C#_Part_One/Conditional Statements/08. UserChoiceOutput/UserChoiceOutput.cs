/*Task 08. Write a program that, depending on the user's choice inputs int, double or string variable. 
 If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
 The program must show the value of that variable as a console output. Use switch statement.*/

using System;

class UserChoiceOutput
{
    static void Main()
    {
        Console.Write("Enter choice: 1 for int; 2 for string and 3 for double: ");
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Console.Write("Enter an integer number: ");
                int firstInput;
                int.TryParse(Console.ReadLine(), out firstInput);
                Console.WriteLine(firstInput + 1);
                break;
            case "2":
                Console.Write("Enter text: ");
                string secondInput = Console.ReadLine();
                Console.WriteLine(secondInput + "*");
                break;
            case "3":
                Console.Write("Enter number with floating point: ");
                double thirdInput;
                double.TryParse(Console.ReadLine(), out thirdInput);
                Console.WriteLine(thirdInput + 1);
                break;
            default:
                Console.WriteLine("You have entered a value I don't recognize! Try again.");
                break;
        }
    }
}


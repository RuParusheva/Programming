//Task 04. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.

using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter a number which contains at least three digits: ");
        int numberToCheck = int.Parse(Console.ReadLine());

        int modifiedValue = Math.Abs(numberToCheck) / 100; 
        //We take the input value, use Mats.Abs to find out its modulus (absolute value) and then divide it by 100
        //Modulus is used to ensure that even if negative number is entered the program will still run.
        int result = modifiedValue % 10;
        string checkedValue = result == 7 ? "True": "False" ; 
        // You can also replace this line with: bool checkedValue = result == 7; 
        // basically it checks whether result = 7 is true or false

        Console.WriteLine("Is it true that the third digit is 7? {0}", checkedValue);
    }
}


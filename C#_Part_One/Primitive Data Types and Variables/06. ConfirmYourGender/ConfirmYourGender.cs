//Task 06. Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

using System;

class ConfirmYourGender
{
    static void Main()
    {
        Console.WriteLine("Are you female?");
        string myGender = Console.ReadLine();
        string lowercaseValue = myGender.ToLower(); //This line converts all user text input into lowercase
        bool isFemale;
        if (lowercaseValue == "yes")
        {
            isFemale = true;
        }
        else 
        {
            isFemale = false;
        }
        Console.WriteLine(isFemale);
    }
}


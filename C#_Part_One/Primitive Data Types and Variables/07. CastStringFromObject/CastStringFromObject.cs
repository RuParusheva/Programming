/*Task 07. Declare two string variables and assign them with “Hello” and “World”. 
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).*/

using System;

class CastStringFromObject
{
    static void Main()
    {
        string firstVariable = "\"Hello";
        string secondVariable = "World\"";
        object combinedValue = firstVariable + " " + secondVariable;
        string thirdVariable = combinedValue.ToString();
        Console.WriteLine(thirdVariable);
    }
}


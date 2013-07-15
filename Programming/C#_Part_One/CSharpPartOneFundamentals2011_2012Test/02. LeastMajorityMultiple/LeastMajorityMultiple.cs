using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int[] userInput = new int[5];

        int counter = 0;
        
        for (int index = 0; index < userInput.Length; index++)
        {
            userInput[index] = int.Parse(Console.ReadLine());      
        }

        Array.Sort(userInput);
        int modifier = userInput[2];

        while (true)
        {
            counter = 0; 

            for (int i = 0; i < userInput.Length && counter < 3; i++)
            {
                if (modifier % userInput[i] == 0)
                {
                    counter++;
                }
            }
            if (counter >= 3)
            {
                break;
            }
            modifier++;
        }
        Console.WriteLine(modifier);
    }
}


using System;

class MissCat2011
{
    static void Main()
    {
        int votes = int.Parse(Console.ReadLine());

        int[] juryChoice = new int[votes];

        for (int i = 0; i < votes; i++)
        {
            juryChoice[i] = int.Parse(Console.ReadLine());
        }

        int[] catVoteCount = new int[11];

        for (int i = 0; i < juryChoice.Length; i++)
        {
            catVoteCount[juryChoice[i]]++;
        }

        int winnerIndex = 0;
        for (int i = 0; i < catVoteCount.Length; i++)
        {
            if (catVoteCount[i] > catVoteCount[winnerIndex])
            {
                winnerIndex = i;
            }
        }
        Console.WriteLine(winnerIndex);
    }
}


using System;

class BullsAndCows
{
    static void Main()
    {
        string secretNumber = Console.ReadLine();
        int targetBulls = int.Parse(Console.ReadLine()); ;
        int targetCows = int.Parse(Console.ReadLine()); ;

        for (int num = 1111; num <= 9999; num++)
        {
            int bulls = 0;
            int cows = 0;
            bool[] isVisited = new bool[4];
            string numStr = num.ToString();

            if (numStr.Contains("0"))
            {
                continue;
            }

            // count bulls
            for (int i = 0; i < 4; i++)
            {
                if (numStr[i] == secretNumber[i])
                {
                    bulls++;
                    isVisited[i] = true;
                }

            }

            // count cows 
            for (int i = 0; i < numStr.Length; i++)
            {
                if (!isVisited[i])
                {
                    for (int j = 0; j < numStr.Length; j++)
                    {
                        if (i != j && !isVisited[j] && numStr[i] == secretNumber[j])
                        {
                            cows++;
                            isVisited[j] = true;
                        }
                    }
                }
            }

            if (bulls == targetBulls && cows == targetCows)
            {
                Console.Write(num + " ");
            }
        }
    }
}
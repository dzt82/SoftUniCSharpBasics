using System;

class BonusScore
{
    static void Main()
    {
        int score;
        int bonusScore;
        while (true)
        {
            Console.Write("Enter score: ");
            if (int.TryParse(Console.ReadLine(), out score))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }

        if (score >= 1 && score <= 3)
        {
            bonusScore = score * 10;
            Console.WriteLine("The result is: {0}", bonusScore);
        }
        else if (score >= 4 && score <= 6)
        {
            bonusScore = score * 100;
            Console.WriteLine("The result is: {0}", bonusScore);
        }
         else if (score >= 7 && score <= 9)
        {
            bonusScore = score * 1000;
            Console.WriteLine("The result is: {0}", bonusScore);
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
    }
}
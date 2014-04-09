using System;

class AgeInTenYears
{
    static void Main()
    {
        int yearBorn;
        while (true)
        {
            Console.WriteLine("Please enter the year you were born in:");
            if (int.TryParse(Console.ReadLine(), out yearBorn) && yearBorn > 1900 && yearBorn < DateTime.Now.Year)
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorect data, please try again!");
            }
        }
        int birthMonth;
        while (true)
        {
            Console.WriteLine("Please enter the month 1 (for January) up to 12 (for December) you were born:");
            if (int.TryParse(Console.ReadLine(), out birthMonth) && birthMonth > 0 && birthMonth < 13)
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorect data, please try again!");
            }
        }
        int birthDay;
        while (true)
        {
            Console.WriteLine("Please enter the date of the month 1 to 31 you were born at:");
            if (int.TryParse(Console.ReadLine(), out birthDay) && birthDay > 0 && birthDay < 32)
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorect data, please try again!");
            }
        }
        int monthCheck = DateTime.Now.Month - birthMonth;
        int dateCheck = DateTime.Now.Day - birthDay;
        int yearsNow = DateTime.Now.Year - yearBorn;
        int futureAge = yearsNow + 10;
        {
            if (monthCheck > 0)
            {
                Console.WriteLine("Your age now is {0} and you will be {1} years old after 10 years", yearsNow, futureAge);
            }
                if (monthCheck < 0)
                {
                    Console.WriteLine("Your age now is {0} and you will be {1} years old after 10 years", yearsNow - 1, futureAge - 1);
                }
                else
                    if (dateCheck == 0 && monthCheck == 0)
                    {
                        Console.WriteLine("Happy Birthday! Today you turn {0}. You will be {1} years old after 10 years", yearsNow, futureAge);
                    }
                    if (dateCheck > 0 && monthCheck == 0)
                    {
                        Console.WriteLine("Your age now is {0} and you will be {1} years old after 10 years", yearsNow, futureAge);
                    }
                    if (dateCheck < 0 && monthCheck == 0)
                    {
                        Console.WriteLine("Your age now is {0} and you will be {1} years old after 10 years", yearsNow - 1, futureAge - 1);
                    }
          }
    }
}
        


    

using System;

class NumberComparer
{
    static void Main()
    {
        double numb1;
        double numb2;
        while (true)
        {
            Console.Write("Enter the first number to compare: ");
            if (double.TryParse(Console.ReadLine(), out numb1))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        while (true)
        {
            Console.Write("Enter the second number to compare: ");
            if (double.TryParse(Console.ReadLine(), out numb2))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        {
            Console.WriteLine("The greater number is: {0}", Math.Max(numb1, numb2));
        }
    }
}


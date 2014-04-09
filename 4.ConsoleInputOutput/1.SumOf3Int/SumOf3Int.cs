using System;

class SumOf3Int
{
    static void Main()
    {
        double numb1;
        double numb2;
        double numb3;
        while (true)
        {
            Console.Write("Enter the first number: ");
            if (double.TryParse(Console.ReadLine(), out numb1))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        while (true)
        {
            Console.Write("Enter the second number: ");
            if (double.TryParse(Console.ReadLine(), out numb2))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        while (true)
        {
            Console.Write("Enter the third number: ");
            if (double.TryParse(Console.ReadLine(), out numb3))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        double sum = numb1 + numb2 + numb3;
        Console.WriteLine("The sum of the three numbers = {0}" , sum);
    }
}
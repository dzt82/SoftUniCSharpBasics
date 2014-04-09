using System;

class ExchangeIfGrater
{
    static void Main()
    {
        int a;
        int b;
        while (true)
        {
            Console.Write("Enter number a: ");
            if (int.TryParse(Console.ReadLine(), out a))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        while (true)
        {
            Console.Write("Enter number b: ");
            if (int.TryParse(Console.ReadLine(), out b))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("The result is: {0} {1}", a, b);
        }
        else
        {
            Console.WriteLine("The result is: {0} {1}", a, b);
        }
    }
}

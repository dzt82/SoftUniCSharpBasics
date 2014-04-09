using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int n;
        while (true)
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n;
        while (true)
        {
            Console.Write("Please enter an Integer number between 1 and 100: ");
            if (int.TryParse(Console.ReadLine(), out n) && n >= 0 && n <=100)
                break;
            else Console.WriteLine("Incorrect data, please try again enter 0<= n <=100!");
        }
        bool isPrime = true;

        if (n < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) isPrime = false;
            }
        }

        Console.WriteLine("The entered number is prime = {0}" , isPrime);
    }
}

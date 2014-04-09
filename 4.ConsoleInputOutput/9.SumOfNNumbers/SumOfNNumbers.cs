using System;

class SumOfNNumbers
{
    static void Main()
    {
        int length;
        while (true)
        {
            Console.Write("Enter loop length: ");
            if (int.TryParse(Console.ReadLine(), out length))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        double sum = 0;
        for (int i = 0; i < length; i++)
        {
            Console.Write("Number [{0}]: ", i);
            double number = double.Parse(Console.ReadLine());

            sum += number;
        }

        Console.WriteLine("The sum of the numbers = " + sum);
    }
}

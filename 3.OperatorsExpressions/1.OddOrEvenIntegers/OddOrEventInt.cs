using System;

class OddOrEventInt
{
    static void Main()
    {
        int i;
        while (true)
        {
            Console.WriteLine("Please enter an Integer number:");
            if (int.TryParse(Console.ReadLine(), out i))
                break;
            else Console.WriteLine("Incorrect data, please try again!");
        }
        Console.WriteLine("The entered number is odd? \n{0} " , (i%2) != 0);
    }
}

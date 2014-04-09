using System;

class MultiplicationSign
{
    static void Main()
    {
        double a;
        double b;
        double c;
        while (true)
        {
            Console.Write("Enter number a: ");
            if (double.TryParse(Console.ReadLine(), out a))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        while (true)
        {
            Console.Write("Enter number b: ");
            if (double.TryParse(Console.ReadLine(), out b))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        while (true)
        {
            Console.Write("Enter number c: ");
            if (double.TryParse(Console.ReadLine(), out c))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        
        if ((a == 0) || (b == 0) || (c == 0))
            {
                Console.WriteLine("0");
            }
            else if ((a<0) && (b < 0) && (c < 0))
                {
                    Console.WriteLine("-");
                }
            else if ((a<0) && (b>0) && (c>0))
                {
                Console.WriteLine("-");
                }
            else if ((a > 0) && (b < 0) && (c > 0))
                {
                    Console.WriteLine("-");
                }
            else if ((a > 0) && (b > 0) && (c < 0))
                {
                    Console.WriteLine("-");
                }
        else
        {
            Console.WriteLine("+");
        }
    }
}

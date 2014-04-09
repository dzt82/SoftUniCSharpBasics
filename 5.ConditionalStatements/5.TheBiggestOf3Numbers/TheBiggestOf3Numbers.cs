using System;

class TheBiggestOf3Numbers
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

        if ((a >= b) && (b >= c))
        {
            Console.WriteLine(a);
        }
        else if (b >= c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

using System;

class Trapezoids
{
    static void Main()
    {
        float a;
        float b;
        float h;
        while (true)
        {
            Console.Write("Please enter the length of the first side of the trapezoid : ");
            if (float.TryParse(Console.ReadLine(), out a) && a > 0)
                break;
            else Console.WriteLine("Incorrect data, please enter new dimension!");
        }
        while (true)
        {
            Console.Write("Please enter the length of the second side of the trapezoid : ");
            if (float.TryParse(Console.ReadLine(), out b) && b > 0)
                break;
            else Console.WriteLine("Incorrect data, please enter new dimension!");
        }
        while (true)
        {
            Console.Write("Please enter the height of the trapezoid : ");
            if (float.TryParse(Console.ReadLine(), out h) && h > 0)
                break;
            else Console.WriteLine("Incorrect data, please enter new dimension!");
        }
        double areaTrapeze;
        areaTrapeze = ((a + b) / 2) * h;
        Console.WriteLine("The area of the trapezoid is: {0}" , areaTrapeze);

    }
}

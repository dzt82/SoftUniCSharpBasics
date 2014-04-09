using System;

class Program
{
    static void Main()
    {
        double width;
        double height;
        while (true)
        {
            Console.Write("Please enter rectangle’s width :");
            if (double.TryParse(Console.ReadLine(), out width) && width > 0)
                break;
            else Console.WriteLine("Incorrect data, please enter the width again!");
        }
        while (true)
        {
            Console.Write("Please enter rectangle’s height :");
            if (double.TryParse(Console.ReadLine(), out height) && height > 0)
                break;
            else Console.WriteLine("Incorrect data, please enter the height again!");
        }
        {
            double perimeter = 2*width + 2*height;
            double area = width*height; 
            Console.WriteLine("The perimeter of your rectangle is: {0}" , perimeter);
            Console.WriteLine("The area of your rectangle is: {0}", area);
        }
    }
}
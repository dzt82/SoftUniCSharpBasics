using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double r; // Circle Radius
        {
            while (true)
            {
                Console.Write("Enter the circle radius : ");
                if (double.TryParse(Console.ReadLine(), out r) && r > 0)
                {
                    break;
                }
                else Console.WriteLine("Incorrect data please try again!");
            }
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("The circle perimeter is = {0:0.00}" , perimeter);
            Console.WriteLine("The area of the circle is = {0:0.00}" , area);
            {
            }
        }
    }
}
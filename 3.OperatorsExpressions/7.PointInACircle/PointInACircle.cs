using System;

class PointInACircle
{
    static void Main()
    {
        float x;
        float y;
        float r=2f;
        while (true)
        {
            Console.Write("Please enter the 'x' coordinate of your point: ");
            if (float.TryParse(Console.ReadLine(), out x))
                break;
            else Console.WriteLine("Incorrect data, please enter the 'x' coordinate of your point again!");
        }
        while (true)
        {
            Console.Write("Please enter the 'y' coordinate of your point: ");
            if (float.TryParse(Console.ReadLine(), out y))
                break;
            else Console.WriteLine("Incorrect data, please enter the 'y' coordinate of your point again!");
        }
        {
            bool inCircle = ((x * x + y * y) <= r * r);
                Console.WriteLine("The point with coordinates {0} and {1} is inside the circle = {2}" , x, y, inCircle);
        }
    }
}

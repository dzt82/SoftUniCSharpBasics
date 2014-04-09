using System;

class PointInCircleOutOfRctangle
{
    static void Main()
    {
        float x;
        float y;
        float r = 1.5f;
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
            bool inCircleOutRect = ( ((x-1)*(x-1) + (y-1) * (y-1)) <= r * r && y > 1);
            string yesNo;
            if (inCircleOutRect == false)
                yesNo = "no";
            else yesNo = "yes";
            Console.WriteLine("The point with coordinates {0} and {1} is inside the circle and out of the rectangle = {2}", x, y, yesNo);
        }
    }
}

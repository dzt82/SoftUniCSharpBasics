using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("a*x^2 + bx + c = 0");
        Console.WriteLine("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());
        double determinant = (b * b) - (4 * a * c);
        {
            if (determinant < 0)
            {
                Console.WriteLine("Determinant < 0 , no real roots");
            }
            else if (determinant > 0)
            {
                Console.WriteLine("X1 = {0}; X2 = {1}", (-b - Math.Sqrt(determinant)) / (2 * a), (-b + Math.Sqrt(determinant)) / (2 * a));
            }
            else
            {
                Console.WriteLine("Determinant = 0, Root X1=X2={0}", (-b / (2 * a)));
            }
        }
    }	
}

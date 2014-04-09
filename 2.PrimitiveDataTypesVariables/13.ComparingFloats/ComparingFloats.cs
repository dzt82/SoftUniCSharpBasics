using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Please enter first real number:");
        double numb1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second real number:");
        double numb2 = double.Parse(Console.ReadLine());
        {
            Console.WriteLine("The two numbers to compare are: {0} and {1}", numb1, numb2);
        }
        float eps = 0.000001f;
        if (numb1 - numb2 < eps)
        {
            Console.WriteLine("The numbers are equal with precision of 0.000001");
        }
        else
        {
            Console.WriteLine("The numbers are not equal with the required precision of 0.000001");
        }
    }
}

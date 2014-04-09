using System;

class FormattingNumbers
{
    static void Main()
    {
        int a;
        float b;
        float c;
        while (true)
        {
            Console.Write("Enter the first number: ");
            if (int.TryParse(Console.ReadLine(), out a) && 0 <= a && a <= 500)
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        while (true)
        {
            Console.Write("Enter the second number: ");
            if (float.TryParse(Console.ReadLine(), out b))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        while (true)
        {
            Console.Write("Enter the third number: ");
            if (float.TryParse(Console.ReadLine(), out c))
            {
                break;
            }
            else Console.WriteLine("Incorrect data please try again!");
        }
        {
            Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:F2}|{3, -10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        double n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sn = 0;
        double s = 1;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sn = factorial / Math.Pow(x, i);
            s += sn;
        }
        {
            Console.WriteLine("{0:0.00000}", s);
        }
    }
}

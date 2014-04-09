using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // 1<n<100
        BigInteger factorial2n = 1;
        BigInteger factorialn = 1;
        BigInteger dev;
        BigInteger res;

        for (int i = 1; i <= 2 * n; i++)
        {
            factorial2n *= i;
        }

        for (int i = 1; i <= n; i++)
        {
            factorialn *= i;
        }

        {
            dev = (factorialn * factorialn * (n + 1));
            res = (factorial2n / dev);
            Console.WriteLine(res);
        }
    }
}

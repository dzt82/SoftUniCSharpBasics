using System;
using System.Numerics;

class Calculate //N!/K!
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // 1<k<n<100
        int k = int.Parse(Console.ReadLine()); // 1<k<n<100
        BigInteger factorialn = 1;
        BigInteger factorialk = 1;
        BigInteger factorialnk = 1;
        BigInteger result;

        for (int i = 1; i <= n; i++)
        {
            factorialn *= i;
            if (i <= k)
            {
                factorialk *= i;
            }
        }

        {
            result = factorialn / factorialk ;
            Console.WriteLine(result);
        }
    }
}

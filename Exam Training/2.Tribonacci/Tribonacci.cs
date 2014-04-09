using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        ushort N = ushort.Parse(Console.ReadLine());
        BigInteger result = 0;

        if (N == 1)
        {
            Console.WriteLine(first);
        }
        else if (N == 2)
        {
            Console.WriteLine(second);
        }
        else if (N == 3)
        {
            Console.WriteLine(third);
        }

        else
        {
            for (ushort i = 0; i < (N - 3); i++)
            {
                result = first + second + third;
                first = second;
                second = third;
                third = result;
            }
            Console.WriteLine(result);
        }
    }
}

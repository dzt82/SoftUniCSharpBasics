using System;
using System.Numerics;

class BimaryToDecimalNumber
{
    static void Main()
    {
        BigInteger num, binary_val, decimal_val = 0, base_val = 1, rem;

        Console.Write("Enter a Binary Number(1s and 0s) : ");

        num = BigInteger.Parse(Console.ReadLine());

        binary_val = num;

        while (num > 0)
        {

            rem = num % 10;

            decimal_val = decimal_val + rem * base_val;

            num = num / 10;

            base_val = base_val * 2;

        }

        Console.Write("The Binary Number is : " + binary_val);
        Console.Write("\nIts Decimal Equivalent is : " + decimal_val);
        Console.ReadLine();
    }
}

using System;

class ZeroSubset
{
    static void Main()
    {
        int numCount = 5;
        Console.WriteLine("Input  numbers!", numCount);
        bool valid = true;
        int[] num = new int[numCount];
        for (int i = 0; i < numCount; i++)
        {
            Console.Write("Number {0}: ", i + 1);
            valid &= int.TryParse(Console.ReadLine(), out num[i]);
        }
        if (valid)
        {
            int sum;
            for (int i = 1; i < Math.Pow(2, numCount); i++)
            {
                sum = 0;
                for (int j = 0; j < numCount; j++)
                {
                    sum += num[j] * BinaryDigit(number: i, digit: j);
                }
                if (sum == 0)
                {
                    for (int j = 0; j < numCount; j++)
                    {
                        if (BinaryDigit(number: i, digit: j) == 1)
                        {
                            Console.Write("{1}{0}{2} + ", num[j], num[j] < 0 ? "(" : "", num[j] < 0 ? ")" : "");
                        }
                    }
                    Console.WriteLine("\b\b= 0");
                }
            }
        }
        else
        {
            Console.WriteLine("You have inputed incorrect data");
        }
    }

    public static int BinaryDigit(int number, int digit)
    {
        return (number & (1 << digit)) >> digit;
    }
}
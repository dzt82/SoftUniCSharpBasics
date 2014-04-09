using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        int fiboTempA = 0;
        int fiboTempB = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(fiboTempA + " ");
            int temp = fiboTempA;
            fiboTempA = fiboTempB;
            fiboTempB = temp + fiboTempB;
        }
    }
}

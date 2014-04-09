using System;

class NumbersInIntervalDividableBy5
{
    static void Main()
    {
        Console.Write("Start= ");
        uint a = uint.Parse(Console.ReadLine());
        Console.Write("End= ");
        uint b = uint.Parse(Console.ReadLine());
        uint p = 0;
        for (uint i = a; i <= b; i++)
        {
            if (i % 5 == 0) p = p + 1;
        }
        Console.WriteLine("p= {0} " ,p);
    }
}
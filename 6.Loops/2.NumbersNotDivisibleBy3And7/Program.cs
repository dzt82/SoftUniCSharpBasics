using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        {
            Console.Write(1);
        }

        for (int i = 2; i <= n; i++)
            if ((i % 3 != 0) && (i % 7 != 0))
        {
            Console.Write(" {0}", i);
        }
    }
}


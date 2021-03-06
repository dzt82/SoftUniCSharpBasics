﻿using System;

class ExtractBitFromInt
{
    static void Main()
    {
        int n;
        int p; // Bit position to be extracted.
        while (true)
        {
            Console.Write("Please enter an Integer number: ");
            if (int.TryParse(Console.ReadLine(), out n))
                break;
            else Console.WriteLine("Incorrect data, please try again!");
        }
        while (true)
        {
            Console.Write("Please enter the bit position: ");
            if (int.TryParse(Console.ReadLine(), out p) && p >= 0 && p <32)
                break;
            else Console.WriteLine("Incorrect data, please try again!");
        }
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine("Bit at position {0} is: {1}", p, bit);
    }
}
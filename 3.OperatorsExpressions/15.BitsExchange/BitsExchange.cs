using System;

class BitsExchange
{
    static void Main()
    {
        uint n;
        uint r;    // Bit-swapped result goes here
        while (true)
        {
            Console.Write("Please enter an Unsigned Integer number: ");
            if (uint.TryParse(Console.ReadLine(), out n))
                break;
            else Console.WriteLine("Incorrect data, please try again!");
        }
        {
            uint x = ((n >> 3) ^ (n >> 24)) & ((1U << 3) - 1); // XOR temporary
            r = n ^ ((x << 3) | (x << 24));
            Console.WriteLine("The result after the bits exchange is: {0}" , r);
        }
    }
}

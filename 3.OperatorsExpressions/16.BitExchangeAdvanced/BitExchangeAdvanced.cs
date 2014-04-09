using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        uint n;
        int p, q; // positions of bit sequences to swap
        int k;    // number of consecutive bits in each sequence
        uint r;    // Bit-swapped result goes here
        while (true)
            {
                Console.Write("Please enter an Unsigned Integer number: ");
                if (uint.TryParse(Console.ReadLine(), out n))
                    break;
                else Console.WriteLine("Incorrect data, please try again!");
            }
        while (true)
            {
                Console.Write("Please enter first position of bits to be exchanged: ");
                if (int.TryParse(Console.ReadLine(), out p) & p < 33)
                    break;
                else Console.WriteLine("Incorrect data, please try again!");
            }
        while (true)
            {
                Console.Write("Please enter first position of bits to be exchanged: ");
                if (int.TryParse(Console.ReadLine(), out q) & q < 33 & q != p)
                    break;
                else Console.WriteLine("Incorrect data, please try again!");
            }
        while (true)
            {
                Console.Write("Please enter the numbers of bits to be exchanged: ");
                if (int.TryParse(Console.ReadLine(), out k) & k < 32 & k >0)
                    break;
                else Console.WriteLine("Incorrect data, please try again!");
            }
        if (Math.Max(p, q) + k > 32)
            {
                Console.WriteLine("Out of range");
            }
            else if (Math.Min(p, q) + k > Math.Max(p, q))
            {
                Console.WriteLine("Overlapping");
            }
        else
        {
            uint x = ((n >> p) ^ (n >> q)) & ((1U << k) - 1); // XOR temporary
            r = n ^ ((x << p) | (x << q));
            Console.WriteLine("The result after the bits exchange is: {0}", r);
        }
    }
}

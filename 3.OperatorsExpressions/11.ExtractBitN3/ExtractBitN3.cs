using System;

class ExtractBitN3
{
    static void Main()
    {
        uint n;
        while (true)
        {
            Console.Write("Please enter an Integer number: ");
            if (uint.TryParse(Console.ReadLine(), out n))
                break;
            else Console.WriteLine("Incorrect data, please try again!");
        }
        int p = 3; // Number of positions to move right.
        uint nRightP = n >> p;
        uint bit = nRightP & 1;
        Console.WriteLine(bit);
    }
}

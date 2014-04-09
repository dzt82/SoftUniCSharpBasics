using System;

class CheckBitAtPosition
{
    static void Main()
    {
        int n;
        int p; // Bit position to be modofied.
        byte v;
        while (true)
        {
            Console.Write("Please enter an Integer number: ");
            if (int.TryParse(Console.ReadLine(), out n))
                break;
            else Console.WriteLine("Incorrect data, please try again!");
        }
        while (true)
        {
            Console.Write("Please enter the bit position to be modified: ");
            if (int.TryParse(Console.ReadLine(), out p) && p >= 0 && p < 32)
                break;
            else Console.WriteLine("Incorrect data, please try again!");
        }
        while (true)
        {
            Console.Write("Please enter the new bit value 0 or 1: ");
            if (byte.TryParse(Console.ReadLine(), out v) && v == 0 || v == 1)
                break;
            else Console.WriteLine("Incorrect data, please try again!");
        }
        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine("The modefied number is: {0}", result);
        }
        else
        {
           int mask = 1 << p;
           int result = n | mask;
           Console.WriteLine("The modefied number is: {0}", result);
        }
    }
}
 
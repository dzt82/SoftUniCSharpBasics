using System;

class BinaryDigitsCount
{
    static void Main()
    {
        byte B = byte.Parse(Console.ReadLine());
        ushort N = ushort.Parse(Console.ReadLine());
        
        
        for (int i = 0; i < N; i++)
        {
            uint count0 = 0;
            uint count1 = 0;
            uint n = uint.Parse(Console.ReadLine());
            while (n != 0)
            {
                if ((n & 1) == 1)
                {
                    count1++;
                }
                else 
                {
                    count0++;
                }
                n >>= 1;
            }
            if (B == 0)
            {
                Console.WriteLine(count0);
            }
            else
            {
                Console.WriteLine(count1);
            }
        }
    }
}

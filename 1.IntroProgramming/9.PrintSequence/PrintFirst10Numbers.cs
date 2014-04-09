using System;

class PrintFirst10Numbers
{
    static void Main()
    {
        for (sbyte i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(-i + ", ");
            }
        }
            Console.WriteLine();
    }
} 


using System;

class ForestRoad
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());

        for (int row = 0; row < N; row++)
        {
            int dotFCount = row;
            string dotFr = new string('.', dotFCount);
            int dotRCount = N -1 - row;
            string dotRear = new string('.', dotRCount);
            Console.Write(dotFr);
            Console.Write('*');
            Console.Write(dotRear);
            Console.WriteLine();
        }

        for (int row = (N-2); row >= 0; row--)
        {
            int dotFCount = row;
            string dotFr = new string('.', dotFCount);
            int dotRCount = N - 1 - row;
            string dotRear = new string('.', dotRCount);
            Console.Write(dotFr);
            Console.Write('*');
            Console.Write(dotRear);
            Console.WriteLine();
        }
    }
}

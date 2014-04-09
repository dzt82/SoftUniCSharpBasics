using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            Console.Write(row);
            for (int column = 1; column <n ; column++)
            {
                Console.Write(" " + (column + row));
            }
            Console.WriteLine();
        }
    }
}

using System;

class SandGlass
{
    static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for ( int row = 0; row < N; row +=2)
            {
                int starCount = (N - row);
                string stars = new string('*', starCount);
                int dotCount = row / 2;
                string dots = new string('.', dotCount);
                Console.Write(dots);
                Console.Write(stars);
                Console.Write(dots);
                Console.WriteLine();
            }

            for (int row = 3; row <= N; row += 2)
            {
                int starCount = (row);
                string stars = new string('*', starCount);
                int dotCount =(N - row) / 2;
                string dots = new string('.', dotCount);
                Console.Write(dots);
                Console.Write(stars);
                Console.Write(dots);
                Console.WriteLine();

            }
        }
}

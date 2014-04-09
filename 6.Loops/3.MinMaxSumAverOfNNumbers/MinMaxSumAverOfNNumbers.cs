using System;

    class MinMaxSumAverOfNNumbers
{
    static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            double average = 0;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                sum += numb;

                if (numb > max)
                {
                    max = numb;
                }
                if (numb < min)
                {
                    min = numb;
                }
            }
            {
                average = (sum / n);
                Console.WriteLine("min = {0} \nmax = {1} \nsum = {2} \navg = {3:0.00}", min, max, sum, average);
            }
        }
}

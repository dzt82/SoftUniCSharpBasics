using System;

class SubsetSums
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        long n = long.Parse(Console.ReadLine());
        long[] nums = new long[n];        
        
        for (int i = 0; i < n; i++)
        {
            nums[i] = long.Parse(Console.ReadLine());
        }
        int sumCounter = 0;
        int combinations = (int)Math.Pow(2, n);
            for (int i = 1; i < combinations; i++)
            {
                long tempSum = 0;
                for (int j = 0; j < n; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = mask & i;
                    int bit = iAndMask >> j;
                    
                    if (bit == 1)
                    {
                    tempSum += nums[j];
                    }
                }
                if (tempSum == s)
                {
                    sumCounter ++;
                }   
            }
            Console.WriteLine(sumCounter);
    }
}
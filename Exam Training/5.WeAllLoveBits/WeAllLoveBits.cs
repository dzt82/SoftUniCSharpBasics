using System;
using System.Linq;
class WeAllLoveBits
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < N; i++)
        {
            int num = int.Parse(Console.ReadLine());
           
            int result = 0;
            while (num > 0)
            {
                int lastBit = num & 1;
                num = num >> 1;
                result = result << 1;
                result = result | lastBit;
            }
            Console.WriteLine(result);
        }
    }
}

 //int N = int.Parse(Console.ReadLine());
 //       int[] nums = new int[N];

 //       for (int i = 0; i < nums.Length; i++)
 //       {
 //           nums[i] = int.Parse(Console.ReadLine());
 //       }

 //       string[] binary = new string[N];
 //       for (int i = 0; i < N; i++)
 //           {
 //            binary[i] = Convert.ToString(nums[i], 2);
 //           }

 //       string[] binrev = new string[N];
 //       for (int i = 0; i < N; i++)
 //           {
 //               binrev[i] = binary[i].Reverse().ToString(); 
 //           }
 //       Console.WriteLine(binrev);
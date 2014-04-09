using System;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            Random random = new Random();
            foreach (int i in array)
            {
                int randNum = random.Next(0, n);
                int temp = array[randNum];
                array[randNum] = array[0];
                array[0] = temp;
            }
            Console.WriteLine(String.Join(" ", array));
    }
}
